using GreatHRM.Entities;
using GreatHRM.Repo.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatHRM.Repo
{
   public class CompanyRepository:Repository<Company>,ICompanyRepository
    {
        public GreatHRMDbContext _context;

        public CompanyRepository(GreatHRMDbContext context):base(context)
        {
            _context = context;
        }
    }
}
