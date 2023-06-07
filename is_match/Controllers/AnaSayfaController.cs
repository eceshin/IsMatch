using is_match.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace is_match.Controllers
{
    public class AnaSayfaController : Controller
    {

        IsMatchEntities db = new IsMatchEntities();
        // GET: AnaSayfa
        public ActionResult Index(int id)
        {
            var ilanlar= db.is_ilan.ToList();

                return View(ilanlar);

        }
            
      


    }
}