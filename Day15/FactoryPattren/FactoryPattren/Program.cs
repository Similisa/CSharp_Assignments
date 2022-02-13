using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattren
{
    public interface shape
    {
        void draw();
    }
    public class Rectangle: shape
    {
        public void draw()
        {
            Console.WriteLine("Rectangle");
        }
    }

    public class Square : shape
    {
        public void draw()
        {
            Console.WriteLine("Square");
        }
    }

    public class Circle : shape
    {
        public void draw()
        {
            Console.WriteLine("Circle");
        }
    }

    public class ShapeFactory
    {
        public shape getShape(string shapetype)
        {
            if (shapetype.Equals("Rectangle"))
            {
                return new Rectangle();
            }
            else if (shapetype.Equals("Square"))
            {
                return new Square(); 
            }
            else if ((shapetype.Equals("Circle")))
            {
                return new Circle();
            }
            else
            {
                return null;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory sf = new ShapeFactory();
            shape s = sf.getShape("Rectangle");
            s.draw();
            shape s1 = sf.getShape("Square");
            s1.draw();
            s = sf.getShape("Circle");
            s.draw();
            Console.Read();

        }
    }
}
