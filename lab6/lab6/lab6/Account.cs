using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Account
    {
        string accName;
        string acid;
        int balance;

        public string AccName
        {
            set { accName = value; }
            get { return accName; }
        }

        public string Acid
        {
            set { acid = value; }
            get { return acid; }
        }

        public int Balance
        {
            set { balance = value; }
            get { return balance; }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Acc Name: " + accName);
            Console.WriteLine("A/C Id: " + acid);
            Console.WriteLine("Primary balance: " + balance);
        }

        public void Deposit(int amount)
        {
            balance += amount;
            Console.WriteLine("Balance after deposite: " + balance);
        }

        public void Withdraw(int amount)
        {
            balance -= amount;
            Console.WriteLine("Balance after withdraw: " + balance);
        }

        public void Transfer(int amount, Account receiver)
        {
            if (amount < balance)
            {
                this.balance -= amount;
                receiver.balance += amount;
            }
        }

        public Account()
        {

        }

        public Account(string accName, string acid, int balance)
        {
            this.accName = accName;
            this.acid = acid;
            this.balance = balance;
        }
    }
}
