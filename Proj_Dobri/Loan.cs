using System;
using System.Collections.Generic;
using System.Text;

namespace Proj_Dobri
{
    class Loan : BasicOperations, IParameters
    {
        public int Amount { get; set; }
        public double Rate { get; set; }
        public int Term { get; set; }


        public Loan(int amount, double rate, int term) : base(amount)
        {
            Amount = amount;
            Rate = rate;
            Term = term;
        }

        public double CalculateMonthlyPaymentAmount()
        {
            double paymentAmount = (this.Amount * (this.Rate / 12 /100) * Math.Pow((1 + this.Rate / 12 /100), this.Term)) / (Math.Pow((1 + this.Rate / 12 /100), this.Term) - 1);

            return paymentAmount;
        }



    }
}
