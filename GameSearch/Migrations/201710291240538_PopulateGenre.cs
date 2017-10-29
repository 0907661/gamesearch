namespace GameSearch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Adventure')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Fantasy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'FPS')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Sci-Fi')");
        }
        
        public override void Down()
        {
        }
    }
}
