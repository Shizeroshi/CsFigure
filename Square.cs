using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_something
{
    class Square : Figure, IFigure
    {
        private readonly double _side;

        public Square(double side) => _side = side;

        public double CalcPerimeter()
        {
            Perimeter = 4 * _side;
            return Perimeter;
        }

        public double CalcArea()
        {
            Area = _side * _side;
            return Area;
        }
    }
}
