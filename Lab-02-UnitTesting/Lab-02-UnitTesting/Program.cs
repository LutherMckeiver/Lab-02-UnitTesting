using System;


namespace Lab_02_UnitTesting
{
    public class Program
    {

        public static decimal userBalance = 500.00M;

        static void Main(string[] args)
        {
            Console.WriteLine("*************************************************");
            Console.WriteLine("***        Welcome To Luther's ATM!           ***");
            Console.WriteLine("***     Please see your options below!        ***");
            Console.WriteLine("***                                           ***");
            Console.WriteLine("***     To quit at any time, type quit        ***");
            Console.WriteLine("************************************************* \n");

            Console.WriteLine("**************************************************");
            Console.WriteLine("***    What would you like to do today?        ***");
            Console.WriteLine("***    1. View Balance                         ***");
            Console.WriteLine("***    2. Withdraw Money                       ***");
            Console.WriteLine("***    3. Deposit Money                        ***");
            Console.WriteLine("***                                            ***");
            Console.WriteLine("***    Choose a number to continue.            ***");
            Console.WriteLine("**************************************************");
            Console.Write("> ");

            string userInput = Console.ReadLine();
            ATMOptions(userInput);
            
            while (Continue("c") == true)
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
                string input = Console.ReadLine();
                ATMOptions(input);
            } 
        }

              
        public static void ATMOptions(string userInput)
        {
            switch (userInput)
            {
                case "quit":
                    Console.WriteLine("Have a good day!");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
                case "1":
                    ViewBalance(userBalance);
                    Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("How much would you like to withdraw?");
                    Console.Write("> ");
                    string userAmount = Console.ReadLine();
                    Console.WriteLine(WithdrawMoney(userBalance, userAmount));
                    Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("How much would you like to deposit?");
                    Console.Write("> ");
                    string userAnswer = Console.ReadLine();
                    Console.WriteLine(DepositMoney(userBalance, userAnswer));
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Pleae choose a valid number \n");
                    string input = Console.ReadLine();
                    ATMOptions(input);
                    Console.ReadLine();
                    break;
            }
        }
        
        public static bool Continue(string userAnswer)
        {
            Console.WriteLine("Do you want to continue, or quit?");
            Console.WriteLine("Press any other key to exit, or type c to continue");
            Console.Write("> ");
            userAnswer = Console.ReadLine();

           if (userAnswer == "c")
            {
                return true;
            }
           else
                return false;
            
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


        public static string WithdrawMoney(decimal userBalance, string userAmount)
        {
            try
            {
                decimal correctNumber = decimal.Parse(userAmount);

                if (correctNumber > userBalance)
                {
                   return "Funds insuffiecient, you have " + userBalance.ToString() + " in your account.";
                }
                else if (correctNumber < userBalance)
                {
                    Program.userBalance = userBalance - correctNumber;
                    Console.WriteLine("You have succesfully taken out: {0}", correctNumber);
                    return "You have " + Program.userBalance.ToString() + " left in your account.";

                }
                else if (correctNumber == userBalance)
                {
                    Console.WriteLine("Error: The amount you are trying to withdraw is the same as your balance.");
                    Console.WriteLine("Your current balance is {0}", Program.userBalance);
                    return Program.userBalance.ToString(); 
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("{0} Not a valid format.", e);
                throw;
            }
            return Program.userBalance.ToString();
        }


        public static string DepositMoney(decimal userBalance, string userInput)
        {
            try
            {
                decimal formattedResponse = decimal.Parse(userInput);

                Program.userBalance = formattedResponse + userBalance;
                Console.WriteLine("Your new balance is {0} ", Program.userBalance);
            }
            catch (FormatException e)
            {
                Console.WriteLine("{0} Not a valid format", e);
                throw;
            }
            return Program.userBalance.ToString();
        } 
    } 
}




