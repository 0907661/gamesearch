namespace GameSearch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateGenreNames : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Games SET Genre = 'Adventure' WHERE Id = 1");
            Sql("UPDATE Games SET Genre = 'Fantasy' WHERE Id = 2");
            Sql("UPDATE Games SET Genre = 'First Person Shooter' WHERE Id = 3");
            Sql("UPDATE Games SET Genre = 'Science Fiction' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
