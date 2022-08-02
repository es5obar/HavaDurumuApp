using HavaDurumuApp.OpenWeatherMap_Model;

namespace HavaDurumuApp.Repositories
{
    public interface IHDurumuRepository
    {
        HavaResponse GetTahmin(string sehir);
    }
}
