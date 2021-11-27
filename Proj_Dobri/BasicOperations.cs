using System;
using System.Collections.Generic;
using System.Text;

namespace Proj_Dobri
{
    class BasicOperations
    {
        private int _amount;
        public BasicOperations(int amount)
        {
            _amount = amount;
        }

        public int AddModeyToAccount(int amount)
        {
          return  _amount += amount;
        }

        public int WithdrawMoneyFromAccount(int amount)
        {
            return _amount -= amount;
        }
    }
}
