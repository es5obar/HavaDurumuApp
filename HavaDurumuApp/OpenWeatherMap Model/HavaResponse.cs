using System.Collections.Generic;

namespace HavaDurumuApp.OpenWeatherMap_Model
{
    public class HavaResponse
    {
        public Koordinasyon Koordinasyon { get; set; }
        public List<HavaDurumu> HavaDurumları { get; set; }
        public string Base { get; set; }
        public Main Main { get; set; }
        public int  Gorunurluk { get; set; }
        public Ruzgar Ruzgar { get; set; }
        public Bulutlar Bulutlar { get; set; }
        public int Dt { get; set; }
        public Sistem Sistem { get; set; }
        public int Saatdilimi { get; set; }
        public int Id { get; set; }
        public string Adi { get; set; }
        
        public int Kod { get; set; }

    }
}
