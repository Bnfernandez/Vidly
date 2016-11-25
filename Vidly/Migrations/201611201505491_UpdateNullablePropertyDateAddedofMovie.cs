using System.Data.Entity.Migrations;

namespace Vidly.Migrations
{
    public partial class UpdateNullablePropertyDateAddedofMovie : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE Movies ALTER COLUMN DateAdded Datetime NULL");
        }

        public override void Down()
        {
        }
    }
}