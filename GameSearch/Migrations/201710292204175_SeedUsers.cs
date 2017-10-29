namespace GameSearch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a90466f1-ba87-4330-b6bb-d705d4e1aa9b', N'guest@gamesearch.com', 0, N'AL1Ibx8ALd29F3hdqEucRo3gyq+o//PrGQJpzKg/KdTFCnWOkhUVE3QZKFuy2mYYMw==', N'c1e92ccc-f01b-4aa3-9b17-b65f72ca7be6', NULL, 0, 0, NULL, 1, 0, N'guest@gamesearch.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f5931282-8612-41b1-a1f8-b76ec9101559', N'admin@gamesearch.com', 0, N'AKyaDnUexBbCDOtLdAOjzh/fEivgcgRk/y8YG5L42DQEys3eDGGbVmVPxqhoQWFhIA==', N'6303e65d-bd47-4526-bff2-1adef7bae5fe', NULL, 0, 0, NULL, 1, 0, N'admin@gamesearch.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'569cfac9-7668-4009-9edd-4576d914d4db', N'Admin')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'f5931282-8612-41b1-a1f8-b76ec9101559', N'569cfac9-7668-4009-9edd-4576d914d4db')


");
        }
        
        public override void Down()
        {
        }
    }
}
