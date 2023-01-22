using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VegetableStore.Models;

namespace VegetableStore.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context = null;

        public ProductsController()
        {
            _context=new ApplicationDbContext();
        }
        // GET: Products
        public ActionResult Index()
        {
            var products = _context.Products.ToList();
            return View(products);
        }

        //public ActionResult Details()
        //{
        //    var products = _context.Products.Include(d)
        //}

        public ActionResult Create()
        {
            var categories=_context.Categories.ToList();
            ViewBag.Categories = categories;

            var packsize=_context.Packsize.ToList();
            ViewBag.Packsize = packsize;
            return View();
        }
        [HttpPost]
        public ActionResult Create(Products product)
        {
            if(ModelState.IsValid)
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }
            var categories = _context.Categories.ToList();
            ViewBag.Categories = categories;

            var packsize = _context.Packsize.ToList();
            ViewBag.Packsize = packsize;
            return View();


        }
    }
}