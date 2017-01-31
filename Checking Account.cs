using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Checking_Account : BankAccount
    {
        //fields
        public double OverdraftFee;
        public double MaxBalance;

        //constructors
        public Checking_Account(double OverdraftFee, double MaxBalance): base("Walter White", 100, "My Checking")

        {
            this.OverdraftFee = OverdraftFee;
            this.MaxBalance = MaxBalance;
        }

        //properties

        public double Overdraft
        {
            get { return this.OverdraftFee; }
            set { this.OverdraftFee = value; }
        }
        public double Maximum
        {
            get { return this.MaxBalance; }
            set { this.MaxBalance = value; }
        }

        
    

    }
}
