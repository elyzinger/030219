using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    class Rectangle : Shape
    {
        public double _a;
        public double _b;
        public virtual double CalcArea()
        {
          return _a * _b;
        }

        public Rectangle(string name, double a, double b) : base(name)
        {
            _a = a;
            _b = b;
        }
    }
}
