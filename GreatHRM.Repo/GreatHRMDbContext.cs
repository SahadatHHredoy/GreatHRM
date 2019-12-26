using GreatHRM.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatHRM.Repo
{
   public class GreatHRMDbContext:DbContext
    {
       public GreatHRMDbContext(DbContextOptions<GreatHRMDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<UserRolePermission> UserRolePermissions { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<OfficeTimePolicy> OfficeTimePolicies { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<SecondWeeklyOff> SecondWeeklyOffs { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Holiday> Holidays { get; set; }
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<HolidayEmployee> HolidayEmployees { get; set; }
        public DbSet<Machine> Machines { get; set; }
        public DbSet<Log> Logs { get; set; }
    }
}
