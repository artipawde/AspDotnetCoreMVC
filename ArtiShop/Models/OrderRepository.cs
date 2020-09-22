using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtiShop.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;


        public OrderRepository(AppDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }


        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            _appDbContext.orders.Add(order);

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetails()
                {
                    Amount = shoppingCartItem.Amount,
                    PieId = shoppingCartItem.Pie.PieId,
                    OrderId = order.OrderId,
                    Price = shoppingCartItem.Pie.Price
                };

                _appDbContext.orderDetails.Add(orderDetail);
            }

            _appDbContext.SaveChanges();
        }

        //public void CreatePieGiftOrder(PieGiftOrder pieGiftOrder)
        //{
        //    _appDbContext.pieGiftOrders.Add(pieGiftOrder);
        //    _appDbContext.SaveChanges();
        //}
    }
}
