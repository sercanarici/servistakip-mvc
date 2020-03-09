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
        public ActionResult Index()
        {
            return View();
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