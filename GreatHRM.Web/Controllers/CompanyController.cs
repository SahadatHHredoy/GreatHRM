using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreatHRM.Entities;
using GreatHRM.Repo;
using GreatHRM.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace GreatHRM.Web.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyRepository repository;

        public CompanyController(ICompanyRepository repository)
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
        public IActionResult Add(Company company)
        {
            if (ModelState.IsValid)
            {
                repository.Add(company);
                return RedirectToAction("Index");
            }
            return View(company);
        }
    }
}