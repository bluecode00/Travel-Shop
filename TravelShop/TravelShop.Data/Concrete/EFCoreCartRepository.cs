using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelShop.Data.Abstract;
using TravelShop.Entity;

namespace TravelShop.Data.Concrete
{
    public class EFCoreCartRepository : EFCoreGenericRepository<Cart, TravelShopContext>, ICartRepository
    {
        public void DeleteFromCard(int cardId, int productId)
        {
            using (var context = new TravelShopContext())
            {
                var cmd = @"DELETE FROM CardItems WHERE CartId=@p0 AND ProductId=@p1";
                context.Database.ExecuteSqlRaw(cmd, cardId, productId);
            }
        }

        public Cart GetByUserId(string userId)
        {
            using (var context = new TravelShopContext())
            {
                var x = context.Carts.Include(i => i.CartItems).ThenInclude(i => i.Product).FirstOrDefault(i => i.UserId == userId);
                return x;

            }
        }
        public override void Update(Cart entity)
        {
            using (var context = new TravelShopContext())
            {
                context.Carts.Update(entity);
                context.SaveChanges();

            }
            
        }
    }
}
