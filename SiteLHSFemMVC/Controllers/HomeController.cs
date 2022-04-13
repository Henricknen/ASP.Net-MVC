using Microsoft.AspNetCore.Mvc;
using SiteLHSFemMVC.Models;
using System.Diagnostics;

namespace SiteLHSFemMVC.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            HomeModel home = new HomeModel();   /* instanciando */

            home.Nome = "Luis henrique silva ferreira";
                                                            /* seta o nome e email */
            home.Email = "l.henrick@live.com";

            return View(home);  /* retorna as informações de home para view */
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