using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TRRY.Models;
using TRRY.Models.Repositories;

namespace Bookstore.Models.Repositories
{
    public class OrderRepository : IShopRepositpry<Order>
    {
        List<Order> orders; // As context database

        public OrderRepository()
        {
            orders = new List<Order>()
             {
                 new ()
                 {
                     Id= 1,
                     status="completed"
                 },
                  new Order()
                 {
                     Id= 2,
                     status="pending"
                 }
             };
        }

        public void Add(Order entinty)
        {
            orders.Add(entinty);
        }

        public void Delete(int id)
        {
            var book = orders.SingleOrDefault(x => x.Id == id);
            orders.Remove(book);
        }

        public Order Find(int id)
        {
            var order = orders.SingleOrDefault(x => x.Id == id);
            return order;
        }

        public IList<Order> List()
        {
            return orders;
        }

        public void Update(Order newOrder, int id)
        {
            var order= orders.SingleOrDefault(x => x.Id == id);
            order.status = newOrder.status;
            order.Customer = newOrder.Customer;

        }
    }
}
