using System;
using System.Collections.Generic;
using System.Text;

namespace Proj_Dobri
{
    class Deposit : BasicOperations,IParameters
    {
        public int Amount { get; set; }
        public double Rate { get; set; }
        public int Term { get; set; }

        public Deposit(int amount, double rate, int term) :base(amount)
        {
            Amount = amount;
            Rate = rate;
            Term = term;
        }

        public double CalculateDepositInterest()
        {
            double Interest = this.Amount*(1 + this.Rate / 100 * this.Term / 12);

            return Interest;
        }
    }
}
