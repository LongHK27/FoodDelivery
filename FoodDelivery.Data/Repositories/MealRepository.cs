using FoodDelivery.Data.Infrastructure;
using FoodDelivery.Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace FoodDelivery.Data.Repositories
{
    public interface IMealRepository
    {
        IEnumerable<MEAL> GetByAlias(string alias);
    }

    internal class MealRepository : RepositoryBase<MEAL>, IMealRepository
    {
        public MealRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<MEAL> GetByAlias(string alias)
        {
            return this.DbContext.Meals.Where(x => x.Alias == alias);
        }
    }
}