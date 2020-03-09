using ServisTakipMVC.BLL;
using ServisTakipMVC.MODEL;
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
            string qs = Request.QueryString["table_search"];
           
            using (MusteriRepository repo = new MusteriRepository())
            {
                List<Musteri> musteriList;

                if (qs !=null && qs.Length>0)
                {
                    musteriList = repo.Listele(x => !x.Silindi && x.FirmaAdi.Contains(qs)).ToList();
                }
                else
                {
                    musteriList = repo.Listele(x => !x.Silindi).ToList();
                }

                return View(musteriList);
            }
        }

        // GET: Admin/Musteri/Details/5
        public ActionResult Details(int id)
        {
            using (var repo = new MusteriRepository())
            {
                var model = repo.Getir(x => x.Id == id);
                return View(model);

            }
        }

        // GET: Admin/Musteri/Create
        public ActionResult Create()
        {
            using (BayiRepository bayiRepo = new BayiRepository())
            {
                var bayiler = bayiRepo.Listele(x => !x.Silindi);
                ViewBag.Bayiler = new SelectList(bayiler, "Id", "Adi"); ;
            }
            return View();
        }

        // POST: Admin/Musteri/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Musteri model)
        {
            try
            {

                using (MusteriRepository repo = new MusteriRepository())
                {
                    model.KayitTarihi = DateTime.Now;
                    repo.Ekle(model);
                }


                return RedirectToAction("Index");
            }
            catch
            {
                //return RedirectToAction(nameof(Create));
                using (BayiRepository bayiRepo = new BayiRepository())
                {
                    var bayiler = bayiRepo.Listele(x => !x.Silindi);
                    ViewBag.Bayiler = new SelectList(bayiler, "Id", "Adi"); ;
                }
                return View(model);
            }
        }

        // GET: Admin/Musteri/Edit/5
        public ActionResult Edit(int id)
        {
            using (BayiRepository bayiRepo = new BayiRepository())
            {
                var bayiler = bayiRepo.Listele(x => !x.Silindi);
                ViewBag.Bayiler = new SelectList(bayiler, "Id", "Adi"); ;
            }

            using (var repo = new MusteriRepository())
            {
                var model = repo.Getir(x => x.Id == id);
                return View(model);
            }
        }

        // POST: Admin/Musteri/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Musteri model)
        {
            try
            {
                using (var repo = new MusteriRepository())
                {
                    model.GuncellemeTarihi = DateTime.Now;
                    repo.Guncelle(model);
                }               

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                using (BayiRepository bayiRepo = new BayiRepository())
                {
                    var bayiler = bayiRepo.Listele(x => !x.Silindi);
                    ViewBag.Bayiler = new SelectList(bayiler, "Id", "Adi"); ;
                }
                return View(model);
            }
        }

        // GET: Admin/Musteri/Delete/5
        public ActionResult Delete(int id)
        {
            using (var repo = new MusteriRepository())
            {
                var model = repo.Getir(x=>x.Id==id);
                return View(model);
            }
        }

        // POST: Admin/Musteri/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection fc)
        {
            try
            {
                using (var repo = new MusteriRepository())
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
