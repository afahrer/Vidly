namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9ed8131b-18a1-4490-8f53-58a67ac52d8b', N'realadmin@vidly.com', 0, N'AJol0VyjV597qvP/0eMO3j3eoCzDS+9OhHPOTeoHr0S2tAIOXtL69gtK6Z4twcBQfA==', N'ecec0d19-7f6a-400e-a279-45c273153198', NULL, 0, 0, NULL, 1, 0, N'realadmin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'fc23fae2-ce63-4c52-8025-acd1d180d1ac', N'guest@vidly.com', 0, N'AIhe23WVIk2kmmlzmprwYqfyxIJOT0KWOy9+yUS4Umirovx4UAcOxZfcabAR06FNGw==', N'15dab924-cc60-43c0-b504-8aeb47762cd9', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'9d092eee-5bea-4c6d-9a8a-c131a0634e6b', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9ed8131b-18a1-4490-8f53-58a67ac52d8b', N'9d092eee-5bea-4c6d-9a8a-c131a0634e6b')

");
        }
        
        public override void Down()
        {
        }
    }
}
