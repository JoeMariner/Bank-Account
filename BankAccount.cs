using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class BankAccount
    {//fields
        public string UserName;
        public double CurrentBalance;
        public string NameOfAccount;
        
       


        //constructors
     
      
        public BankAccount(string UserName, int CurrentBalance, string NameOfAccount)
        {
            this.UserName = UserName;
            this.CurrentBalance = CurrentBalance;
            this.NameOfAccount = NameOfAccount;
        }




        //Methods
       
        public virtual void ShowBalance()
        {
            
            Console.WriteLine(NameOfAccount + ": " + CurrentBalance);
           
        }

        public virtual void DepositTrans(double DepAmount)
        {
           this.CurrentBalance = CurrentBalance + DepAmount;
        }

        public virtual void WithdrawTrans(double WithAmount)
        {
            CurrentBalance = CurrentBalance - WithAmount;
        }

    }
}
  
