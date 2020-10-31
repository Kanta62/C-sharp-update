using System;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Account obj = new Account();
            Console.WriteLine("Account name is :" + obj.AccName);
            Console.WriteLine("Account no is :" + obj.Acid);
            Console.WriteLine("Balance is :" + obj.Balance);

            obj.Deposit(100000);
            obj.WithDraw(5000);
            Console.WriteLine("New balance  is :" + obj.Balance);
        }
    }

    public class Account
    {
        private string accName = "Kanta Maria Akter";
        private string acid = "19403431";
        private int balance = 0;

        public string AccName
        {
            get { return accName; }
            //  set { accName = value; }
        }
        public string Acid
        {
            get { return acid; }
            //   set { acid = value; }
        }

        public int Balance
        {
            get { return balance; }
            //  set { balance = value; }
        }

        public void Deposit(int amount)
        {
            balance += amount;
        }
        public void WithDraw(int amount)
        {
            balance -= amount;
        }
    }
}
