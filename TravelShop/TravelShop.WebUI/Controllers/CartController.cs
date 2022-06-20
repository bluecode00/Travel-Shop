using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TravelShop.Business.Abstract;
using TravelShop.Entity;
using TravelShop.WebUI.Identity;
using TravelShop.WebUI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelShop.WebUI.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private ICartService _cartService;
        private UserManager<User> _userManager;

        public CartController(ICartService cartService, UserManager<User> userManager)
        {
            _cartService = cartService;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            var userId = _userManager.GetUserId(User);
            var cart = _cartService.GetCardByUserId(userId);
            var model = new CartModel()
            {
                CartId = cart.CartId,
                CartItems = cart.CartItems.Select(i => new CartItemModel()
                {
                    CartItemId = i.Id,
                    ProductId = i.ProductId,
                    Name = i.Product.Name,
                    Price = (double)i.Product.Price,
                    ImageUrl = i.Product.ImageUrl,
                    Quantity = i.Quantity
                }).ToList()
            };
            return View(model);
        }
        
        [HttpPost]
        public IActionResult AddToCard(int productId, int quantity)
        {
            var userId = _userManager.GetUserId(User);
            _cartService.AddToCard(userId, productId, quantity);

            return RedirectToAction("Index");
        }
        public IActionResult DeleteFromCard(int productId)
        {
            var userId = _userManager.GetUserId(User);
            _cartService.DeleteFromCard(userId, productId);
            return RedirectToAction("Index","Cart");
        }
    }
}
