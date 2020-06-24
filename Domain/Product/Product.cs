using Domain.Common;
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

        public virtual void SetProductInventoryDetails(ProductInventoryDetails productInventoryDetails)
        {
            this.productInventoryDetails = productInventoryDetails;
        }

        public virtual void SetProductItemDetails(ProductItemDetails productItemDetails)
        {
            this.productItemDetails = productItemDetails;
        }
    }
}