using MyLinkhay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyLinkhay.Controllers
{
    public class PatientController : Controller
    {
        //
        // GET: /Patients/
        HMSContext objContext;
        public PatientController()
        {
            objContext = new HMSContext();
        }

        public ActionResult Index()
        {
            var Patients = objContext.Patients.ToList();
            return View(Patients);
        }

        public ActionResult Create()
        {
            var pat = new Patient();
            return View(pat);
        }

        [HttpPost]
        public ActionResult Create(Patient patient)
        {
            objContext.Patients.Add(patient);
            objContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
