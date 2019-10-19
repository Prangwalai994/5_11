using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NUnit.Framework;
using Testing_the_Interaction_5_11.Mocking;

namespace OrderServiceTests5_11
{
    [TestFixture]
    public class OrderServiceTests
    {
       [Test]
        public void PlaceOrder_WhenCalled_StoreTheOrder()
        {
            var storage = new Mock<IStorage>();
            var service = new OrderService(storage.Object);

            var order = new Order();
            service.PlaceOrder(order);

            storage.Verify(s => s.Store(order));


        }
    }
}
