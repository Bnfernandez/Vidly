using System.Data.Entity.Migrations;

namespace Vidly.Migrations
{
    public partial class AddBirthdateToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "BirthDate", c => c.DateTime(false));
        }

        public override void Down()
        {
            DropColumn("dbo.Customers", "BirthDate");
        }
    }
}