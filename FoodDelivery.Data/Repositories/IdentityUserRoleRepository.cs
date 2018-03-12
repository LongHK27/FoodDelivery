using FoodDelivery.Data.Infrastructure;
using FoodDelivery.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Data.Repositories
{
    public interface IIdentityUserRoleRepository
    {

    }
    public class IdentityUserRoleRepository : RepositoryBase<IDENTITY_USER_ROLE>, IIdentityUserRoleRepository
    {
        public IdentityUserRoleRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
