namespace GameSearch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetMembershipTypeName : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'Free' WHERE Id = 1");
            Sql("UPDATE MembershipTypes SET Name = 'Free' WHERE Id = 2");
            Sql("UPDATE MembershipTypes SET Name = 'Donator' WHERE Id = 3");
            Sql("UPDATE MembershipTypes SET Name = 'Mod' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
