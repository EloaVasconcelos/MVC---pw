using Microsoft.AspNetCore.Mvc;
using Projeto3ds.Models;
using System.Diagnostics;

namespace Projeto3ds.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }
}
