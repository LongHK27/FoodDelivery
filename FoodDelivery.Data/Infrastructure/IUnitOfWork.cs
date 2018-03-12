namespace FoodDelivery.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}