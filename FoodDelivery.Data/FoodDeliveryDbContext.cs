using FoodDelivery.Model.Models;
using System.Data.Entity;

namespace FoodDelivery.Data
{
    public class FoodDeliveryDbContext : DbContext
    {
        public FoodDeliveryDbContext() : base("TeduShopConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<APPLICATION_USER> Footers { set; get; }
        public DbSet<IDENTITY_ROLE> Menus { set; get; }
        public DbSet<IDENTITY_USER_CLAIMS> MenuGroups { set; get; }
        public DbSet<IDENTITY_USER_ROLE> Orders { set; get; }
        public DbSet<MEAL> OrderDetails { set; get; }
        public DbSet<MEAL_CATEGORIES> Pages { set; get; }
        public DbSet<MEAL_PROMOTION> Posts { set; get; }
        public DbSet<ORDER> PostCategories { set; get; }
        public DbSet<ORDER_DETAIL> PostTags { set; get; }
        public DbSet<ORDER_PROMOTION> Products { set; get; }

        public DbSet<RESTAURANT> ProductCategories { set; get; }
        public DbSet<SIDE_DISH> ProductTags { set; get; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
        }
    }
}