using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NCL.Helper;
using NCL.LuceneService;
using NCL.WebApp.Models;

namespace NCL.WebApp.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
          await     new CategoryLucenService().InitIndex();
          
            return View(  );
        }

       
        public IActionResult About()
        {
            var category = new CategoryLucenService();
            var data = category.GetCagegory("1");

            return View(data);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}