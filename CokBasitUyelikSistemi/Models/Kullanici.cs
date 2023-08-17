using System.ComponentModel.DataAnnotations;

namespace CokBasitUyelikSistemi.Models
{
    public class Kullanici
    {
        [Required]
        public string KullaniciAdi { get; set; } = null!;
        [Required]
        [DataType(DataType.Password)]
        public string Parola { get; set; } = null!;
    }
}
