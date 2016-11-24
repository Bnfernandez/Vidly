namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateNumberAvailableProperty : DbMigration
    {
        public override void Up()
        {
            Sql("Update Movies set NumberAvailable = NumberInStock");
        }
        
        public override void Down()
        {
        }
    }
}
