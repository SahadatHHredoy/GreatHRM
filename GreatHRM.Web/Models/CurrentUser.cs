
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GreatHRM.Web.Models
{
    public static class CurrentUserManager
    {
        public static IdentityUser CurrentUser()
        {
         
            return new IdentityUser()
            {
             

        };
        }


    }
    public class IdentityUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string DisplayName { get; set; }
        public string Image { get; set; }
    }
}
