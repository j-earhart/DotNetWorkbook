using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelloWorldMvcApp.Models;

namespace HelloWorldMvcApp.Controllers
{
    public class HomeController : Controller
    {
        private static Random _rnd = new Random();

        private static List<string> _db = new List<string> { "Hell Nah", "Hell Yeah", "Like Kanye loves Kanye", "Know your truth", "Looks like, feels" };


        [HttpGet]
        public IActionResult Index()
        {
            return View(new SampleViewModel());
        }

        [HttpPost]
        //public JsonResult GetResponse(string answer, string question)
        public IActionResult GetAnswer(string Question, int Number)
        {
            ResponseViewModel model = new ResponseViewModel();

            int index = _rnd.Next(_db.Count);
            var answer = _db[index];

            model.Response = answer;

            model.Number = Number;
           
            

            #region OlderCode
            // return Json(answer);
            #endregion

            return View(model);
        }

        public IActionResult Customer()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
