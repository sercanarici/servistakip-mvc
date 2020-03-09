using ServisTakipMVC.UI.Areas.Admin.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServisTakipMVC.UI.Areas.Admin.Controllers
{
    [AuthFilter]
    public class BayiController : Controller
    {
        // GET: Admin/Bayi
        public ActionResult Index()
        {
            return View();
        }

        // GET: Admin/Bayi/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Bayi/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Bayi/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Bayi/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Bayi/Edit/5
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

        // GET: Admin/Bayi/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Bayi/Delete/5
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
