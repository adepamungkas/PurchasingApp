using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PurchasingApp.Data;
using PurchasingApp.Models;

namespace PurchasingApp.Controllers
{
    public class PurchaseOrderModelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PurchaseOrderModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PurchaseOrderModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.PurchaseOrders.ToListAsync());
        }

        // GET: PurchaseOrderModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchaseOrderModel = await _context.PurchaseOrders
                .FirstOrDefaultAsync(m => m.PurchaseId == id);
            if (purchaseOrderModel == null)
            {
                return NotFound();
            }

            return View(purchaseOrderModel);
        }

        // GET: PurchaseOrderModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PurchaseOrderModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PurchaseId,OrderNumber,VendorName,VendorCompanyName,VendorContactName,VendorAddress,VendorPhone,ShippingName,ShippingCompanyName,ShippingDept,ShippingAddress,ShippingPhone,ShippingVia,ShippingMethod,ShippingTerm,DeliveryDate,OrderyDate,ProductCode,ProductName,QtyOrder,UnitPrice,PurchaseRemark")] PurchaseOrderModel purchaseOrderModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(purchaseOrderModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(purchaseOrderModel);
        }

        // GET: PurchaseOrderModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchaseOrderModel = await _context.PurchaseOrders.FindAsync(id);
            if (purchaseOrderModel == null)
            {
                return NotFound();
            }
            return View(purchaseOrderModel);
        }

        // POST: PurchaseOrderModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PurchaseId,OrderNumber,VendorName,VendorCompanyName,VendorContactName,VendorAddress,VendorPhone,ShippingName,ShippingCompanyName,ShippingDept,ShippingAddress,ShippingPhone,ShippingVia,ShippingMethod,ShippingTerm,DeliveryDate,OrderyDate,ProductCode,ProductName,QtyOrder,UnitPrice,PurchaseRemark")] PurchaseOrderModel purchaseOrderModel)
        {
            if (id != purchaseOrderModel.PurchaseId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(purchaseOrderModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PurchaseOrderModelExists(purchaseOrderModel.PurchaseId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(purchaseOrderModel);
        }

        // GET: PurchaseOrderModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchaseOrderModel = await _context.PurchaseOrders
                .FirstOrDefaultAsync(m => m.PurchaseId == id);
            if (purchaseOrderModel == null)
            {
                return NotFound();
            }

            return View(purchaseOrderModel);
        }

        // POST: PurchaseOrderModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var purchaseOrderModel = await _context.PurchaseOrders.FindAsync(id);
            _context.PurchaseOrders.Remove(purchaseOrderModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PurchaseOrderModelExists(int id)
        {
            return _context.PurchaseOrders.Any(e => e.PurchaseId == id);
        }
    }
}
