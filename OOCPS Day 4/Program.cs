using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOCPS_Day_4
{

    class Customer
    {
        private string name;
        private string address;
        public string Name
        {
            get
            {
                return name;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
        }
        public Customer(string n, string a)
        {
            name = n;
            address = a;
        }

        public override string ToString()
        {
            return name + address;
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Customer c = new Customer("Tan Ah Kow", "4 Short Street");
            int n = 65;
            Console.WriteLine(n); //prints integer n
            Console.WriteLine(c);  //prints the object which is customer.c
            Console.WriteLine(n.ToString());
            Console.WriteLine(c.ToString());
        }
    }

}
