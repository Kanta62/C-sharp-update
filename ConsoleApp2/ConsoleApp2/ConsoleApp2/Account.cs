using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Account
    {

        private string accName;
        private string acid;
        private int balance;

        public string AccName
        {
            get { return accName; }
            set { accName = value; }
        }
        public string Acid
        {
            get { return acid; }
            set { acid = value; }
        }
        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public Account()
        {
            accName = "Maria's Account";
            acid = "19403431";
            balance = 5000;
        }
        public Account(string accName, string acid, int balance)
        {
            this.accName = accName;
            this.acid = acid;
            this.balance = balance;
        }
        public void Deposit(int amount)
        {
            balance += amount;
        }
        public void Withdraw(int amount)
        {
            balance -= amount;
        }
    }
}
