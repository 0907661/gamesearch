namespace GameSearch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewGamesApproach : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "Genre", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.Games", "ReleaseDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Games", "ReleaseDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Games", "Genre");
        }
    }
}
