using System.Data.Entity.Migrations;

namespace Vidly.Migrations
{
    public partial class AddNewMoviesPropertiesAndGenreModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                {
                    Id = c.Int(false, true),
                    Name = c.String(),
                    ReleaseDate = c.DateTime(false),
                    DateAdded = c.DateTime(false),
                    NumberInStock = c.Int(false),
                    MovieGenreId = c.Int(false)
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MovieGenres", t => t.MovieGenreId, true)
                .Index(t => t.MovieGenreId);

            CreateTable(
                "dbo.MovieGenres",
                c => new
                {
                    Id = c.Int(false, true),
                    Name = c.String(false)
                })
                .PrimaryKey(t => t.Id);
        }

        public override void Down()
        {
            DropForeignKey("dbo.Movies", "MovieGenreId", "dbo.MovieGenres");
            DropIndex("dbo.Movies", new[] {"MovieGenreId"});
            DropTable("dbo.MovieGenres");
            DropTable("dbo.Movies");
        }
    }
}