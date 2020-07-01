using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Sales
{
    public class SalesDbMap : ClassMap<Sales>
    {
        public SalesDbMap()
        {
            Table("Sale");
            Id(x => x.Id)
                 .Column("Sales_ID");
            Component(x => x.salesDetails, y =>
            {
                y.Map(z => z.DateOfSales)
                    .Column("Date_of_Sale")
                    .Nullable();

                y.Map(z => z.TotalAmountOfSales)
                    .Column("Total_Amount_of_Sale")
                    .Nullable();
            });
        }
    }
}
