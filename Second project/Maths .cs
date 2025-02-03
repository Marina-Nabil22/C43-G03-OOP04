using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_04_Assignment.Second_project
{
    internal static class Maths
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Subtract(int x,int y)
        {
            return x - y;

        }

        public static int	Multiply(int x, int y)
        {
            return x * y;

        }

        public static double  Divide(int x, int y)
        {
            if(y !=0)
            {
                return x / y;
            }
            return 0;

        }
    }
}
