using MyLinkhay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyLinkhay.Controllers
{
    public class LinkhayController : Controller
    {
        HMSContext objContext;
        //
        // GET: /Linkhay/
        public LinkhayController()
        {
            objContext = new HMSContext();
        }

        public ActionResult Index()
        {
            var linkhays = objContext.Linkhays.ToList();
            return View(linkhays);
        }

        public ActionResult Create()
        {
            var linkhay = new Linkhay();
            return View(linkhay);
        }

        [HttpPost]
        public ActionResult Create(Linkhay linkhay)
        {
            linkhay.UpdateDate = DateTime.Now;
            objContext.Linkhays.Add(linkhay);
            objContext.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
