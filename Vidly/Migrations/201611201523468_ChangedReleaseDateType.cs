using System.Data.Entity.Migrations;

namespace Vidly.Migrations
{
    public partial class ChangedReleaseDateType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(false, 7, storeType: "datetime2"));
        }

        public override void Down()
        {
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(false));
        }
    }
}