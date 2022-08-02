using System.ComponentModel.DataAnnotations;

namespace HavaDurumuApp.Models
{
    public class SehirAra
    {
        [Required(ErrorMessage ="Şehir adı boş girilemez!")] // girilmesi zorunlu alan tanımlandı. Boş girilirse hata mesajı yazdırıldı.
        [Display(Name ="Şehir Adı")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Geçersiz giriş, karakter uzunluğu 2 ile 20 karakter arasında olmalıdır!")]
        public string SehirAdi { get; set; }
    }
}
