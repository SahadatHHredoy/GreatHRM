using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace GreatHRM.Repo
{
  public  class GreatHRMContextFactory: IDesignTimeDbContextFactory<GreatHRMDbContext>
    {
        public IConfiguration Configuration { get; }
        public GreatHRMDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<GreatHRMDbContext>();
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("GreatHRMConnString"));

            return new GreatHRMDbContext(optionsBuilder.Options);
        }
    }
}
