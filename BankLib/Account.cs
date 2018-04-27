using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLib
{
    public enum AcctType{checking, savings, retirement, loan};
    public abstract class Account
    {
        private int _accNumber;
        private decimal _currentBalance;
        private string _bankName;
        private AcctType _acctType;
        private List<Transaction> _transactionsList = new List<Transaction>();

        public Account(int accountNumber, decimal currentBalance, string bankName,AcctType acctType)
        {
            _accNumber = accountNumber;
            _currentBalance = currentBalance;
            _bankName = bankName;
            _acctType = acctType;
        }

        public virtual int AccNumber { get => _accNumber; }
        public virtual decimal CurrentBalance { get => _currentBalance; }
        public virtual string BankName { get => _bankName; }
        public virtual Transaction[] TransactionList { get => _transactionsList.ToArray(); }

        public virtual Transaction Deposit(decimal amount)
        {
            //maybe a better description
            string depDescription = String.Format("Your Deposit of {0:c} is complete!", amount);
            Transaction t = new Transaction(amount, TransType.deposit, DateTime.Now, depDescription);
            _currentBalance += amount;
            return t;
        }
        public abstract Transaction Withdrawal(decimal amount);
        public virtual Transaction TransferTo(Account toOther, decimal amount)
        {
            //maybe a better description
            string transDescription = String.Format("Your transfer of {0:c} to Acct Num: {1} is complete!", amount, toOther.AccNumber);
            Transaction t = new Transaction(amount, TransType.transferOut, DateTime.Now, transDescription);
            _currentBalance -= amount;
            toOther.Deposit(amount);
            return t;
        }
    }
}
