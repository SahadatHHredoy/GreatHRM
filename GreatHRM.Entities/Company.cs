using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatHRM.Entities
{
    [Table("Companies")]
   public class Company:AuditableEntity
    {
        [Required]
        [Display(Name ="Company Name")]
        public string CompanyName { get; set; }

        public string Address { get; set; }
        public string Email { get; set; }
        [Display(Name = "Phone No")]
        public string PhoneNo { get; set; }

        public string Description { get; set; }
        public string VatNo { get; set; }
        public string PFNo { get; set; }
        public string TaxNo { get; set; }
        public string TinNo { get; set; }
        public string RegistrationNo { get; set; }
        public string ESINo { get; set; }
        public string PanCardNo { get; set; }
        public double PFPercent { get; set; }
        public double EPFPercent { get; set; }
        public double PPFPercent { get; set; }
        public double ESIPercent { get; set; }

    }
}
