using System.Data.Entity.Migrations;

namespace Vidly.Migrations
{
    public partial class ChangedMovieModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Name", c => c.String(false, 255));
        }

        public override void Down()
        {
            AlterColumn("dbo.Movies", "Name", c => c.String(false));
        }
    }
}