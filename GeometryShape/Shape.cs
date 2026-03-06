using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShape
{
    public abstract class Shape
    {
        public abstract double Area();
        public abstract double Perimeter();
        public override abstract string ToString();
    }


}
