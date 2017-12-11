using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using disec.Areas.Seget.Models;

namespace disec.Areas.Seget.Controllers
{
    public class OFPLA_UNIDADController : Controller
    {
        private ContextSeget db = new ContextSeget();

        // GET: Seget/OFPLA_UNIDAD
        public ActionResult Index()
        {
            return View(db.OFPLA_UNIDAD.ToList());
        }

        // GET: Seget/OFPLA_UNIDAD/Details/5
        public ActionResult Details(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OFPLA_UNIDAD oFPLA_UNIDAD = db.OFPLA_UNIDAD.Find(id);
            if (oFPLA_UNIDAD == null)
            {
                return HttpNotFound();
            }
            return View(oFPLA_UNIDAD);
        }

        // GET: Seget/OFPLA_UNIDAD/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Seget/OFPLA_UNIDAD/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UNIDAD_ID,UNDE_LUGAR_GEOGRAFICO,IDENTIFICACION_CREA,FECHA_CREACION,MAQUINA_CREACION,VIGENTE,UNDE_CONSECUTIVO")] OFPLA_UNIDAD oFPLA_UNIDAD)
        {
            if (ModelState.IsValid)
            {
                db.OFPLA_UNIDAD.Add(oFPLA_UNIDAD);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(oFPLA_UNIDAD);
        }

        // GET: Seget/OFPLA_UNIDAD/Edit/5
        public ActionResult Edit(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OFPLA_UNIDAD oFPLA_UNIDAD = db.OFPLA_UNIDAD.Find(id);
            if (oFPLA_UNIDAD == null)
            {
                return HttpNotFound();
            }
            return View(oFPLA_UNIDAD);
        }

        // POST: Seget/OFPLA_UNIDAD/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UNIDAD_ID,UNDE_LUGAR_GEOGRAFICO,IDENTIFICACION_CREA,FECHA_CREACION,MAQUINA_CREACION,VIGENTE,UNDE_CONSECUTIVO")] OFPLA_UNIDAD oFPLA_UNIDAD)
        {
            if (ModelState.IsValid)
            {
                db.Entry(oFPLA_UNIDAD).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(oFPLA_UNIDAD);
        }

        // GET: Seget/OFPLA_UNIDAD/Delete/5
        public ActionResult Delete(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OFPLA_UNIDAD oFPLA_UNIDAD = db.OFPLA_UNIDAD.Find(id);
            if (oFPLA_UNIDAD == null)
            {
                return HttpNotFound();
            }
            return View(oFPLA_UNIDAD);
        }

        // POST: Seget/OFPLA_UNIDAD/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(decimal id)
        {
            OFPLA_UNIDAD oFPLA_UNIDAD = db.OFPLA_UNIDAD.Find(id);
            db.OFPLA_UNIDAD.Remove(oFPLA_UNIDAD);
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
