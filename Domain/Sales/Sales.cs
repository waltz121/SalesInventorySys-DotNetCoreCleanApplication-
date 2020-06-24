using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Sales
{
    public class Sales: AggregateRoot
    {
        public virtual SalesDetails salesDetails { get; protected set; }

        public Sales()
        {
        }

        public virtual void GetSalesDetails(DateTime? dateOfSales, double? TotalAmountOfSales)
        {
            salesDetails = new SalesDetails(dateOfSales, TotalAmountOfSales);
        }
    }
}