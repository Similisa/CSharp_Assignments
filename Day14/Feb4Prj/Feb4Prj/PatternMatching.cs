using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb4Prj
{
    public class Shape
    {
        const float PI = 3.14f;
    }
    class Circle:Shape
    {
        int r;
    }

    class Rectangle:Shape
    {
        int l, b;
    }
    class Triangle : Shape
    {
        int l, h;
    }
    class PatternMatching
    {
        static void Main()
        {

        }
        public static void DisplayArea(Shape shape)
        {
            if (shape is Circle)
            {
                Circle c = (Circle)shape;
                Console.WriteLine("Area of circle is" + " " + c.r * c.r * Shape.PI);
            }
            else if(shape is Rectangle)
            {
                
            }
        }
    }
}
