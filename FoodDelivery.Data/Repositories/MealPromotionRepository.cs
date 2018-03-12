using FoodDelivery.Data.Infrastructure;
using FoodDelivery.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Data.Repositories
{
    public interface IMealPromotionRepository
    {
        IEnumerable<MEAL_PROMOTION> GetDataOverTime(DateTime start, DateTime end);
        IEnumerable<MEAL_PROMOTION> GetByStatus(int status);

    }
    public class MealPromotionRepository : RepositoryBase<MEAL_PROMOTION>, IMealPromotionRepository
    {
        public MealPromotionRepository(DbFactory dbFactory) : base(dbFactory) { }

        public IEnumerable<MEAL_PROMOTION> GetByStatus(int status)
        {
            return this.DbContext.MealPromotions.Where(x => x.Status == status);
        }

        public IEnumerable<MEAL_PROMOTION> GetDataOverTime(DateTime start, DateTime end)
        {
            return this.DbContext.MealPromotions.Where(x => x.StartDate >= start && x.EndDate <= end);
        }
    }
}
