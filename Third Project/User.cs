using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_04_Assignment.Third_Project
{
    internal abstract class User
    {

        public string Name { get; set; }
        public abstract Discount GetDiscount();
    }
    class RegularUser : User
    {
        public RegularUser() { Name = "RegularUser"; }
        public override Discount GetDiscount()
        {
           return new PercentageDiscount(5);
        }
    }
    class PremiumUser : User
    {
        public PremiumUser()
        {
            Name = " Perimum";
        }
        public override Discount GetDiscount()
        {
            return new FlatDiscount(100);
        }
    }
    class GuestUser : User
    {
        public GuestUser()
        {
            Name = "Guest";
        }
        public override Discount GetDiscount()
        {
            return null ;
        }
    }

}
