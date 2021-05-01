using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitaplikProje.Models;

namespace KitaplikProje.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var ktp = new List<Kitap>()
            {
                new Kitap() { ID = 1, KitapAd = "Satranç", Yazar = "Zweig" },
                new Kitap() { ID = 2, KitapAd = "Satranç", Yazar = "Zweig" },
                new Kitap() { ID = 3, KitapAd = "Satranç", Yazar = "Zweig" },
                new Kitap() { ID = 4, KitapAd = "Satranç", Yazar = "Zweig" },
                new Kitap() { ID = 5, KitapAd = "Satranç", Yazar = "Zweig" },
                new Kitap() { ID = 6, KitapAd = "Satranç", Yazar = "Zweig" }
            };

            return View(ktp);
        }
    }
}
