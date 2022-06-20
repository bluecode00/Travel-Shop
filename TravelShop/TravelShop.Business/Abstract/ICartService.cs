using TravelShop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelShop.Business.Abstract
{
    public interface ICartService
    {
        Cart GetCardByUserId(string userId);
        void AddToCard(string userId, int productId, int quantity);
        void DeleteFromCard(string userId, int productId);
        void Create(Cart entity);
        void Update(Cart entity);
    }
}
