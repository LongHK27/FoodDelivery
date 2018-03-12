using FoodDelivery.Data.Infrastructure;
using FoodDelivery.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Data.Repositories
{
    public interface IIdentityUserClaimRepository
    {

    }
    public class IdentityUserClaimRepository : RepositoryBase<IDENTITY_USER_CLAIMS>, IIdentityUserClaimRepository
    {
        public IdentityUserClaimRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
