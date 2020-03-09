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
    public class HomeController : Controller
    {
        // GET: Admin/Home
        //[LoginFilter]
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult getLoggedUserName()
        {
            var model = (Kullanici)Session["User"];
            return PartialView("_UserPartialView", model);       

        }
    }
}