using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_04_Assignment.Third_Project
{
    internal class FlatDiscount:Discount
    {
        private decimal flatamount;
        public FlatDiscount(int _flatamount)
        {
            flatamount = _flatamount;
          
        }
     
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
           return flatamount * Math.Min(quantity, 1);
        }

   
    }
}
