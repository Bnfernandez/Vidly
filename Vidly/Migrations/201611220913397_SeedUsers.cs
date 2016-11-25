using System.Data.Entity.Migrations;

namespace Vidly.Migrations
{
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(
                @"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a6439a0f-034c-4e7a-aadf-d62581e842b3', N'guest@vidly.com', 0, N'AHra9E1XyXZv69POU2Lr9/yvcf64sApZ/sdxjCB+kFn9P+/dGDySOAjfrwIinLFiCA==', N'7e77d980-b3e8-460e-8d68-e638362c385e', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e0a0dcd3-ef01-4078-9e14-ef23ea74fcd9', N'admin@vidly.com', 0, N'AA2xYMnt2wiX9taRGSNsLsGW7qQ9oS8Ad/e3fneMuPUdRa8gDgj61BXDqWhz2vVttw==', N'91c92963-fc6a-48fd-a87c-7490c3f90572', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

");
            Sql(
                @"INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'28f8c0d3-2057-4d2b-86c6-6333f4a65e38', N'CanManageMovies')
");
            Sql(
                @"INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e0a0dcd3-ef01-4078-9e14-ef23ea74fcd9', N'28f8c0d3-2057-4d2b-86c6-6333f4a65e38')
");
        }

        public override void Down()
        {
        }
    }
}