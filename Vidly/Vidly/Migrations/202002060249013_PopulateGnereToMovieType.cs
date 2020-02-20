namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGnereToMovieType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MovieTypes (Genre) VALUES ('Comedy')");
            Sql("INSERT INTO MovieTypes (Genre) VALUES ('Action')");
            Sql("INSERT INTO MovieTypes (Genre) VALUES ('Action')");
            Sql("INSERT INTO MovieTypes (Genre) VALUES ('Family')");
            Sql("INSERT INTO MovieTypes (Genre) VALUES ('Romance')");
        }
        
        public override void Down()
        {
        }
    }
}
