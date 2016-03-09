using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpectedObjects;

namespace BusinessLayer.Tests
{
    [TestClass()]
    public class SaleProductServiceTests
    {
        [TestMethod()]
        public void GetSaleProduct_GroupColumn_Cost_GroupCount_3()
        {
            //// Arrange
            var saleProduct = new SaleProductService();
            var groupColumn = "Cost";
            var groupCount = 3;

            var expected = new List<int> { 6, 15, 24, 21 };

            //// Act
            var actual = saleProduct.GetSaleProductDataGroupSum(groupColumn, groupCount);

            //// Assert
            expected.ToExpectedObject().ShouldEqual(actual);
        }

        [TestMethod()]
        public void GetSaleProduct_GroupColumn_Revenue_GroupCount_4()
        {
            //// Arrange
            var saleProduct = new SaleProductService();
            var groupColumn = "Revenue";
            var groupCount = 4;

            var expected = new List<int> { 50, 66, 60 };

            //// Act
            var actual = saleProduct.GetSaleProductDataGroupSum(groupColumn, groupCount);

            //// Assert
            expected.ToExpectedObject().ShouldEqual(actual);
        }
    }
}