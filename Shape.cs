using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
      abstract class Shape
    {
        public string _name;
        public double _area;

        public  Shape(string name)
        {
            _name = name;
        }
        
        
    }
}
