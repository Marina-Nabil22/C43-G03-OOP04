using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_04_Assignment.First_Project
{
    internal class _3D_Point:ICloneable,IComparer
    {
        private int x, y,z;
        public int X { get=> x; set=>x=value; }
        public int Y { get=> y; set=>y=value; }
        public int Z { get=> z; set=>z=value; }
        public _3D_Point() { }
        public _3D_Point(int p1, int p2) { x = p1; y = p2; z = 0; }
        public _3D_Point(int p1) { x = p1; y = 0; z = 0; }
        public _3D_Point(int p1,int p2,int p3) { x=p1; y = p2; z = p3; }


        public static _3D_Point ReadPointFromUser()
        {
            int x, y, z;
            bool flag;
            do
            {
                Console.WriteLine("First Coordinate");
                flag = int.TryParse(Console.ReadLine(), out x);

            } while (!flag);
            do
            {
                 Console.WriteLine("2nd Coordinate");

                flag = int.TryParse(Console.ReadLine(), out y);

            } while (!flag);
            do
            {
                Console.WriteLine("3rd Coordinate");

                flag = int.TryParse(Console.ReadLine(), out z);

            } while (!flag);
            return new _3D_Point(x, y, z);
        }
        public override string ToString()
        {
            return $"Point Coordinates: ({x},{y},{z})";
        }

        public object Clone()
        {
           return new _3D_Point();
        }



        public int Compare(object? x, object? y)
        {
            _3D_Point? Point1 = x as _3D_Point;
            _3D_Point? Point2 = y as _3D_Point;
            int result = Point1.x.CompareTo(Point2.x);
            if (result == 0) result = Point1.y.CompareTo(Point2.y);

            return result;

        }
        #region to use == and !=

        public static bool operator ==(_3D_Point p1, _3D_Point p2)
        {
            return p1.x == p2.x && p1.y == p2.y && p1.z == p2.z ? true : false;
        }

        public static bool operator !=(_3D_Point p1, _3D_Point p2)
        {
            return p1.x != p2.x && p1.y != p2.y && p1.z != p2.z;
        } 
        #endregion

    }
}
