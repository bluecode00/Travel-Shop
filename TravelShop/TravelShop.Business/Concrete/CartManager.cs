using TravelShop.Business.Abstract;
using TravelShop.Data.Abstract;
using TravelShop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelShop.Business.Concrete
{
    public class CartManager : ICartService
    {
        private ICartRepository _cartRepository;

        public CartManager(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public void AddToCard(string userId, int productId, int quantity)
        {
            var card = GetCardByUserId(userId);
            if (card != null)
            {
                var index = card.CartItems.FindIndex(i => i.ProductId == productId);
                if (index < 0)
                {
                    card.CartItems.Add(new CartItem()
                    {
                        ProductId = productId,
                        Quantity = quantity,
                        CartId = card.CartId
                    });
                }
                else
                {
                    card.CartItems[index].Quantity += quantity;
                }
                _cartRepository.Update(card);
                
            }
        }

        public Cart GetCardByUserId(string userId)
        {
            return _cartRepository.GetByUserId(userId);
        }

        public void InitializeCard(string userId)
        {
            _cartRepository.Create(new Cart() { UserId = userId });
        }
        public void DeleteFromCard(string userId, int productId)
        {
            var card = GetCardByUserId(userId);
            if (card != null)
            {
                _cartRepository.DeleteFromCard(card.CartId, productId);
            }
        }

        public void Create(Cart entity)
        {
            _cartRepository.Create(entity);
        }

        public void Update(Cart entity)
        {
            _cartRepository.Update(entity);
        }

    }
}
