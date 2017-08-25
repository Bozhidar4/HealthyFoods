using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HealthyFoods.DAL;
using HealthyFoods.Models;

namespace HealthyFoods.Controllers
{
    public class NutController : Controller
    {
        private HealthContext db = new HealthContext();

        // GET: Nut
        public ActionResult Index()
        {
            return View(db.Nuts.ToList());
        }

        // GET: Nut/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nut nut = db.Nuts.Find(id);
            if (nut == null)
            {
                return HttpNotFound();
            }
            return View(nut);
        }

        // GET: Nut/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Nut/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NutID,Image,Name,Protein,Carbohydrates,Fat,Energy")] Nut nut)
        {
            if (ModelState.IsValid)
            {
                db.Nuts.Add(nut);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nut);
        }

        // GET: Nut/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nut nut = db.Nuts.Find(id);
            if (nut == null)
            {
                return HttpNotFound();
            }
            return View(nut);
        }

        // POST: Nut/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NutID,Image,Name,Protein,Carbohydrates,Fat,Energy")] Nut nut)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nut).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nut);
        }

        // GET: Nut/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nut nut = db.Nuts.Find(id);
            if (nut == null)
            {
                return HttpNotFound();
            }
            return View(nut);
        }

        // POST: Nut/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Nut nut = db.Nuts.Find(id);
            db.Nuts.Remove(nut);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
