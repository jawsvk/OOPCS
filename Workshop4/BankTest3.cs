using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOCPS_Day_4
{
    class BankTest3

    {
        static void Main()
        {
            BankBranch OCBC_AMK = new BankBranch("OCBC Ang Mo Kio", "Foo Da Yao");
            Customer y = new Customer("Tan Ah Kow", "20, Seaside Road", "XXX20", new DateTime(1989, 10, 11));
            Customer z = new Customer("Kim Lee Keng", "2, Rich View", "XXX9F", new DateTime(1993, 4, 25));
            BankAccount a = new CurrentAccount("001-001-001", y, 2000);
            BankAccount b = new SavingsAccount("001-001-002", z, 5000);
            BankAccount c = new OverdraftAccount("001-001-003", z, 5000);
            OCBC_AMK.AddAcc(a);
            OCBC_AMK.AddAcc(b);
            OCBC_AMK.AddAcc(c);
            Console.WriteLine(a.Show());
            Console.WriteLine(b.Show());
            Console.WriteLine(c.Show());
            Console.WriteLine("\nThe list of customers as below:\n");

            OCBC_AMK.PrintCustomers();
            Console.WriteLine();
            Console.WriteLine("Total Deposits" + OCBC_AMK.TotalDeposit());
            c.Withdraw(9000);
            Console.WriteLine("Total Deposits after c-9000 : " + OCBC_AMK.TotalDeposit());
            Console.WriteLine("Total Interest Paid " + OCBC_AMK.TotalInterestPaid());
            Console.WriteLine("Total Interest Earned " + OCBC_AMK.TotalInterestEarned());


        }
    }

}
