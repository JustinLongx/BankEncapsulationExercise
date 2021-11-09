using System;

namespace BankEncapsulationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bAccount = new BankAccount();

            Console.WriteLine("Welcome to BOSS Bank, How much money do you want to deposit?");
            double amountToDeposit = double.Parse(Console.ReadLine());

            bAccount.Deposit(amountToDeposit);
            double userBalance = bAccount.GetBalance();
            Console.WriteLine($"Your current balance is: ${userBalance} ");
        }
    }
}
