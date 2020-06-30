using Domain.Common;
using System;
using System.Linq;
using static Domain.Product.ProductInventoryDetails;
using static Domain.Product.ProductItemDetails;

namespace Domain.Product
{
    public class Product: AggregateRoot
    {
        public virtual ProductInventoryDetails productInventoryDetails { get; protected set; }
        public virtual ProductItemDetails productItemDetails { get; protected set; }

        public Product()
        {
            productInventoryDetails = NoneInventoryDetails;
            productItemDetails = NoneItemDetails;
        }

        public string CanSetProductInventoyDetails(ProductInventoryDetails productInventoryDetails)
        {


            return string.Empty;
        }

        private string CanSetProductItemDetails(ProductItemDetails productItemDetails)
        {
            if(productItemDetails.Product_Description.Any(x => x> 255))
            {
                return "Product Description must have Unicode Characters";
            }

            if(productItemDetails.Other_Details.Length > 120)
            {
                return "Other Details must be less than 120 Characters";
            }

            return string.Empty;
        }

        public virtual void SetProductInventoryDetails(ProductInventoryDetails productInventoryDetails)
        {
            this.productInventoryDetails = productInventoryDetails;
        }

        public virtual void SetProductItemDetails(ProductItemDetails productItemDetails)
        {
            if (CanSetProductItemDetails(productItemDetails) != string.Empty)
                throw new InvalidOperationException();

            this.productItemDetails = productItemDetails;
        }
    }
}