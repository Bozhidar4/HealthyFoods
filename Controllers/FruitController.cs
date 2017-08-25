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
    public class FruitController : Controller
    {
        private HealthContext db = new HealthContext();

        // GET: Fruit
        public ActionResult Index()
        {
            return View(db.Fruits.ToList());
        }

        // GET: Fruit/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fruit fruit = db.Fruits.Find(id);
            if (fruit == null)
            {
                return HttpNotFound();
            }
            return View(fruit);
        }

        // GET: Fruit/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Fruit/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FruitID,Image,Name,Protein,Carbohydrates,Fat,Energy")] Fruit fruit)
        {
            if (ModelState.IsValid)
            {
                db.Fruits.Add(fruit);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fruit);
        }

        // GET: Fruit/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fruit fruit = db.Fruits.Find(id);
            if (fruit == null)
            {
                return HttpNotFound();
            }
            return View(fruit);
        }

        // POST: Fruit/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FruitID,Image,Name,Protein,Carbohydrates,Fat,Energy")] Fruit fruit)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fruit).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fruit);
        }

        // GET: Fruit/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fruit fruit = db.Fruits.Find(id);
            if (fruit == null)
            {
                return HttpNotFound();
            }
            return View(fruit);
        }

        // POST: Fruit/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Fruit fruit = db.Fruits.Find(id);
            db.Fruits.Remove(fruit);
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
