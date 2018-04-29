using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLib
{
    public enum AcctType { checking, savings };
    public abstract class Account
    {
        private int _acctNumber;
        private decimal _currentBalance;
        private string _bankName;
        private List<Transaction> _transactionsList = new List<Transaction>();

        public Account(int accountNumber, decimal currentBalance, string bankName)
        {
            _acctNumber = accountNumber;
            _currentBalance = currentBalance;
            _bankName = bankName;
        }

        public virtual int AcctNumber { get => _acctNumber; }
        public virtual decimal CurrentBalance { get => _currentBalance;}
        public virtual string BankName { get => _bankName; }
        public virtual Transaction[] TransactionList { get => _transactionsList.ToArray(); }

        public virtual void Deposit(decimal amount)
        {
            string depDescription = String.Format("Your Deposit of {0:c} is complete!", amount);
            Transaction t = new Transaction(amount, TransType.deposit, DateTime.Now, depDescription);
            _currentBalance += amount;
            _transactionsList.Add(t);
        }
        
        public abstract void Withdraw(decimal amount);
        
        public virtual void TransferTo(Account toOther, decimal amount)
        {
            string transDescription = String.Format("Your transfer of {0:c} to Acct Num: {1} is complete!", amount, toOther.AcctNumber);
            Transaction tOut = new Transaction(amount, TransType.transferOut, DateTime.Now, transDescription);
            Transaction tIn = new Transaction(amount, TransType.transferIn, DateTime.Now, transDescription);
            _currentBalance -= amount;
            toOther.Deposit(amount);
            _transactionsList.Add(tOut);
            toOther.AddTransaction(tIn);
        }
        public virtual void AddTransaction(Transaction t)
        {
            _transactionsList.Add(t);
        }

        public virtual void UpdateBalance(decimal newBalance)
        {
            _currentBalance = newBalance;
        }
    }
}
