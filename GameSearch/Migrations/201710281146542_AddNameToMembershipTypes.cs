namespace GameSearch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameToMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE MembershipTypes ADD Name char(50)");
        }
        
        public override void Down()
        {
        }
    }
}
