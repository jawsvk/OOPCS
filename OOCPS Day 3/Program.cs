using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOCPS_Day_3
{

    class Program
    {
        static void Main(string[] args)
        {
            Customer y = new Customer("Tan Ah Kow", "20, Seaside Road", "XXX20", new DateTime(1989, 10, 11));
            Customer z = new Customer("Kim Lee Keng", "2, Rich View", "XXX9F", new DateTime(1993, 4, 25));
            CurrentAccount a = new CurrentAccount("001-001-001", y, 2000);
            SavingsAccount b = new SavingsAccount("001-001-002", z, 5000);
            OverdraftAccount c = new OverdraftAccount("001-001-003", z, 5000);
            Console.WriteLine(a.Show());
            Console.WriteLine("Interest is " + a.CalculateInterest());
            Console.WriteLine(); 
            Console.WriteLine(b.Show());
            Console.WriteLine("Interest is " + b.CalculateInterest());
            Console.WriteLine();
            Console.WriteLine(c.Show());
            Console.WriteLine("Interest is " + c.CalculateInterest());
            Console.WriteLine();

            a.Withdraw(200);
            Console.WriteLine(a.Show());
            a.TransferTo(300, b);

            Console.WriteLine(a.Show());
            Console.WriteLine(b.Show());
            b.TransferTo(500, c);
            Console.WriteLine(b.Show());
            Console.WriteLine(c.Show());

            c.Withdraw(9000);
            Console.WriteLine(c.Show());
            Console.WriteLine("Interest Rate is " + c.CalculateInterest());

            Console.WriteLine(z.getName() + " has " +z.GetAccountCount()+ " bank accounts"); 
        }
    }
}
