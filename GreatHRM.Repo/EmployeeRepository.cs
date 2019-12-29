using GreatHRM.Entities;
using GreatHRM.Repo.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatHRM.Repo
{
    public class EmployeeRepository:Repository<Employee>,IEmployeeRepository
    {
        private GreatHRMDbContext _context;

        public EmployeeRepository(GreatHRMDbContext context):base(context)
        {
            _context = context;
        }
    }
}
