namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate = '1992-10-31' where ID = 1");
        }
        
        public override void Down()
        {
        }
    }
}
