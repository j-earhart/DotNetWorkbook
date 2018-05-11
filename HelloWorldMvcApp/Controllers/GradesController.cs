using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWorldMvcApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldMvcApp.Controllers
{
    public class GradesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            Grades model = new Grades();

            return View(model);
        }
        [HttpPost]
        public IActionResult Create(Grades model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            return View("Details", model);
        }

        public IActionResult Details(Grades model)
        {
            return View(model);
        }
    }
}