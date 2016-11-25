using System.Data.Entity.Migrations;

namespace Vidly.Migrations
{
    public partial class AddDrivingLicenseToApplicationUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "DrivingLicense", c => c.String(false, 255));
        }

        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "DrivingLicense");
        }
    }
}