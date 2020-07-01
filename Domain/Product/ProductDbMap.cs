using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Product
{
    public class ProductDbMap : ClassMap<Product>
    {
        public ProductDbMap()
        {
            Table("Product");
            Id(x => x.Id)
                .Column("Product_ID");
            Component(x => x.productItemDetails, y =>
            {
                y.Map(z => z.Other_Details);
                y.Map(z => z.Product_Description)
                    .Nullable();
                y.Map(z => z.Product_Name)
                    .Nullable();
                y.Map(z => z.Product_Type_Code)
                    .Nullable();
            });

            Component(x => x.productInventoryDetails, y =>
            {
                y.Map(z => z.Unit_Price);
                y.Map(z => z.Reorder_Quantity);
                y.Map(z => z.Reorder_Level);
            });
        }
    }
}
