using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Product
{
    public class ProductItemDetails : ValueObject<ProductItemDetails>
    {
        public int? Product_Type_Code { get; }
        public string Product_Name { get; }
        public string Product_Description { get; }
        public string Other_Details { get; }

        public ProductItemDetails(int? product_Type_Code, string product_Name, string product_Description, string other_Details)
        {
            Product_Type_Code = product_Type_Code;
            Product_Name = product_Name ?? throw new ArgumentNullException(nameof(product_Name));
            Product_Description = product_Description ?? throw new ArgumentNullException(nameof(product_Description));
            Other_Details = other_Details ?? throw new ArgumentNullException(nameof(other_Details));
        }

        protected override bool EqualsCore(ProductItemDetails other)
        {
            throw new NotImplementedException();
        }

        protected override int GetHashCodeCore()
        {
            throw new NotImplementedException();
        }
    }
}
