using ServisTakipMVC.BLL;
using ServisTakipMVC.MODEL;
using ServisTakipMVC.UI.Areas.Admin.Filters;
using ServisTakipMVC.UI.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServisTakipMVC.UI.Areas.Admin.Controllers
{    
    public class KullaniciController : Controller
    {
        // GET: Admin/Kullanici
        [LoginFilter]
        public ActionResult Index()
        {
            using (KullaniciRepository repo = new KullaniciRepository())
            {
                var model = repo.Listele();
                return View(model);
            }
        }

        // GET: Admin/Kullanici/Create
        [LoginFilter]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Kullanici/Create
        [LoginFilter]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Kullanici model)
        {
            try
            {

                using (KullaniciRepository repo = new KullaniciRepository())
                {
                    model.KayitTarihi = DateTime.Now;
                    repo.Ekle(model);
                }


                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }

        // GET: Admin/Kullanici/Edit/5
        [LoginFilter]
        public ActionResult Edit(int id)
        {
            using (var repo = new KullaniciRepository())
            {
                var model = repo.Getir(x => x.Id == id);
                return View(model);
            }
        }

        // POST: Admin/Kullanici/Edit/5
        [LoginFilter]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Kullanici model)
        {
            try
            {
                using (var repo = new KullaniciRepository())
                {
                    model.GuncellemeTarihi = DateTime.Now;
                    repo.Guncelle(model);
                }

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {   
                return View(model);
            }
        }

        // GET: Admin/Kullanici/Delete/5
        [LoginFilter]
        public ActionResult Delete(int id)
        {
            using (var repo = new KullaniciRepository())
            {
                var model = repo.Getir(x => x.Id == id);
                return View(model);
            }
        }

        // POST: Admin/Kullanici/Delete/5
        [LoginFilter]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection fc)
        {
            try
            {
                using (var repo = new KullaniciRepository())
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

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                using (KullaniciRepository repo = new KullaniciRepository())
                {
                    Kullanici durum = repo.Getir(x => x.KullaniciAdi == model.KullaniciAdi && x.Parola == model.Parola && x.Silindi == false);

                    if (durum != null)
                    {
                        //TempData["Mesaj"] = new TempDataDictionary { { "class", "alert alert-success" }, { "mesaj", "Başarılı." } };
                        //TempData["Mesaj"] = new TempDataDictionary { { "class", "alert alert-success" }, { "mesaj", "Başarılı." } };
                        Session["User"] = durum;

                        durum.SonGirisZamani = DateTime.Now;
                        repo.Guncelle(durum);
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        //TempData["Mesaj"] = new TempDataDictionary { { "class", "alert alert-danger" }, { "mesaj", "Başarısız." } };
                        TempData["Mesaj"] = "Yanlış kullanıcı adı veya parola";
                        return View();
                    }
                }
            }
            //TempData["Mesaj"] = new TempDataDictionary { { "class", "alert alert-danger" }, { "mesaj", "Bilgileri eksiksiz giriniz." } };
            TempData["Mesaj"] = "LÜtfen bilgileri eksiksiz giriniz.";
            return View();
        }

        [LoginFilter]
        public ActionResult Logout()
        {
            Session["User"] = null;
            Session.Remove("User");
            Session.Abandon();
            return RedirectToAction("Login");
        }
    }
}