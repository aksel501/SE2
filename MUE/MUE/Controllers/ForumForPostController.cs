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
    [Authorize]
    public class ForumForPostController : Controller
    {
        private ModelReferencesHere db = new ModelReferencesHere();

        // GET: ForumForPost
        public ActionResult Index()
        {
            var pOSTs = db.POSTs.Include(p => p.AspNetUser);
            return View(pOSTs.ToList());
        }

        // GET: ForumForPost/Details/5
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

        // GET: ForumForPost/Create
        public ActionResult Create()
        {
            ViewBag.USERID = new SelectList(db.AspNetUsers, "Id", "FirstName");
            return View();
        }

        // POST: ForumForPost/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,USERID,SUBJECT,TITLE,DATETIMEPOSTED")] POST pOST)
        {
            if (ModelState.IsValid)
            {
                db.POSTs.Add(pOST);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.USERID = new SelectList(db.AspNetUsers, "Id", "FirstName", pOST.USERID);
            return View(pOST);
        }

        // GET: ForumForPost/Edit/5
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
            return View(pOST);
        }

        // POST: ForumForPost/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,USERID,SUBJECT,TITLE,DATETIMEPOSTED")] POST pOST)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pOST).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.USERID = new SelectList(db.AspNetUsers, "Id", "FirstName", pOST.USERID);
            return View(pOST);
        }

        // GET: ForumForPost/Delete/5
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

        // POST: ForumForPost/Delete/5
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
