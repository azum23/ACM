using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveOrderDisplayTest()
        {
            //  Arrange
            var orderRepository = new OrderRepository();
            var excepted = new OrderDisplay()
            {
                FirstName = "Alex",
                LastName = "Znamensky",
                OrderDate = new DateTimeOffset(2017, 1, 1, 00, 00, 00, new TimeSpan(7, 0, 0)),
                ShippingAddressId = new Address()
                {
                    AddressType = 1,
                    StreetLine1 = "Kirova",
                    StreetLine2 = "39/1",
                    City = "Arzamas",
                    State = "NN",
                    Country = "Ru",
                    PostalCode = "607220"
                },
                OrderDisplayItemList = new List<OrderDisplayItem>()
                {
                    new OrderDisplayItem()
                    {
                        OrderQuantity =2,
                        ProductName = "Flower",
                        PurchasePrice = 15.96M
                    },
                    new OrderDisplayItem()
                    {
                        OrderQuantity =1,
                        ProductName = "Rake",
                        PurchasePrice = 6M
                    }
                }

            };

            //  Act
            var actual = orderRepository.RetrieveOrderDisplay(10);
            //  Assert

            Assert.AreEqual(excepted.FirstName, actual.FirstName);
            Assert.AreEqual(excepted.LastName, actual.LastName);
            Assert.AreEqual(excepted.OrderDate, actual.OrderDate);

            Assert.AreEqual(excepted.ShippingAddressId.AddressType, actual.ShippingAddressId.AddressType);
            Assert.AreEqual(excepted.ShippingAddressId.StreetLine1, actual.ShippingAddressId.StreetLine1);
            Assert.AreEqual(excepted.ShippingAddressId.StreetLine2, actual.ShippingAddressId.StreetLine2);
            Assert.AreEqual(excepted.ShippingAddressId.Country, actual.ShippingAddressId.Country);
            Assert.AreEqual(excepted.ShippingAddressId.State, actual.ShippingAddressId.State);
            Assert.AreEqual(excepted.ShippingAddressId.PostalCode, actual.ShippingAddressId.PostalCode);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(excepted.OrderDisplayItemList[i].OrderQuantity, actual.OrderDisplayItemList[i].OrderQuantity);
                Assert.AreEqual(excepted.OrderDisplayItemList[i].ProductName, actual.OrderDisplayItemList[i].ProductName);
                Assert.AreEqual(excepted.OrderDisplayItemList[i].PurchasePrice, actual.OrderDisplayItemList[i].PurchasePrice);
            }
        }
    }
}
