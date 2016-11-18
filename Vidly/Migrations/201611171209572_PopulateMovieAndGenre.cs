using System.Data.Entity.Migrations;

namespace Vidly.Migrations
{
    public partial class PopulateMovieAndGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MovieGenres (Name) VALUES ('Action')");
            Sql("INSERT INTO MovieGenres (Name) VALUES ('Drama')");
            Sql("INSERT INTO MovieGenres (Name) VALUES ('Comedy')");
            Sql("INSERT INTO MovieGenres (Name) VALUES ('Romance')");

            Sql(
                "INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, MovieGenreId) VALUES ('Hangover', '2009-06-24', '2016-11-17', 5, 3)");
            Sql(
                "INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, MovieGenreId) VALUES ('Inception', '2010-07-21', '2016-11-17', 3, 2)");
            Sql(
                "INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, MovieGenreId) VALUES ('Rocky Balboa', '2007-01-24', '2016-11-17', 5, 2)");
            Sql(
                "INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, MovieGenreId) VALUES ('Creed', '2016-01-13', '2016-11-17', 5, 1)");
        }

        public override void Down()
        {
        }
    }
}