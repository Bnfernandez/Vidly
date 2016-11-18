using System.Data.Entity.Migrations;

namespace Vidly.Migrations
{
    public partial class AddBirthdateNullablePropertyToCustomer : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "BirthDate", c => c.DateTime());
        }

        public override void Down()
        {
            AlterColumn("dbo.Customers", "BirthDate", c => c.DateTime(false));
        }
    }
}