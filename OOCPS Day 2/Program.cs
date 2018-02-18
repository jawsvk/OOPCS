using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOCPS_Day_2
{
    public class MyNum
    {
        private int val;
     

        public MyNum(int iniVal)
        {
            val = iniVal;
            
        }

        public void SetValue(int newVal )
        {
            val = newVal;
           
        }

        public int GetValue()
        {
            return val;
        }


    }
    public class Paramtester
    {
        public static void Main(string[] args)
        {
            int val1 = 111;
            MyNum val2 = new MyNum(222);

            Console.WriteLine("Before calling change values method");
            Console.WriteLine("val1 \t val2");
            Console.WriteLine(val1 + "\t" + val2.GetValue());

            Console.WriteLine();

            ChangeValues(val1, val2);

            Console.WriteLine();
            Console.WriteLine("After calling change values method");
            Console.WriteLine("val1 \t val2");
            Console.WriteLine(val1 + "\t" + val2.GetValue());

        }

        public static void ChangeValues(int val1, MyNum val2)
        {
            Console.WriteLine("In ChangeValues() : before changing");
            Console.WriteLine("val1 \t val2");

            Console.WriteLine(val1 + "\t" + val2.GetValue());

            //changing the values,
            val1 = 777;
            val2.SetValue(888);

            Console.WriteLine("In ChangeValues() : after changing");
            Console.WriteLine("val1 \t val2");

            Console.WriteLine(val1 + "\t" + val2.GetValue());

        }

    }
}
