using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication36.Models
{
    public class Tour
    {
        public Tours TourType { get; set; }
        public enum Tours
        {
            
            Ushaka,          
            Cape_Of_Good_Hope,         
            Apartheid_Museum,
            Gold_Reef_City_Theme_Park,           
            Durban_Natural_Science_Museum,
            

        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int TourId { get; set; }

        [Display(Name = "Tour Name")]
        public string Tour_Name { get; set; }
        [Display(Name = "Tour Duration")]
        public string Tour_Duration { get; set; }

        [Display(Name = "Tour Date")]
        [DataType(DataType.Date)]
        public DateTime Tour_Date { get; set; }
        [Display(Name = "Tour Time")]
        [DataType(DataType.Time)]
        public DateTime Tour_Time { get; set; }
        public double UshakPrice = 150;
        public double DNS = 100;
        public double AppMuseum = 200;
        public double GoodHope = 250;
        public double GoldReef = 175;
    }
}
