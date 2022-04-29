using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    public class Account
    {
        private string _accountNumber;
        private string _pin;
        private string _name;
        private decimal _balance;

        public Account()
        {

        }

        public Account(string account, string pin, string name, decimal balance)
        {
            _accountNumber = account;
            _pin = pin;
            _name = name;
            _balance = balance;
        }
        public void MakeDeposit(decimal amount)
        {
            _balance = _balance + amount;
        }
        public void MakeWithdrawal(decimal amount)
        {
            _balance = _balance - amount;
        }
        public string GetAccountNumber()
        {
            return _accountNumber;
        }
        public string GetPin()
        {
            return _pin;
        }
        public string GetName()
        {
            return _name;
        }
        public decimal GetBalance()
        {
            get { return _balance; }
            set { _balance = value; }
        }
        public override string ToString(string name, decimal balance)
        {
            lblWelcome.Text = "Welcome back {_name}!";
            lblBalance.Text = "Your account balance is {_balance}";
        }
            
    }
   
}
