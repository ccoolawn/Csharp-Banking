using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLib
{
    public class Checking : Account
    {
        private decimal _minBalance;
        private decimal _fees;

        public Checking(int accountNumber, decimal currentBalance, string bankName) : base(
            accountNumber, currentBalance, bankName)
        {
            _minBalance = 25; 
            _fees = 25;
        }

        public override void Withdraw(decimal amount)
        {
            Transaction t;
            decimal newBalance;

            if (CurrentBalance - amount < _minBalance)
            {
                newBalance = CurrentBalance - amount - _fees;
                string withrawDescription = String.Format("Your Withdrawal of {0:c} is complete and you have been charged a fee of {1:c}", amount, _fees);
                t = new Transaction(newBalance, TransType.withdrawal, DateTime.Now, withrawDescription);
            }
            else
            {
                newBalance = CurrentBalance - amount;
                string withrawDescription = String.Format("Your Withdrawal of {0:c} is complete!", amount);
                t = new Transaction(newBalance, TransType.withdrawal, DateTime.Now, withrawDescription);
            }
            UpdateBalance(newBalance);
            //add transaction to _transactionList
            AddTransaction(t);
        }
    }
}
