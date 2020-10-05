using System;

// Namespace
namespace GuessANumber
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo(); // Get info about this app
            GreetUser(); // Greet user after asking for the username

            while (true)
            {
                // Generate a new random number
                Random random = new Random();

                // Init correct number
                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                // Ask user for the number
                Console.WriteLine("Please guess a number between 1 and 10");

                // Continue asking for another guess if the current guess is not correct
                while (guess != correctNumber)
                {
                    // Get user input
                    string input = Console.ReadLine();

                    // Make sure the input is a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please enter an actual number..");

                        continue;
                    }

                    // Cast input string to int
                    guess = Int32.Parse(input);

                    // Compare guess to the correctNumber
                    if (guess != correctNumber)
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again..");
                    }
                }

                // Print success message 
                PrintColorMessage(ConsoleColor.Yellow, "Congratulations, you guessed the correct answer!!");

                // Ask user want to play again or not 
                Console.WriteLine("Play again? [Y or N]");

                // Get answer
                string answer = Console.ReadLinne().ToUpper();

                // Check answer
                if (answer == "Y") {
                    continue;
                } else if (answer == "N") {
                    return;
                } else {
                    return;
                }
            }
        }

        // Get and display app info
        static void GetAppInfo() {
            // Set app vars
            string appName = "Guess A Number";
            string appVersion = "1.0.0";
            string appAuthor = "Cong Huang";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }

        // Ask user name and greet
        static void GreetUser() {
            // Ask user name 
            Console.WriteLine("What is your name?");

            // Get user input
            string inputNName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let`s play a game :)", inputName);
        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message) {
            // Change text color 
            Console.ForegroundColor = color;

            // Print the message
            Console.WriteLine(message);

            // Reset text color to default
            Console.ResetColor();
        }
    }
}
