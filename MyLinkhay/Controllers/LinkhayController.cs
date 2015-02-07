using MyLinkhay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Data;
using MyLinkhay.ViewModels;
using PagedList;

namespace MyLinkhay.Controllers
{
    public class LinkhayController : Controller, IDisposable
    {
        public const int PAGE_SIZE = 50;

        public HMSContext objContext;
        //
        // GET: /Linkhay/
        public LinkhayController()
        {
            objContext = new HMSContext();
        }

        public ActionResult Index(int page = 1)
        {
            var linkhays = objContext.Linkhays.OrderByDescending(l => l.UpdateDate).ToPagedList(page, PAGE_SIZE);
            return View(linkhays);
        }

        public ActionResult Create()
        {
            var linkhay = new Linkhay();

            if (Request.IsAjaxRequest())
            {
                return PartialView("_LinkhayCreate", linkhay);
            }

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

        public ActionResult Details(int id)
        {
            var linkHay = objContext.Linkhays.Find(id);

            if (Request.IsAjaxRequest())
            {
                return PartialView("_LinkhayDetails", linkHay);
            }

            return View(linkHay);
        }

        public ActionResult Edit(int id)
        {
            var linkHay = objContext.Linkhays.Find(id);

            if (Request.IsAjaxRequest())
            {
                return PartialView("_LinkhayEdit", linkHay);
            }

            return View(linkHay);
        }

        [HttpPost]
        public ActionResult Edit(Linkhay linkHay){
            if (ModelState.IsValid)
            {
                objContext.Entry(linkHay).State = EntityState.Modified;
                objContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(linkHay);
        }

        public ActionResult Delete(int id)
        {
            var linkhay = objContext.Linkhays.Find(id);

            //objContext.Entry(linkhay).State = EntityState.Deleted;

            objContext.Linkhays.Remove(linkhay);
            objContext.SaveChanges();

            return RedirectToAction("Index"); 
        }


        protected override void Dispose(bool disposing)
        {
            objContext.Dispose();
            base.Dispose(disposing);
        }


    }
}
