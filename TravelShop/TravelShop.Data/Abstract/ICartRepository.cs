using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelShop.Entity;

namespace TravelShop.Data.Abstract
{
    public interface ICartRepository : IRepository<Cart>
    {
        Cart GetByUserId(string userId);
        void DeleteFromCard(int cardId, int productId);
    }
}
