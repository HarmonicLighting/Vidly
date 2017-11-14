namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7ad52f65-bef7-442f-8332-b1d42132a45a', N'admin@vidly.com', 0, N'AJKXrpPC/96f8n6Krz3qRaY6lWa8YHtUUA9+EDXeBBz4mrAH2jFnq1/lomSp6CNZnw==', N'6a27afbd-a3e6-4b19-bc10-5c64f0d04537', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'da86456d-aa6d-46aa-b929-c55648900679', N'user@vidly.com', 0, N'AMfmEqnh7s4swKDgWQp8EkQL8Fet+kdfSv5HGt9wxqlVqxhT6Ks4WlTyKdG4nHC7AA==', N'0801ef0b-9e0d-4adf-b547-e59a7d03fce3', NULL, 0, 0, NULL, 1, 0, N'user@vidly.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'a3b264c9-b421-4dba-87fa-2c578dd5d42e', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'7ad52f65-bef7-442f-8332-b1d42132a45a', N'a3b264c9-b421-4dba-87fa-2c578dd5d42e')");
        }
        
        public override void Down()
        {
        }
    }
}
