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
    public class UbicacionsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Ubicacions
        public ActionResult Index()
        {
            return View(db.Ubicaciones.ToList());
        }

        // GET: Ubicacions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ubicacion ubicacion = db.Ubicaciones.Find(id);
            if (ubicacion == null)
            {
                return HttpNotFound();
            }
            return View(ubicacion);
        }

        // GET: Ubicacions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ubicacions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id_Ubicaciones,Descripcion,Direccion,Edificio,Estado")] Ubicacion ubicacion)
        {
            if (ModelState.IsValid)
            {
                db.Ubicaciones.Add(ubicacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ubicacion);
        }

        // GET: Ubicacions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ubicacion ubicacion = db.Ubicaciones.Find(id);
            if (ubicacion == null)
            {
                return HttpNotFound();
            }
            return View(ubicacion);
        }

        // POST: Ubicacions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id_Ubicaciones,Descripcion,Direccion,Edificio,Estado")] Ubicacion ubicacion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ubicacion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ubicacion);
        }

        // GET: Ubicacions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ubicacion ubicacion = db.Ubicaciones.Find(id);
            if (ubicacion == null)
            {
                return HttpNotFound();
            }
            return View(ubicacion);
        }

        // POST: Ubicacions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ubicacion ubicacion = db.Ubicaciones.Find(id);
            db.Ubicaciones.Remove(ubicacion);
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
