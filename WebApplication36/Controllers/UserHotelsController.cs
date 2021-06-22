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
    public class UserHotelsController : Controller
    {
        private WebApplication36Context db = new WebApplication36Context();

        // GET: UserHotels
        public ActionResult Index()
        {
            return View(db.UserHotels.ToList());
        }

        // GET: UserHotels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserHotel userHotel = db.UserHotels.Find(id);
            if (userHotel == null)
            {
                return HttpNotFound();
            }
            return View(userHotel);
        }

        // GET: UserHotels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserHotels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserID,Email,CheckIn,CheckOut,Room_Type,Name_Guests,Num_Adults,Num_Children,Guest_Type,Breakfast,Breakfast_Price,Room_Type_Price,Meal_Price")] UserHotel userHotel)
        {
            if (ModelState.IsValid)
            {
                userHotel.Breakfast_Price = userHotel.BreakfastPrice();
                userHotel.Room_Type_Price = userHotel.RoomTypePrice();
                userHotel.Meal_Price = userHotel.MealPrice();
                db.UserHotels.Add(userHotel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(userHotel);
        }

        // GET: UserHotels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserHotel userHotel = db.UserHotels.Find(id);
            if (userHotel == null)
            {
                return HttpNotFound();
            }
            return View(userHotel);
        }

        // POST: UserHotels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserID,Email,CheckIn,CheckOut,Room_Type,Name_Guests,Num_Adults,Num_Children,Guest_Type,Breakfast")] UserHotel userHotel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userHotel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userHotel);
        }

        // GET: UserHotels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserHotel userHotel = db.UserHotels.Find(id);
            if (userHotel == null)
            {
                return HttpNotFound();
            }
            return View(userHotel);
        }

        // POST: UserHotels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserHotel userHotel = db.UserHotels.Find(id);
            db.UserHotels.Remove(userHotel);
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
