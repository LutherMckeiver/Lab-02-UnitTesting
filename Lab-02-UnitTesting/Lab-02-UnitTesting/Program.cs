using System;


namespace Lab_02_UnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintWelcomeMessage();
            BankOptions();
            while (true)
            {
                Console.Write("> ");
                string userInput = Console.ReadLine();

                if (userInput == "quit")
                {
                    Console.WriteLine("Have a good day!");
                    Environment.Exit(0);
                }
                else if (userInput == "1")
                {
                    ViewBalance();
                }
                else if (userInput == "2")
                {

                }
                else if (userInput == "3")
                {

                }
                else
                {
                    Console.WriteLine("Please choose a valid number");
                    BankOptions();
                }


                Console.ReadLine();
            }
            
            
           
        }

        static void PrintWelcomeMessage()
        {
            Console.WriteLine("*************************************************");
            Console.WriteLine("***        Welcome To Luther's Bank!          ***");
            Console.WriteLine("***     Please see your options below!        ***");
            Console.WriteLine("***                                           ***");
            Console.WriteLine("***     To quit at any time, type quit        ***");
            Console.WriteLine("************************************************* \n");
        }

        static void BankOptions()
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("***    What would you like to do today?        ***");
            Console.WriteLine("***    1. View Balance                         ***");
            Console.WriteLine("***    2. Withdraw Money                       ***");
            Console.WriteLine("***    3. Deposit Money                        ***");
            Console.WriteLine("***                                            ***");
            Console.WriteLine("***    Choose a number to continue.            ***");
            Console.WriteLine("**************************************************");
            
        }

        static decimal ViewBalance()
        {
            decimal userBalance = 1000.00M;
            string formatCurrency = String.Format("{0:C0}", Convert.ToInt32(userBalance));
            Console.WriteLine("Your balance is: {0}", formatCurrency);
            return userBalance;
        }



        
        


    }
}
