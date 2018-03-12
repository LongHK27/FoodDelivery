using FoodDelivery.Data.Infrastructure;
using FoodDelivery.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Data.Repositories
{
    public interface IIdentityRoleRepository
    {

    }
    public class IdentityRoleRepository : RepositoryBase<IDENTITY_ROLE>, IIdentityRoleRepository
    {
        public IdentityRoleRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
