using GreatHRM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace GreatHRM.Repo.Core
{
    public class UserRepository : Repository<User>,IUserRepository
    {
        private readonly GreatHRMDbContext _context;

        public UserRepository(GreatHRMDbContext context)
            : base(context)
        {
            _context = context;
        }
        public IEnumerable<User> GetAllUsers()
        {
            var users = _context.Users.Where(x => x.Status != 2);
            return users.OrderBy(x => x.DisplayName);
        }
        public User GetUserByUsername(string username)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserName.ToUpper() == username.ToUpper() && u.Status != 0);
            return user;

        }
        public bool CheckUsernameIsValid(string username)
        {
            return _context.Users.Any(u => u.UserName.ToUpper() == username.ToUpper() && u.Status != 0);
        }
        public User GetValidUserByPassword(string username, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserName.ToUpper() == username.ToUpper() && u.Status != 0 && u.Password.Equals(password));
            return user;

        }

      
        public bool IsUserNameExist(string UserName, string InitialUserName)
        {
            bool isNotExist = true;
            if (UserName != string.Empty && InitialUserName == "undefined")
            {
                var isExist = _context.Users.Any(x => x.Status != 0 && x.UserName.ToLower().Equals(UserName.ToLower()));
                if (isExist)
                {
                    isNotExist = false;
                }
            }
            if (UserName != string.Empty && InitialUserName != "undefined")
            {
                var isExist = _context.Users.Any(x => x.Status != 0 && x.UserName.ToLower() == UserName.ToLower() && x.UserName.ToLower() != InitialUserName.ToLower());
                if (isExist)
                {
                    isNotExist = false;
                }
            }
            return isNotExist;
        }
        public bool IsEmailExist(string Email, string InitialEmail)
        {
            bool isNotExist = true;
            if (Email != string.Empty && InitialEmail == "undefined")
            {
                var isExist = _context.Users.Any(x => x.Status != 0 && x.Email.ToLower().Equals(Email.ToLower()));
                if (isExist)
                {
                    isNotExist = false;
                }
            }
            if (Email != string.Empty && InitialEmail != "undefined")
            {
                var isExist = _context.Users.Any(x => x.Status != 0 && x.Email.ToLower() == Email.ToLower() && x.Email.ToLower() != InitialEmail.ToLower());
                if (isExist)
                {
                    isNotExist = false;
                }
            }
            return isNotExist;
        }
      
    }
}
