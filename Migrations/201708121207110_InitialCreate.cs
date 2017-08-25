namespace HealthyFoods.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bean",
                c => new
                    {
                        BeanID = c.Int(nullable: false, identity: true),
                        Image = c.Byte(nullable: false),
                        Name = c.String(),
                        Protein = c.Double(nullable: false),
                        Carbohydrates = c.Double(nullable: false),
                        Fat = c.Double(nullable: false),
                        Energy = c.Double(nullable: false),
                        Food_ID = c.Int(),
                    })
                .PrimaryKey(t => t.BeanID)
                .ForeignKey("dbo.Food", t => t.Food_ID)
                .Index(t => t.Food_ID);
            
            CreateTable(
                "dbo.Food",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Image = c.Byte(nullable: false),
                        Name = c.String(),
                        Group = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Fruit",
                c => new
                    {
                        FruitID = c.Int(nullable: false, identity: true),
                        Image = c.Byte(nullable: false),
                        Name = c.String(),
                        Protein = c.Double(nullable: false),
                        Carbohydrates = c.Double(nullable: false),
                        Fat = c.Double(nullable: false),
                        Energy = c.Double(nullable: false),
                        Food_ID = c.Int(),
                    })
                .PrimaryKey(t => t.FruitID)
                .ForeignKey("dbo.Food", t => t.Food_ID)
                .Index(t => t.Food_ID);
            
            CreateTable(
                "dbo.MeatFishEgg",
                c => new
                    {
                        MeatFishEggID = c.Int(nullable: false, identity: true),
                        Image = c.Byte(nullable: false),
                        Name = c.String(),
                        Protein = c.Double(nullable: false),
                        Carbohydrates = c.Double(nullable: false),
                        Fat = c.Double(nullable: false),
                        Energy = c.Double(nullable: false),
                        Food_ID = c.Int(),
                    })
                .PrimaryKey(t => t.MeatFishEggID)
                .ForeignKey("dbo.Food", t => t.Food_ID)
                .Index(t => t.Food_ID);
            
            CreateTable(
                "dbo.Nut",
                c => new
                    {
                        NutID = c.Int(nullable: false, identity: true),
                        Image = c.Byte(nullable: false),
                        Name = c.String(),
                        Protein = c.Double(nullable: false),
                        Carbohydrates = c.Double(nullable: false),
                        Fat = c.Double(nullable: false),
                        Energy = c.Double(nullable: false),
                        Food_ID = c.Int(),
                    })
                .PrimaryKey(t => t.NutID)
                .ForeignKey("dbo.Food", t => t.Food_ID)
                .Index(t => t.Food_ID);
            
            CreateTable(
                "dbo.Vegetable",
                c => new
                    {
                        VegetableID = c.Int(nullable: false, identity: true),
                        Image = c.Byte(nullable: false),
                        Name = c.String(),
                        Protein = c.Double(nullable: false),
                        Carbohydrates = c.Double(nullable: false),
                        Fat = c.Double(nullable: false),
                        Energy = c.Double(nullable: false),
                        Food_ID = c.Int(),
                    })
                .PrimaryKey(t => t.VegetableID)
                .ForeignKey("dbo.Food", t => t.Food_ID)
                .Index(t => t.Food_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vegetable", "Food_ID", "dbo.Food");
            DropForeignKey("dbo.Nut", "Food_ID", "dbo.Food");
            DropForeignKey("dbo.MeatFishEgg", "Food_ID", "dbo.Food");
            DropForeignKey("dbo.Fruit", "Food_ID", "dbo.Food");
            DropForeignKey("dbo.Bean", "Food_ID", "dbo.Food");
            DropIndex("dbo.Vegetable", new[] { "Food_ID" });
            DropIndex("dbo.Nut", new[] { "Food_ID" });
            DropIndex("dbo.MeatFishEgg", new[] { "Food_ID" });
            DropIndex("dbo.Fruit", new[] { "Food_ID" });
            DropIndex("dbo.Bean", new[] { "Food_ID" });
            DropTable("dbo.Vegetable");
            DropTable("dbo.Nut");
            DropTable("dbo.MeatFishEgg");
            DropTable("dbo.Fruit");
            DropTable("dbo.Food");
            DropTable("dbo.Bean");
        }
    }
}
