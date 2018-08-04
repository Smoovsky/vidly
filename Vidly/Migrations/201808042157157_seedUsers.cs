namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'96f935c4-631a-41e6-bc8e-afc06589a407', N'admin@vidly.com', 0, N'AAZmA2k4zmYhrZ6SKWarCilg0HwCPBEpA9PawwZ0VtaQkggHWv5XEIbS2TmtGiK+jw==', N'1f6d02b5-4b00-4d9e-8bcb-7f50c92a2d54', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a704a873-dd86-4c1e-9a09-aefda71b0e1b', N'guest@vidly.com', 0, N'AEGV59Azmf6uzYbVF/RuCbr/EKr5JpF9+fztU5DiyOT78vxuoOKuKwIrhj9pFsQ2Nw==', N'3bf6ac04-2911-404e-8c07-ccf68061b695', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'771e7034-136b-466a-9bd6-86a433a7729b', N'CanMangeMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'96f935c4-631a-41e6-bc8e-afc06589a407', N'771e7034-136b-466a-9bd6-86a433a7729b')
");
        }
        
        public override void Down()
        {
        }
    }
}
