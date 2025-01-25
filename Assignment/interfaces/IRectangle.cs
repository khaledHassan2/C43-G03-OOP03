using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.interfaces
{
    internal interface IRectangle : IShape
    {
        public double Dim1 { get; set; }
        public double Dim2 { get; set; }

    }
}
