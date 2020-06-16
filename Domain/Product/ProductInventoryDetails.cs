using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Product
{
    public class ProductInventoryDetails : ValueObject<ProductInventoryDetails>
    {
        public double Unit_Price { get; }
        public int Reorder_Level { get; }
        public int Reorder_Quantity { get; }

        public ProductInventoryDetails(double unit_Price, int reorder_Level, int reorder_Quantity)
        {
            Unit_Price = unit_Price;
            Reorder_Level = reorder_Level;
            Reorder_Quantity = reorder_Quantity;
        }

        protected override bool EqualsCore(ProductInventoryDetails other)
        {
            throw new NotImplementedException();
        }

        protected override int GetHashCodeCore()
        {
            throw new NotImplementedException();
        }
    }
}
