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
            double currentBalance = 1000;


            Console.WriteLine(" Type your name here please Mr(s)");

            string name = Console.ReadLine();

            Console.WriteLine("Hello, " + name);

            Console.WriteLine(@" What kind of opperation would you like to do? 
Type 1 for Deposit 
Type 2 for Withdraw 
Type 3 for Current Balance 
Type 4 to Close ");
            Console.WriteLine("Your current balance is R$:" + currentBalance);


            int x = 0;

            while (x < 4)
            {
                if (x < 4)

                {


                    //exit

                    double deposit, withdraw, close;

                    Console.WriteLine(" What kind of opperation would you like to do? ");



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

                    }
                    else if (operation == "2")
                    {
                        //Withdraw
                        Console.WriteLine("How much would you like to withdraw?");

                        withdraw = Convert.ToDouble(Console.ReadLine());

                        currentBalance = currentBalance - withdraw;

                        Console.WriteLine("Your new current balance is R$ " + currentBalance);


                    }
                    else if (operation == "3")
                    {

                        //Balance

                        currentBalance = 1000;

                        Console.WriteLine("Your current balance is R$" + currentBalance);

                    }
                    else if (Convert.ToInt32(operation) >= 4)
                    {
                        x = Convert.ToInt32(operation);

                        Console.WriteLine("Thank you for using our service Mr(s) " + name);
                        Console.ReadKey();

                    }
                    else
                    {
                        //Exit
                    }



                }
            }
        }

    }
}
