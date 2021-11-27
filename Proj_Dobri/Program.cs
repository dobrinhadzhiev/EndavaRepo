using System;

namespace Proj_Dobri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To My Financial Calculator");

            Console.Write("What Instrument Would You Like to Calculate: \n 1. Loan \n 2. Deposit \n Choice:");
            int instrumentChoice = int.Parse(Console.ReadLine());

            Console.Write("Enter Amount of the instument ($):");
            int amount = int.Parse(Console.ReadLine());
            Console.Write("Enter Rate of the instument (%):");
            double rate = double.Parse(Console.ReadLine());
            Console.Write("Enter Term of the instument (months):");
            int term = int.Parse(Console.ReadLine());
            Loan loan;
            Deposit deposit;

            if (instrumentChoice == 1)
            {
                loan = new Loan(amount, rate, term);
                Console.WriteLine($"Loan Monthlty Payment Amount: {loan.CalculateMonthlyPaymentAmount()}");
                Console.Write("Enter Amount to add to the acount:");
                int addRepricingAmount = int.Parse(Console.ReadLine());
                loan.Amount = loan.AddModeyToAccount(addRepricingAmount);
                Console.WriteLine($"New Monthlty Payment Amount: {loan.CalculateMonthlyPaymentAmount()} for Loan Amount {loan.Amount}");
                Console.Write("Enter Amount to withdraw from the acount:");
                int withdrawRepricingAmount = int.Parse(Console.ReadLine());
                loan.Amount = loan.WithdrawMoneyFromAccount(withdrawRepricingAmount);
                Console.WriteLine($"New Monthlty Payment Amount: {loan.CalculateMonthlyPaymentAmount()} for Loan Amount {loan.Amount}");
            }
            else if (instrumentChoice == 2)
            {
                deposit = new Deposit(amount, rate, term);
                deposit.Amount = deposit.AddModeyToAccount(100);
                Console.WriteLine(deposit.CalculateDepositInterest());
            }
            else
            {
                Console.WriteLine("Invalid Selection!");
            }

        }
        
    }
}
