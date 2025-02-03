using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_04_Assignment.Third_Project
{
    internal class PercentageDiscount : Discount
    {
       public decimal percentage;
        public PercentageDiscount(decimal percentage)
        {
            this.percentage = percentage;
        }
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return price*quantity*(percentage / 100);
        }
    }
}
