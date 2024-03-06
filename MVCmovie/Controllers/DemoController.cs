using Microsoft.AspNetCore.Mvc;
using MVCmovie.Models;
using System.Diagnostics;

namespace DemoController.Controllers;
 
    public class DemoController : Controller
    {
         public IActionResult Index()
        {
           return View();
        }
        [HttpPost]
        public IActionResult Index(Person ps) 
        {

         string strResult = "Xin chao" + ps.PersonID + " - " + ps.FullName;
         ViewBag.info = strResult; 
         return View();

        }
    }
