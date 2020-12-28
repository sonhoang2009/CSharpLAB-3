using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet6._15
{
    class Dismension
    {
        double _length;
        double _breadth;

        public double Area (double _length , double _breadth)
        {
            this._breadth = _breadth;
            this._length = _length;
            return _length * _breadth;
        }
        static void Main(string[] args)
        {
            Dismension objDes = new Dismension();
            Console.WriteLine("Area of rectangle = " + objDes.Area(10.5, 12.5));
            Console.ReadKey();
        }
    }
}
