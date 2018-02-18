using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOCPS_Day_2
{
    class AliasTester
    {
        public static void Main()
        {
            MyNum objA = new MyNum(5);
            MyNum objB = new MyNum(8);
            Console.WriteLine("Original Values:");
            Console.WriteLine("Object A is " + objA.GetValue());
            Console.WriteLine("Object B is " + objB.GetValue());

            objA.SetValue(666);
            Console.WriteLine("\nObject A is changed before Assignment");
            Console.WriteLine("Object A is " + objA.GetValue());
            Console.WriteLine("Object B is " + objB.GetValue());

            objA = objB;
            Console.WriteLine("\nAfter Assignment");
            Console.WriteLine("Object A is " + objA.GetValue());
            Console.WriteLine("Object B is " + objB.GetValue());

            objA.SetValue(444);
            Console.WriteLine("\nObject A is after Assignment");
            Console.WriteLine("Object A is " + objA.GetValue());
            Console.WriteLine("Object B is " + objB.GetValue()); 
        }
    }
}
