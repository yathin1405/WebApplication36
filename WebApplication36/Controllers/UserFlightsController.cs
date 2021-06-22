using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication36.Data;
using WebApplication36.Models;

namespace WebApplication36.Controllers
{
    public class UserFlightsController : Controller
    {
        private WebApplication36Context db = new WebApplication36Context();

        // GET: UserFlights
        public ActionResult Index()
        {
            return View(db.UserFlights.ToList());
        }
        public ActionResult PlaneList()
        {
            var tours = from e in db.Flights
                        orderby e.Airways
                        
                        select e;
            return View("PlaneList");
        }

        // GET: UserFlights/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserFlights userFlights = db.UserFlights.Find(id);
            if (userFlights == null)
            {
                return HttpNotFound();
            }
            return View(userFlights);
        }

        // GET: UserFlights/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserFlights/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserID,Seat_Type,Departure_Date,DepartureTime,Passenger_Type,NumOfTickets,Return_Flight,Airline_Fee,passenger_Cost,Airline_Price")] UserFlights userFlights)
        {
            if (ModelState.IsValid)
            {

                userFlights.Airline_Fee = userFlights.AirlineFee();
                userFlights.passenger_Cost = userFlights.passengerCost();
                userFlights.Airline_Price = userFlights.AirlinePrice();
                db.UserFlights.Add(userFlights);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(userFlights);
        }

        // GET: UserFlights/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserFlights userFlights = db.UserFlights.Find(id);
            if (userFlights == null)
            {
                return HttpNotFound();
            }
            return View(userFlights);
        }

        // POST: UserFlights/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserID,Seat_Type,Departure_Date,DepartureTime,Passenger_Type,NumOfTickets,Return_Flight")] UserFlights userFlights)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userFlights).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userFlights);
        }

        // GET: UserFlights/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserFlights userFlights = db.UserFlights.Find(id);
            if (userFlights == null)
            {
                return HttpNotFound();
            }
            return View(userFlights);
        }

        // POST: UserFlights/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserFlights userFlights = db.UserFlights.Find(id);
            db.UserFlights.Remove(userFlights);
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
