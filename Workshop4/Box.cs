using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop4
{
    class Box
    {

        int length, breadth, height;

        public Box()
        { }


        public Box(int a, int b, int c) : this()
        {
            length = a;
            breadth = b;
            height = c;
        }
        public static Box operator +(Box b, Box c)
        {
            Box box = new Box();
            box.length = b.length + c.length;
            box.breadth = b.breadth + c.breadth;
            box.height = b.height + c.height;
            return box;

        }
    }

    class program
    {
        static void Main()
        {
            Box A = new Box(3, 4, 5);
            Box B = new Box(1, 2, 3);
            Box C = new Box();
            C =A + B;  //C will have (4,6,8)

        }
    }
}
