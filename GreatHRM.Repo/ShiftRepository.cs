using GreatHRM.Entities;
using GreatHRM.Repo.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatHRM.Repo
{
   public class ShiftRepository:Repository<Shift>,IShiftRepository
    {
        private GreatHRMDbContext _context;
        public ShiftRepository(GreatHRMDbContext context):base(context)
        {
            _context = context;
        }
    }
}
