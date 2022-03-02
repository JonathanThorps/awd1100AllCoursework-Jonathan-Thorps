using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLogin
{
    public class Account
    {
        private string _account;
        private string _pin;
        private string _name;
        private decimal _balance;

        public Account(string accountNumber, string pin, string name, decimal balance)
        {
            _account = accountNumber;
            _pin = pin;
            _name = name;
            _balance = balance;
        }
        public string GetAccountNumber(string accountNumber)
        {
            return _account;
        }
        public string GetPin(string pin)
        {
            return _pin;
        }
        public string GetName(string name)
        {
            return _name;
        }
        public decimal GetBalance(decimal balance)
        {
            return _balance;
        }
        public decimal MakeDeposit()
        {
            _balance = _balance + amount;
        }
        public decimal MakeWithdrawal()
        {
            _balance = _balance - amount;
        }
    }
    
}
