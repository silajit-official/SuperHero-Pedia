using Microsoft.AspNetCore.Mvc;
using Super_Hero_Pedia.Models;
using System.Diagnostics;

namespace Super_Hero_Pedia.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

 
        public IActionResult Privacy()
        {
            return View();
        }

       
    }
}