using HavaDurumuApp.Models;
using HavaDurumuApp.OpenWeatherMap_Model;
using HavaDurumuApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HavaDurumuApp.Controllers
{
    public class HavaDurumuController : Controller
    {
        private readonly IHDurumuRepository _HDurumuRepository;
        public HavaDurumuController(IHDurumuRepository HDurumuRepository)
        {
            _HDurumuRepository = HDurumuRepository;
        }
        [HttpGet]
        public IActionResult SehirAra()
        {
            var viewModel = new SehirAra();
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult SehirAra(SehirAra model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Sehir", "HavaDurumu", new { sehir = model.SehirAdi });
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Sehir(string sehir)
        {
            HavaResponse havaResponse = _HDurumuRepository.GetTahmin(sehir);
            Sehir viewModel = new Sehir();
            if (havaResponse != null)
            {
                viewModel.Adi = havaResponse.Adi;
                viewModel.Sicaklik = havaResponse.Main.Sicaklik;
                viewModel.Nem = havaResponse.Main.Nem;
                viewModel.Basinc = havaResponse.Main.Basinc;
                viewModel.HavaDurumu = havaResponse.HavaDurumları[0].Main;
                viewModel.Ruzgar = havaResponse.Ruzgar.Hiz;


            }
            return View(viewModel);
        }
    }

}
