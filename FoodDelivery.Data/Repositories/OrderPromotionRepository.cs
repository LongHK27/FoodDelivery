using FoodDelivery.Data.Infrastructure;
using FoodDelivery.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Data.Repositories
{
    public interface IOrderPromotionRepository
    {

    }
    public class OrderPromotionRepository : RepositoryBase<ORDER_PROMOTION>, IOrderPromotionRepository
    {
        public OrderPromotionRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
