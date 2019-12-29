using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GreatHRM.Web.Models;
using GreatHRM.Repo;
using System.Net;
using System.Net.Sockets;

namespace GreatHRM.Web.Controllers
{
    public class HomeController : Controller
    {
     

        public HomeController()
        {
           
        }

        public IActionResult Index()
        {
            return View();
        }
       


    }
}
