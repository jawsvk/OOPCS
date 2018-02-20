using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISS.LIB;
namespace Workshop2
{
    class rectangle
    {
        float height;
        float length;

        public float getHeight()
        {
            return height;
        }

        public void setHeight(float a)
        {
            height = a;
        }

        public void setLength(float b)
        {
            length = b;
        }
        public float getLength()
        {
            return length;
        }


        public float getPerimeter()
        {
            return height * 2 + length * 2;
        }

        public float getArea()
        {
            return height * length;
        }
    }
    class triangle
    {
        float side1;
        float side2;
        float side3;

        public triangle(float a, float b, float c)
        {
            
            side1 = a;
            side2 = b;
            side3 = c;
        }
    

       public float getPerimeter()
        {
            return side1 + side2+ side3;
        }

        public double getArea()
        {
            float s = getPerimeter()/2;

            double area =Math.Sqrt(Convert.ToDouble(s * (s - side1) * (s - side2) * (s - side3)));
            return area;
        }

    }
    class Shapes
    {
        static void Main(string[] args)
        {
            triangle ABC = new triangle(3, 4, 5);
            Console.WriteLine("Triangle with sides 3,4,5");
            Console.WriteLine("Perimeter of ABC is " + ABC.getPerimeter());
            Console.WriteLine("Area of ABC is " + ABC.getArea());

            rectangle A = new rectangle();
            A.setHeight(5);
            A.setLength(12);

            Console.WriteLine("Perimeter of rectangle A is " + A.getPerimeter());
            Console.WriteLine("Area of rectange A is " + A.getArea());
    
        }
    }
}
