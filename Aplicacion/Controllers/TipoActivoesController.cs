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
    public class TipoActivoesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TipoActivoes
        public ActionResult Index()
        {
            return View(db.TipoActivos.ToList());
        }

        // GET: TipoActivoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoActivo tipoActivo = db.TipoActivos.Find(id);
            if (tipoActivo == null)
            {
                return HttpNotFound();
            }
            return View(tipoActivo);
        }

        // GET: TipoActivoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoActivoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Activo,Descripcion,Cuentascontablecompra,Cuentacontabledepreciacion,Estado")] TipoActivo tipoActivo)
        {
            if (ModelState.IsValid)
            {
                db.TipoActivos.Add(tipoActivo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoActivo);
        }

        // GET: TipoActivoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoActivo tipoActivo = db.TipoActivos.Find(id);
            if (tipoActivo == null)
            {
                return HttpNotFound();
            }
            return View(tipoActivo);
        }

        // POST: TipoActivoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Activo,Descripcion,Cuentascontablecompra,Cuentacontabledepreciacion,Estado")] TipoActivo tipoActivo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoActivo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoActivo);
        }

        // GET: TipoActivoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoActivo tipoActivo = db.TipoActivos.Find(id);
            if (tipoActivo == null)
            {
                return HttpNotFound();
            }
            return View(tipoActivo);
        }

        // POST: TipoActivoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoActivo tipoActivo = db.TipoActivos.Find(id);
            db.TipoActivos.Remove(tipoActivo);
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
