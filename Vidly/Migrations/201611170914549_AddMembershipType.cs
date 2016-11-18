using System.Data.Entity.Migrations;

namespace Vidly.Migrations
{
    public partial class AddMembershipType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                {
                    Id = c.Byte(false),
                    SignUpFeee = c.Short(false),
                    DurationInMonths = c.Byte(false),
                    DiscountRate = c.Byte(false)
                })
                .PrimaryKey(t => t.Id);

            AddColumn("dbo.Customers", "MembershipTypeId", c => c.Byte(false));
            CreateIndex("dbo.Customers", "MembershipTypeId");
            AddForeignKey("dbo.Customers", "MembershipTypeId", "dbo.MembershipTypes", "Id", true);
        }

        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MembershipTypeId", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] {"MembershipTypeId"});
            DropColumn("dbo.Customers", "MembershipTypeId");
            DropTable("dbo.MembershipTypes");
        }
    }
}