using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MUE.Models;

namespace MUE.Controllers
{
    
    public class POSTsController : Controller
    {
        private ExpertsDatabase3 db = new ExpertsDatabase3();

        // GET: POSTs
        public ActionResult Index()
        {
            var pOSTs = db.POSTs.Include(p => p.AspNetUser).Include(p => p.POST2);
            return View(pOSTs.ToList());
        }

        // GET: POSTs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            POST pOST = db.POSTs.Find(id);
            if (pOST == null)
            {
                return HttpNotFound();
            }
            return View(pOST);
        }

        // GET: POSTs/Create
        public ActionResult Create()
        {
            ViewBag.USERID = new SelectList(db.AspNetUsers, "Id", "FirstName");
            ViewBag.REPLIED_TO_POST_ID = new SelectList(db.POSTs, "ID", "USERID");
            return View();
        }

        // POST: POSTs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,REPLIED_TO_POST_ID,USERID,SUBJECT,TITLE,DATETIMEPOSTED")] POST pOST)
        {
            if (ModelState.IsValid)
            {
                db.POSTs.Add(pOST);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.USERID = new SelectList(db.AspNetUsers, "Id", "FirstName", pOST.USERID);
            ViewBag.REPLIED_TO_POST_ID = new SelectList(db.POSTs, "ID", "USERID", pOST.REPLIED_TO_POST_ID);
            return View(pOST);
        }

        // GET: POSTs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            POST pOST = db.POSTs.Find(id);
            if (pOST == null)
            {
                return HttpNotFound();
            }
            ViewBag.USERID = new SelectList(db.AspNetUsers, "Id", "FirstName", pOST.USERID);
            ViewBag.REPLIED_TO_POST_ID = new SelectList(db.POSTs, "ID", "USERID", pOST.REPLIED_TO_POST_ID);
            return View(pOST);
        }

        // POST: POSTs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,REPLIED_TO_POST_ID,USERID,SUBJECT,TITLE,DATETIMEPOSTED")] POST pOST)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pOST).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.USERID = new SelectList(db.AspNetUsers, "Id", "FirstName", pOST.USERID);
            ViewBag.REPLIED_TO_POST_ID = new SelectList(db.POSTs, "ID", "USERID", pOST.REPLIED_TO_POST_ID);
            return View(pOST);
        }

        // GET: POSTs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            POST pOST = db.POSTs.Find(id);
            if (pOST == null)
            {
                return HttpNotFound();
            }
            return View(pOST);
        }

        // POST: POSTs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            POST pOST = db.POSTs.Find(id);
            db.POSTs.Remove(pOST);
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
