using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void ToString()
        {
            //  Arrange
            Product p = new Product() {ProductName ="Apple" };
            string excepted = "Apple";

            //  Act
            string actual = p.ToString();

            //  Assert
            Assert.AreEqual(excepted, actual);
        }
    }
}
