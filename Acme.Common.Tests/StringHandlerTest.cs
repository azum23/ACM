using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.Common;

namespace Acme.CommonTests
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTests()
        {
            // Arrange.
            var source = "ApplePhone";
            var excepted = "Apple Phone";

            // Act.
            var actual = StringHandler.InsertSpaces(source);

            // Assert.
            Assert.AreEqual(excepted, actual);
        }
    }
}
