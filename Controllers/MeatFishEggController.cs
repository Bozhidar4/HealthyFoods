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
    public class MeatFishEggController : Controller
    {
        private HealthContext db = new HealthContext();

        // GET: MeatFishEgg
        public ActionResult Index()
        {
            return View(db.MeatFishEggs.ToList());
        }

        // GET: MeatFishEgg/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MeatFishEgg meatFishEgg = db.MeatFishEggs.Find(id);
            if (meatFishEgg == null)
            {
                return HttpNotFound();
            }
            return View(meatFishEgg);
        }

        // GET: MeatFishEgg/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MeatFishEgg/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MeatFishEggID,Image,Name,Protein,Carbohydrates,Fat,Energy")] MeatFishEgg meatFishEgg)
        {
            if (ModelState.IsValid)
            {
                db.MeatFishEggs.Add(meatFishEgg);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(meatFishEgg);
        }

        // GET: MeatFishEgg/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MeatFishEgg meatFishEgg = db.MeatFishEggs.Find(id);
            if (meatFishEgg == null)
            {
                return HttpNotFound();
            }
            return View(meatFishEgg);
        }

        // POST: MeatFishEgg/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MeatFishEggID,Image,Name,Protein,Carbohydrates,Fat,Energy")] MeatFishEgg meatFishEgg)
        {
            if (ModelState.IsValid)
            {
                db.Entry(meatFishEgg).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(meatFishEgg);
        }

        // GET: MeatFishEgg/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MeatFishEgg meatFishEgg = db.MeatFishEggs.Find(id);
            if (meatFishEgg == null)
            {
                return HttpNotFound();
            }
            return View(meatFishEgg);
        }

        // POST: MeatFishEgg/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MeatFishEgg meatFishEgg = db.MeatFishEggs.Find(id);
            db.MeatFishEggs.Remove(meatFishEgg);
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
