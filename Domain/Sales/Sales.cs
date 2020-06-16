using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Sales
{
    public class Sales: AggregateRoot
    {
        public DateTime? DateOfSales { get; protected set; }
        public double? TotalAmountOfSales { get; protected set; }
    }
}