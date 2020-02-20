namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateGenreToMovieType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MovieTypes (Id, Gnere) VALUES (1, 'Comedy')");
            Sql("INSERT INTO MovieTypes (Id, Gnere) VALUES (2, 'Action')");
            Sql("INSERT INTO MovieTypes (Id, Gnere) VALUES (3, 'Action')");
            Sql("INSERT INTO MovieTypes (Id, Gnere) VALUES (4, 'Family')");
            Sql("INSERT INTO MovieTypes (Id, Gnere) VALUES (5, 'Romance')");
        }
        
        public override void Down()
        {
        }
    }
}
