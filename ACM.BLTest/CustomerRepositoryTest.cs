using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void CustomerRepositoryRetrieveTest()
        {
            //  Arrange
            var customerRepository = new CustomerRepository();
            var excepted = new Customer(1)
            {
                EmailAddress = "a@amail.com",
                FirstName = "Alex",
                LastName = "Znamensky"
            };
            excepted.AddressList.Add(new Address()
            {
                AddressType = 1,
                StreetLine1 = "Kirova",
                StreetLine2 = "39/1",
                City = "Arzamas",
                State = "NN",
                Country = "Ru",
                PostalCode = "607220"
            });
            excepted.AddressList.Add(new Address()
            {
                AddressType = 2,
                StreetLine1 = "Zelenaya",
                StreetLine2 = "32/1",
                City = "Arzamas",
                State = "NN",
                Country = "Ru",
                PostalCode = "607220"
            });

            //  Act
            var actual = customerRepository.Retrieve(1);

            Assert.AreEqual(excepted.CustomerId, actual.CustomerId);
            Assert.AreEqual(excepted.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(excepted.FirstName, actual.FirstName);
            Assert.AreEqual(excepted.LastName, actual.LastName);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(excepted.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(excepted.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(excepted.AddressList[i].StreetLine2, actual.AddressList[i].StreetLine2);
                Assert.AreEqual(excepted.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(excepted.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(excepted.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }

        }

    }




}
