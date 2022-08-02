using System.ComponentModel.DataAnnotations;

namespace HavaDurumuApp.Models
{
    public class Sehir
    {

        // entity oluşturma
        [Display(Name = "Şehir Adı:")]
        public string Adi { get; set; }

        [Display(Name ="Sıcaklık")]
        public float Sicaklik { get; set; }

        [Display(Name = "Nem")]
        public int Nem { get; set; }

        [Display(Name = "Basınç:")]

        public int Basinc { get; set; }

        [Display(Name = "Rüzgar Hızı:")]

        public float Ruzgar { get; set; }

        [Display(Name = "Hava Durumu:")]

        public string HavaDurumu { get; set; }


    }
}
