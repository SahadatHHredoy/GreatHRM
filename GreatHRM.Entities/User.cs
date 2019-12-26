using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatHRM.Entities
{
    [Table("Users")]
    public class User : AuditableEntity
    {
        [Required]
        [Display(Name = "Role")]
        public string UserName { get; set; }
        public string DisplayName { get; set; }
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
        public string Mobile { get; set; }
        [Required]
        public string Password { get; set; }

        public bool AllowAdminPermission { get; set; }
        public bool AllowPayroll { get; set; }
        public bool AllowAccessControl { get; set; }
        public bool AllowLeave { get; set; }

        public new int? CreatedBy { get; set; }
        [NotMapped]
        public new int? CreatedByUser { get; set; }
        public new int? UpdatedBy { get; set; }
        [NotMapped]
        public new int? UpdatedByUser { get; set; }

        public int RoleId { get; set; }
        [ForeignKey("RoleId")]
        public virtual UserRole UserRole { get; set; }
        public bool SupUser { get; set; }
        public string ImageFile { get; set; }
    }
}
