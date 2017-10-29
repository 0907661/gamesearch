namespace GameSearch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteGamesData : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM Games");
        }
        
        public override void Down()
        {
        }
    }
}
