using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreatHRM.Entities;
using GreatHRM.Repo;
using Microsoft.AspNetCore.Mvc;

namespace GreatHRM.Web.Controllers
{
    public class OfficeTimePolicyController : Controller
    {
        private readonly IOfficeTimeRepository repository;

        public OfficeTimePolicyController(IOfficeTimeRepository repository)
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
        public IActionResult Add(OfficeTimePolicy officeTimePolicy)
        {
            if (ModelState.IsValid)
            {
                repository.Add(officeTimePolicy);
                return RedirectToAction("Index");
            }
            return View(officeTimePolicy);
        }
    }
}