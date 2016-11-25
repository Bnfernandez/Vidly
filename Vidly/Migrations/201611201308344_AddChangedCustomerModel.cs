using System.Data.Entity.Migrations;

namespace Vidly.Migrations
{
    public partial class AddChangedCustomerModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Name", c => c.String(false, 255));
        }

        public override void Down()
        {
            AlterColumn("dbo.Customers", "Name", c => c.String(false));
        }
    }
}