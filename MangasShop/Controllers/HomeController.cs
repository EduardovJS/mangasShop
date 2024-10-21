using MangasShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MangasShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
