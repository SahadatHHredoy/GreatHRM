using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatHRM.Entities
{
    [Table("Departments")]
    public  class Department:AuditableEntity
    {
        public string DepartmentName { get; set; }
        public string HeadEmail { get; set; }
    }
}
