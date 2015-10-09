using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TesteBD.Models;

namespace TesteBD.Controllers
{
    public class CidadeController : Controller
    {
        private BDEntities3 db = new BDEntities3();

        //
        // GET: /Cidade/

        public ActionResult Index()
        {
            return View(db.Cidade.ToList());
        }

        //
        // GET: /Cidade/Details/5

        public ActionResult Details(int id = 0)
        {
            Cidade cidade = db.Cidade.Find(id);
            if (cidade == null)
            {
                return HttpNotFound();
            }
            return View(cidade);
        }

        //
        // GET: /Cidade/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Cidade/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Cidade cidade)
        {
            if (ModelState.IsValid)
            {
                var idInc = String.Empty;
                if (db.Cidade.Count() != 0)
                {
                    idInc = db.Cidade.ToList().Select(a => a.Id).Last().ToString();
                    cidade.Id = Convert.ToInt32(idInc) + 1;
                }
                db.Cidade.Add(cidade);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cidade);
        }

        //
        // GET: /Cidade/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Cidade cidade = db.Cidade.Find(id);
            if (cidade == null)
            {
                return HttpNotFound();
            }
            return View(cidade);
        }

        //
        // POST: /Cidade/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Cidade cidade)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cidade).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cidade);
        }

        //
        // GET: /Cidade/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Cidade cidade = db.Cidade.Find(id);
            if (cidade == null)
            {
                return HttpNotFound();
            }
            return View(cidade);
        }

        //
        // POST: /Cidade/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cidade cidade = db.Cidade.Find(id);
            db.Cidade.Remove(cidade);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}