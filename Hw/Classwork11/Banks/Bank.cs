using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Classwork11
{
    class Bank
    {
        public BankAccount OpenAccount()
        {
            BankAccount opened = new BankAccount();
            accounts[opened.Number()] = opened;
            return opened;
        }
        private Hashtable accounts = new Hashtable();
    }
    class BankAccount
    {
        private long number;
        internal BankAccount() {  }
        public long Number() { return number; }
        public void Deposit(decimal amount) {  }
    }
}
