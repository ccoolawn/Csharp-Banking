using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLib
{
    public class Savings : Account
    {
        private double _interest = .03;

        public Savings(int accountNumber, decimal currentBalance, string bankName, double interest) : base(
            accountNumber, currentBalance, bankName)
        {
            _interest = interest;
        }

        public override Transaction Withdrawal(decimal amount)
        {
            string withrawDescription = String.Format("Your Withdrawal of {0:c} is complete!", amount);
            Transaction t = new Transaction(amount, TransType.withdrawal, DateTime.Now, withrawDescription);
            return t;
        }

        public void ApplyInterest()
        {
            decimal newBalance = CurrentBalance * Convert.ToDecimal(_interest);
            string interestDescription = String.Format("Your Savings Account has earned {0:p} of interest! We have deposited {1:c} to your account", _interest, newBalance);
            Transaction t = new Transaction(newBalance, TransType.deposit, DateTime.Now, interestDescription);
            return t;
        }
    }
}
