namespace VidlyCourse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7263a331-b3b6-4a84-a944-d18fec83e77a', N'guest@gmail.com', 0, N'AOapOtD6A+b10CjxcIMdARg77k04pSs5QJsmye+3ugR7r8USWR/aUMMgSZjJO8gvTQ==', N'07be6a0f-f274-4cf8-9077-26395705cd8a', NULL, 0, 0, NULL, 1, 0, N'guest')
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e180078f-4213-434d-b324-6c9ab1645006', N'admin@vidly.com', 0, N'AIE5Z/xw9/zLskG3O8WN+oyIOkyhNfQ78qnkH9wyfSR4KKgDa1dVEZV5TjiiCtUacw==', N'9c0bd7c6-8d5c-440d-9c6d-2eda86eadc0a', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

                    INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'0810c55a-de55-4b1a-ab6b-cc31558b9456', N'CanManageMovies')

                    INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e180078f-4213-434d-b324-6c9ab1645006', N'0810c55a-de55-4b1a-ab6b-cc31558b9456')

            ");
        }
        
        public override void Down()
        {
        }
    }
}
