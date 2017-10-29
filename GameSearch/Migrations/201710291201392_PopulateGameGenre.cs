namespace GameSearch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGameGenre : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Games SET Genre = 'Adventure' WHERE Id = 1");
            Sql("UPDATE Games SET Genre = 'Fantasy' WHERE Id = 2");
        }
        
        public override void Down()
        {
        }
    }
}
