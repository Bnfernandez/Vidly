using System.Data.Entity.Migrations;

namespace Vidly.Migrations
{
    public partial class UpdateCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate = '1992-10-31' where ID = 1");
        }

        public override void Down()
        {
        }
    }
}