using FoodDelivery.Data.Infrastructure;
using FoodDelivery.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Data.Repositories
{
    public interface IRestaurantRepository
    {

    }
    public class RestaurantRepository : RepositoryBase<RESTAURANT>, IRestaurantRepository
    {
        public RestaurantRepository(DbFactory dbFactory) : base(dbFactory) { }
    }
}
