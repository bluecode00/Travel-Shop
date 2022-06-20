using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelShop.Data.Abstract;
using TravelShop.Entity;

namespace TravelShop.Data.Concrete
{
    public class EFCoreProductRepository : EFCoreGenericRepository<Product, TravelShopContext>, IProductRepository
    {

    }
}
