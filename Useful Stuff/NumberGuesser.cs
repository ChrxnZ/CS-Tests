using System;

namespace NumberGuesser // reason im making this cus it has variable assignments, while loops, !=, if statements, ++ and etc
{
  class Code
  {
    static void Main(string[] args)
        {
            Random random = new Random();

            bool PlayAgain = true; // assignments 
            int min = 1;
            int max = 10;
            int Guess;
            int Number;
            int Guesses;
            string Response = "";

            while (PlayAgain) // "While PlayAgain = true;"
            {
                Guess = 0;    // define a int value for these variables
                Guesses = 0;
                Response = ""; // define a empty string for if when the player wants to go again or exit the code
                Number = random.Next(min, max + 1); // generate a random number between 1-10

                while (Guess != Number) // "while guess is not equal number"
                {
                    Console.WriteLine("Guess A Number Between " + min + " - " + max + " : ");
                    Guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + Guess);

                    if (Guess > Number) // "if guess is bigger than number"
                    {
                        Console.WriteLine(Guess + " Is Too High");
                    }
                    else if (Guess < Number) // "Else If Guess Is Lower Than number"
                    {
                        Console.WriteLine(Guess + " Is Too Low");
                    }
                    Guesses++; // add 1 number to variable guesses for every wrong guess

                } // if you win:
                Console.WriteLine("Number: " + Number);
                Console.WriteLine("Congrats");
                Console.WriteLine("Guesses: " + Guesses);
                Console.WriteLine("Would You Like To Play Again? (Y/N) : ");
                Response = Console.ReadLine();
                Response = Response.ToUpper();

                if (Response == "Y") // if response = y (yes)
                {
                    PlayAgain = true; // set playagain to true
                }
                else
                {
                    PlayAgain = false; // set playagain to false
                }
            } // if playagain is false:
            Console.WriteLine("ok fuck off and enjoy this garbage code");
                Console.ReadKey();
        }
    }
}
