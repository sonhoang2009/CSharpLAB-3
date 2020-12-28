﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet6._19
{   
    
     public class Rectangle
        {
        double _length;
        double _breadth;
        public Rectangle()
        {
            _length = 13.5;
            _breadth = 20.5;
        }

        public Rectangle (double len , double wide)
        {
            _length = len;
            _breadth = wide;
        }

        public double Area()
        {
            return _length * _breadth;
        }
        static void Main(string[] args)
        {
            Rectangle objRec1 = new Rectangle();
            Console.WriteLine("Area of Rectangle = " + objRec1.Area());
            Rectangle objRec2 = new Rectangle(2.5,6.9);
            Console.WriteLine("Area of Rectangle = " + objRec2.Area());
            Console.ReadKey();


        }
    }
}
