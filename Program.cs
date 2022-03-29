using System;

//Namespace
namespace NumberGuesser
{
    //Main Class
    class Program
    {
        //Entry Point Method  
        static void Main(string[] args)
        {
            GetAppInfo(); //Run GetAppInfo Function to get info

            GreetUser(); //Greets user
        
            while (true)
            {
            //int correctNumber = 7;
            //Create new random object
            Random random = new Random();

            //Init correct number
            int correctNumber = random.Next(1, 10);

            //Init guess var
            int guess = 0;

            //Ask user for number
            Console.WriteLine("Guess a number between 1 and 10");

            //While guess is not correct
            while(guess != correctNumber)
            {
                //Get user input
                string input = Console.ReadLine();

                //Make sure it's a number
                if (!int.TryParse(input, out guess))
                {
                    //Print error message
                    PrintColorMessage(ConsoleColor.Red, "Please use an actualnumber");
                    
                    //keep going
                    continue;
                }

                //Cast to int and put in guess
                guess = Int32.Parse(input);

                //Match guess to correct number
                if(guess != correctNumber)
                {
                      //Wrong number error message
                      PrintColorMessage(ConsoleColor.Red, "Please choose another number");
                }
            }

                //Output Success Message
                PrintColorMessage(ConsoleColor.Green, "CONGRATS!! You did it!!!");

                //Ask to play again
                Console.Write("Play Again? [Y or N]");

                //Get Answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }
        }

        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Felicia Williamson";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Yellow;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Console reset color
            Console.ResetColor();
        }

        //Ask user name and greet
        static void GreetUser()
        {
            //Ask user name
            Console.WriteLine("What is your name?");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);

        }

        //Pritn color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            //Tell user wrong number
            Console.WriteLine(message);

            //Console reset color
            Console.ResetColor();
        }

    }
}
