using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreatHRM.Entities;
using GreatHRM.Repo;
using Microsoft.AspNetCore.Mvc;

namespace GreatHRM.Web.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepository repository;

        public DepartmentController(IDepartmentRepository repository)
        {
            this.repository = repository;
        }
        public IActionResult Index()
        {
            return View(repository.GetAll());
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Department department)
        {
            if (ModelState.IsValid)
            {
                repository.Add(department);
                return RedirectToAction("Index");
            }
            return View(department);
        }
    }
}