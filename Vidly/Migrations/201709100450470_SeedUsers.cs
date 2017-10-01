namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'02bd46d8-dd01-423f-9685-25f0e9bd0b28', N'guest@vidly.com', 0, N'AJX34tOeWVGvcBaqAJVJ7CUCWZAkZedqx4cNHTQxNiju3wpmgNZe/40SGExguM6Amw==', N'818dd1ef-5623-4fba-ad63-7c03fd9f3c43', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'391aba54-f17e-408e-8aa1-542a270c96fa', N'husnainakmal14@gmail.com', 0, N'ABWOdUCNzI9IvKBEP8/4JQg9J56xMUMU/UhDAwShDb9ddKSX0OhHcYQkoAmC11YtaA==', N'1080edf7-0c9a-4166-95a9-59573315daff', NULL, 0, 0, NULL, 1, 0, N'husnainakmal14@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'426940ca-47e8-475f-a5a8-4161fe9d7f4f', N'husnainakmal5@gmail.com', 0, N'ALPEIbzTFIda/a3B4VhM0+EukoLdBAXAWosn7EiT6DtPC+Nad1dXAn3oS5gJhat8Ig==', N'464706d9-9440-465a-8ffa-40f4e5c0947d', NULL, 0, 0, NULL, 1, 0, N'husnainakmal5@gmail.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'4d6dd4d3-8ea1-447d-a198-948b3e55601a', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'391aba54-f17e-408e-8aa1-542a270c96fa', N'4d6dd4d3-8ea1-447d-a198-948b3e55601a')


");
        }
        
        public override void Down()
        {
        }
    }
}
