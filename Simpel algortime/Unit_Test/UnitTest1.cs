using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simpel_algortime;
using System.Collections.Generic;

namespace Unit_Test
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void TestAvgPrice()
        {
            // Arrange
            double expected = 2.57;
            Order product = new Order(ProductList.LoadData());

            // Act
            product.GiveAveragePrice();

            // Assert
            double actual = product.GiveAveragePrice();
            Assert.AreEqual(expected, actual, 0.001, "AVG not calculated correctly");
        }
        [TestMethod]
        public void TestMaxPrice()
        {
            // Arrange
            Order order = new Order(ProductList.LoadData());
            List<Product> expected = new List<Product>();
            expected.Add(new Product { Name = "Beef", Price = 4.42 });

            // Act
            order.GetHighestPriceProduct();

            // Assert
            Product actual = order.GetHighestPriceProduct();
            Assert.AreEqual(expected[0].Price, actual.Price, "Max not calculated correctly");
        }
        public void TestGetAllProducts()
        {
            // Arrange
            Order order = new Order(ProductList.LoadData());



            // Act



            // Assert


        }
    }
}
