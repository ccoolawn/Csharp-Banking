using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLib
{
    public abstract class Account
    {
        private int _accNumber;
        private decimal _currentBalance;
        private string _bankName;
        private List<Transaction> _transactionsList = new List<Transaction>();

        public Account(int accountNumber, decimal currentBalance, string bankName, List<Transaction> transactionsList)
        {
            _accNumber = accountNumber;
            _currentBalance = currentBalance;
            _bankName = bankName;
            _transactionsList = transactionsList;
        }

        public virtual int AccNumber { get => _accNumber; }
        public virtual decimal CurrentBalance { get => _currentBalance; }
        public virtual string BankName { get => _bankName; }
        public virtual Transaction[] TransactionList { get => _transactionsList.ToArray(); }

        public virtual Transaction Deposit(decimal amount)
        {
            //maybe a better description
            string description = String.Format("Deposit of {0:c} complete!", amount);
            Transaction t = new Transaction(amount, AccType.deposit, DateTime.Now, description);
            _currentBalance += amount;
            return t;
        }
        public abstract Transaction Withdrawal(decimal amount);
        public virtual Transaction TransferTo(Account toOther, decimal amount)
        {
            //maybe a better description
            string description = String.Format("Transfer out of {0:c} to {1} complete!", amount, toOther.AccNumber);
            Transaction t = new Transaction(amount, AccType.transferOut, DateTime.Now, description);
            _currentBalance -= amount;
            toOther.Deposit(amount);
            return t;
        }
    }
}
