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
        private readonly HelloWorldContext _context;
        
        public GradesController(HelloWorldContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            var model = _context.Grades.ToList();
            return View(model);
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

            _context.Add(model);
            _context.SaveChanges();

            return View("Details", model);
        }

        public IActionResult Details(Grades model)
        {
            return View(model);
        }
    }
}