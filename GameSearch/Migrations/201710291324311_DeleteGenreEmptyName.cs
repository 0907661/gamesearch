namespace GameSearch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteGenreEmptyName : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM Games WHERE Genre = 'Adventure'");
            Sql("DELETE FROM Games WHERE Genre = 'Fantasy'");
            Sql("DELETE FROM Games WHERE Genre = 'Fist Person Shooter'");
            Sql("DELETE FROM Games WHERE Genre = 'Science Fictions'");
        }
        
        public override void Down()
        {
        }
    }
}
