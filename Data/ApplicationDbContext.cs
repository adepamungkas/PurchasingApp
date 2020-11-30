using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PurchasingApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PurchasingApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<PurchaseOrderModel> PurchaseOrders { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
    }
}
