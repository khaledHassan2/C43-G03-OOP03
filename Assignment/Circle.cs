using Assignment.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Circle : ICircle
    {
        public double Redius { get; set; }

        public double Area => Math.PI * Redius*Redius;
        public Circle(double _Redius)
        {
            Redius = _Redius;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Redius: {Redius}\n Area: {Area}");
        }
    }
}
