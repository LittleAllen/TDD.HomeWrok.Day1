using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class SaleProductService
    {
        public List<int> GetSaleProductDataGroupSum(string groupColumn, int groupCount)
        {
            var saleProductList = this.GetSaleProductList();

            var groupList = new List<int>();
            var groupSum = 0;
            var countIndex = 0;

            foreach (var item in saleProductList)
            {
                Type type = item.GetType();
                var property = type.GetProperty(groupColumn);
                var value = (int)property.GetValue(item);
                groupSum += value;

                countIndex++;

                if (countIndex % groupCount == 0)
                {
                    groupList.Add(groupSum);
                    groupSum = 0;
                    countIndex = 0;
                }
            }

            //// 剩餘資料自成一組
            if (groupSum > 0)
            {
                groupList.Add(groupSum);
            }

            return groupList;
        }

        private List<SaleProductListEntity> GetSaleProductList()
        {
            var saleProductList = new List<SaleProductListEntity>();
            saleProductList.Add(new SaleProductListEntity { Id = 1, Cost = 1, Revenue = 11, SellPrice = 21 });
            saleProductList.Add(new SaleProductListEntity { Id = 2, Cost = 2, Revenue = 12, SellPrice = 22 });
            saleProductList.Add(new SaleProductListEntity { Id = 3, Cost = 3, Revenue = 13, SellPrice = 23 });
            saleProductList.Add(new SaleProductListEntity { Id = 4, Cost = 4, Revenue = 14, SellPrice = 24 });
            saleProductList.Add(new SaleProductListEntity { Id = 5, Cost = 5, Revenue = 15, SellPrice = 25 });
            saleProductList.Add(new SaleProductListEntity { Id = 6, Cost = 6, Revenue = 16, SellPrice = 26 });
            saleProductList.Add(new SaleProductListEntity { Id = 7, Cost = 7, Revenue = 17, SellPrice = 27 });
            saleProductList.Add(new SaleProductListEntity { Id = 8, Cost = 8, Revenue = 18, SellPrice = 28 });
            saleProductList.Add(new SaleProductListEntity { Id = 9, Cost = 9, Revenue = 19, SellPrice = 29 });
            saleProductList.Add(new SaleProductListEntity { Id = 10, Cost = 10, Revenue = 20, SellPrice = 30 });
            saleProductList.Add(new SaleProductListEntity { Id = 11, Cost = 11, Revenue = 21, SellPrice = 31 });

            return saleProductList;
        }
    }

    class SaleProductListEntity
    {
        public int Id { get; set; }

        public int Cost { get; set; }

        public int Revenue { get; set; }

        public int SellPrice { get; set; }
    }
}
