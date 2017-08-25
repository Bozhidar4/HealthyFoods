namespace HealthyFoods.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initials : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Bean", "Image", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Bean", "Image", c => c.Byte(nullable: false));
        }
    }
}
