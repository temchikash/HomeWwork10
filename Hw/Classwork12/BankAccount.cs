using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork12
{
    enum BankAccountType
    {
        Current,
        Saving
    }
    class BankAccount
    {
        private int account_number;
        private double balance;
        private BankAccountType type;
        public BankAccount()
        {
            account_number = generic_number;
        }
        public int Number
        {
            get => account_number;
            set => account_number = value;
        }
        public double Balance
        {
            get => balance;
            set => balance = value;
        }
        public BankAccountType Type
        {
            get => type;
            set => type = value;
        }
        static Random r = new Random();
        private static int generic_number = r.Next(999, 10000);
        public int Generic
        {
            get => generic_number;
            set => generic_number++;
        }
        public double PutOnAccount(double balance)
        {
            Console.Write("Введите сумму для пополнения ");
            double temp = Convert.ToDouble(Console.ReadLine());
            return balance + temp;
        }
        public double WithdrawFromAccount(double balance)
        {
            Console.Write("Введите сумму для снятия ");
            double temp = Convert.ToDouble(Console.ReadLine());
            if (balance >= temp)
            { return balance - temp; }
            else
            { Console.WriteLine("На вашем счёте недостаточно средств!"); return balance; }
        }

        public static bool operator ==(BankAccount b1, BankAccount b2)
        {
            if (b1.Number == b2.Number && b1.Balance == b2.Balance && b1.Type == b2.Type)
            { return true; }
            else
            { return false; }
        }
        public static bool operator !=(BankAccount b1, BankAccount b2)
        {
            if (b1.Number != b2.Number && b1.Balance != b2.Balance && b1.Type != b2.Type)
            { return true; }
            else
            { return false; }
        }
        public override bool Equals(object o)
        {
            BankAccount b2 = (BankAccount)o;
            if (Number == b2.Number && Balance == b2.Balance && Type == b2.Type)
            { return true; }
            else
            { return false; }
        }
        public override int GetHashCode()
        {
            return account_number;
        }
        public override string ToString()
        {
            return Number.ToString() +" "+ Balance.ToString()+" " + Type.ToString(); 
        }
    }
}
