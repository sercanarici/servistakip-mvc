﻿using ServisTakipMVC.UI.Areas.Admin.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServisTakipMVC.UI.Areas.Admin.Controllers
{
    [AuthFilter]
    public class BakimAnlasmaTipController : Controller
    {
        // GET: Admin/BakimAnlasmaTip
        public ActionResult Index()
        {
            return View();
        }

        // GET: Admin/BakimAnlasmaTip/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/BakimAnlasmaTip/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/BakimAnlasmaTip/Create
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

        // GET: Admin/BakimAnlasmaTip/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/BakimAnlasmaTip/Edit/5
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

        // GET: Admin/BakimAnlasmaTip/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/BakimAnlasmaTip/Delete/5
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
