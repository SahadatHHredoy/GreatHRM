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
    public class MachineController : Controller
    {
        private readonly IMachineRepository repository;
        private readonly IBranchRepository branchRepository;

        public MachineController(IMachineRepository repository,IBranchRepository branchRepository)
        {
            this.repository = repository;
            this.branchRepository = branchRepository;
        }
        public IActionResult Index()
        {
            return View(repository.GetAll());
        }
   
        public IActionResult Add()
        {
            ViewBag.BranchId = new SelectList(branchRepository.GetAll(x=>x.Status!=0), "Id", "BranchName");
            return View();
        }
        [HttpPost]
        public IActionResult Add(Machine machine)
        {
            if (ModelState.IsValid)
            {
                repository.Add(machine);
                return RedirectToAction("Index");
            }
            return View(machine);
        }
    }
}