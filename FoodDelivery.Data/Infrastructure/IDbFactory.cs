using System;

namespace FoodDelivery.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        FoodDeliveryDbContext Init();
    }
}