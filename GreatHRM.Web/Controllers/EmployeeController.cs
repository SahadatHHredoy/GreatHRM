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
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository repository;
        private readonly ICompanyRepository companyRepository;
        private readonly IBranchRepository branchRepository;
        private readonly IDepartmentRepository departmentRepository;
        private readonly IDesignationRepository designationRepository;
        private readonly IShiftRepository shiftRepository;
        private readonly IOfficeTimeRepository officeTimeRepository;

        public EmployeeController(IEmployeeRepository repository,ICompanyRepository companyRepository,IBranchRepository branchRepository,IDepartmentRepository departmentRepository,IDesignationRepository designationRepository,IShiftRepository shiftRepository,IOfficeTimeRepository officeTimeRepository)
        {
            this.repository = repository;
            this.companyRepository = companyRepository;
            this.branchRepository = branchRepository;
            this.departmentRepository = departmentRepository;
            this.designationRepository = designationRepository;
            this.shiftRepository = shiftRepository;
            this.officeTimeRepository = officeTimeRepository;
        }
        public IActionResult Index()
        {
            return View(repository.GetAll());
        }
        public IActionResult Add()
        {
            ViewBag.CompanyId = new SelectList(companyRepository.GetAll(x => x.Status != 0), "Id", "CompanyName");
            ViewBag.BranchId = new SelectList(branchRepository.GetAll(x => x.Status != 0), "Id", "BranchName");
            ViewBag.DepartmentId = new SelectList(departmentRepository.GetAll(x => x.Status != 0), "Id", "DepartmentName");
            ViewBag.DesignationId = new SelectList(designationRepository.GetAll(x => x.Status != 0), "Id", "DesignationName");
            ViewBag.ShiftId = new SelectList(shiftRepository.GetAll(x => x.Status != 0), "Id", "ShiftName");
            ViewBag.OfficeTimePolicyId = new SelectList(officeTimeRepository.GetAll(x => x.Status != 0), "Id", "PolicyName");
            return View();
        }
        [HttpPost]
        public IActionResult Add(Employee employee)
        {
            if (ModelState.IsValid)
            {
                repository.Add(employee);
                return RedirectToAction("Index");
            }
            return View(employee);
        }
    }
}