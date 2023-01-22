namespace VegetableStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Packsizes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        PackSize = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Int(nullable: false),
                        Qunatity = c.Int(nullable: false),
                        TotalPrice = c.Int(nullable: false),
                        Discount = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        PackId = c.Int(nullable: false),
                        Packsize_id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Packsizes", t => t.Packsize_id)
                .Index(t => t.CategoryId)
                .Index(t => t.Packsize_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Packsize_id", "dbo.Packsizes");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "Packsize_id" });
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropTable("dbo.Products");
            DropTable("dbo.Packsizes");
            DropTable("dbo.Categories");
        }
    }
}
