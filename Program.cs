using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bank_Account
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello! Welcome to BankWorld. \nWhat would you like to do?");

            
            Savings_Account Savings = new Savings_Account(100, 1000000);
            Checking_Account Checking = new Checking_Account(100, 500000);
            Reserve_Account Reserve = new Reserve_Account(100, 100000);

            

            int selection = 0;
            while (selection != 7)
            {
                Console.Clear();
                Console.WriteLine("Name: Walter White");
                Savings.ShowBalance();
                Checking.ShowBalance();
                Reserve.ShowBalance();
                Console.WriteLine("\t");
                Console.WriteLine("1. Deposit into savings \n2. Withdraw from savings \n3. Deposit into checking \n4. Withdraw from checking \n5. Deposit into reserve \n6. Withdraw from reserve. \n7. Leave BankWorld");

                selection = int.Parse(Console.ReadLine());

                if (selection == 1)
                {
                    Console.WriteLine("How much?");
                    double depositAction = int.Parse(Console.ReadLine());

                    Savings.DepositTrans(depositAction);
                }
                else if (selection == 2)
                {
                    Console.WriteLine("How Much?");
                    double withdrawAction = int.Parse(Console.ReadLine());
                    Savings.WithdrawTrans(withdrawAction);
                }
                else if (selection == 3)
                {
                    Console.WriteLine("How Much?");
                    double depositAction = int.Parse(Console.ReadLine());
                    Checking.DepositTrans(depositAction);
                }
                else if (selection == 4)
                {
                    Console.WriteLine("How much?");
                    double withdrawAction = int.Parse(Console.ReadLine());
                    Checking.WithdrawTrans(withdrawAction);
                }
                else if (selection == 5)
                {
                    Console.WriteLine("How Much?");
                    double depositAction = int.Parse(Console.ReadLine());
                    Reserve.DepositTrans(depositAction);
                }
                else if (selection == 6)
                {
                    Console.WriteLine("How Much?");
                    double withdrawAction = int.Parse(Console.ReadLine());
                    Reserve.WithdrawTrans(withdrawAction);
                }
                else if (selection == 7)
                {
                    Console.WriteLine("Come again soon!");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Sorry...what? Select a correct action please. \"press enter\"");
                }    
                

                if (Savings.Goal >= 100000)
                {
                    Savings.GoalMessage();
                   
                    
                }
                if (Savings.Minimum <= 0)
                {
                    Console.WriteLine("Your savings is empty!");
                    Console.ReadLine();
                }
                if (Checking.Overdraft <= 0)
                {
                    Console.WriteLine("Sorry. You overdrafted. I'm gonna have to fine ya.");
                    Checking.WithdrawTrans(50);
                    Console.ReadLine();
                    
                }
                if (Checking.Maximum >= 500000)
                {
                    Console.WriteLine("What do you do for a living?");
                    Console.ReadLine();
                }
                
            }


           

        




        }
    }
}
