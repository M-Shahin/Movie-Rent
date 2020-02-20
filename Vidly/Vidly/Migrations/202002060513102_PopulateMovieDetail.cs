namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovieDetail : DbMigration
    {
        public override void Up()
        {
            /*Sql("INSERT INTO Movies(Name, ReleaseDate, DateAdded, NumberInStock) VALUES ('Hangover', '6/11/2009', '1/2/2020', 5)");
            Sql("INSERT INTO Movies(Name, ReleaseDate, DateAdded, NumberInStock) VALUES ('Die Hard', '6/11/2010', '1/2/2020', 6)");
            Sql("INSERT INTO Movies(Name, ReleaseDate, DateAdded, NumberInStock) VALUES ('The Terminator', '6/11/1996', '1/2/2020', 4)");
            Sql("INSERT INTO Movies(Name, ReleaseDate, DateAdded, NumberInStock) VALUES ('Toy Story', '6/11/1999', '1/2/2020', 5)");
            Sql("INSERT INTO Movies(Name, ReleaseDate, DateAdded, NumberInStock) VALUES ('Titanic', '6/11/1998', '1/2/2020', 15)");*/
        }
        
        public override void Down()
        {
        }
    }
}
