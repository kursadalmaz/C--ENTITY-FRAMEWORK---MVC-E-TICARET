using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcKursad.Models.Entity;

namespace MvcKursad.Controllers
{
    public class MasaustuController : Controller
    {
        // GET: Masaustu
        UrunMvcEntities db = new UrunMvcEntities();
        public ActionResult Masaustu()
        {
            var degerler = from d in db.urunler select d;
            degerler = degerler.Where(m => m.urunkategori.Contains("Masaüstü PC"));
            return View(degerler.ToList());
        }
    }
}