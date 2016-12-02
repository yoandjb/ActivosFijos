using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Aplicacion.Models;

namespace Aplicacion.Controllers
{
    public class ProovedorsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Proovedors
        public ActionResult Index()
        {
            return View(db.Proveedores.ToList());
        }

        // GET: Proovedors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Proovedor proovedor = db.Proveedores.Find(id);
            if (proovedor == null)
            {
                return HttpNotFound();
            }
            return View(proovedor);
        }

        // GET: Proovedors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Proovedors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Proveedor,Nombre,Cedula,Tipodepersona,Fechadeingreso,Estado")] Proovedor proovedor)
        {
            if (ModelState.IsValid)
            {
                db.Proveedores.Add(proovedor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(proovedor);
        }

        // GET: Proovedors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Proovedor proovedor = db.Proveedores.Find(id);
            if (proovedor == null)
            {
                return HttpNotFound();
            }
            return View(proovedor);
        }

        // POST: Proovedors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Proveedor,Nombre,Cedula,Tipodepersona,Fechadeingreso,Estado")] Proovedor proovedor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(proovedor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(proovedor);
        }

        // GET: Proovedors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Proovedor proovedor = db.Proveedores.Find(id);
            if (proovedor == null)
            {
                return HttpNotFound();
            }
            return View(proovedor);
        }

        // POST: Proovedors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Proovedor proovedor = db.Proveedores.Find(id);
            db.Proveedores.Remove(proovedor);
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
