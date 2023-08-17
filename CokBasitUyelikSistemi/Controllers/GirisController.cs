using CokBasitUyelikSistemi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CokBasitUyelikSistemi.Controllers
{
    public class GirisController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost,ValidateAntiForgeryToken]
        public IActionResult Index(Kullanici kullanici)
        {

            if (ModelState.IsValid)
            {
                if (kullanici.KullaniciAdi == "ali" && kullanici.Parola == "123")
                {
                    // bu istegi yaparn tarayici tarafindan giris yapildigini not al

                    return RedirectToAction("Index", "Home", new { giris = "basarili"});
                }
                else
                {
                    ModelState.AddModelError("", "Kullanici adi yada parola yanlis");
                }
            }
            return View();
        }
    }
}
