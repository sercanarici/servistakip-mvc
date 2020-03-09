using ServisTakipMVC.UI.Areas.Admin.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServisTakipMVC.UI.Areas.Admin.Controllers
{
    [AuthFilter]
    public class CihazModelController : Controller
    {
        // GET: Admin/CihazModel
        public ActionResult Index()
        {
            return View();
        }

        // GET: Admin/CihazModel/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/CihazModel/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/CihazModel/Create
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

        // GET: Admin/CihazModel/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/CihazModel/Edit/5
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

        // GET: Admin/CihazModel/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/CihazModel/Delete/5
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
