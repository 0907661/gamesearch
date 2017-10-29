namespace GameSearch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenreNameToGames : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Games (Genre) VALUES ('Adventure')");
            Sql("INSERT INTO Games (Genre) VALUES ('Fantasy')");
            Sql("INSERT INTO Games (Genre) VALUES ('Fist Person Shooter')");
            Sql("INSERT INTO Games (Genre) VALUES ('Science Fictions')");
        }
        
        public override void Down()
        {
        }
    }
}
