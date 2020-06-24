using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Sales
{
    public class SalesDetails : ValueObject<SalesDetails>
    {
        public DateTime? DateOfSales { get; }
        public double? TotalAmountOfSales { get; }

        public SalesDetails(DateTime? dateOfSales, double? totalAmountOfSales)
        {
            DateOfSales = dateOfSales;
            TotalAmountOfSales = totalAmountOfSales;
        }

        protected override bool EqualsCore(SalesDetails other)
        {
            throw new NotImplementedException();
        }

        protected override int GetHashCodeCore()
        {
            throw new NotImplementedException();
        }
    }
}
