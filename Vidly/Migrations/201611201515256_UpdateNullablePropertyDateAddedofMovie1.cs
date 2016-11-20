namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateNullablePropertyDateAddedofMovie1 : DbMigration
    {
        public override void Up()
        {
            Sql("alter table Movies alter column releasedate datetime null");
        }
        
        public override void Down()
        {
        }
    }
}
