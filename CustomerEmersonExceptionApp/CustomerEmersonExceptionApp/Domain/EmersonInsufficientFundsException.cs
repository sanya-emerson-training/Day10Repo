using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Exception;

namespace CustomerEmersonExceptionApp.Domain
{
    class EmersonInsufficientFundsException : Exception
    {
        private Account _acc;
        public EmersonInsufficientFundsException(Account acc)
        {
            _acc = acc;
        }
        public Account Acc
        {
            get { return _acc; }
        }

        public override string Message
        {
            get
            {
                return $"no balance left to withdraw";
            }
        }
    } }
