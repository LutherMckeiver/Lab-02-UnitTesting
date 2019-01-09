using System;

namespace Lab_02_UnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintWelcomeMessage();
            BankOptions();
            string userInput = Console.ReadLine();
            
            switch (userInput)
            {
                case "1":
                    Console.WriteLine("View Balance");
                    break;
                    
            }

            Console.ReadLine();
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
            Console.Write("> ");
        }

        
        


    }
}
