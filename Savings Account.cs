using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Savings_Account : BankAccount
    {
        //fields
        public double MinBalance;
        public double SavingsGoal;

        //properties
        public double Minimum
        {
            get { return this.MinBalance; }
            set { this.MinBalance = value; }
        }

        public double Goal
        {
            get { return this.SavingsGoal; }
            set { this.SavingsGoal = value; }
        }

        //constructors

        public Savings_Account(double MinBalance, double SavingsGoal): base("Walter White", 100, "My Savings")
        {
            this.MinBalance = MinBalance;
            this.SavingsGoal = SavingsGoal;
        }

        //methods
        public void GoalMessage()
        {
            Console.WriteLine("You should go on a shopping spree!");
            Console.ReadLine();
        }

    }
}
    

     


    