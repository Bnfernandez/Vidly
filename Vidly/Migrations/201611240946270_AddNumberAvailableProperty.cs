using System.Data.Entity.Migrations;

namespace Vidly.Migrations
{
    public partial class AddNumberAvailableProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "NumberAvailable", c => c.Int(false));
        }

        public override void Down()
        {
            DropColumn("dbo.Movies", "NumberAvailable");
        }
    }
}