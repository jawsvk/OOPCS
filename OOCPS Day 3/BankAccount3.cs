using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOCPS_Day_3
{
    public class BankAccount
    {
        private string AccountNumber { get; set; }
        protected double balance { get; set; }
        protected double interestRate = 0;
    
        Customer AccountHolder;
        public BankAccount(string AccountNumber, Customer AccountHolder, double balance)
        {
            this.AccountNumber = AccountNumber;
            this.balance = balance;
            this.AccountHolder = AccountHolder;
            AccountHolder.AddAccount(this); //without this bank account will have customer object but customer object will not have account object
        }

        public double getBalance()
        {
            return balance;
        }

        public void Deposit(double num)
        {
            balance = balance + num;
        }

        public void Withdraw(double num)
        {
            if (balance < num) Console.WriteLine("Insufficient funds");
            else balance = balance - num;
        }

        public void TransferTo(double sum, BankAccount other)
        {
            if (balance >= sum)
            {
                Withdraw(sum);
                other.Deposit(sum);
            }

            else Console.WriteLine("Transfer unsuccessful");
        }

        public double CalculateInterest()
        {
            return balance * interestRate;
        }

        public void CreditInterest()
        {
            balance = balance + CalculateInterest();
        }

        public string Show()
        {
            return AccountNumber + "| " + AccountHolder.getName() + "| " + Convert.ToString(balance);
        }

    }

    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(string AccountNumber, Customer AccountHolder, double balance) : base (AccountNumber, AccountHolder, balance)
        {
            interestRate = 0.01;
            
        }
                
    }

    public class CurrentAccount : BankAccount
    {
        public CurrentAccount(string AccountNumber, Customer AccountHolder, double balance) : base(AccountNumber, AccountHolder, balance)
        {
            interestRate = 0.0025;

        }
    }

    public class OverdraftAccount : BankAccount
    {
        public OverdraftAccount(string AccountNumber, Customer AccountHolder, double balance) : base(AccountNumber, AccountHolder, balance)
        {
            interestRate = 0;
        }

        public new double CalculateInterest()
        {
            if (getBalance() > 0) interestRate =0.0025;
            else if (getBalance() < 0) interestRate = 0.06;

            return getBalance() * interestRate;
        }

        public new void Withdraw(double num)
        {
           // if (balance < num) Console.WriteLine("Insufficient funds");
            balance = getBalance() - num;
        }

    }
}
