using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOCPS_Day_4
{
    class BankBranch
    {
        string branchName;
        string branchManager;
        BankAccount[] ListofAcc= new BankAccount[99];
        private int NoOfAcc = 0;

        public BankBranch(string branchname, string managerName)
        {
            branchName = branchname;
            branchManager = managerName;
        }
        public string BranchName
        {
            get { return branchName; }
            set { branchName = value; }
        }

        public string BranchManager
        {
            get { return branchManager; }
            set { branchManager = value; }
        }

        public void AddAcc(BankAccount A)
        {
            ListofAcc[NoOfAcc] = A;

            NoOfAcc++;
        }

        public void PrintCustomers()
        {
            for(int i=0; i<NoOfAcc; i++)
            {
                Console.WriteLine(ListofAcc[i].AccOwner.getName());
            }
        }

        public double TotalDeposit()
        {
            double TotalDep = 0;
            for(int i=0; i<NoOfAcc; i++)
            {
                if (ListofAcc[i].getBalance() > 0) TotalDep = TotalDep + ListofAcc[i].getBalance(); 
            }
            return TotalDep;
        }

        public double TotalInterestPaid()
        {
            double sum = 0;
            for (int i = 0; i < NoOfAcc; i++)
            {
                if (ListofAcc[i].getBalance() > 0) sum = sum + ListofAcc[i].CalculateInterest();
            }
            return sum;
        }

        public double TotalInterestEarned()
        {
            double sum = 0;
            for (int i = 0; i < NoOfAcc; i++)
            {
                if (ListofAcc[i].getBalance() < 0) sum = sum + Math.Abs(ListofAcc[i].CalculateInterest());
            }
            return sum;

        }
   

    }
}
