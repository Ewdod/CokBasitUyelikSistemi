using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CokBasitUyelikSistemi.Filters
{
    public class GirisControlAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.HttpContext.Session.GetString("giris") == null)
            {
                context.Result = new RedirectToActionResult("Index", "Giris",null);
            }
        }
    }
}
