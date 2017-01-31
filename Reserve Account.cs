using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Reserve_Account : BankAccount
    {
        //fields
        public int MinBalance;
        public int MaxBalance;

        //constructors

        public Reserve_Account (int MinBalance, int MaxBalance): base ("Walter White", 100, "My Reserve")
        {
            this.MinBalance = MinBalance;
            this.MaxBalance = MaxBalance;
        }

        //properties
        public int Minimum
        {
            get { return this.MinBalance; }
            set { this.MinBalance = value; }
        }
        public int Maximum
        {
            get { return this.MaxBalance; }
            set { this.MaxBalance = value; }
        }
    }
}
