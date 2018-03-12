using FoodDelivery.Model.Models;
using System.Data.Entity;

namespace FoodDelivery.Data
{
    public class FoodDeliveryDbContext : DbContext
    {
        public FoodDeliveryDbContext() : base("FoodDeliveryConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<APPLICATION_USER> ApplicationUsers { set; get; }
        public DbSet<IDENTITY_ROLE> IdentityRoles { set; get; }
        public DbSet<IDENTITY_USER_CLAIMS> IdentityUserClainms { set; get; }
        public DbSet<IDENTITY_USER_ROLE> IdentityUserRoles { set; get; }
        public DbSet<MEAL> Meals { set; get; }
        public DbSet<MEAL_CATEGORIES> MealCategories { set; get; }
        public DbSet<MEAL_PROMOTION> MealPromotions { set; get; }
        public DbSet<ORDER> Orders { set; get; }
        public DbSet<ORDER_DETAIL> OrderDetails { set; get; }
        public DbSet<ORDER_PROMOTION> OrderPromotions { set; get; }
        public DbSet<RESTAURANT> Restaurants { set; get; }
        public DbSet<SIDE_DISH> SideDishs { set; get; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
        }
    }
}