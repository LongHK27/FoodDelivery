using FoodDelivery.Data.Infrastructure;
using FoodDelivery.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Data.Repositories
{
    public interface IApplicationUserRepository
    {

    }
    public class ApplicationUserRepository : RepositoryBase<APPLICATION_USER>
    {
        public ApplicationUserRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
