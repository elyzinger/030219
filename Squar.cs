using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    class Squar : Rectangle
    {
        public Squar(string name, double a) : base (name, a, a)
        {
                
        }
        public override double CalcArea()
        {
            return _a * _a;

        }

    }
}
