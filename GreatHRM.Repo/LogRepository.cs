using GreatHRM.Entities;
using GreatHRM.Repo.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatHRM.Repo
{
    public class LogRepository:Repository<Log>,ILogRepository
    {
        private GreatHRMDbContext _context;

        public LogRepository(GreatHRMDbContext context):base(context)
        {
            _context = context;
        }
    }
}
