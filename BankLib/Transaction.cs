using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLib
{
    public enum AccType { deposit, withdrawal, transferIn, transferOut };
    public class Transaction
    {
        private decimal _amount;
        private AccType _type;
        private DateTime _date;
        private string _description;

        public Transaction(decimal amount, AccType type, DateTime date, string description)
        {
            _amount = amount;
            _type = type;
            _date = date;
            _description = description;
        }

        public decimal Amount { get => _amount; }
        public AccType Type { get => _type; }
        public DateTime Date { get => _date; }
        public string Description { get => _description; }
    }
}
