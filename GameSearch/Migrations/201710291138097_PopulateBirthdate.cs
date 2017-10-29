namespace GameSearch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBirthdate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate = '1985-07-11 20:56:00' WHERE Id = 1");
            Sql("UPDATE Customers SET BirthDate = '1993-11-04 12:06:10' WHERE Id = 2");
        }
        
        public override void Down()
        {
        }
    }
}
