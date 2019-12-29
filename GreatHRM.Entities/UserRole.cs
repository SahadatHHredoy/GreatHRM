using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatHRM.Entities
{
    [Table("UserRoles")]
    public class UserRole : Entity
    {
        [MaxLength(1000)]
        [Required]
        [Display(Name = "Role")]
        public string RoleName { get; set; }
        public virtual ICollection<UserRolePermission> RolePermissions { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
