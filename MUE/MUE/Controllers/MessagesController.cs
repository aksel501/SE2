using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MUE.Models;
using Microsoft.AspNet.Identity;

namespace MUE.Controllers
{
    public class MessagesController : Controller
    {
        private ModelReferencesHere db = new ModelReferencesHere();

        // GET: Messages
       
        public ActionResult Index(string sortOrder, string searchString)
        {
            var userId = User.Identity.GetUserId();
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Email" : "";
            var messages = from m in db.Messages where m.USERID == userId  select m;
            if (!String.IsNullOrEmpty(searchString))
            {
                messages = messages.Where(m => m.TEXT.Contains(searchString) || m.AspNetUser.FirstName.Contains(searchString));
            }
            switch(sortOrder)
            {
                case "Email":
                    messages = messages.OrderBy(m => m.AspNetUser.Email);
                    break;
                default:
                    messages = messages.OrderByDescending(m => m.DATETIMEMADE);
                    break;
            }
            return View(messages.ToList());
        }
    
        // GET: Messages/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Message message = db.Messages.Find(id);
            if (message == null)
            {
                return HttpNotFound();
            }
            return View(message);
        }

        // GET: Messages/Create
       
        public ActionResult Create()
        {
            ViewBag.USERID = new SelectList(db.AspNetUsers, "Id", "FirstName");
            return View();
        }

        // POST: Messages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "USERID,TEXT")] Message message)
        {
            if (ModelState.IsValid)
            {
                var mes = new Message
                {
                    USERID = message.USERID,
                    DATETIMEMADE = DateTime.Now,
                    TEXT = message.TEXT
                };
                db.Messages.Add(mes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.USERID = new SelectList(db.AspNetUsers, "Id", "FirstName", message.USERID);
            return View(message);
        }

        // GET: Messages/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Message message = db.Messages.Find(id);
            if (message == null)
            {
                return HttpNotFound();
            }
            ViewBag.USERID = new SelectList(db.AspNetUsers, "Id", "FirstName", message.USERID);
            return View(message);
        }

        // POST: Messages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,USERID,DATETIMEMADE,TEXT")] Message message)
        {
            if (ModelState.IsValid)
            {
                db.Entry(message).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.USERID = new SelectList(db.AspNetUsers, "Id", "FirstName", message.USERID);
            return View(message);
        }

        // GET: Messages/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Message message = db.Messages.Find(id);
            if (message == null)
            {
                return HttpNotFound();
            }
            return View(message);
        }

        // POST: Messages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Message message = db.Messages.Find(id);
            db.Messages.Remove(message);
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
