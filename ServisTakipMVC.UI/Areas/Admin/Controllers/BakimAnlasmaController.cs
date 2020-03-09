using ServisTakipMVC.BLL;
using ServisTakipMVC.MODEL;
using ServisTakipMVC.UI.Areas.Admin.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServisTakipMVC.UI.Areas.Admin.Controllers
{
    [AuthFilter]
    public class BakimAnlasmaController : Controller
    {
        // GET: Admin/BakimAnlasma
        public ActionResult Index()
        {
            using (var repo = new BakimAnlasmaRepository())
            {
                var model = repo.Listele(x => !x.Silindi);
                return View(model);
            }

        }

        // GET: Admin/BakimAnlasma/Details/5
        public ActionResult Details(int id)
        {
            using (BakimAnlasmaRepository repo = new BakimAnlasmaRepository())
            {
                var model = repo.Getir(x=> x.Id==id);
                return View(model);

            }
        }

        // GET: Admin/BakimAnlasma/Create
        public ActionResult Create()
        {
            using (MusteriRepository repo = new MusteriRepository())
            {
                var musteriler = repo.Listele(x => !x.Silindi);
                ViewBag.Musteriler = new SelectList(musteriler, "Id", "FirmaAdi"); ;
            }

            using (BakimAnlasmaTipRepository repo = new BakimAnlasmaTipRepository())
            {
                var anlasmaTipleri = repo.Listele(x => !x.Silindi);
                ViewBag.AnlasmaTipleri = new SelectList(anlasmaTipleri, "Id", "Adi"); ;
            }
            return View();
        }

        // POST: Admin/BakimAnlasma/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BakimAnlasma model)
        {
            try
            {
                using (BakimAnlasmaRepository repo = new BakimAnlasmaRepository())
                {
                    model.KayitTarihi = DateTime.Now;                    
                    repo.Ekle(model);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                using (MusteriRepository repo = new MusteriRepository())
                {
                    var musteriler = repo.Listele(x => !x.Silindi);
                    ViewBag.Musteriler = new SelectList(musteriler, "Id", "FirmaAdi"); ;
                }

                using (BakimAnlasmaTipRepository repo = new BakimAnlasmaTipRepository())
                {
                    var anlasmaTipleri = repo.Listele(x => !x.Silindi);
                    ViewBag.AnlasmaTipleri = new SelectList(anlasmaTipleri, "Id", "Adi"); ;
                }
                return View(model);
            }
        }

        // GET: Admin/BakimAnlasma/Edit/5
        public ActionResult Edit(int id)
        {
            using (MusteriRepository repo = new MusteriRepository())
            {
                var musteriler = repo.Listele(x => !x.Silindi);
                ViewBag.Musteriler = new SelectList(musteriler, "Id", "FirmaAdi"); ;
            }

            using (BakimAnlasmaTipRepository repo = new BakimAnlasmaTipRepository())
            {
                var anlasmaTipleri = repo.Listele(x => !x.Silindi);
                ViewBag.AnlasmaTipleri = new SelectList(anlasmaTipleri, "Id", "Adi"); ;
            }

            using (BakimAnlasmaRepository repo = new BakimAnlasmaRepository())
            {
                var model = repo.Getir(x=> x.Id==id);
                return View(model);
            }
        }

        // POST: Admin/BakimAnlasma/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, BakimAnlasma model)
        {
            try
            {
                using (BakimAnlasmaRepository repo = new BakimAnlasmaRepository())
                {
                    model.GuncellemeTarihi = DateTime.Now;
                    repo.Guncelle(model);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                using (MusteriRepository repo = new MusteriRepository())
                {
                    var musteriler = repo.Listele(x => !x.Silindi);
                    ViewBag.Musteriler = new SelectList(musteriler, "Id", "FirmaAdi"); ;
                }

                using (BakimAnlasmaTipRepository repo = new BakimAnlasmaTipRepository())
                {
                    var anlasmaTipleri = repo.Listele(x => !x.Silindi);
                    ViewBag.AnlasmaTipleri = new SelectList(anlasmaTipleri, "Id", "Adi"); ;
                }

                return View(model);
            }
        }

        // GET: Admin/BakimAnlasma/Delete/5
        public ActionResult Delete(int id)
        {
            using (var repo = new BakimAnlasmaRepository())
            {
                var model = repo.Getir(x => x.Id == id);
                return View(model);
            }
        }

        // POST: Admin/BakimAnlasma/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Delete(int id, FormCollection fc)
        {
            try
            {
                using (var repo = new BakimAnlasmaRepository())
                {
                    var model = repo.Getir(x => x.Id == id);
                    model.Silindi = true;
                    repo.Guncelle(model);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
