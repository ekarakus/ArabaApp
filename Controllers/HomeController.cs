using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ArabaApp.Models;

namespace ArabaApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index(int id)
    {
        int deger = id;
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
    
    [HttpGet]
    public IActionResult kayit()
    {
        return View();
    }
   [HttpPost]
    public IActionResult kayit(Kullanici model)
    {
        return View();
    }

}
