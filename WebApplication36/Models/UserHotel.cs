using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication36.Models
{
    public class UserHotel
    {
        Hotel User = new Hotel();
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int UserID { get; set; }

        [Display(Name = "Email adddress")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Check in ")]
        [DataType(DataType.Date)]
        public DateTime CheckIn { get; set; }

        [Display(Name = "Check out ")]
        [DataType(DataType.Date)]
        public DateTime CheckOut { get; set; }

        [Display(Name = "Room Type")]
        [Required(ErrorMessage = " required")]
        [MaxLength(30, ErrorMessage = "Maxinum 30 charecters allowed"), MinLength(3, ErrorMessage = "Minimun 3 charecters allowed")]
        public string Room_Type { get; set; }

        [Display(Name = "Name of guests")]
        public string Name_Guests { get; set; }
        [Display(Name = "Number of Adults")]
        public string Num_Adults { get; set; }
        [Display(Name = "Number of Children")]
        public string Num_Children { get; set; }
        [Display(Name = "Guest Type")]
        public string Guest_Type { get; set; }

        [Display(Name = " Breakfast?")]
        public bool Breakfast { get; set; }
        public double Breakfast_Price { get; set; }
        public double BreakfastPrice()
        {
            double x = 0;
            if (Breakfast == true)
            {
                x = 150;
            }
            return x;
        }
        public double Meal_Price { get; set; }
    public double MealPrice()
        {
            double x = 0;
            if (User.MealType == Hotel.Meal.Meat)
            {
                x = 200;
            }
            if (User.MealType == Hotel.Meal.Veg)
            {
                x = 140;
            }
            if (User.MealType == Hotel.Meal.No)
            {
                x = 0;

            }
            return x;
        }


        public double Room_Type_Price { get; set; }
        public double RoomTypePrice()
        {
            double x = 0;
            if (User.Rooms == Hotel.Room_Type.Single_Person_NoView && User.Hotels == Hotel.Hotel_Name.Belmond_Mount_Nelson_Hotel && User.NumOfGuests == Hotel.Num_Guests.Single_Adult)
            {
                x = 300;
            }//price for 1 adult in a room for 1 no view

            if (User.Rooms == Hotel.Room_Type.Two_People_NoView && User.Hotels == Hotel.Hotel_Name.Belmond_Mount_Nelson_Hotel && User.NumOfGuests == Hotel.Num_Guests.Two_Adults)
            {
                x = 500;

            }// price for 2 adults in a room for2 no view

            if (User.Rooms == Hotel.Room_Type.Two_People_NoView && User.Hotels == Hotel.Hotel_Name.Belmond_Mount_Nelson_Hotel && User.NumOfGuests == Hotel.Num_Guests.Single_adult_and_Single_Child)
            {
                x = 450;

            }// price for 1 adult and 1 child  in a room for 2 no view

            if (User.Rooms == Hotel.Room_Type.Two_People_NoView && User.Hotels == Hotel.Hotel_Name.Belmond_Mount_Nelson_Hotel && User.NumOfGuests == Hotel.Num_Guests.Single_Adult_and_Single_Infant)
            {
                x = 350;

            }// price for 1 adult and 1 baby in a room for 2 no view

            if (User.Rooms == Hotel.Room_Type.Three_People_NoView && User.Hotels == Hotel.Hotel_Name.Belmond_Mount_Nelson_Hotel && User.NumOfGuests == Hotel.Num_Guests.Three_Adults)
            {
                x = 775;
            }// price for 3 adults in a room for 3  no view

            if (User.Rooms == Hotel.Room_Type.Three_People_NoView && User.Hotels == Hotel.Hotel_Name.Belmond_Mount_Nelson_Hotel && User.NumOfGuests == Hotel.Num_Guests.Single_Adult_and_two_Children)
            {
                x = 705;
            }// price for 1 adults and 2 children in a room for 3 no view

            if (User.Rooms == Hotel.Room_Type.Three_People_NoView && User.Hotels == Hotel.Hotel_Name.Belmond_Mount_Nelson_Hotel && User.NumOfGuests == Hotel.Num_Guests.Single_Adult_and_Two_Infant)
            {
                x = 690;
            }// price for 1 adults 2 babies in a room for 3 no view

            if (User.Rooms == Hotel.Room_Type.Three_People_NoView && User.Hotels == Hotel.Hotel_Name.Belmond_Mount_Nelson_Hotel && User.NumOfGuests == Hotel.Num_Guests.Two_Adults_and_One_Child)
            {
                x = 775;
            }// price for 2 adults and 1 child in a room for 3 no view

            if (User.Rooms == Hotel.Room_Type.Three_People_NoView && User.Hotels == Hotel.Hotel_Name.Belmond_Mount_Nelson_Hotel && User.NumOfGuests == Hotel.Num_Guests.Two_Adults_and_One_Infant)
            {
                x = 775;
            }// price for 2 adults and 1 baby in a room for 3 no view

            if (User.Rooms == Hotel.Room_Type.Three_People_NoView && User.Hotels == Hotel.Hotel_Name.Belmond_Mount_Nelson_Hotel && User.NumOfGuests == Hotel.Num_Guests.Single_Adult_and_One_Child_and_one_Infant)
            {
                x = 775;
            }// price for 1 adult, 1 child, 1 baby in a room for 3 no view

            if (User.Rooms == Hotel.Room_Type.Four_People_NoView && User.Hotels == Hotel.Hotel_Name.Belmond_Mount_Nelson_Hotel && User.NumOfGuests == Hotel.Num_Guests.Four_adults)
            {
                x = 1000;
            } // price for  4 adults in a room for 4 no view

            if (User.Rooms == Hotel.Room_Type.Four_People_NoView && User.Hotels == Hotel.Hotel_Name.Belmond_Mount_Nelson_Hotel && User.NumOfGuests == Hotel.Num_Guests.Three_Adults_and_One_Child)
            {
                x = 1000;
            } // price for  3 adults 1 child in a room for 4 no view

            if (User.Rooms == Hotel.Room_Type.Four_People_NoView && User.Hotels == Hotel.Hotel_Name.Belmond_Mount_Nelson_Hotel && User.NumOfGuests == Hotel.Num_Guests.Three_Adults_and_One_Infant)
            {
                x = 1000;
            } // price for  3 adults  1 baby in a room for 4 no view

            if (User.Rooms == Hotel.Room_Type.Four_People_NoView && User.Hotels == Hotel.Hotel_Name.Belmond_Mount_Nelson_Hotel && User.NumOfGuests == Hotel.Num_Guests.Two_Adults_and_Two_Child)
            {
                x = 1000;
            } // price for  2 adults 2 children in a room for 4 no view

            if (User.Rooms == Hotel.Room_Type.Four_People_NoView && User.Hotels == Hotel.Hotel_Name.Belmond_Mount_Nelson_Hotel && User.NumOfGuests == Hotel.Num_Guests.Two_Adults_and_Two_Infant)
            {
                x = 1000;
            } // price for  2 adults 2 babies in a room for 4 no view

            if (User.Rooms == Hotel.Room_Type.Four_People_NoView && User.Hotels == Hotel.Hotel_Name.Belmond_Mount_Nelson_Hotel && User.NumOfGuests == Hotel.Num_Guests.Two_Adults_and_One_Child_and_One_Infant)
            {
                x = 1000;
            } // price for  2 adults,1 child, 1 baby in a room for 4 no view

            if (User.Rooms == Hotel.Room_Type.Four_People_NoView && User.Hotels == Hotel.Hotel_Name.Belmond_Mount_Nelson_Hotel && User.NumOfGuests == Hotel.Num_Guests.Single_Adult_and_Three_Children)
            {
                x = 1000;
            } // price for  1 adult 3 children in a room for 4 no view

            if (User.Rooms == Hotel.Room_Type.Four_People_NoView && User.Hotels == Hotel.Hotel_Name.Belmond_Mount_Nelson_Hotel && User.NumOfGuests == Hotel.Num_Guests.Single_Adult_and_Three_Infant)
            {
                x = 1000;
            } // price for  1 adults 3 babies in a room for 4 no view

            /////////////////////////////////////////////////////////////////////////////////

            if (User.Rooms == Hotel.Room_Type.Single_Person_View && User.Hotels == Hotel.Hotel_Name.Belmond_Mount_Nelson_Hotel && User.NumOfGuests == Hotel.Num_Guests.Single_Adult)
            {
                x = 300;
            }//price for 1 adult in a room for 1  view

            if (User.Rooms == Hotel.Room_Type.Two_People_View && User.Hotels == Hotel.Hotel_Name.Belmond_Mount_Nelson_Hotel && User.NumOfGuests == Hotel.Num_Guests.Two_Adults)
            {
                x = 500;

            }// price for 2 adults in a room for2  view

            if (User.Rooms == Hotel.Room_Type.Two_People_View && User.Hotels == Hotel.Hotel_Name.Belmond_Mount_Nelson_Hotel && User.NumOfGuests == Hotel.Num_Guests.Single_adult_and_Single_Child)
            {
                x = 450;

            }// price for 1 adult and 1 child  in a room for 2  view

            if (User.Rooms == Hotel.Room_Type.Two_People_View && User.Hotels == Hotel.Hotel_Name.Belmond_Mount_Nelson_Hotel && User.NumOfGuests == Hotel.Num_Guests.Single_Adult_and_Single_Infant)
            {
                x = 350;

            }// price for 1 adult and 1 baby in a room for 2 view

            if (User.Rooms == Hotel.Room_Type.Three_People_View && User.Hotels == Hotel.Hotel_Name.Belmond_Mount_Nelson_Hotel && User.NumOfGuests == Hotel.Num_Guests.Three_Adults)
            {
                x = 775;
            }// price for 3 adults in a room for 3   view

            if (User.Rooms == Hotel.Room_Type.Three_People_View && User.Hotels == Hotel.Hotel_Name.Belmond_Mount_Nelson_Hotel && User.NumOfGuests == Hotel.Num_Guests.Single_Adult_and_two_Children)
            {
                x = 705;
            }// price for 1 adults and 2 children in a room for 3  view

            if (User.Rooms == Hotel.Room_Type.Three_People_View && User.Hotels == Hotel.Hotel_Name.Belmond_Mount_Nelson_Hotel && User.NumOfGuests == Hotel.Num_Guests.Single_Adult_and_Two_Infant)
            {
                x = 690;
            }// price for 1 adults 2 babies in a room for 3  view

            if (User.Rooms == Hotel.Room_Type.Three_People_View && User.Hotels == Hotel.Hotel_Name.Belmond_Mount_Nelson_Hotel && User.NumOfGuests == Hotel.Num_Guests.Two_Adults_and_One_Child)
            {
                x = 775;
            }// price for 2 adults and 1 child in a room for 3  view

            if (User.Rooms == Hotel.Room_Type.Three_People_View && User.Hotels == Hotel.Hotel_Name.Belmond_Mount_Nelson_Hotel && User.NumOfGuests == Hotel.Num_Guests.Two_Adults_and_One_Infant)
            {
                x = 775;
            }// price for 2 adults and 1 baby in a room for 3  view

            if (User.Rooms == Hotel.Room_Type.Three_People_View && User.Hotels == Hotel.Hotel_Name.Belmond_Mount_Nelson_Hotel && User.NumOfGuests == Hotel.Num_Guests.Single_Adult_and_One_Child_and_one_Infant)
            {
                x = 775;
            }// price for 1 adult, 1 child, 1 baby in a room for 3  view

            if (User.Rooms == Hotel.Room_Type.Four_People_View && User.Hotels == Hotel.Hotel_Name.Belmond_Mount_Nelson_Hotel && User.NumOfGuests == Hotel.Num_Guests.Four_adults)
            {
                x = 1000;
            } // price for  4 adults in a room for 4  view

            if (User.Rooms == Hotel.Room_Type.Four_People_View && User.Hotels == Hotel.Hotel_Name.Belmond_Mount_Nelson_Hotel && User.NumOfGuests == Hotel.Num_Guests.Three_Adults_and_One_Child)
            {
                x = 1000;
            } // price for  3 adults 1 child in a room for 4  view

            if (User.Rooms == Hotel.Room_Type.Four_People_View && User.Hotels == Hotel.Hotel_Name.Belmond_Mount_Nelson_Hotel && User.NumOfGuests == Hotel.Num_Guests.Three_Adults_and_One_Infant)
            {
                x = 1000;
            } // price for  3 adults  1 baby in a room for 4  view

            if (User.Rooms == Hotel.Room_Type.Four_People_View && User.Hotels == Hotel.Hotel_Name.Belmond_Mount_Nelson_Hotel && User.NumOfGuests == Hotel.Num_Guests.Two_Adults_and_Two_Child)
            {
                x = 1000;
            } // price for  2 adults 2 children in a room for 4  view

            if (User.Rooms == Hotel.Room_Type.Four_People_View && User.Hotels == Hotel.Hotel_Name.Belmond_Mount_Nelson_Hotel && User.NumOfGuests == Hotel.Num_Guests.Two_Adults_and_Two_Infant)
            {
                x = 1000;
            } // price for  2 adults 2 babies in a room for 4  view

            if (User.Rooms == Hotel.Room_Type.Four_People_View && User.Hotels == Hotel.Hotel_Name.Belmond_Mount_Nelson_Hotel && User.NumOfGuests == Hotel.Num_Guests.Two_Adults_and_One_Child_and_One_Infant)
            {
                x = 1000;
            } // price for  2 adults,1 child, 1 baby in a room for 4  view

            if (User.Rooms == Hotel.Room_Type.Four_People_View && User.Hotels == Hotel.Hotel_Name.Belmond_Mount_Nelson_Hotel && User.NumOfGuests == Hotel.Num_Guests.Single_Adult_and_Three_Children)
            {
                x = 1000;
            } // price for  1 adult 3 children in a room for 4  view

            if (User.Rooms == Hotel.Room_Type.Four_People_View && User.Hotels == Hotel.Hotel_Name.Belmond_Mount_Nelson_Hotel && User.NumOfGuests == Hotel.Num_Guests.Single_Adult_and_Three_Infant)
            {
                x = 1000;
            } // price for  1 adults 3 babies in a room for 4  view

            //////////////////////////////////////////////////////////////////////////////////////


            ///////////////////////////////////////////////

            if (User.Rooms == Hotel.Room_Type.Single_Person_NoView && User.Hotels == Hotel.Hotel_Name.Four_Seasons_hotel_The_Westcliff && User.NumOfGuests == Hotel.Num_Guests.Single_Adult)
            {
                x = 300;
            }//price for 1 adult in a room for 1 no view

            if (User.Rooms == Hotel.Room_Type.Two_People_NoView && User.Hotels == Hotel.Hotel_Name.Four_Seasons_hotel_The_Westcliff && User.NumOfGuests == Hotel.Num_Guests.Two_Adults)
            {
                x = 500;

            }// price for 2 adults in a room for2 no view

            if (User.Rooms == Hotel.Room_Type.Two_People_NoView && User.Hotels == Hotel.Hotel_Name.Four_Seasons_hotel_The_Westcliff && User.NumOfGuests == Hotel.Num_Guests.Single_adult_and_Single_Child)
            {
                x = 450;

            }// price for 1 adult and 1 child  in a room for 2 no view

            if (User.Rooms == Hotel.Room_Type.Two_People_NoView && User.Hotels == Hotel.Hotel_Name.Four_Seasons_hotel_The_Westcliff && User.NumOfGuests == Hotel.Num_Guests.Single_Adult_and_Single_Infant)
            {
                x = 350;

            }// price for 1 adult and 1 baby in a room for 2 no view

            if (User.Rooms == Hotel.Room_Type.Three_People_NoView && User.Hotels == Hotel.Hotel_Name.Four_Seasons_hotel_The_Westcliff && User.NumOfGuests == Hotel.Num_Guests.Three_Adults)
            {
                x = 775;
            }// price for 3 adults in a room for 3  no view

            if (User.Rooms == Hotel.Room_Type.Three_People_NoView && User.Hotels == Hotel.Hotel_Name.Four_Seasons_hotel_The_Westcliff && User.NumOfGuests == Hotel.Num_Guests.Single_Adult_and_two_Children)
            {
                x = 705;
            }// price for 1 adults and 2 children in a room for 3 no view

            if (User.Rooms == Hotel.Room_Type.Three_People_NoView && User.Hotels == Hotel.Hotel_Name.Four_Seasons_hotel_The_Westcliff && User.NumOfGuests == Hotel.Num_Guests.Single_Adult_and_Two_Infant)
            {
                x = 690;
            }// price for 1 adults 2 babies in a room for 3 no view

            if (User.Rooms == Hotel.Room_Type.Three_People_NoView && User.Hotels == Hotel.Hotel_Name.Four_Seasons_hotel_The_Westcliff && User.NumOfGuests == Hotel.Num_Guests.Two_Adults_and_One_Child)
            {
                x = 775;
            }// price for 2 adults and 1 child in a room for 3 no view

            if (User.Rooms == Hotel.Room_Type.Three_People_NoView && User.Hotels == Hotel.Hotel_Name.Four_Seasons_hotel_The_Westcliff && User.NumOfGuests == Hotel.Num_Guests.Two_Adults_and_One_Infant)
            {
                x = 775;
            }// price for 2 adults and 1 baby in a room for 3 no view

            if (User.Rooms == Hotel.Room_Type.Three_People_NoView && User.Hotels == Hotel.Hotel_Name.Four_Seasons_hotel_The_Westcliff && User.NumOfGuests == Hotel.Num_Guests.Single_Adult_and_One_Child_and_one_Infant)
            {
                x = 775;
            }// price for 1 adult, 1 child, 1 baby in a room for 3 no view

            if (User.Rooms == Hotel.Room_Type.Four_People_NoView && User.Hotels == Hotel.Hotel_Name.Four_Seasons_hotel_The_Westcliff && User.NumOfGuests == Hotel.Num_Guests.Four_adults)
            {
                x = 1000;
            } // price for  4 adults in a room for 4 no view

            if (User.Rooms == Hotel.Room_Type.Four_People_NoView && User.Hotels == Hotel.Hotel_Name.Four_Seasons_hotel_The_Westcliff && User.NumOfGuests == Hotel.Num_Guests.Three_Adults_and_One_Child)
            {
                x = 1000;
            } // price for  3 adults 1 child in a room for 4 no view

            if (User.Rooms == Hotel.Room_Type.Four_People_NoView && User.Hotels == Hotel.Hotel_Name.Four_Seasons_hotel_The_Westcliff && User.NumOfGuests == Hotel.Num_Guests.Three_Adults_and_One_Infant)
            {
                x = 1000;
            } // price for  3 adults  1 baby in a room for 4 no view

            if (User.Rooms == Hotel.Room_Type.Four_People_NoView && User.Hotels == Hotel.Hotel_Name.Four_Seasons_hotel_The_Westcliff && User.NumOfGuests == Hotel.Num_Guests.Two_Adults_and_Two_Child)
            {
                x = 1000;
            } // price for  2 adults 2 children in a room for 4 no view

            if (User.Rooms == Hotel.Room_Type.Four_People_NoView && User.Hotels == Hotel.Hotel_Name.Four_Seasons_hotel_The_Westcliff && User.NumOfGuests == Hotel.Num_Guests.Two_Adults_and_Two_Infant)
            {
                x = 1000;
            } // price for  2 adults 2 babies in a room for 4 no view

            if (User.Rooms == Hotel.Room_Type.Four_People_NoView && User.Hotels == Hotel.Hotel_Name.Four_Seasons_hotel_The_Westcliff && User.NumOfGuests == Hotel.Num_Guests.Two_Adults_and_One_Child_and_One_Infant)
            {
                x = 1000;
            } // price for  2 adults,1 child, 1 baby in a room for 4 no view

            if (User.Rooms == Hotel.Room_Type.Four_People_NoView && User.Hotels == Hotel.Hotel_Name.Four_Seasons_hotel_The_Westcliff && User.NumOfGuests == Hotel.Num_Guests.Single_Adult_and_Three_Children)
            {
                x = 1000;
            } // price for  1 adult 3 children in a room for 4 no view

            if (User.Rooms == Hotel.Room_Type.Four_People_NoView && User.Hotels == Hotel.Hotel_Name.Four_Seasons_hotel_The_Westcliff && User.NumOfGuests == Hotel.Num_Guests.Single_Adult_and_Three_Infant)
            {
                x = 1000;
            } // price for  1 adults 3 babies in a room for 4 no view
              ////////////////////////////////////

            if (User.Rooms == Hotel.Room_Type.Single_Person_View && User.Hotels == Hotel.Hotel_Name.Four_Seasons_hotel_The_Westcliff && User.NumOfGuests == Hotel.Num_Guests.Single_Adult)
            {
                x = 300;
            }//price for 1 adult in a room for 1  view

            if (User.Rooms == Hotel.Room_Type.Two_People_View && User.Hotels == Hotel.Hotel_Name.Four_Seasons_hotel_The_Westcliff && User.NumOfGuests == Hotel.Num_Guests.Two_Adults)
            {
                x = 500;

            }// price for 2 adults in a room for2  view

            if (User.Rooms == Hotel.Room_Type.Two_People_View && User.Hotels == Hotel.Hotel_Name.Four_Seasons_hotel_The_Westcliff && User.NumOfGuests == Hotel.Num_Guests.Single_adult_and_Single_Child)
            {
                x = 450;

            }// price for 1 adult and 1 child  in a room for 2  view

            if (User.Rooms == Hotel.Room_Type.Two_People_View && User.Hotels == Hotel.Hotel_Name.Four_Seasons_hotel_The_Westcliff && User.NumOfGuests == Hotel.Num_Guests.Single_Adult_and_Single_Infant)
            {
                x = 350;

            }// price for 1 adult and 1 baby in a room for 2 view

            if (User.Rooms == Hotel.Room_Type.Three_People_View && User.Hotels == Hotel.Hotel_Name.Four_Seasons_hotel_The_Westcliff && User.NumOfGuests == Hotel.Num_Guests.Three_Adults)
            {
                x = 775;
            }// price for 3 adults in a room for 3   view

            if (User.Rooms == Hotel.Room_Type.Three_People_View && User.Hotels == Hotel.Hotel_Name.Four_Seasons_hotel_The_Westcliff && User.NumOfGuests == Hotel.Num_Guests.Single_Adult_and_two_Children)
            {
                x = 705;
            }// price for 1 adults and 2 children in a room for 3  view

            if (User.Rooms == Hotel.Room_Type.Three_People_View && User.Hotels == Hotel.Hotel_Name.Four_Seasons_hotel_The_Westcliff && User.NumOfGuests == Hotel.Num_Guests.Single_Adult_and_Two_Infant)
            {
                x = 690;
            }// price for 1 adults 2 babies in a room for 3  view

            if (User.Rooms == Hotel.Room_Type.Three_People_View && User.Hotels == Hotel.Hotel_Name.Four_Seasons_hotel_The_Westcliff && User.NumOfGuests == Hotel.Num_Guests.Two_Adults_and_One_Child)
            {
                x = 775;
            }// price for 2 adults and 1 child in a room for 3  view

            if (User.Rooms == Hotel.Room_Type.Three_People_View && User.Hotels == Hotel.Hotel_Name.Four_Seasons_hotel_The_Westcliff && User.NumOfGuests == Hotel.Num_Guests.Two_Adults_and_One_Infant)
            {
                x = 775;
            }// price for 2 adults and 1 baby in a room for 3  view

            if (User.Rooms == Hotel.Room_Type.Three_People_View && User.Hotels == Hotel.Hotel_Name.Four_Seasons_hotel_The_Westcliff && User.NumOfGuests == Hotel.Num_Guests.Single_Adult_and_One_Child_and_one_Infant)
            {
                x = 775;
            }// price for 1 adult, 1 child, 1 baby in a room for 3  view

            if (User.Rooms == Hotel.Room_Type.Four_People_View && User.Hotels == Hotel.Hotel_Name.Four_Seasons_hotel_The_Westcliff && User.NumOfGuests == Hotel.Num_Guests.Four_adults)
            {
                x = 1000;
            } // price for  4 adults in a room for 4  view

            if (User.Rooms == Hotel.Room_Type.Four_People_View && User.Hotels == Hotel.Hotel_Name.Four_Seasons_hotel_The_Westcliff && User.NumOfGuests == Hotel.Num_Guests.Three_Adults_and_One_Child)
            {
                x = 1000;
            } // price for  3 adults 1 child in a room for 4  view

            if (User.Rooms == Hotel.Room_Type.Four_People_View && User.Hotels == Hotel.Hotel_Name.Four_Seasons_hotel_The_Westcliff && User.NumOfGuests == Hotel.Num_Guests.Three_Adults_and_One_Infant)
            {
                x = 1000;
            } // price for  3 adults  1 baby in a room for 4  view

            if (User.Rooms == Hotel.Room_Type.Four_People_View && User.Hotels == Hotel.Hotel_Name.Four_Seasons_hotel_The_Westcliff && User.NumOfGuests == Hotel.Num_Guests.Two_Adults_and_Two_Child)
            {
                x = 1000;
            } // price for  2 adults 2 children in a room for 4  view

            if (User.Rooms == Hotel.Room_Type.Four_People_View && User.Hotels == Hotel.Hotel_Name.Four_Seasons_hotel_The_Westcliff && User.NumOfGuests == Hotel.Num_Guests.Two_Adults_and_Two_Infant)
            {
                x = 1000;
            } // price for  2 adults 2 babies in a room for 4  view

            if (User.Rooms == Hotel.Room_Type.Four_People_View && User.Hotels == Hotel.Hotel_Name.Four_Seasons_hotel_The_Westcliff && User.NumOfGuests == Hotel.Num_Guests.Two_Adults_and_One_Child_and_One_Infant)
            {
                x = 1000;
            } // price for  2 adults,1 child, 1 baby in a room for 4  view

            if (User.Rooms == Hotel.Room_Type.Four_People_View && User.Hotels == Hotel.Hotel_Name.Four_Seasons_hotel_The_Westcliff && User.NumOfGuests == Hotel.Num_Guests.Single_Adult_and_Three_Children)
            {
                x = 1000;
            } // price for  1 adult 3 children in a room for 4  view

            if (User.Rooms == Hotel.Room_Type.Four_People_View && User.Hotels == Hotel.Hotel_Name.Four_Seasons_hotel_The_Westcliff && User.NumOfGuests == Hotel.Num_Guests.Single_Adult_and_Three_Infant)
            {
                x = 1000;
            } // price for  1 adults 3 babies in a room for 4  view
              ////////////////////////


            ///////////////////////////
            if (User.Rooms == Hotel.Room_Type.Single_Person_NoView && User.Hotels == Hotel.Hotel_Name.Pearls_Of_Umhlanga && User.NumOfGuests == Hotel.Num_Guests.Single_Adult)
            {
                x = 300;
            }//price for 1 adult in a room for 1 no view

            if (User.Rooms == Hotel.Room_Type.Two_People_NoView && User.Hotels == Hotel.Hotel_Name.Pearls_Of_Umhlanga && User.NumOfGuests == Hotel.Num_Guests.Two_Adults)
            {
                x = 500;

            }// price for 2 adults in a room for2 no view

            if (User.Rooms == Hotel.Room_Type.Two_People_NoView && User.Hotels == Hotel.Hotel_Name.Pearls_Of_Umhlanga && User.NumOfGuests == Hotel.Num_Guests.Single_adult_and_Single_Child)
            {
                x = 450;

            }// price for 1 adult and 1 child  in a room for 2 no view

            if (User.Rooms == Hotel.Room_Type.Two_People_NoView && User.Hotels == Hotel.Hotel_Name.Pearls_Of_Umhlanga && User.NumOfGuests == Hotel.Num_Guests.Single_Adult_and_Single_Infant)
            {
                x = 350;

            }// price for 1 adult and 1 baby in a room for 2 no view

            if (User.Rooms == Hotel.Room_Type.Three_People_NoView && User.Hotels == Hotel.Hotel_Name.Pearls_Of_Umhlanga && User.NumOfGuests == Hotel.Num_Guests.Three_Adults)
            {
                x = 775;
            }// price for 3 adults in a room for 3  no view

            if (User.Rooms == Hotel.Room_Type.Three_People_NoView && User.Hotels == Hotel.Hotel_Name.Pearls_Of_Umhlanga && User.NumOfGuests == Hotel.Num_Guests.Single_Adult_and_two_Children)
            {
                x = 705;
            }// price for 1 adults and 2 children in a room for 3 no view

            if (User.Rooms == Hotel.Room_Type.Three_People_NoView && User.Hotels == Hotel.Hotel_Name.Pearls_Of_Umhlanga && User.NumOfGuests == Hotel.Num_Guests.Single_Adult_and_Two_Infant)
            {
                x = 690;
            }// price for 1 adults 2 babies in a room for 3 no view

            if (User.Rooms == Hotel.Room_Type.Three_People_NoView && User.Hotels == Hotel.Hotel_Name.Pearls_Of_Umhlanga && User.NumOfGuests == Hotel.Num_Guests.Two_Adults_and_One_Child)
            {
                x = 775;
            }// price for 2 adults and 1 child in a room for 3 no view

            if (User.Rooms == Hotel.Room_Type.Three_People_NoView && User.Hotels == Hotel.Hotel_Name.Pearls_Of_Umhlanga && User.NumOfGuests == Hotel.Num_Guests.Two_Adults_and_One_Infant)
            {
                x = 775;
            }// price for 2 adults and 1 baby in a room for 3 no view

            if (User.Rooms == Hotel.Room_Type.Three_People_NoView && User.Hotels == Hotel.Hotel_Name.Pearls_Of_Umhlanga && User.NumOfGuests == Hotel.Num_Guests.Single_Adult_and_One_Child_and_one_Infant)
            {
                x = 775;
            }// price for 1 adult, 1 child, 1 baby in a room for 3 no view

            if (User.Rooms == Hotel.Room_Type.Four_People_NoView && User.Hotels == Hotel.Hotel_Name.Pearls_Of_Umhlanga && User.NumOfGuests == Hotel.Num_Guests.Four_adults)
            {
                x = 1000;
            } // price for  4 adults in a room for 4 no view

            if (User.Rooms == Hotel.Room_Type.Four_People_NoView && User.Hotels == Hotel.Hotel_Name.Pearls_Of_Umhlanga && User.NumOfGuests == Hotel.Num_Guests.Three_Adults_and_One_Child)
            {
                x = 1000;
            } // price for  3 adults 1 child in a room for 4 no view

            if (User.Rooms == Hotel.Room_Type.Four_People_NoView && User.Hotels == Hotel.Hotel_Name.Pearls_Of_Umhlanga && User.NumOfGuests == Hotel.Num_Guests.Three_Adults_and_One_Infant)
            {
                x = 1000;
            } // price for  3 adults  1 baby in a room for 4 no view

            if (User.Rooms == Hotel.Room_Type.Four_People_NoView && User.Hotels == Hotel.Hotel_Name.Pearls_Of_Umhlanga && User.NumOfGuests == Hotel.Num_Guests.Two_Adults_and_Two_Child)
            {
                x = 1000;
            } // price for  2 adults 2 children in a room for 4 no view

            if (User.Rooms == Hotel.Room_Type.Four_People_NoView && User.Hotels == Hotel.Hotel_Name.Pearls_Of_Umhlanga && User.NumOfGuests == Hotel.Num_Guests.Two_Adults_and_Two_Infant)
            {
                x = 1000;
            } // price for  2 adults 2 babies in a room for 4 no view

            if (User.Rooms == Hotel.Room_Type.Four_People_NoView && User.Hotels == Hotel.Hotel_Name.Pearls_Of_Umhlanga && User.NumOfGuests == Hotel.Num_Guests.Two_Adults_and_One_Child_and_One_Infant)
            {
                x = 1000;
            } // price for  2 adults,1 child, 1 baby in a room for 4 no view

            if (User.Rooms == Hotel.Room_Type.Four_People_NoView && User.Hotels == Hotel.Hotel_Name.Pearls_Of_Umhlanga && User.NumOfGuests == Hotel.Num_Guests.Single_Adult_and_Three_Children)
            {
                x = 1000;
            } // price for  1 adult 3 children in a room for 4 no view

            if (User.Rooms == Hotel.Room_Type.Four_People_NoView && User.Hotels == Hotel.Hotel_Name.Pearls_Of_Umhlanga && User.NumOfGuests == Hotel.Num_Guests.Single_Adult_and_Three_Infant)
            {
                x = 1000;
            } // price for  1 adults 3 babies in a room for 4 no view
              /////////////////////////////////////////

            if (User.Rooms == Hotel.Room_Type.Single_Person_View && User.Hotels == Hotel.Hotel_Name.Pearls_Of_Umhlanga && User.NumOfGuests == Hotel.Num_Guests.Single_Adult)
            {
                x = 300;
            }//price for 1 adult in a room for 1  view

            if (User.Rooms == Hotel.Room_Type.Two_People_View && User.Hotels == Hotel.Hotel_Name.Pearls_Of_Umhlanga && User.NumOfGuests == Hotel.Num_Guests.Two_Adults)
            {
                x = 500;

            }// price for 2 adults in a room for2  view

            if (User.Rooms == Hotel.Room_Type.Two_People_View && User.Hotels == Hotel.Hotel_Name.Pearls_Of_Umhlanga && User.NumOfGuests == Hotel.Num_Guests.Single_adult_and_Single_Child)
            {
                x = 450;

            }// price for 1 adult and 1 child  in a room for 2  view

            if (User.Rooms == Hotel.Room_Type.Two_People_View && User.Hotels == Hotel.Hotel_Name.Pearls_Of_Umhlanga && User.NumOfGuests == Hotel.Num_Guests.Single_Adult_and_Single_Infant)
            {
                x = 350;

            }// price for 1 adult and 1 baby in a room for 2 view

            if (User.Rooms == Hotel.Room_Type.Three_People_View && User.Hotels == Hotel.Hotel_Name.Pearls_Of_Umhlanga && User.NumOfGuests == Hotel.Num_Guests.Three_Adults)
            {
                x = 775;
            }// price for 3 adults in a room for 3   view

            if (User.Rooms == Hotel.Room_Type.Three_People_View && User.Hotels == Hotel.Hotel_Name.Pearls_Of_Umhlanga && User.NumOfGuests == Hotel.Num_Guests.Single_Adult_and_two_Children)
            {
                x = 705;
            }// price for 1 adults and 2 children in a room for 3  view

            if (User.Rooms == Hotel.Room_Type.Three_People_View && User.Hotels == Hotel.Hotel_Name.Pearls_Of_Umhlanga && User.NumOfGuests == Hotel.Num_Guests.Single_Adult_and_Two_Infant)
            {
                x = 690;
            }// price for 1 adults 2 babies in a room for 3  view

            if (User.Rooms == Hotel.Room_Type.Three_People_View && User.Hotels == Hotel.Hotel_Name.Pearls_Of_Umhlanga && User.NumOfGuests == Hotel.Num_Guests.Two_Adults_and_One_Child)
            {
                x = 775;
            }// price for 2 adults and 1 child in a room for 3  view

            if (User.Rooms == Hotel.Room_Type.Three_People_View && User.Hotels == Hotel.Hotel_Name.Pearls_Of_Umhlanga && User.NumOfGuests == Hotel.Num_Guests.Two_Adults_and_One_Infant)
            {
                x = 775;
            }// price for 2 adults and 1 baby in a room for 3  view

            if (User.Rooms == Hotel.Room_Type.Three_People_View && User.Hotels == Hotel.Hotel_Name.Pearls_Of_Umhlanga && User.NumOfGuests == Hotel.Num_Guests.Single_Adult_and_One_Child_and_one_Infant)
            {
                x = 775;
            }// price for 1 adult, 1 child, 1 baby in a room for 3  view

            if (User.Rooms == Hotel.Room_Type.Four_People_View && User.Hotels == Hotel.Hotel_Name.Pearls_Of_Umhlanga && User.NumOfGuests == Hotel.Num_Guests.Four_adults)
            {
                x = 1000;
            } // price for  4 adults in a room for 4  view

            if (User.Rooms == Hotel.Room_Type.Four_People_View && User.Hotels == Hotel.Hotel_Name.Pearls_Of_Umhlanga && User.NumOfGuests == Hotel.Num_Guests.Three_Adults_and_One_Child)
            {
                x = 1000;
            } // price for  3 adults 1 child in a room for 4  view

            if (User.Rooms == Hotel.Room_Type.Four_People_View && User.Hotels == Hotel.Hotel_Name.Pearls_Of_Umhlanga && User.NumOfGuests == Hotel.Num_Guests.Three_Adults_and_One_Infant)
            {
                x = 1000;
            } // price for  3 adults  1 baby in a room for 4  view

            if (User.Rooms == Hotel.Room_Type.Four_People_View && User.Hotels == Hotel.Hotel_Name.Pearls_Of_Umhlanga && User.NumOfGuests == Hotel.Num_Guests.Two_Adults_and_Two_Child)
            {
                x = 1000;
            } // price for  2 adults 2 children in a room for 4  view

            if (User.Rooms == Hotel.Room_Type.Four_People_View && User.Hotels == Hotel.Hotel_Name.Pearls_Of_Umhlanga && User.NumOfGuests == Hotel.Num_Guests.Two_Adults_and_Two_Infant)
            {
                x = 1000;
            } // price for  2 adults 2 babies in a room for 4  view

            if (User.Rooms == Hotel.Room_Type.Four_People_View && User.Hotels == Hotel.Hotel_Name.Pearls_Of_Umhlanga && User.NumOfGuests == Hotel.Num_Guests.Two_Adults_and_One_Child_and_One_Infant)
            {
                x = 1000;
            } // price for  2 adults,1 child, 1 baby in a room for 4  view

            if (User.Rooms == Hotel.Room_Type.Four_People_View && User.Hotels == Hotel.Hotel_Name.Pearls_Of_Umhlanga && User.NumOfGuests == Hotel.Num_Guests.Single_Adult_and_Three_Children)
            {
                x = 1000;
            } // price for  1 adult 3 children in a room for 4  view

            if (User.Rooms == Hotel.Room_Type.Four_People_View && User.Hotels == Hotel.Hotel_Name.Pearls_Of_Umhlanga && User.NumOfGuests == Hotel.Num_Guests.Single_Adult_and_Three_Infant)
            {
                x = 1000;
            } // price for  1 adults 3 babies in a room for 4  view

            /////////////////////////////////


            return x;
        }
    }
}