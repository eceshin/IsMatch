using is_match.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;

namespace is_match.Controllers
{
    public class HomeController : Controller
    {
        IsMatchEntities db = new IsMatchEntities();
        public ActionResult Index()
        {
            var yorum = db.yorumlar.ToList();

            return View(yorum);

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        [HttpGet]
        public ActionResult BireyselUyeOl()
        {
            return View();
        }



        [HttpPost]
        public ActionResult BireyselUyeOl(bireysel_uyelik b_uye)
        {
            db.bireysel_uyelik.Add(b_uye);
            db.SaveChanges();
            return View();
        }

      
        [HttpPost]
        public ActionResult Index(bireysel_uyelik ad)
        {
            var bilgiler = db.bireysel_uyelik.FirstOrDefault(x =>
                x.b_email == ad.b_email && x.b_sifre == ad.b_sifre);

            if (bilgiler != null)
            {
                return RedirectToAction("Index", "AnaSayfa", new { id = bilgiler.id });
            }
            else
            {
                return View();
            }
        }

        public class RouteConfig
        {
            public static void RegisterRoutes(RouteCollection routes)
            {
                routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

                routes.MapRoute(
                    name: "Default",
                    url: "{controller}/{action}/{id}",
                    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                );
            }
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }


    }
}