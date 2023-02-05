using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using Mvc_Cv_Project.Models.Entity;

namespace Mvc_Cv_Project.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        // GET: Default
        DbCvEntities1 db = new DbCvEntities1();
        public ActionResult Index()
        {
            var degerler = db.TblHakkimda.ToList();
            return View(degerler);
        }
        public ActionResult Hakkımda()
        {
            var s = db.TblHakkimda.ToList();
            return View(s);
        }

        public PartialViewResult Egitim()
        {
            var egitim = db.TblEgitimlerim.ToList();
            return PartialView(egitim);
        }
        public PartialViewResult Yetenekler()
        {
            var yetenek = db.TblYetenekler.ToList();
            return PartialView(yetenek);
        }
        public PartialViewResult Sertifikalar()
        {
            var sertifika = db.TblSertifikalarim.ToList();
            return PartialView(sertifika);
        }
        public PartialViewResult Projeler()
        {
            var proje = db.TblDeneyimlerim.ToList();
            return PartialView(proje);
        }
        public PartialViewResult Tecrubelerim()
        {
            var tecrube = db.TblTecrubelerim.ToList();
            return PartialView(tecrube);
        }
        [HttpGet]
        public PartialViewResult iletisim()
        {
            var iletisimm = db.TblHakkimda.ToList();
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult iletisim(Tbliletisim t)
        {
            t.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.Tbliletisim.Add(t);
            db.SaveChanges();
            return PartialView();
        }

    }
}