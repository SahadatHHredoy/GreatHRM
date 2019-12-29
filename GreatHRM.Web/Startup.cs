using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreatHRM.Repo;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using GreatHRM.Repo.Core;
using System.Security.Policy;

namespace GreatHRM.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<GreatHRMDbContext>(options=> {
                options.UseSqlServer(Configuration.GetConnectionString("GreatHRMConnString"));
               
            });
            services.AddScoped<IMachineRepository, MachineRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<IBranchRepository, BranchRepository>();
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<IDesignationRepository, DesignationRepository>();
            services.AddScoped<IOfficeTimeRepository, OfficeTimeRepository>();
            services.AddScoped<IShiftRepository, ShiftRepository>();
            services.AddScoped<ILogRepository, LogRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddWebSocketManager();
            
           
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseRouting();
           
            app.UseStaticFiles();
            app.UseAuthorization();
            app.UseWebSockets();
            var serviceScopeFactory = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>();
            var serviceProvider = serviceScopeFactory.CreateScope().ServiceProvider;
            app.MapWebSocketManager("", serviceProvider.GetService<ChatMessageHandler>());
            app.UseEndpoints(endpoints =>
            {
               
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
               
            });
            
        }
    }
}

