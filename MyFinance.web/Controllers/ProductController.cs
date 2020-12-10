using MyFinance.domain.Entities;
using MyFinance.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFinance.web.Controllers
{
    public class ProductController : Controller
    {
        ProductService ps;
        CategoryService cs;
        public ProductController()
        {
            ps = new ProductService();
            cs = new CategoryService();
        }

        // GET: Product
        public ActionResult Index()
        {

            return View(ps.GetAll());
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            var ListCategory = cs.GetAll();
            ViewBag.CategoryId = new SelectList(ListCategory,"CategoryId","Name");
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(Product prod)
        {
            
            try
            {
                // TODO: Add insert logic here
                ps.Add(prod);
                ps.Commit();
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
