using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication36.Models;

namespace WebApplication36.Data
{
    public class WebApplication36Context :DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public WebApplication36Context() : base("name=WebApplication36Context")
        {
        }

        public DbSet<Models.Tour> Tours { get; set; }

        public DbSet<Models.UserTour> UserTours { get; set; }

        public System.Data.Entity.DbSet<WebApplication36.Models.Flights> Flights { get; set; }

        public System.Data.Entity.DbSet<WebApplication36.Models.UserFlights> UserFlights { get; set; }

        public System.Data.Entity.DbSet<WebApplication36.Models.Hotel> Hotels { get; set; }

        public System.Data.Entity.DbSet<WebApplication36.Models.UserHotel> UserHotels { get; set; }
    }
}
