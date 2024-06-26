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
            arabalar.Add(new Araba() { marka = "Togg", model = "t10x", uretimYili = 2022, motorHacmi = 100, renk = "kırmızı", yakit = yakitTipi.Elektrik });
            arabalar.Add(new Araba() { marka = "tesla", model = "s", motorHacmi = 200, uretimYili = 2024, renk = " beyaz" });
            arabalar.Add(new Araba() { marka = "byd", model = "atto3", motorHacmi = 75, renk = "lacivert", uretimYili = 2023, yakit = yakitTipi.Hibrid });
            return View(arabalar);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }

        public IActionResult Ekle()
        {
            return View(new Araba() { marka = "Ferrari" });
        }

        public IActionResult EkleM(Araba model)
        {
            return Json(model);
        }
        [HttpGet]
        public IActionResult yukle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult yukle(string adsoyad,IFormFile foto)
        {
            
            if(foto==null || foto.Length==0){
                return Content("foto seçiniz");
            } 
            string webadresi=DateTime.Now.ToString("yyMMddHHmmssffff")+"_"+foto.FileName;
            string yol= Path.Combine(Directory.GetCurrentDirectory(),"wwwroot",webadresi);
            foto.CopyTo(new FileStream(yol,FileMode.Create));
            //return Content("Dosya yükleme tamamlandı");
            ViewBag.yol =webadresi;
            return View();
        }
    }
}