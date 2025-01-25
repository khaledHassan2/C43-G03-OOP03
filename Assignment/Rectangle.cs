using Assignment.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Rectangle : IRectangle
    {
        public double Dim1 { get  ; set ; }
        public double Dim2 { get ; set ; }

        public double Area => Dim1*Dim2;
        public Rectangle(double _Dim1,double _Dime2)
        {
            Dim1 = _Dim1;
            Dim2 = _Dime2;
        }
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Area: {Area}");
        }
    }
}
