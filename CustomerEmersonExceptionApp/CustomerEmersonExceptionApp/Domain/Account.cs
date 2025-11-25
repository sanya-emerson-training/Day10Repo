using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerEmersonExceptionApp.Domain
{
     class Account
    {
        private int _accno;
        private string _name;
        private double _balance;
        
        public Account(int accno, string name, double balance)
        {
            _accno = accno;
            _name = name;
            _balance = balance;
        }
        public void Withdraw(double amount)
        {
            if(_balance- amount <500)
            {
                throw new EmersonInsufficientFundsException(this);
            }
            _balance = _balance - amount;
        }

        public int Accno
        {
            get { return _accno; }
        }
        public string Name 
        {
            get { return _name; }
        }
        public double Balance 
        {
            get { return _balance; }
        }

    }
}
