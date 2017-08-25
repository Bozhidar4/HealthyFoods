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
    public class VegetableController : Controller
    {
        private HealthContext db = new HealthContext();

        // GET: Vegetable
        public ActionResult Index()
        {
            return View(db.Vegetables.ToList());
        }

        // GET: Vegetable/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vegetable vegetable = db.Vegetables.Find(id);
            if (vegetable == null)
            {
                return HttpNotFound();
            }
            return View(vegetable);
        }

        // GET: Vegetable/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Vegetable/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VegetableID,Image,Name,Protein,Carbohydrates,Fat,Energy")] Vegetable vegetable)
        {
            if (ModelState.IsValid)
            {
                db.Vegetables.Add(vegetable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vegetable);
        }

        // GET: Vegetable/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vegetable vegetable = db.Vegetables.Find(id);
            if (vegetable == null)
            {
                return HttpNotFound();
            }
            return View(vegetable);
        }

        // POST: Vegetable/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VegetableID,Image,Name,Protein,Carbohydrates,Fat,Energy")] Vegetable vegetable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vegetable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vegetable);
        }

        // GET: Vegetable/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vegetable vegetable = db.Vegetables.Find(id);
            if (vegetable == null)
            {
                return HttpNotFound();
            }
            return View(vegetable);
        }

        // POST: Vegetable/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Vegetable vegetable = db.Vegetables.Find(id);
            db.Vegetables.Remove(vegetable);
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
