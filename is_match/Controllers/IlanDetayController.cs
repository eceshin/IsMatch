using is_match.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace is_match.Controllers
{
    public class IlanDetayController : Controller
    {
        // GET: IlanDetay
        IlanYorum by=new IlanYorum();
        IsMatchEntities db = new IsMatchEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult IlanDetay(int id)
        {
            by.Deger1 = db.is_ilan.Where(x => x.id == id).ToList();
            by.Deger2 = db.yorumlar.Where(x => x.IlanId == id).ToList();
            return View(by);

        }

        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult YorumYap(yorumlar y)


        {

            db.yorumlar.Add(y);
            db.SaveChanges();
            return PartialView();

        }


    }
}