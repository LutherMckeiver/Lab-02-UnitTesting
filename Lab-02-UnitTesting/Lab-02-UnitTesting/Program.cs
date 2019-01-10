using System;


namespace Lab_02_UnitTesting
{
    public class Program
    {


        static void Main(string[] args)
        {
            PrintWelcomeMessage();
            BankOptions();
            
            while (true)
            {
                decimal userBalance = 1000.00M;
                Console.Write("> ");
                string userInput = Console.ReadLine();

                if (userInput == "quit")
                {
                    Console.WriteLine("Have a good day!");
                    Environment.Exit(0);
                }
                else if (userInput == "1")
                {
                    ViewBalance(userBalance);
                    continue;
                }
                else if (userInput == "2")
                {
                    WithdrawMoney(userBalance);
                    continue;
                }
                else if (userInput == "3")
                {
                    DepositMoney(userBalance);
                    continue;
                }
                else
                {
                    Console.WriteLine("Please choose a valid number \n");
                    BankOptions();
                    continue;
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

        public static decimal ViewBalance(decimal userBalance)
        {

            string formatCurrency = String.Format("{0:C0}", Convert.ToInt32(userBalance));
            Console.WriteLine("Your balance is: {0}", formatCurrency);

            if (userBalance < 10)
            {
                Console.WriteLine("Your balance is lower than $10, you should deposit some money!");
                Console.WriteLine("Your current balance is {0}", userBalance);
            }
            return userBalance;
        }

        public static decimal WithdrawMoney(decimal userBalance)
        {
            Console.WriteLine("How much would you like to withdraw?");
            Console.Write("> ");

            string userAmount = Console.ReadLine();
            try
            {
                decimal correctNumber = decimal.Parse(userAmount);

                if (correctNumber > userBalance)
                {
                    Console.WriteLine("Funds insufficient");
                    Console.WriteLine("Your balance is: {0}", userBalance);
                    return userBalance;
                }
                else if (correctNumber < userBalance)
                {
                    userBalance = userBalance - correctNumber;
                    Console.WriteLine("You have succesfully taken out: {0}", correctNumber);
                    Console.WriteLine("You have {0} left in your account", userBalance);
                    return userBalance;

                }
                else if (correctNumber == userBalance)
                {
                    Console.WriteLine("Error: The amount you are trying to withdraw is the same as your balance.");
                    Console.WriteLine("Your current balance is {0}", userBalance);
                    return userBalance;
                }


            }
            catch (FormatException e)
            {
                Console.WriteLine("{0} Not a valid format.", e);
                throw;

            }
            return userBalance;
        }

        public static decimal DepositMoney(decimal userBalance)
        {
            Console.WriteLine("How much would you like to deposit?");
            Console.Write("> ");
            string userInput = Console.ReadLine();

            try
            {
                decimal formattedResponse = decimal.Parse(userInput);

                userBalance = formattedResponse + userBalance;
                Console.WriteLine("Your new balance is {0} ", userBalance);
            }
            catch (FormatException e)
            {
                Console.WriteLine("{0} Not a valid format", e);
                throw;
            }
            return userBalance;
        } 
    } 
}


