using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication36.Models
{
    public class Flights
    {
        public Airline Airways { get; set; }
        public enum Airline
        {
            Mango,
            SAA,
            British_Airways,
            Kulula,

        }
        public From FROM { get; set; }
        public enum From
        {
            King_Shaka_International,
            OR_Tambo,
            Lanseria,
            CapeTown_International,

        }
        public To TO { get; set; }
        public enum To
        {
            King_Shaka_International,
            OR_Tambo,
            Lanseria,
            CapeTown_International,

        }
        public Class SeatType { get; set; }
        public enum Class
        {
            Economy,
            Business,
            First,

        }
        public Passenger PassengerType { get; set; }
        public enum Passenger
        {
            Adult,
            child,
            infant,
        }


        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Display(Name = "Plane ID")]
        public int PlaneID { get; set; }

        //[Display(Name = "Plane Name")]
        //public string Plane_Name { get; set; }
        public double Mango = 0;
        public double SAA = 0;
        public double Kulula = 0;
        public double British_Airways = 0;
        [Display(Name = "Flight Duration")]
        public string Flight_Duration { get; set; }

        [Display(Name = "Flight Delay")]
        public bool FDelay { get; set; }
        [Display(Name = "Estimated Flight Delay")]
        public string Flight_Delay { get; set; }

        [Display(Name = "Plane Capacity")]
        public string Plane_Capacity { get; set; }
        [Display(Name = "Seating Type")]
        public string Seat_Type { get; set; }

        //[Display(Name = "From")]
        //public string LocationFrom { get; set; }
        //[Display(Name = "TO")]
        //public string LocationTO { get; set; }

        [Display(Name = "Departure Date")]
        [DataType(DataType.Date)]
        public DateTime Departure_Date { get; set; }

        [Display(Name = "Departure Time")]
        [DataType(DataType.Time)]
        public DateTime DepartureTime { get; set; }

        [Display(Name = "Passenger Type")]
        [Required(ErrorMessage = " required")]
        public string Passenger_Type { get; set; }

        [Display(Name = "Ticket Price")]
        [Required(ErrorMessage = "Price Required")]
        public float Price { get; set; }

        [Display(Name = "Number of tickets")]
        [Required(ErrorMessage = "Required")]
        public int NumOfTickets { get; set; }

        [Display(Name = "Return Flight")]
        public bool Return_Flight { get; set; }
        public enum SeatAvail
        {
            Available,
            Unavailable,
        }

      
    }
}