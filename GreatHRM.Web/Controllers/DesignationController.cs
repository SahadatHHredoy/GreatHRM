using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreatHRM.Entities;
using GreatHRM.Repo;
using Microsoft.AspNetCore.Mvc;

namespace GreatHRM.Web.Controllers
{
    public class DesignationController : Controller
    {
        private readonly IDesignationRepository repository;

        public DesignationController(IDesignationRepository repository)
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
        public IActionResult Add(Designation designation)
        {
            if (ModelState.IsValid)
            {
                repository.Add(designation);
                return RedirectToAction("Index");
            }
            return View(designation);
        }
    }
}