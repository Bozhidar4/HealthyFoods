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
    public class BeanController : Controller
    {
        private HealthContext db = new HealthContext();

        // GET: Bean
        public ActionResult Index()
        {
            return View(db.Beans.ToList());
        }

        // GET: Bean/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bean bean = db.Beans.Find(id);
            if (bean == null)
            {
                return HttpNotFound();
            }
            return View(bean);
        }

        // GET: Bean/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bean/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BeanID,Image,Name,Protein,Carbohydrates,Fat,Energy")] Bean bean)
        {
            if (ModelState.IsValid)
            {
                db.Beans.Add(bean);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bean);
        }

        // GET: Bean/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bean bean = db.Beans.Find(id);
            if (bean == null)
            {
                return HttpNotFound();
            }
            return View(bean);
        }

        // POST: Bean/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BeanID,Image,Name,Protein,Carbohydrates,Fat,Energy")] Bean bean)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bean).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bean);
        }

        // GET: Bean/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bean bean = db.Beans.Find(id);
            if (bean == null)
            {
                return HttpNotFound();
            }
            return View(bean);
        }

        // POST: Bean/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Bean bean = db.Beans.Find(id);
            db.Beans.Remove(bean);
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
