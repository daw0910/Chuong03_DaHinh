using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong03_DaHinh
{
    class Account
    {
        private double _balance;
        public Account() { }
        public Account(double balance)
        {
            this._balance = balance;
        }
        public double Blance
        {
            set { _balance = value; }
            get { return _balance; }
        }
        public virtual bool WithDraw(double amount)
        {
            return false;
        }
        public virtual bool Deposit(double amount)
        {
            return false;
        }
        class SavingAccount : Account
        {
            private double _interesRate = 0.8;
            public SavingAccount() : base() { }
            public SavingAccount(double balance) : base(balance) { }
            public double InteresRate
            {
                set { _interesRate = value; }
                get { return _interesRate; }
            }
            public override bool WithDraw(double amount)
            {
                return false;
            }
            public override bool Deposit(double amount)
            {
                return false;
            }
        }
        class CheckingAccount : Account
        {
            public CheckingAccount() : base() { }
            public CheckingAccount(double balance) : base(balance) { }
            public override bool WithDraw(double amount)
            {
                return false;
            }
            public override bool Deposit(double amount)
            {
                return false;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Account ac1 = new SavingAccount(200);
                Account ac2 = new CheckingAccount(200);
                ac1.WithDraw(100);
                ac2.WithDraw(50);

                Console.ReadLine();
            }
        }
    }
}
