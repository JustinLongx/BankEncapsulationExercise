using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulationExercise
{
    public class BankAccount
    {
        private double _balance = 0;

        public void Deposit(double amount)
        {
            Console.WriteLine($"simulating a deposit of {amount.ToString("C")} to your account! ");
            _balance = amount;
        }

        public double GetBalance() 
        {
            return _balance;
        }
        
    }
}
