using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLib
{
    public class Checking : Account
    {
        private decimal _minBalance = 25;
        private decimal _fees;

        public Checking(int accountNumber, decimal currentBalance, string bankName, AcctType acctType, decimal minBalance, decimal fees) : base(
            accountNumber, currentBalance, bankName, acctType)
        {
            _minBalance = minBalance; 
            _fees = fees;
        }

        public override Transaction Withdrawal(decimal amount)
        {
            Transaction t;
            decimal newBalance;

            if (amount <= _minBalance || CurrentBalance - amount < _minBalance)
            {
                _fees = 25;
                newBalance = CurrentBalance - _fees;

                string withrawDescription = String.Format("Your Withdrawal of {0:c} was unsuccessful! You have been charged a fee of {1:c}", amount, _fees);
                t = new Transaction(newBalance, TransType.withdrawal, DateTime.Now, withrawDescription);
                
            }
            else
            {
                newBalance = CurrentBalance - amount;
                string withrawDescription = String.Format("Your Withdrawal of {0:c} is complete!", amount);
                t = new Transaction(newBalance, TransType.withdrawal, DateTime.Now, withrawDescription);
            }

            return t;
        }

    }
}
