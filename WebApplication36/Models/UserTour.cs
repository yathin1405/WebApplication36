using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication36.Models
{
    public class UserTour
    {
        Tour user = new Tour();
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int GuestID { get; set; }

        [Display(Name = "Number of adults")]
        public int Num_Adults { get; set; }

        [Display(Name = "Number of Kids")]
        public int Num_Kids { get; set; }

        [Display(Name = "Email address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Tour Name")]
        public string Tour_Name { get; set; }

        public double Deposit { get; set; }
        public double Discount { get; set; }
        public int Total_Tickets { get; set; }
        public double Total_Cost { get; set; }
        public double GuestCost { get; set; }
        public double Tour_Cost { get; set; }
        public double TourCost()
        {
            double x = 0;
            if ((user.TourType == Tour.Tours.Ushaka))
            {
                x = (user.UshakPrice * Num_Adults) + ((user.UshakPrice * Num_Kids) / 0.05);
            }
            else if (user.TourType == Tour.Tours.Apartheid_Museum)
            {
                x = (user.AppMuseum * Num_Adults) + ((user.UshakPrice * Num_Kids) / 0.10);
            }
            else if (user.TourType == Tour.Tours.Apartheid_Museum)
            {
                x = (user.GoodHope * Num_Adults) + ((user.UshakPrice * Num_Kids) / 0.10);
            }
            else if (user.TourType == Tour.Tours.Apartheid_Museum)
            {
                x = (user.GoldReef * Num_Adults) + ((user.UshakPrice * Num_Kids) / 0.10);
            }
            else if (user.TourType == Tour.Tours.Apartheid_Museum)
            {
                x = (user.DNS * Num_Adults) + ((user.UshakPrice * Num_Kids) / 0.10);
            }
            return x;


        }


        public double deposit()
        {

            double deposit = 0;
            if (TourCost() <= 100)
            {
                deposit = TourCost() * 0.15;
            }
            else
                if (TourCost() > 100 && TourCost() <= 150)
            {
                deposit = TourCost() * 0.20;
            }
            else
                if (TourCost() > 150 && TourCost() <= 175)
            {
                deposit = TourCost() * 0.25;
            }
            else
                if (TourCost() > 175 && TourCost() <= 200)
            {
                deposit = TourCost() * 0.30;
            }
            else
                if (TourCost() > 200)
            {
                deposit = TourCost() * 0.40;
            }
            return deposit;

        }
        public double Guest_Cost()
        {
            double x = 0;
            x = (TourCost() * Num_Adults) + ((TourCost() * Num_Kids) / 0.50);
            return x;
        }

        public double TotalCost()
        {
            double x = 0;
            if (user.TourType == Tour.Tours.Apartheid_Museum)
            {
                x = TourCost() + Guest_Cost() + deposit() - discount();

            }
            if (user.TourType == Tour.Tours.Cape_Of_Good_Hope)
            {
                x = TourCost() + Guest_Cost() + deposit() - discount();

            }

            if (user.TourType == Tour.Tours.Durban_Natural_Science_Museum)
            {
                x = TourCost() + Guest_Cost() + deposit() - discount();

            }

            if (user.TourType == Tour.Tours.Gold_Reef_City_Theme_Park)
            {
                x = TourCost() + Guest_Cost() + deposit() - discount();

            }
            if (user.TourType == Tour.Tours.Ushaka)
            {
                x = TourCost() + Guest_Cost() + deposit() - discount();

            }

            return x;

        }
        public double discount()
        {
            double x = 0;
            if (Num_Adults + Num_Kids >= 4 && Num_Adults + Num_Kids <= 6)
            {
                x = TourCost() * 0.05;

            }
            if (Num_Adults + Num_Kids > 6 && Num_Adults + Num_Kids <= 10)
            {
                x = TourCost() * 0.10;

            }
            if (Num_Adults + Num_Kids > 10 && Num_Adults + Num_Kids <= 15)
            {
                x = TourCost() * 0.15;

            }
            if (Num_Adults + Num_Kids > 15 && Num_Adults + Num_Kids <= 20)
            {
                x = TourCost() * 0.20;

            }
            else
            {
                x = 0;
            }
            return x;



        }
        public int numOfTickets()
        {
            int x = Num_Adults + Num_Kids;
            return x;
        }

    }

}