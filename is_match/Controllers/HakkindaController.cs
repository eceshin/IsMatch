using is_match.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace is_match.Controllers
{
    public class HakkindaController : Controller
    {
        // GET: Hakkinda
        IsMatchEntities db = new IsMatchEntities();
        public ActionResult Index()
        {
            var yonetim = db.yonetici.ToList();

            return View(yonetim);
           
        }
    }
}