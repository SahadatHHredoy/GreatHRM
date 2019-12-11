using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatHRM.Entities
{
    [Table("Designations")]
  public  class Designation:AuditableEntity
    {
        public string DesignationName { get; set; }
        public string Description { get; set; }
    }
}
