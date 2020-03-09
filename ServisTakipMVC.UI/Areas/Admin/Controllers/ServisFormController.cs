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
    public class ServisFormController : Controller
    {
        // GET: Admin/ServisForm
        public ActionResult Index()
        {
            using (var repo = new ServisFormRepository())
            {
                var model = repo.Listele(x=>!x.Silindi);
                return View(model);
            }
        }

        // GET: Admin/ServisForm/Details/5
        public ActionResult Details(int id)
        {
            using (var repo = new ServisFormRepository())
            {
                var model = repo.Getir(x => x.Id == id);
                return View(model);
            }
        }

        // GET: Admin/ServisForm/Create
        public ActionResult Create()
        {
            using (MusteriRepository repo = new MusteriRepository())
            {
                var liste = repo.Listele(x => !x.Silindi);
                ViewBag.Musteriler = new SelectList(liste, "Id", "FirmaAdi"); ;
            }

            using (ServisTipRepository repo = new ServisTipRepository())
            {
                var liste = repo.Listele(x => !x.Silindi);
                ViewBag.ServisTipleri = new SelectList(liste, "Id", "Adi"); ;
            }

            using (ServisIcerikRepository repo = new ServisIcerikRepository())
            {
                var liste = repo.Listele(x => !x.Silindi);
                ViewBag.ServisIcerikleri = new SelectList(liste, "Id", "Adi"); ;
            }

            using (ServisSekliRepository repo = new ServisSekliRepository())
            {
                var liste = repo.Listele(x => !x.Silindi);
                ViewBag.ServisSekilleri = new SelectList(liste, "Id", "Adi"); ;
            }

            using (BakimAnlasmaRepository repo = new BakimAnlasmaRepository())
            {
                var liste = repo.Listele(x => !x.Silindi);
                ViewBag.BakimAnlasmalari = new SelectList(liste, "Id", "Musterisi.FirmaAdi"); ;
            }

            return View();

        }

        // POST: Admin/ServisForm/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ServisForm model)
        {
            try
            {

                using (ServisFormRepository repo = new ServisFormRepository())
                {
                    model.KayitTarihi = DateTime.Now;
                    model.KullaniciId = ((Kullanici)Session["User"]).Id;
                    repo.Ekle(model);
                }


                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                //return RedirectToAction(nameof(Create));
                using (MusteriRepository repo = new MusteriRepository())
                {
                    var liste = repo.Listele(x => !x.Silindi);
                    ViewBag.Musteriler = new SelectList(liste, "Id", "FirmaAdi"); ;
                }

                using (ServisTipRepository repo = new ServisTipRepository())
                {
                    var liste = repo.Listele(x => !x.Silindi);
                    ViewBag.ServisTipleri = new SelectList(liste, "Id", "Adi"); ;
                }

                using (ServisIcerikRepository repo = new ServisIcerikRepository())
                {
                    var liste = repo.Listele(x => !x.Silindi);
                    ViewBag.ServisIcerikleri = new SelectList(liste, "Id", "Adi"); ;
                }

                using (ServisSekliRepository repo = new ServisSekliRepository())
                {
                    var liste = repo.Listele(x => !x.Silindi);
                    ViewBag.ServisSekilleri = new SelectList(liste, "Id", "Adi"); ;
                }

                using (BakimAnlasmaRepository repo = new BakimAnlasmaRepository())
                {
                    var liste = repo.Listele(x => !x.Silindi);
                    ViewBag.BakimAnlasmalari = new SelectList(liste, "Id", "Musterisi.FirmaAdi"); ;
                }
                return View(model);
            }
        }

        // GET: Admin/ServisForm/Edit/5
        public ActionResult Edit(int id)
        {
            using (MusteriRepository repo = new MusteriRepository())
            {
                var liste = repo.Listele(x => !x.Silindi);
                ViewBag.Musteriler = new SelectList(liste, "Id", "FirmaAdi"); ;
            }

            using (ServisTipRepository repo = new ServisTipRepository())
            {
                var liste = repo.Listele(x => !x.Silindi);
                ViewBag.ServisTipleri = new SelectList(liste, "Id", "Adi"); ;
            }

            using (ServisIcerikRepository repo = new ServisIcerikRepository())
            {
                var liste = repo.Listele(x => !x.Silindi);
                ViewBag.ServisIcerikleri = new SelectList(liste, "Id", "Adi"); ;
            }

            using (ServisSekliRepository repo = new ServisSekliRepository())
            {
                var liste = repo.Listele(x => !x.Silindi);
                ViewBag.ServisSekilleri = new SelectList(liste, "Id", "Adi"); ;
            }

            using (BakimAnlasmaRepository repo = new BakimAnlasmaRepository())
            {
                var liste = repo.Listele(x => !x.Silindi);
                ViewBag.BakimAnlasmalari = new SelectList(liste, "Id", "Musterisi.FirmaAdi"); ;
            }

            using (var repo = new ServisFormRepository())
            {
                var model = repo.Getir(x=> x.Id==id);
                return View(model);
            }
        }

        // POST: Admin/ServisForm/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ServisForm model)
        {
            try
            {
                using (var repo = new ServisFormRepository())
                {
                    model.GuncellemeTarihi = DateTime.Now;
                    repo.Guncelle(model);
                }

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                using (MusteriRepository repo = new MusteriRepository())
                {
                    var liste = repo.Listele(x => !x.Silindi);
                    ViewBag.Musteriler = new SelectList(liste, "Id", "FirmaAdi"); ;
                }

                using (ServisTipRepository repo = new ServisTipRepository())
                {
                    var liste = repo.Listele(x => !x.Silindi);
                    ViewBag.ServisTipleri = new SelectList(liste, "Id", "Adi"); ;
                }

                using (ServisIcerikRepository repo = new ServisIcerikRepository())
                {
                    var liste = repo.Listele(x => !x.Silindi);
                    ViewBag.ServisIcerikleri = new SelectList(liste, "Id", "Adi"); ;
                }

                using (ServisSekliRepository repo = new ServisSekliRepository())
                {
                    var liste = repo.Listele(x => !x.Silindi);
                    ViewBag.ServisSekilleri = new SelectList(liste, "Id", "Adi"); ;
                }

                using (BakimAnlasmaRepository repo = new BakimAnlasmaRepository())
                {
                    var liste = repo.Listele(x => !x.Silindi);
                    ViewBag.BakimAnlasmalari = new SelectList(liste, "Id", "Musterisi.FirmaAdi"); ;
                }
                return View(model);
            }
        }

        // GET: Admin/ServisForm/Delete/5
        public ActionResult Delete(int id)
        {
            using (var repo = new ServisFormRepository())
            {
                var model = repo.Getir(x => x.Id == id);
                return View(model);
            }

        }

        // POST: Admin/ServisForm/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (var repo = new ServisFormRepository())
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
