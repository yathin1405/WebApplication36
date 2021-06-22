using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication36.Models
{
    public class Hotel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Display(Name = "Hotel ID")]
        public int HotelID { get; set; }

        //[Display(Name = "Hotel Name")]
        //public string Hotel_Name { get; set; }

        //[Display(Name = "Cruise Duration")]
        //public string Cruise_Duration { get; set; }

       

        //[Display(Name = "Email adddress")]
        //[DataType(DataType.EmailAddress)]
        //public string Email { get; set; }

        //[Display(Name = "Number of guests")]
        ////public string Num_Guests { get; set; }
      



        //[Display(Name = "Check in ")]
        //[DataType(DataType.Date)]
        //public DateTime CheckIn{ get; set; }


        //[Display(Name = "Check out ")]
        //[DataType(DataType.Date)]
        //public DateTime CheckOut { get; set; }



        //[Display(Name = "Room Type")]
        //[Required(ErrorMessage = " required")]
        //[MaxLength(30, ErrorMessage = "Maxinum 30 charecters allowed"), MinLength(3, ErrorMessage = "Minimun 3 charecters allowed")]
        //public string Room_Type { get; set; }

        //[Display(Name = "Price")]
        //[Required(ErrorMessage = "Price Required")]
        public float Price { get; set; }
        //work out days between 2 date pickers
        // booking()- (Price*NumGuests)+RoomType()+Breakfast()
        //RoomType- if single then x=500
        //enum for room type, guest type
        //Boolean for breakfast
        //Breakfast()
        //bool Meal
        //MealType()-veg,meat 
        [Display(Name = "Hotel Name")]
        public Hotel_Name Hotels { get; set; }
        public enum Hotel_Name
        {
            Belmond_Mount_Nelson_Hotel,//western cape
            he_Cellars_Hohenort,//western cape
            
            Four_Seasons_hotel_The_Westcliff,//Gauteng
            
            Pearls_Of_Umhlanga,//KZN
          

        }

        [Display(Name = "Number of guests")]
        public Num_Guests NumOfGuests { get; set; }
        public enum Num_Guests
        {
            Single_Adult,//1 person
            Two_Adults,//2 people
            Three_Adults,//3 people
            Four_adults,//4 poeple
            Single_adult_and_Single_Child,//2 peolpe
            Single_Adult_and_Single_Infant,//2 people
            Single_Adult_and_two_Children,//3 people
            Single_Adult_and_Two_Infant,//3 people
            Two_Adults_and_One_Child,//3 poeple
            Two_Adults_and_One_Infant,//3 poeple
            Single_Adult_and_One_Child_and_one_Infant,//3 poeple
            Three_Adults_and_One_Child,//4 people
            Three_Adults_and_One_Infant,//4 poelpe
            Two_Adults_and_Two_Child,//4 people
            Two_Adults_and_Two_Infant,// 4 poeple
            Single_Adult_and_Three_Children,//4 poeple
            Single_Adult_and_Three_Infant,//4 poeple
            Two_Adults_and_One_Child_and_One_Infant,//4 people

        }






        //[Display(Name = "Room Type")]
        //[Required(ErrorMessage = " required")]
        //[MaxLength(30, ErrorMessage = "Maxinum 30 charecters allowed"), MinLength(3, ErrorMessage = "Minimun 3 charecters allowed")]
        public Room_Type Rooms { get; set; }
        public enum Room_Type
        {
            Single_Person_NoView,
            Two_People_NoView,
            Three_People_NoView,
            Four_People_NoView,
            Single_Person_View,
            Two_People_View,
            Three_People_View,
            Four_People_View,

        }


        public Meal MealType { get; set; }
        public enum Meal
        {
            Meat,
            Veg,
            No,
        }


    

    }
}