namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovieData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, releaseDate, dateAdded, stock, GenreId) VALUES ('Shrek', '2001-10-11', '2008-05-10', 5, 1)");
            Sql("INSERT INTO Movies (Name, releaseDate, dateAdded, stock, GenreId) VALUES ('Die Hard', '1998-10-11', '2006-05-10', 2, 3)");
            Sql("INSERT INTO Movies (Name, releaseDate, dateAdded, stock, GenreId) VALUES ('Toy Story', '2001-01-11', '2008-05-10', 10, 2)");
            Sql("INSERT INTO Movies (Name, releaseDate, dateAdded, stock, GenreId) VALUES ('Titanic', '2000-06-11', '2009-03-10', 20, 4)");
        }
        
        public override void Down()
        {
        }
    }
}
