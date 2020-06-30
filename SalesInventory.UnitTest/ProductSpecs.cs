using Domain.Product;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SalesInventory.UnitTest
{
    public class ProductSpecs
    {
        [Fact]
        public void ProductDescription_Have_Non_Unicode_Characters()
        {
            Product product = new Product();
            ProductItemDetails productItemDetails = new ProductItemDetails(10, "Spoon", "testभारत", "Good ole spoon");
            ProductInventoryDetails productInventoryDetails = new ProductInventoryDetails(12, 1, 100);
           
            product.SetProductInventoryDetails(productInventoryDetails);

            Action action = () => product.SetProductItemDetails(productItemDetails);
            action.Should().Throw<InvalidOperationException>();
        }

        [Fact]
        public void OtherDetails_Must_be_Less_than_120_Characters()
        {
            Product product = new Product();
            ProductItemDetails productItemDetails = new ProductItemDetails(10, "Spoon", "testभारत", "Good ole spoon dasdfasdfj uperqioweurioqweuriqw jksahflkjadhfakjdf nasdbfma,ndfasdfhasjkdfhasjkdfhaldfajdh 2342#adasdaghsdkgsadf");
            ProductInventoryDetails productInventoryDetails = new ProductInventoryDetails(12, 1, 100);

            product.SetProductInventoryDetails(productInventoryDetails);

            Action action = () => product.SetProductItemDetails(productItemDetails);
            action.Should().Throw<InvalidOperationException>();
        }
    }
}
