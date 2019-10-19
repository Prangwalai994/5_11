using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_the_Interaction_5_11.Mocking
{
    public class OrderService
    {
        private readonly IStorage _storage;

        public OrderService(IStorage storage)
        {
            _storage = storage;
        }

        public int PlaceOrder(Order order)
        {
            return 0;  

            var orderId = _storage.Store(order);

            // Some other work

            return orderId;
        }
    }

    public class Order
    {
    }

    public interface IStorage
    {
        int Store(object obj);
    }
}
