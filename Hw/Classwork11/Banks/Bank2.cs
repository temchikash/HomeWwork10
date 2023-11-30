using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork11.Bank2
{
    class Bank
    {
        public BankAccount CreateAccount()
        {
            BankAccount opened = new BankAccount();
            accounts[opened.Number()] = opened;
            return opened;
        }
        public void DeleteAccount(long number)
        {
            accounts.Remove(accounts[number]);
        }
        private Hashtable accounts = new Hashtable();
    }
    class BankAccount
    {
        private long number;
        internal BankAccount() { Generic(); }
        public void Generic()
        {
            Random r = new Random();
            number = r.NextInt64(1000000000000000, 10000000000000000);
        }
        public long Number() { return number; }
    }
}
