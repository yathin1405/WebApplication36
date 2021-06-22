namespace WebApplication36.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tours",
                c => new
                    {
                        TourId = c.Int(nullable: false, identity: true),
                        TourType = c.Int(nullable: false),
                        Tour_Name = c.String(),
                        Tour_Duration = c.String(),
                        Tour_Date = c.DateTime(nullable: false),
                        Tour_Time = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.TourId);
            
            CreateTable(
                "dbo.UserTours",
                c => new
                    {
                        GuestID = c.Int(nullable: false, identity: true),
                        Num_Adults = c.Int(nullable: false),
                        Num_Kids = c.Int(nullable: false),
                        Email = c.String(),
                        Tour_Name = c.String(),
                        Deposit = c.Double(nullable: false),
                        Discount = c.Double(nullable: false),
                        Total_Tickets = c.Int(nullable: false),
                        Total_Cost = c.Double(nullable: false),
                        GuestCost = c.Double(nullable: false),
                        Tour_Cost = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.GuestID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserTours");
            DropTable("dbo.Tours");
        }
    }
}
