using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PurchasingApp.Data.Migrations
{
    public partial class PurchaseOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PurchaseOrders",
                columns: table => new
                {
                    PurchaseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    VendorName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    VendorCompanyName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    VendorContactName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    VendorAddress = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    VendorPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShippingName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    ShippingCompanyName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    ShippingDept = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    ShippingAddress = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    ShippingPhone = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    ShippingVia = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    ShippingMethod = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    ShippingTerm = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductCode = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    QtyOrder = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<int>(type: "int", nullable: false),
                    PurchaseRemark = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrders", x => x.PurchaseId);
                });

            migrationBuilder.CreateTable(
                name: "Vendors",
                columns: table => new
                {
                    VendorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorName = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    ContactName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    EmailNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendors", x => x.VendorId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PurchaseOrders");

            migrationBuilder.DropTable(
                name: "Vendors");
        }
    }
}
