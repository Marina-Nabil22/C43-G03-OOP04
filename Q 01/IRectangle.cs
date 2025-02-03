using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_04_Assignment.Q_01
{
    internal interface IRectangle:IShape
    {
        double Dim1 { get; set; }
        double Dim2 { get; set; }
    }
}
