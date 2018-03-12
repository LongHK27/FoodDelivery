namespace FoodDelivery.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private FoodDeliveryDbContext dbContext;

        public FoodDeliveryDbContext Init()
        {
            return dbContext ?? (dbContext = new FoodDeliveryDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}