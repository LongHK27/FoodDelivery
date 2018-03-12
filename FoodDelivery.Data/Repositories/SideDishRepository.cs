using FoodDelivery.Data.Infrastructure;
using FoodDelivery.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Data.Repositories
{
    public interface ISideDishRepository
    {

    }
    public class SideDishRepository : RepositoryBase<SIDE_DISH>, ISideDishRepository
    {
        public SideDishRepository(DbFactory dbFactory) : base(dbFactory) { }
    }
}
