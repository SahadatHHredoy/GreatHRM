using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreatHRM.Entities;
using GreatHRM.Repo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GreatHRM.Web.Controllers
{
    public class BranchController : Controller
    {
        private readonly IBranchRepository repository;
        private readonly ICompanyRepository companyRepository;

        public BranchController(IBranchRepository repository,ICompanyRepository companyRepository)
        {
            this.repository = repository;
            this.companyRepository = companyRepository;
        }
        public IActionResult Index()
        {
            return View(repository.GetAll(null,null,"Company",false));
        }
        public IActionResult Add()
        {
            ViewBag.CompanyId = new SelectList(companyRepository.GetAll().ToList(),"Id","CompanyName");
            return View();
        }
        [HttpPost]
        public IActionResult Add(Branch branch)
        {
            if (ModelState.IsValid)
            {
                repository.Add(branch);
                return RedirectToAction("Index");
            }
            return View(branch);
        }
    }
}