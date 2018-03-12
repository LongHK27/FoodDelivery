namespace FoodDelivery.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.APPLICATION_USER",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 64, fixedLength: true),
                        FullName = c.String(maxLength: 100),
                        Birthday = c.DateTime(),
                        Email = c.String(maxLength: 100),
                        Phone = c.String(maxLength: 20),
                        Address = c.String(maxLength: 200),
                        Username = c.String(maxLength: 100),
                        Password = c.String(maxLength: 20),
                        SercurityStamp = c.String(maxLength: 50),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IDENTITY_ROLE",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 64, fixedLength: true),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IDENTITY_USER_CLAIMS",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 64, fixedLength: true),
                        ClaimType = c.Int(nullable: false),
                        ClaimValue = c.String(nullable: false, maxLength: 50),
                        ApplicationId = c.String(maxLength: 64, fixedLength: true),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.APPLICATION_USER", t => t.ApplicationId)
                .Index(t => t.ApplicationId);
            
            CreateTable(
                "dbo.IDENTITY_USER_ROLE",
                c => new
                    {
                        IdentityRoleId = c.String(nullable: false, maxLength: 64, fixedLength: true),
                        ApplicationId = c.String(nullable: false, maxLength: 64, fixedLength: true),
                    })
                .PrimaryKey(t => new { t.IdentityRoleId, t.ApplicationId })
                .ForeignKey("dbo.APPLICATION_USER", t => t.ApplicationId, cascadeDelete: true)
                .ForeignKey("dbo.IDENTITY_ROLE", t => t.IdentityRoleId, cascadeDelete: true)
                .Index(t => t.IdentityRoleId)
                .Index(t => t.ApplicationId);
            
            CreateTable(
                "dbo.MEAL_CATEGORIES",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 64, fixedLength: true),
                        Display = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        CreateBy = c.String(maxLength: 64, fixedLength: true),
                        Status = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                        Alias = c.String(nullable: false, maxLength: 100),
                        ImageLink = c.String(maxLength: 1000),
                        Description = c.String(maxLength: 2000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MEAL_PROMOTION",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 64, fixedLength: true),
                        Quanlity = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        ComboList = c.String(maxLength: 200),
                        RestaurantId = c.String(maxLength: 64, fixedLength: true),
                        MealId = c.String(maxLength: 64, fixedLength: true),
                        CreateDate = c.DateTime(nullable: false),
                        CreateBy = c.String(maxLength: 64, fixedLength: true),
                        Status = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                        Alias = c.String(nullable: false, maxLength: 100),
                        ImageLink = c.String(maxLength: 1000),
                        Description = c.String(maxLength: 2000),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MEAL", t => t.MealId)
                .ForeignKey("dbo.RESTAURANT", t => t.RestaurantId)
                .Index(t => t.RestaurantId)
                .Index(t => t.MealId);
            
            CreateTable(
                "dbo.MEAL",
                c => new
                    {
                        RestaurantId = c.String(maxLength: 64, fixedLength: true),
                        MealCategoryId = c.String(maxLength: 64, fixedLength: true),
                        Id = c.String(nullable: false, maxLength: 64, fixedLength: true),
                        Price = c.Int(nullable: false),
                        Content = c.String(maxLength: 2000),
                        UpdateDate = c.DateTime(nullable: false),
                        UpdateBy = c.String(maxLength: 64, fixedLength: true),
                        CreateDate = c.DateTime(nullable: false),
                        CreateBy = c.String(maxLength: 64, fixedLength: true),
                        Status = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                        Alias = c.String(nullable: false, maxLength: 100),
                        ImageLink = c.String(maxLength: 1000),
                        Description = c.String(maxLength: 2000),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MEAL_CATEGORIES", t => t.MealCategoryId)
                .ForeignKey("dbo.RESTAURANT", t => t.RestaurantId)
                .Index(t => t.RestaurantId)
                .Index(t => t.MealCategoryId);
            
            CreateTable(
                "dbo.RESTAURANT",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 64, fixedLength: true),
                        UpdateDate = c.DateTime(nullable: false),
                        UpdateBy = c.String(maxLength: 64, fixedLength: true),
                        Address = c.String(nullable: false, maxLength: 200),
                        Location = c.String(nullable: false, maxLength: 50),
                        CreateDate = c.DateTime(nullable: false),
                        CreateBy = c.String(maxLength: 64, fixedLength: true),
                        Status = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                        Alias = c.String(nullable: false, maxLength: 100),
                        ImageLink = c.String(maxLength: 1000),
                        Description = c.String(maxLength: 2000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ORDER_DETAIL",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 64, fixedLength: true),
                        Quanlity = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        OrderId = c.String(maxLength: 64, fixedLength: true),
                        MealId = c.String(maxLength: 64, fixedLength: true),
                        SideDishId = c.String(maxLength: 64, fixedLength: true),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MEAL", t => t.MealId)
                .ForeignKey("dbo.ORDER", t => t.OrderId)
                .ForeignKey("dbo.SIDE_DISH", t => t.SideDishId)
                .Index(t => t.OrderId)
                .Index(t => t.MealId)
                .Index(t => t.SideDishId);
            
            CreateTable(
                "dbo.ORDER",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 64, fixedLength: true),
                        CustomerName = c.String(nullable: false, maxLength: 100),
                        CustomerEmail = c.String(maxLength: 100),
                        CustomerAddress = c.String(nullable: false, maxLength: 200),
                        CustomerMobile = c.String(nullable: false, maxLength: 20),
                        CustomerMessage = c.String(maxLength: 1000),
                        PromotionPrice = c.Int(nullable: false),
                        TotalAount = c.Int(nullable: false),
                        PaymentMenthod = c.String(nullable: false, maxLength: 50),
                        PaymentStatus = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        UserId = c.String(maxLength: 64, fixedLength: true),
                        RestaurantId = c.String(maxLength: 64, fixedLength: true),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.APPLICATION_USER", t => t.UserId)
                .ForeignKey("dbo.RESTAURANT", t => t.RestaurantId)
                .Index(t => t.UserId)
                .Index(t => t.RestaurantId);
            
            CreateTable(
                "dbo.SIDE_DISH",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 64, fixedLength: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Price = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        MealId = c.String(maxLength: 64, fixedLength: true),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MEAL", t => t.MealId)
                .Index(t => t.MealId);
            
            CreateTable(
                "dbo.ORDER_PROMOTION",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 64, fixedLength: true),
                        TotalMeal = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        ComboList = c.String(maxLength: 200),
                        RestaurantId = c.String(maxLength: 64, fixedLength: true),
                        CreateDate = c.DateTime(nullable: false),
                        CreateBy = c.String(maxLength: 64, fixedLength: true),
                        Status = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                        Alias = c.String(nullable: false, maxLength: 100),
                        ImageLink = c.String(maxLength: 1000),
                        Description = c.String(maxLength: 2000),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RESTAURANT", t => t.RestaurantId)
                .Index(t => t.RestaurantId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ORDER_PROMOTION", "RestaurantId", "dbo.RESTAURANT");
            DropForeignKey("dbo.ORDER_DETAIL", "SideDishId", "dbo.SIDE_DISH");
            DropForeignKey("dbo.SIDE_DISH", "MealId", "dbo.MEAL");
            DropForeignKey("dbo.ORDER_DETAIL", "OrderId", "dbo.ORDER");
            DropForeignKey("dbo.ORDER", "RestaurantId", "dbo.RESTAURANT");
            DropForeignKey("dbo.ORDER", "UserId", "dbo.APPLICATION_USER");
            DropForeignKey("dbo.ORDER_DETAIL", "MealId", "dbo.MEAL");
            DropForeignKey("dbo.MEAL_PROMOTION", "RestaurantId", "dbo.RESTAURANT");
            DropForeignKey("dbo.MEAL_PROMOTION", "MealId", "dbo.MEAL");
            DropForeignKey("dbo.MEAL", "RestaurantId", "dbo.RESTAURANT");
            DropForeignKey("dbo.MEAL", "MealCategoryId", "dbo.MEAL_CATEGORIES");
            DropForeignKey("dbo.IDENTITY_USER_ROLE", "IdentityRoleId", "dbo.IDENTITY_ROLE");
            DropForeignKey("dbo.IDENTITY_USER_ROLE", "ApplicationId", "dbo.APPLICATION_USER");
            DropForeignKey("dbo.IDENTITY_USER_CLAIMS", "ApplicationId", "dbo.APPLICATION_USER");
            DropIndex("dbo.ORDER_PROMOTION", new[] { "RestaurantId" });
            DropIndex("dbo.SIDE_DISH", new[] { "MealId" });
            DropIndex("dbo.ORDER", new[] { "RestaurantId" });
            DropIndex("dbo.ORDER", new[] { "UserId" });
            DropIndex("dbo.ORDER_DETAIL", new[] { "SideDishId" });
            DropIndex("dbo.ORDER_DETAIL", new[] { "MealId" });
            DropIndex("dbo.ORDER_DETAIL", new[] { "OrderId" });
            DropIndex("dbo.MEAL", new[] { "MealCategoryId" });
            DropIndex("dbo.MEAL", new[] { "RestaurantId" });
            DropIndex("dbo.MEAL_PROMOTION", new[] { "MealId" });
            DropIndex("dbo.MEAL_PROMOTION", new[] { "RestaurantId" });
            DropIndex("dbo.IDENTITY_USER_ROLE", new[] { "ApplicationId" });
            DropIndex("dbo.IDENTITY_USER_ROLE", new[] { "IdentityRoleId" });
            DropIndex("dbo.IDENTITY_USER_CLAIMS", new[] { "ApplicationId" });
            DropTable("dbo.ORDER_PROMOTION");
            DropTable("dbo.SIDE_DISH");
            DropTable("dbo.ORDER");
            DropTable("dbo.ORDER_DETAIL");
            DropTable("dbo.RESTAURANT");
            DropTable("dbo.MEAL");
            DropTable("dbo.MEAL_PROMOTION");
            DropTable("dbo.MEAL_CATEGORIES");
            DropTable("dbo.IDENTITY_USER_ROLE");
            DropTable("dbo.IDENTITY_USER_CLAIMS");
            DropTable("dbo.IDENTITY_ROLE");
            DropTable("dbo.APPLICATION_USER");
        }
    }
}
