using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcKursad.Models.Entity;
namespace MvcKursad.Controllers
{
    public class ListeController : Controller
    {
        // GET: Liste
        UrunMvcEntities db = new UrunMvcEntities();

        public ActionResult Index()
        {
            var degerler = db.urunler.ToList();

            return View(degerler);
        }
    }
}