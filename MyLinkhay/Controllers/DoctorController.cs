using MyLinkhay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyLinkhay.Controllers
{
    public class DoctorController : Controller
    {
        HMSContext objContext;

        public DoctorController()
        {
            objContext = new HMSContext();
        }
        //
        // GET: /Doctors/

        public ActionResult Index()
        {
            var Doctors = objContext.Doctors.ToList();
            return View(Doctors);
        }

        public ActionResult Create()
        {
            Doctor doc = new Doctor();
            return View(doc);
        }

        [HttpPost]
        public ActionResult Create(Doctor doctor)
        {
            objContext.Doctors.Add(doctor);
            objContext.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
