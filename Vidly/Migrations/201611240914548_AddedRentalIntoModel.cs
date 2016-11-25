using System.Data.Entity.Migrations;

namespace Vidly.Migrations
{
    public partial class AddedRentalIntoModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rentals",
                c => new
                {
                    Id = c.Int(false, true),
                    DateRented = c.DateTime(false),
                    DateReturned = c.DateTime(),
                    Customer_Id = c.Int(false),
                    Movie_Id = c.Int(false)
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id, true)
                .ForeignKey("dbo.Movies", t => t.Movie_Id, true)
                .Index(t => t.Customer_Id)
                .Index(t => t.Movie_Id);
        }

        public override void Down()
        {
            DropForeignKey("dbo.Rentals", "Movie_Id", "dbo.Movies");
            DropForeignKey("dbo.Rentals", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.Rentals", new[] {"Movie_Id"});
            DropIndex("dbo.Rentals", new[] {"Customer_Id"});
            DropTable("dbo.Rentals");
        }
    }
}