using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_04_Assignment.Third_Project
{
    internal abstract class Discount
    {
        public string type { get; set; }
       public abstract decimal CalculateDiscount(decimal price, int quantity);

    }
}
