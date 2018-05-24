using System;
using System.Collections.Generic;
using System.Linq; //bring in class for grades
using System.Threading.Tasks;
using HelloWorldMvcApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldMvcApp.Controllers
{
    public class StudentController : Controller
    {
        private readonly HelloWorldContext _context;

        public StudentController(HelloWorldContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var model = _context.Student.ToList();
            return View(model);
        }

        public IActionResult Create()
        {
           //initializing the model
            Student model = new Student();

            return View(model);
        }
        [HttpPost]
        public IActionResult Create(Student model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            //save the data
            _context.Add(model); //Adding the data to the context
            _context.SaveChanges(); //Saving the data to the table


            return View("Details", model);
        }

        public IActionResult Details(Student model)
        {
            return View(model);
        }
    }
}