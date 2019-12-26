using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreatHRM.Entities;
using GreatHRM.Repo;
using Microsoft.AspNetCore.Mvc;

namespace GreatHRM.Web.Controllers
{
    public class ShiftController : Controller
    {
        private readonly IShiftRepository repository;

        public ShiftController(IShiftRepository repository)
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
        public IActionResult Add(Shift shift)
        {
            if (ModelState.IsValid)
            {
                repository.Add(shift);
                return RedirectToAction("Index");
            }
            return View(shift);
        }
    }
}