namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateNullablePropertyDateAddedofMovie2 : DbMigration
    {
        public override void Up()
        {
            Sql("alter table movies alter column releasedate datetime not null");
        }
        
        public override void Down()
        {
        }
    }
}
