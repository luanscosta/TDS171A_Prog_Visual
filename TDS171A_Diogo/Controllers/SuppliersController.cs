using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TDS171A_Diogo.Context;
using TDS171A_Diogo.Models;

namespace TDS171A_Diogo.Controllers
{
    public class SuppliersController : Controller
    {
        private readonly EFContext _context = new EFContext();
        // GET: Suppliers
        public ActionResult Index()
        {
            return View(_context
                .Suppliers
                .OrderBy( s => s.Name));
        }
        public ActionResult Create(Supplier supplier)
        {
            _context.Suppliers.Add(supplier);
            _context.SaveChanges();

            return RedirectToAction("Index");
            
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Edit()
        {
            return View();
        }
    }
}