using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using INF272_Project.Models;

namespace INF272_Project.Views
{
    public class Donations1Controller : Controller
    {
        private StarKidzEntities2 db = new StarKidzEntities2();

        // GET: Donations1
        public ActionResult Index()
        {
            var donations = db.Donations.Include(d => d.Payment).Include(d => d.Donor);
            return View(donations.ToList());
        }

        // GET: Donations1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Donation donation = db.Donations.Find(id);
            if (donation == null)
            {
                return HttpNotFound();
            }
            return View(donation);
        }

        // GET: Donations1/Create
        public ActionResult Create()
        {
            ViewBag.PaymentID = new SelectList(db.Payments, "PaymentID", "CardNo");
            ViewBag.DonorID = new SelectList(db.Donors, "DonorID", "Name");
            return View();
        }

        // POST: Donations1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
   

        public ActionResult Create([Bind(Include = "DonationID,DonorID,PaymentID,Amount,Description")] Donation donation)
        {
            if (ModelState.IsValid)
            {
                db.Donations.Add(donation);
                db.SaveChanges();
                return RedirectToAction("home","Star");
            }

            ViewBag.PaymentID = new SelectList(db.Payments, "PaymentID", "CardNo", donation.PaymentID);
            ViewBag.DonorID = new SelectList(db.Donors, "DonorID", "Name", donation.DonorID);
            return View(donation);
        }

        // GET: Donations1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Donation donation = db.Donations.Find(id);
            if (donation == null)
            {
                return HttpNotFound();
            }
            ViewBag.PaymentID = new SelectList(db.Payments, "PaymentID", "CardNo", donation.PaymentID);
            ViewBag.DonorID = new SelectList(db.Donors, "DonorID", "Name", donation.DonorID);
            return View(donation);
        }

        // POST: Donations1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DonationID,DonorID,PaymentID,Amount,Description")] Donation donation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(donation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PaymentID = new SelectList(db.Payments, "PaymentID", "CardNo", donation.PaymentID);
            ViewBag.DonorID = new SelectList(db.Donors, "DonorID", "Name", donation.DonorID);
            return View(donation);
        }

        // GET: Donations1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Donation donation = db.Donations.Find(id);
            if (donation == null)
            {
                return HttpNotFound();
            }
            return View(donation);
        }

        // POST: Donations1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Donation donation = db.Donations.Find(id);
            db.Donations.Remove(donation);
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
