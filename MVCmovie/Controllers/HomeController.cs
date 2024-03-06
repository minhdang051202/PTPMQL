using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCmovie.Models;

namespace MVCmovie.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
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
    [HttpPost]
      public IActionResult Index(Person ps)
    {
        string strResult = "Xin chao" + ps.PersonID + " - " + ps.FullName + "Nha o " + ps.Address;
        ViewBag.info = strResult;
        return View();
    }
}
