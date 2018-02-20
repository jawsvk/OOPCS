using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOCPS_Day_3
{
    class BankTest2
    {
        static void Main()
        {
            Customer z = new Customer("Kim Lee Keng", "2, Rich View", "XXX9F", new DateTime(1993, 4, 25));
            //BankAccount a = new CurrentAccount("001-001-001", y, 2000);
           // BankAccount b = new SavingsAccount("001-001-002", z, 5000);
            BankAccount c = new OverdraftAccount("001-001-003", z, 5000);

            c.Withdraw(9000);
        }
    }

}
