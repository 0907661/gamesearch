namespace GameSearch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGames : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Games (Name) VALUES ('Super Mario')");
            Sql("INSERT INTO Games (Name) VALUES ('Final Fantasy')");
            Sql("INSERT INTO Games (Name) VALUES ('CS: GO')");
            Sql("INSERT INTO Games (Name) VALUES ('Halo')");
        }
        
        public override void Down()
        {
        }
    }
}
