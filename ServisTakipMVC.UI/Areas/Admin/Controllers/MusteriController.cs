using ServisTakipMVC.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServisTakipMVC.UI.Areas.Admin.Controllers
{
    public class MusteriController : Controller
    {
        // GET: Admin/Musteri
        public ActionResult Index()
        {
            using (MusteriRepository repo = new MusteriRepository())
            {
                var model = repo.Listele();
                return View(model);
            }
        }

        // GET: Admin/Musteri/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Musteri/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Musteri/Create
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

        // GET: Admin/Musteri/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Musteri/Edit/5
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

        // GET: Admin/Musteri/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Musteri/Delete/5
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
