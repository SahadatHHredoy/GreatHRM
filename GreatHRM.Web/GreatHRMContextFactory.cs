using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.IO;

namespace GreatHRM.Repo
{
  public  class GreatHRMContextFactory: IDesignTimeDbContextFactory<GreatHRMDbContext>
    {
        public IConfiguration Configuration { get; }
        public GreatHRMDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("appsettings.json")
             .Build();
            var builder = new DbContextOptionsBuilder<GreatHRMDbContext>();
            var connectionString = configuration.GetConnectionString("GreatHRMConnString");
            builder.UseSqlServer(connectionString);
            return new GreatHRMDbContext(builder.Options);
        }
    }
}
