using is_match.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace is_match.Controllers
{
    public class BireyselController : Controller
    {
        // GET: Bireysel
        IsMatchEntities db = new IsMatchEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Bireysel(int id)
        {
            var bireysel= db.bireysel_uyelik.Where(x => x.id == id).ToList();
            return View(bireysel);
        }

    }
}