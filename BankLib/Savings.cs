using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLib
{
    public class Savings : Account
    {
        private double _interest;

        public Savings(int accountNumber, decimal currentBalance, string bankName) : base(
            accountNumber, currentBalance, bankName)
        {
            _interest = .03d;
        }

        public override void Withdraw(decimal amount)
        {
            Transaction t;
            decimal newBalance;

            if (CurrentBalance - amount < 0)
            {
                newBalance = CurrentBalance;
                string withrawDescription = String.Format("Your Withdrawal of {0:c} was unsuccessful! Your balance is {1:c}", amount, CurrentBalance);
                t = new Transaction(CurrentBalance, TransType.withdrawal, DateTime.Now, withrawDescription);
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

        public void ApplyInterest()
        {
            decimal newBalance = CurrentBalance * Convert.ToDecimal(_interest);
            string interestDescription = String.Format("Your Savings Account has earned {0:p} of interest! We have deposited {1:c} to your account", _interest, newBalance);
            Transaction t = new Transaction(newBalance, TransType.deposit, DateTime.Now, interestDescription);
            UpdateBalance(newBalance);
            //add transaction to _transactionList
            AddTransaction(t);
        }
    }
}
