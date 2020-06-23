using System;


// NAmespace
namespace NumberGuesser
{
    // Main class
    class Program
    {
        // Entry point Method
        static void Main(string[] args)
        {

            GetAppInfo(); // Run GetAppinfo function to get app info 

            GreetUser(); // Ask for users name and Greet
           
            while (true)
            {
                // init correct number
                // int correctNumber = 7;

                // Create a new random object
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                // init guess var
                int guess = 0;

                // Ask user for a number
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // guess users input
                    string input = Console.ReadLine();

                    // Make sure if its a number
                    if (!int.TryParse(input, out guess))
                    {

                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please enter an actual number");
                        
                        //Keep going
                        continue;
                    }

                    // cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {

                        // Print wrong message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again!");
                        
                    }


                }

                // Output Success Message

                // Print Success Message
                PrintColorMessage(ConsoleColor.Yellow, "You are Correct!!!");
                
                // Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                // Get Answer
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

        // Get and Display App Info
        static void GetAppInfo()
        {
            // Set App vars
            string appName = "Guess the number";
            string appVersion = "1.0.0";
            string appAuthor = "Brad Traversy";



            // change test color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();

        }

        // Ask users name and greet
        static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            // Welcome message for starting the game
            Console.WriteLine("Hello {0}, let's play a game...", inputName);

        }

        // Print Color Message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change Color
            Console.ForegroundColor = color;

            // Print mesaage
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }
}
