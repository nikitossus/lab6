using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        TransportationContext db = new TransportationContext();

        public ActionResult Index()
        {
            IEnumerable<Tb_Companies> companies = db.Tb_Companies;
            ViewBag.Tb_Companies = companies;

            IEnumerable<Tb_Transportation> transportation = db.Tb_Transportation;
            ViewBag.Tb_Transportation = transportation;

            IEnumerable<Tb_Transport> transport = db.Tb_Transport;
            ViewBag.Tb_Transport = transport;
            return View();
        }
        
        [HttpGet]
        public ActionResult Order(int id)
        {
            ViewBag.TRansportationTRId = id;
            return View();
        }

        [HttpPost]
        public ActionResult Order(Tb_Transport transport)
        {
            transport.Date = DateTime.Now;
            db.Tb_Transport.Add(transport);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TransportId,CarBrand,VehiclePlate,Date,CompaniesTRId,TRansportationTRId")] Tb_Transport tb_Transport)
        {
            if (ModelState.IsValid)
            {
                tb_Transport.Date = DateTime.Now;
                db.Tb_Transport.Add(tb_Transport);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb_Transport);
        }

    }
}