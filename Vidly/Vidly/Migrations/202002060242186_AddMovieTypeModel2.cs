namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovieTypeModel2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MovieTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Genre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Movies", "MovieTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Movies", "MovieTypeId");
            AddForeignKey("dbo.Movies", "MovieTypeId", "dbo.MovieTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "MovieTypeId", "dbo.MovieTypes");
            DropIndex("dbo.Movies", new[] { "MovieTypeId" });
            DropColumn("dbo.Movies", "MovieTypeId");
            DropTable("dbo.MovieTypes");
        }
    }
}
