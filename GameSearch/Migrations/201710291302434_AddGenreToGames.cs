namespace GameSearch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenreToGames : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Games", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.Games", new[] { "Genre_Id" });
            AddColumn("dbo.Games", "Genre", c => c.String());
            DropColumn("dbo.Games", "Genre_Id");
            DropTable("dbo.Genres");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Games", "Genre_Id", c => c.Byte());
            DropColumn("dbo.Games", "Genre");
            CreateIndex("dbo.Games", "Genre_Id");
            AddForeignKey("dbo.Games", "Genre_Id", "dbo.Genres", "Id");
        }
    }
}
