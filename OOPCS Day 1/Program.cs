using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS_Day_1
{
    class Person
    {
        //attributes
        string name;
        int age;

        //methods
        //accessor
        public int GetAge()
        {
            return age;
        }
        //mutator
        public void SetAge(int newvalue)
        {
            if (newvalue > 0) age = newvalue;
            else Console.WriteLine("cannot be...");
        }
        // public int MyProperty { get; set; } 
                                           //property example
                                           // private int Age;
        public int Age
        {
            get
            { return Age; }

            set
            { Age = value; }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person();
            Person p2 = new Person();

            int n = p2.Age; //this involves the get
            p2.Age = 35; //this involves the set
            
            p1.SetAge(10);
            Console.WriteLine(p1.GetAge());

            Coin c1 = new Coin();
            Coin c2 = new Coin();

            for (int i = 0; i < 10; i++)
            {
                c1.Flip();

                Console.WriteLine(c1.Flip());
              

                Console.WriteLine(c1.GetFace());
            }
           // Coin c2 = new Coin();

        }
    }
}
