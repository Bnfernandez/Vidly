using System.Data.Entity.ModelConfiguration.Conventions;

namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateNullablePropertyDateAddedofMovie : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE Movies ALTER COLUMN DateAdded Datetime NULL");
        }
        
        public override void Down()
        {
        }
    }
}
