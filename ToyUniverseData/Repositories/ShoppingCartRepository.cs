using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyUniverseData.Context;
using ToyUniverseData.Models;

namespace ToyUniverseData.Repositories
{
    public interface IShoppingCartRepository : IBaseRepository<ShoppingCart>
    {
    }
    public class ShoppingCartRepository : GenericRepository<ShoppingCart>, IShoppingCartRepository
    {
        public ShoppingCartRepository(ToyUniverseDbContext context) : base(context)
        {
        }
    }
}
