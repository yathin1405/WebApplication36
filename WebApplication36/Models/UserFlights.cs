using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace WebApplication36.Models
{
    public class UserFlights
    {
        Flights User = new Flights();
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Display(Name = "User ID")]
        public int UserID { get; set; }

        [Display(Name = "Seating Type")]
        public string Seat_Type { get; set; }

        [Display(Name = "Departure Date")]
        [DataType(DataType.Date)]
        public DateTime Departure_Date { get; set; }

        [Display(Name = "Departure Time")]
        [DataType(DataType.Time)]
        public DateTime DepartureTime { get; set; }

        [Display(Name = "Passenger Type")]
        [Required(ErrorMessage = " required")]
        public string Passenger_Type { get; set; }

        //[Display(Name = "Ticket Price")]
        //[Required(ErrorMessage = "Price Required")]
        //public float Price { get; set; }

        [Display(Name = "Number of tickets")]
        [Required(ErrorMessage = "Required")]
        public int NumOfTickets { get; set; }

        [Display(Name = "Return Flight")]
        public bool Return_Flight { get; set; }
        public double Airline_Fee { get; set; }
    public double AirlineFee()
        {
            double x = 0;

            if (User.Airways == Flights.Airline.Mango && User.FROM == Flights.From.CapeTown_International && User.TO == Flights.To.King_Shaka_International)
            {
                x = 500;

            }
            if (User.Airways == Flights.Airline.Mango && User.FROM == Flights.From.CapeTown_International && User.TO == Flights.To.Lanseria)
            {
                x = 550;

            }
            if (User.Airways == Flights.Airline.Mango && User.FROM == Flights.From.CapeTown_International && User.TO == Flights.To.OR_Tambo)
            {
                x = 600;

            }
            if (User.Airways == Flights.Airline.Mango && User.FROM == Flights.From.King_Shaka_International && User.TO == Flights.To.CapeTown_International)
            {
                x = 650;

            }
            if (User.Airways == Flights.Airline.Mango && User.FROM == Flights.From.King_Shaka_International && User.TO == Flights.To.Lanseria)
            {
                x = 700;

            }
            if (User.Airways == Flights.Airline.Mango && User.FROM == Flights.From.King_Shaka_International && User.TO == Flights.To.OR_Tambo)
            {
                x = 750;

            }
            if (User.Airways == Flights.Airline.Mango && User.FROM == Flights.From.Lanseria && User.TO == Flights.To.King_Shaka_International)
            {
                x = 800;

            }
            if (User.Airways == Flights.Airline.Mango && User.FROM == Flights.From.Lanseria && User.TO == Flights.To.CapeTown_International)
            {
                x = 850;

            }
            if (User.Airways == Flights.Airline.Mango && User.FROM == Flights.From.Lanseria && User.TO == Flights.To.OR_Tambo)
            {
                x = 900;

            }
            if (User.Airways == Flights.Airline.Mango && User.FROM == Flights.From.OR_Tambo && User.TO == Flights.To.King_Shaka_International)
            {
                x = 1000;

            }
            if (User.Airways == Flights.Airline.Mango && User.FROM == Flights.From.OR_Tambo && User.TO == Flights.To.CapeTown_International)
            {
                x = 1050;

            }
            if (User.Airways == Flights.Airline.Mango && User.FROM == Flights.From.OR_Tambo && User.TO == Flights.To.Lanseria)
            {
                x = 200;

            }
            if (User.Airways == Flights.Airline.British_Airways && User.FROM == Flights.From.CapeTown_International && User.TO == Flights.To.King_Shaka_International)
            {
                x = 500;

            }
            if (User.Airways == Flights.Airline.British_Airways && User.FROM == Flights.From.CapeTown_International && User.TO == Flights.To.Lanseria)
            {
                x = 550;

            }
            if (User.Airways == Flights.Airline.British_Airways && User.FROM == Flights.From.CapeTown_International && User.TO == Flights.To.OR_Tambo)
            {
                x = 600;

            }
            if (User.Airways == Flights.Airline.British_Airways && User.FROM == Flights.From.King_Shaka_International && User.TO == Flights.To.CapeTown_International)
            {
                x = 650;

            }
            if (User.Airways == Flights.Airline.British_Airways && User.FROM == Flights.From.King_Shaka_International && User.TO == Flights.To.Lanseria)
            {
                x = 700;

            }
            if (User.Airways == Flights.Airline.British_Airways && User.FROM == Flights.From.King_Shaka_International && User.TO == Flights.To.OR_Tambo)
            {
                x = 750;

            }
            if (User.Airways == Flights.Airline.British_Airways && User.FROM == Flights.From.Lanseria && User.TO == Flights.To.King_Shaka_International)
            {
                x = 800;

            }
            if (User.Airways == Flights.Airline.British_Airways && User.FROM == Flights.From.Lanseria && User.TO == Flights.To.CapeTown_International)
            {
                x = 850;

            }
            if (User.Airways == Flights.Airline.British_Airways && User.FROM == Flights.From.Lanseria && User.TO == Flights.To.OR_Tambo)
            {
                x = 900;

            }
            if (User.Airways == Flights.Airline.British_Airways && User.FROM == Flights.From.OR_Tambo && User.TO == Flights.To.King_Shaka_International)
            {
                x = 1000;

            }
            if (User.Airways == Flights.Airline.British_Airways && User.FROM == Flights.From.OR_Tambo && User.TO == Flights.To.CapeTown_International)
            {
                x = 1050;

            }
            if (User.Airways == Flights.Airline.British_Airways && User.FROM == Flights.From.OR_Tambo && User.TO == Flights.To.Lanseria)
            {
                x = 200;

            }

            if (User.Airways == Flights.Airline.Kulula && User.FROM == Flights.From.CapeTown_International && User.TO == Flights.To.King_Shaka_International)
            {
                x = 500;

            }
            if (User.Airways == Flights.Airline.Kulula && User.FROM == Flights.From.CapeTown_International && User.TO == Flights.To.Lanseria)
            {
                x = 550;

            }
            if (User.Airways == Flights.Airline.Kulula && User.FROM == Flights.From.CapeTown_International && User.TO == Flights.To.OR_Tambo)
            {
                x = 600;

            }
            if (User.Airways == Flights.Airline.Kulula && User.FROM == Flights.From.King_Shaka_International && User.TO == Flights.To.CapeTown_International)
            {
                x = 650;

            }
            if (User.Airways == Flights.Airline.Kulula && User.FROM == Flights.From.King_Shaka_International && User.TO == Flights.To.Lanseria)
            {
                x = 700;

            }
            if (User.Airways == Flights.Airline.Kulula && User.FROM == Flights.From.King_Shaka_International && User.TO == Flights.To.OR_Tambo)
            {
                x = 750;

            }
            if (User.Airways == Flights.Airline.Kulula && User.FROM == Flights.From.Lanseria && User.TO == Flights.To.King_Shaka_International)
            {
                x = 800;

            }
            if (User.Airways == Flights.Airline.Kulula && User.FROM == Flights.From.Lanseria && User.TO == Flights.To.CapeTown_International)
            {
                x = 850;

            }
            if (User.Airways == Flights.Airline.Kulula && User.FROM == Flights.From.Lanseria && User.TO == Flights.To.OR_Tambo)
            {
                x = 900;

            }
            if (User.Airways == Flights.Airline.Kulula && User.FROM == Flights.From.OR_Tambo && User.TO == Flights.To.King_Shaka_International)
            {
                x = 1000;

            }
            if (User.Airways == Flights.Airline.Kulula && User.FROM == Flights.From.OR_Tambo && User.TO == Flights.To.CapeTown_International)
            {
                x = 1050;

            }
            if (User.Airways == Flights.Airline.Kulula && User.FROM == Flights.From.OR_Tambo && User.TO == Flights.To.Lanseria)
            {
                x = 200;

            }
            if (User.Airways == Flights.Airline.SAA && User.FROM == Flights.From.CapeTown_International && User.TO == Flights.To.King_Shaka_International)
            {
                x = 500;

            }
            if (User.Airways == Flights.Airline.SAA && User.FROM == Flights.From.CapeTown_International && User.TO == Flights.To.Lanseria)
            {
                x = 550;

            }
            if (User.Airways == Flights.Airline.SAA && User.FROM == Flights.From.CapeTown_International && User.TO == Flights.To.OR_Tambo)
            {
                x = 600;

            }
            if (User.Airways == Flights.Airline.SAA && User.FROM == Flights.From.King_Shaka_International && User.TO == Flights.To.CapeTown_International)
            {
                x = 650;

            }
            if (User.Airways == Flights.Airline.SAA && User.FROM == Flights.From.King_Shaka_International && User.TO == Flights.To.Lanseria)
            {
                x = 700;

            }
            if (User.Airways == Flights.Airline.SAA && User.FROM == Flights.From.King_Shaka_International && User.TO == Flights.To.OR_Tambo)
            {
                x = 750;

            }
            if (User.Airways == Flights.Airline.SAA && User.FROM == Flights.From.Lanseria && User.TO == Flights.To.King_Shaka_International)
            {
                x = 800;

            }
            if (User.Airways == Flights.Airline.SAA && User.FROM == Flights.From.Lanseria && User.TO == Flights.To.CapeTown_International)
            {
                x = 850;

            }
            if (User.Airways == Flights.Airline.SAA && User.FROM == Flights.From.Lanseria && User.TO == Flights.To.OR_Tambo)
            {
                x = 900;

            }
            if (User.Airways == Flights.Airline.SAA && User.FROM == Flights.From.OR_Tambo && User.TO == Flights.To.King_Shaka_International)
            {
                x = 1000;

            }
            if (User.Airways == Flights.Airline.SAA && User.FROM == Flights.From.OR_Tambo && User.TO == Flights.To.CapeTown_International)
            {
                x = 1050;

            }
            if (User.Airways == Flights.Airline.SAA && User.FROM == Flights.From.OR_Tambo && User.TO == Flights.To.Lanseria)
            {
                x = 200;

            }
            return x;

        }
        public double Ticket_Price { get; set; }
        public double TicketPrice()
        {
            double x = 0;


            if (User.SeatType ==Flights.Class.Economy && Return_Flight == true)
            {
                x = ((AirlineFee() + passengerCost()) + ((passengerCost() + AirlineFee()) * 66.66));
            }
            else if (User.SeatType == Flights.Class.Business && Return_Flight == true)
            {
                x = ((AirlineFee() + passengerCost()) + ((passengerCost() + AirlineFee()) * 66.66));
            }
            else if (User.SeatType == Flights.Class.First && Return_Flight == true)
            {
                x = ((AirlineFee() + passengerCost()) + ((passengerCost() + AirlineFee()) * 66.66));
            }
            else if (User.SeatType == Flights.Class.Business)
            {
                x = AirlineFee() + passengerCost();
            }
            else if (User.SeatType == Flights.Class.Economy)
            {
                x = AirlineFee() + passengerCost();
            }
            else if (User.SeatType == Flights.Class.First)
            {
                x = AirlineFee() + passengerCost();
            }
            return x;
        }
        public double passenger_Cost { get; set; }
        public double passengerCost()
        {
            double x = 0;

            if (User.PassengerType == Flights.Passenger.Adult)
            {
                x = 75;
            }
            if (User.PassengerType == Flights.Passenger.child)
            {
                x = 50;
            }
            if (User.PassengerType == Flights.Passenger.infant)
            {
                x = 10;
            }
            return x;
        }
        public double Airline_Price { get; set; }
        public double AirlinePrice()
        {
            double x = 0;
            if (User.Airways ==Flights.Airline.British_Airways)
            {
                x = 200;
            }
            else if (User.Airways == Flights.Airline.SAA)
            {
                x = 250;
            }
            else if (User.Airways == Flights.Airline.Kulula)
            {
                x = 300;
            }
            else if (User.Airways == Flights.Airline.Mango)
            {
                x = 350;
            }
            return x;
        }
    }
}