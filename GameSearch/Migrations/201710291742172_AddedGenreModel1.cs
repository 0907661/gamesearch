namespace GameSearch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedGenreModel1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Games", "ReleaseDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Games", "Name", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.Games", "Genre");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Games", "Genre", c => c.String());
            AlterColumn("dbo.Games", "Name", c => c.String());
            DropColumn("dbo.Games", "ReleaseDate");
            DropTable("dbo.Genres");
        }
    }
}
