using System.Data.Entity.Migrations;

namespace Vidly.Migrations
{
    public partial class UpdatedUserModelWithPhone : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Phone", c => c.String(false, 50));
        }

        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Phone");
        }
    }
}