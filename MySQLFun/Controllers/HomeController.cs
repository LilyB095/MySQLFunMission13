using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySQLFun.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MySQLFun.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public homecontroller(ilogger<homecontroller> logger)
        //{
        //    _logger = logger;
        //}
        //----------------------------------------------------------
        //----------------------------------------------------------
        
        private RecipesDbContext _miContextico { get; set; }
        public HomeController(RecipesDbContext temp)
        {
            _miContextico = temp;
        }
        public IActionResult Index()
        {

            var blah = _miContextico.Recipes.ToList();

            return View(blah);
        }



        public IActionResult Privacy()
        {
            return View();
        }

        //----------------------------------------------------------
        //----------------------------------------------------------

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
