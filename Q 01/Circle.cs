using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_04_Assignment.Q_01
{
    internal class Circle : ICircle
    {
       
        public double Area { get => Math.PI* radius*radius; }

        public double radius { get; set; }
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Radius= {radius} , Area= {Area}"); 
        }
    }
}
