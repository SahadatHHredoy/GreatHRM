using GreatHRM.Entities;
using GreatHRM.Repo.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatHRM.Repo
{
  public  interface IUserRepository:IRepository<User>
    {
        User GetUserByUsername(string username);
        User GetValidUserByPassword(string username, string password);
    }
}
