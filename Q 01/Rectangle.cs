using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_04_Assignment.Q_01
{
    internal class Rectangle : IRectangle
    {
        public double Area { get => Dim1*Dim2;  }
        public double Dim1 { get ; set ; }
        public double Dim2 { get; set; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Dim1= {Dim1},Dim2= {Dim2}, Area= {Area}");
         
        }
    }
}
