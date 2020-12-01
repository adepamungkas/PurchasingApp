using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PurchasingApp.Models
{
    public class PurchaseOrderModel
    {
        [Key]
        public int PurchaseId { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Order Number")]
        [Required(ErrorMessage = "The Order Number Field is required.")]
        [MaxLength(30, ErrorMessage = "Maximum 12 characters only")]
        public string OrderNumber { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Vendor")]
        [Required(ErrorMessage = "The Vendor Name Field is required.")]
        public string VendorName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Vendor Company Name")]
        [Required(ErrorMessage = "The Vendor Name Field is required.")]
        public string VendorCompanyName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Vendor Contact Name")]
        [Required(ErrorMessage = "The Vendor Contact Name is required.")]
        public string VendorContactName { get; set; }

        [Column(TypeName = "nvarchar(11)")]
        [DisplayName("Vendor Address")]
        [Required(ErrorMessage = "The Vendor Address is required.")]
        [MaxLength(30)]
        public string VendorAddress { get; set; }

        [DisplayName("Vendor Phone")]
        [Required(ErrorMessage = "The Vendor Phone is required.")]
        public string VendorPhone { get; set; }


        //Modif
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Shipping To")]
        public string ShippingName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Shipping Company Name")]
        public string ShippingCompanyName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Shipping Departement")]
        public string ShippingDept { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Shipping Adress")]
        public string ShippingAddress { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Shipping Phone")]
        public string ShippingPhone { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Shipping Via")]
        public string ShippingVia { get; set; }


        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Shipping Method")]
        public string ShippingMethod { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Shipping Term")]
        public string ShippingTerm { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DeliveryDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime OrderyDate { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Product Code")]
        public string ProductCode { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Product Name")]
        public string ProductName { get; set; }


        [DisplayName("Qty Order")]
        public int QtyOrder { get; set; }

        [DisplayName("Unit Price")]
        public int UnitPrice { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Purchase Remark")]
        public string PurchaseRemark { get; set; }
    }
}
