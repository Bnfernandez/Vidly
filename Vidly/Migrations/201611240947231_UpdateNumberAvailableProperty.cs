using System.Data.Entity.Migrations;

namespace Vidly.Migrations
{
    public partial class UpdateNumberAvailableProperty : DbMigration
    {
        public override void Up()
        {
            Sql("Update Movies set NumberAvailable = NumberInStock");
        }

        public override void Down()
        {
        }
    }
}