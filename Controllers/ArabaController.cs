using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ArabaApp.Models;
namespace ArabaApp.Controllers
{
   
    public class ArabaController : Controller
    {
        private readonly ILogger<ArabaController> _logger;

        public ArabaController(ILogger<ArabaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Araba> arabalar = new List<Araba>();
            arabalar.Add(new Araba() { marka = "Togg", model = "t10x", uretimYili = 2022 , motorHacmi=100 , renk="kırmızı" , yakit= yakitTipi.Elektrik});
            arabalar.Add(new Araba(){marka ="tesla",model="s" , motorHacmi = 200 , uretimYili = 2024 , renk =" beyaz"});
            arabalar.Add(new Araba (){marka= "byd", model= "atto3" , motorHacmi=75 , renk = "lacivert", uretimYili=2023, yakit = yakitTipi.Hibrid} );
            return View(arabalar);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}