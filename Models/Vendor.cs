using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PurchasingApp.Models
{
    public class Vendor
    {
        [Key]
        public int VendorId { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Vendor Number")]
        [Required(ErrorMessage = "This Field is required.")]
        [MaxLength(12, ErrorMessage = "Maximum 12 characters only")]
        public string VendorName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Contact Name")]
        [Required(ErrorMessage = "This Field is required.")]
        public string ContactName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Adress Name")]
        [Required(ErrorMessage = "This Field is required.")]
        public string Adress { get; set; }

        [Column(TypeName = "nvarchar(11)")]
        [DisplayName("Phone Number")]
        [Required(ErrorMessage = "This Field is required.")]
        [MaxLength(11)]
        public string PhoneNumber { get; set; }

        [DisplayName("Email Address")]
        [Required(ErrorMessage = "This Field is required.")]
        public string EmailNumber { get; set; }
    }
}
