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
    [Route("[controller]")]
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
            arabalar.Add(new Araba() { marka = "Togg", model = "t10x", uretimYili = 2022 });
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}