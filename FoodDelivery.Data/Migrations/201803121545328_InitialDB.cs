namespace FoodDelivery.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.APPLICATION_USERs",
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
                "dbo.IDENTITY_ROLEs",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 64, fixedLength: true),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IDENTITY_USER_CLAIMSs",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 64, fixedLength: true),
                        ClaimType = c.Int(nullable: false),
                        ClaimValue = c.String(nullable: false, maxLength: 50),
                        ApplicationId = c.String(maxLength: 64, fixedLength: true),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.APPLICATION_USERs", t => t.ApplicationId)
                .Index(t => t.ApplicationId);
            
            CreateTable(
                "dbo.IDENTITY_USER_ROLEs",
                c => new
                    {
                        IdentityRoleId = c.String(nullable: false, maxLength: 64, fixedLength: true),
                        ApplicationId = c.String(nullable: false, maxLength: 64, fixedLength: true),
                    })
                .PrimaryKey(t => new { t.IdentityRoleId, t.ApplicationId })
                .ForeignKey("dbo.APPLICATION_USERs", t => t.ApplicationId, cascadeDelete: true)
                .ForeignKey("dbo.IDENTITY_ROLEs", t => t.IdentityRoleId, cascadeDelete: true)
                .Index(t => t.IdentityRoleId)
                .Index(t => t.ApplicationId);
            
            CreateTable(
                "dbo.MEAL_CATEGORIESs",
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
                "dbo.MEAL_PROMOTIONs",
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
                .ForeignKey("dbo.MEALs", t => t.MealId)
                .ForeignKey("dbo.RESTAURANTs", t => t.RestaurantId)
                .Index(t => t.RestaurantId)
                .Index(t => t.MealId);
            
            CreateTable(
                "dbo.MEALs",
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
                .ForeignKey("dbo.MEAL_CATEGORIESs", t => t.MealCategoryId)
                .ForeignKey("dbo.RESTAURANTs", t => t.RestaurantId)
                .Index(t => t.RestaurantId)
                .Index(t => t.MealCategoryId);
            
            CreateTable(
                "dbo.RESTAURANTs",
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
                "dbo.ORDER_DETAILs",
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
                .ForeignKey("dbo.MEALs", t => t.MealId)
                .ForeignKey("dbo.ORDERs", t => t.OrderId)
                .ForeignKey("dbo.SIDE_DISHs", t => t.SideDishId)
                .Index(t => t.OrderId)
                .Index(t => t.MealId)
                .Index(t => t.SideDishId);
            
            CreateTable(
                "dbo.ORDERs",
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
                .ForeignKey("dbo.APPLICATION_USERs", t => t.UserId)
                .ForeignKey("dbo.RESTAURANTs", t => t.RestaurantId)
                .Index(t => t.UserId)
                .Index(t => t.RestaurantId);
            
            CreateTable(
                "dbo.SIDE_DISHs",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 64, fixedLength: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Price = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        MealId = c.String(maxLength: 64, fixedLength: true),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MEALs", t => t.MealId)
                .Index(t => t.MealId);
            
            CreateTable(
                "dbo.ORDER_PROMOTIONs",
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
                .ForeignKey("dbo.RESTAURANTs", t => t.RestaurantId)
                .Index(t => t.RestaurantId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ORDER_PROMOTIONs", "RestaurantId", "dbo.RESTAURANTs");
            DropForeignKey("dbo.ORDER_DETAILs", "SideDishId", "dbo.SIDE_DISHs");
            DropForeignKey("dbo.SIDE_DISHs", "MealId", "dbo.MEALs");
            DropForeignKey("dbo.ORDER_DETAILs", "OrderId", "dbo.ORDERs");
            DropForeignKey("dbo.ORDERs", "RestaurantId", "dbo.RESTAURANTs");
            DropForeignKey("dbo.ORDERs", "UserId", "dbo.APPLICATION_USERs");
            DropForeignKey("dbo.ORDER_DETAILs", "MealId", "dbo.MEALs");
            DropForeignKey("dbo.MEAL_PROMOTIONs", "RestaurantId", "dbo.RESTAURANTs");
            DropForeignKey("dbo.MEAL_PROMOTIONs", "MealId", "dbo.MEALs");
            DropForeignKey("dbo.MEALs", "RestaurantId", "dbo.RESTAURANTs");
            DropForeignKey("dbo.MEALs", "MealCategoryId", "dbo.MEAL_CATEGORIESs");
            DropForeignKey("dbo.IDENTITY_USER_ROLEs", "IdentityRoleId", "dbo.IDENTITY_ROLEs");
            DropForeignKey("dbo.IDENTITY_USER_ROLEs", "ApplicationId", "dbo.APPLICATION_USERs");
            DropForeignKey("dbo.IDENTITY_USER_CLAIMSs", "ApplicationId", "dbo.APPLICATION_USERs");
            DropIndex("dbo.ORDER_PROMOTIONs", new[] { "RestaurantId" });
            DropIndex("dbo.SIDE_DISHs", new[] { "MealId" });
            DropIndex("dbo.ORDERs", new[] { "RestaurantId" });
            DropIndex("dbo.ORDERs", new[] { "UserId" });
            DropIndex("dbo.ORDER_DETAILs", new[] { "SideDishId" });
            DropIndex("dbo.ORDER_DETAILs", new[] { "MealId" });
            DropIndex("dbo.ORDER_DETAILs", new[] { "OrderId" });
            DropIndex("dbo.MEALs", new[] { "MealCategoryId" });
            DropIndex("dbo.MEALs", new[] { "RestaurantId" });
            DropIndex("dbo.MEAL_PROMOTIONs", new[] { "MealId" });
            DropIndex("dbo.MEAL_PROMOTIONs", new[] { "RestaurantId" });
            DropIndex("dbo.IDENTITY_USER_ROLEs", new[] { "ApplicationId" });
            DropIndex("dbo.IDENTITY_USER_ROLEs", new[] { "IdentityRoleId" });
            DropIndex("dbo.IDENTITY_USER_CLAIMSs", new[] { "ApplicationId" });
            DropTable("dbo.ORDER_PROMOTIONs");
            DropTable("dbo.SIDE_DISHs");
            DropTable("dbo.ORDERs");
            DropTable("dbo.ORDER_DETAILs");
            DropTable("dbo.RESTAURANTs");
            DropTable("dbo.MEALs");
            DropTable("dbo.MEAL_PROMOTIONs");
            DropTable("dbo.MEAL_CATEGORIESs");
            DropTable("dbo.IDENTITY_USER_ROLEs");
            DropTable("dbo.IDENTITY_USER_CLAIMSs");
            DropTable("dbo.IDENTITY_ROLEs");
            DropTable("dbo.APPLICATION_USERs");
        }
    }
}
