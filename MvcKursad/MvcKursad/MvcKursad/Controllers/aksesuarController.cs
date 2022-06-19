using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcKursad.Models.Entity;
namespace MvcKursad.Controllers
{
    public class aksesuarController : Controller
    {
        // GET: aksesuar
        UrunMvcEntities db = new UrunMvcEntities();
        public ActionResult Aksesuar()
        {
            var degerler = from d in db.urunler select d;
            degerler = degerler.Where(m => m.urunkategori.Contains("Aksesuar"));
            return View(degerler.ToList());
        }
    }
}