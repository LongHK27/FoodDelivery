using FoodDelivery.Data.Infrastructure;
using FoodDelivery.Model.Models;

namespace FoodDelivery.Data.Repositories
{
    public interface IMealCategoryRepository
    {
    }

    internal class MealCategoryRepository : RepositoryBase<MEAL_CATEGORIES>, IMealCategoryRepository
    {
        public MealCategoryRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}