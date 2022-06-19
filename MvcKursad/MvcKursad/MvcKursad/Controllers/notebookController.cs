using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcKursad.Models.Entity;
namespace MvcKursad.Controllers
{
    public class notebookController : Controller
    {
        // GET: notebook
        UrunMvcEntities db = new UrunMvcEntities();
        public ActionResult Notebook()
        {
            var degerler = from d in db.urunler select d;
            degerler = degerler.Where(m => m.urunkategori.Contains("Notebook PC"));
            return View(degerler.ToList());
        }
    }
}