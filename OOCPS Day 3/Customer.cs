using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOCPS_Day_3
{

    public class Customer
    {
        private string name, address, passportNum;
        DateTime Birthdate;
        private int AccCount;
        BankAccount[] Bank_Account;
        public Customer(string Name, string Address, string PassportNum, DateTime date)
        {
            name = Name;
            address = Address;
            passportNum = PassportNum;
            Birthdate = date;
            Bank_Account = new BankAccount[10];
            AccCount = 0;
        }

        public void AddAccount(BankAccount A)
        {
            Bank_Account[AccCount] = A;
            AccCount++;

        }

       public string getAdd()
        {
            return address;
        }

        public string getName()
        {
            return name;
        }

        public string getPassportNo()
        {
            return passportNum;
        }

        public DateTime getBday()
        {
            return Birthdate;
        }
      
       public int GetAge()
        {

            int age = DateTime.Now.Year - Birthdate.Year;
            if (Birthdate > DateTime.Today.AddYears(-age)) age--;
            return age;
        }

        public int GetAccountCount()
        {
            return AccCount;
        }

    }
}
