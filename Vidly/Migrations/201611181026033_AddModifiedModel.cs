using System.Data.Entity.Migrations;

namespace Vidly.Migrations
{
    public partial class AddModifiedModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Name", c => c.String(false));
        }

        public override void Down()
        {
            AlterColumn("dbo.Movies", "Name", c => c.String());
        }
    }
}