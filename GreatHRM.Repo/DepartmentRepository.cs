using GreatHRM.Entities;
using GreatHRM.Repo.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatHRM.Repo
{
   public class DepartmentRepository:Repository<Department>, IDepartmentRepository
    {
        private GreatHRMDbContext _context;

        public DepartmentRepository(GreatHRMDbContext context):base(context)
        {
            _context = context;
        }
    }
}
