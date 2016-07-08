using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giuliano.BankManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit, withdraw, currentBalance, close;

            Console.WriteLine(" Type your name here please");

            string name = Console.ReadLine();

            Console.WriteLine("Hello, " + name);

            Console.WriteLine(@" What kind of opperation would you like to do? 
Type 1 for Deposit 
Type 2 for Withdraw 
Type 3 for Current Balance 
Type 4 to Close ");

            currentBalance = 1000;
            Console.WriteLine("Your current balance is:" + currentBalance);


            string operation = "";
            //number that was typed to int. e.g. 1, 2, 3 or 4
            operation = Console.ReadLine();

            if (operation == "1")
            {
                //Deposit
                Console.WriteLine("How much would you like to deposit?");

                deposit = Convert.ToDouble(Console.ReadLine());

                currentBalance = deposit + currentBalance;

                Console.WriteLine("Your new current balance is R$ " + currentBalance);

                Console.Read();
            }
            else if (operation == "2")
            {
                //Withdraw
                Console.WriteLine("How much would you like to withdraw?");

                withdraw = Convert.ToDouble(Console.ReadLine());

                Console.Read();

            }
            else if (operation == "3")
            {

                //Balance

                Console.WriteLine("Your current balance is:");

                currentBalance = Convert.ToDouble(Console.ReadLine());
            }
            else if (operation == "4")
            {
                //Exit
            }
            else
            {
                //Exit
            }



        }
    }
}
