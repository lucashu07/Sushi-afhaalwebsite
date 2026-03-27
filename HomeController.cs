using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Sushi_afhaalwebsite.Models;

namespace Sushi_afhaalwebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public static List<Gerecht> menu = new List<Gerecht>
        {
            new Gerecht
            {
                Id = 1,
                Naam = "Dragon Roll",
                Prijs = 15.50m,
                Afbeelding = "/Images/DragonRoll.jpg",
                Ingredienten = "Garnaal, avocado, rijst,",
                AantalStuks = 8
            },
            new Gerecht
            {
                Id = 2,
                Naam = "California Roll",
                Prijs = 11.50m,
                Afbeelding = "/Images/CaliforniaRoll.jpg",
                Ingredienten = "krab, avocado, rijst",
                AantalStuks = 8
            },
            new Gerecht
            {
                Id = 3,
                Naam = "Spicy Tuna Roll",
                Prijs = 15.00m,
                Afbeelding = "/Images/SpicyTunaRoll.jpg",
                Ingredienten = "tonijn, sriracha, rijst",
                AantalStuks = 8
            },
             new Gerecht
            {
                Id = 4,
                Naam = "Sake Nigiri",
                Prijs = 4.40m,
                Afbeelding = "/Images/SakeNigiri.jpg",
                Ingredienten = "zalm, rijst",
                AantalStuks = 2
            },
             new Gerecht
            {
                Id = 5,
                Naam = "Ebi Tempura Roll",
                Prijs = 10.00m,
                Afbeelding = "/Images/EbiTempuraRoll.jpg",
                Ingredienten = "tempura garnalen, avocado, rijst",
                AantalStuks = 8
             }
        };

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Menu()
        {
            return View(menu);
        }

        [HttpPost]
        public IActionResult AddGerecht(Gerecht gerecht)
        {
            gerecht.Id = menu.Count + 1;

            menu.Add(gerecht);

            return RedirectToAction("Menu");
        }

        public IActionResult Details(int id)
        {
            var gerecht = menu.FirstOrDefault(x => x.Id == id);

            return View(gerecht);
        }
        public IActionResult Admin()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}