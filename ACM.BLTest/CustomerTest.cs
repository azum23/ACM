using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //  Arrange
            Customer newCustomer = new Customer()
            {
                FirstName = "Alex",
                LastName = "Znamensky",
            };

            string excepted = "Znamensky Alex";

            //  Act
            string actual = newCustomer.FullName;

            //  Assert
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //  Arrange
            Customer newCustomer = new Customer()
            {
                LastName = "Znamensky",
            };

            string excepted = "Znamensky";

            //  Act
            string actual = newCustomer.FullName;

            //  Assert
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //  Arrange
            Customer newCustomer = new Customer()
            {
                FirstName = "Alex",
            };

            string excepted = "Alex";

            //  Act
            string actual = newCustomer.FullName;

            //  Assert
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            //  Arrange
            Customer customer1 = new Customer();
            Customer.InstanceCount++;

            Customer customer2 = new Customer();
            Customer.InstanceCount++;

            Customer customer3 = new Customer();
            Customer.InstanceCount++;

            //  Act

            //  Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            //  Arrange
            Customer c = new Customer();
            c.LastName = "Znamensky";
            c.EmailAddress = "alexznamensky@yandex.ru";

            var excepted = true;

            //  Act
            var actual = c.Validate();

            //  Assert
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            //  Arrange
            Customer c = new Customer();
            c.EmailAddress = "alexznamensky@yandex.ru";

            var excepted = false;

            //  Act
            var actual = c.Validate();

            //  Assert
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void ConstructorWithIntParam()
        {
            Customer c1 = new Customer(1);

            Assert.AreEqual(1, c1.CustomerId);
        }
    }
}


