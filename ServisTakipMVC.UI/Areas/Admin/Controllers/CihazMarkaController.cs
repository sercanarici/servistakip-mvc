using ServisTakipMVC.UI.Areas.Admin.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServisTakipMVC.UI.Areas.Admin.Controllers
{
    [AuthFilter]
    public class CihazMarkaController : Controller
    {
        // GET: Admin/CihazMarka
        public ActionResult Index()
        {
            return View();
        }

        // GET: Admin/CihazMarka/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/CihazMarka/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/CihazMarka/Create
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

        // GET: Admin/CihazMarka/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/CihazMarka/Edit/5
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

        // GET: Admin/CihazMarka/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/CihazMarka/Delete/5
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
