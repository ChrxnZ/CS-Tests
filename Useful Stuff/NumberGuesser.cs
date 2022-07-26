using System;

namespace NumberGuesser // reason im making this cus it has variable assignments, while loops, !=, if statements, ++ and etc
{
  class Code
  {
    static void Main(string[] args)
        {
            Random random = new Random();

            bool PlayAgain = true;
            int min = 1;
            int max = 10;
            int Guess;
            int Number;
            int Guesses;
            string Response = "";

            while (PlayAgain)
            {
                Guess = 0;
                Guesses = 0;
                Response = "";
                Number = random.Next(min, max + 1);

                while (Guess != Number)
                {
                    Console.WriteLine("Guess A Number Between " + min + " - " + max + " : ");
                    Guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + Guess);

                    if (Guess > Number)
                    {
                        Console.WriteLine(Guess + " Is Too High");
                    }
                    else if (Guess < Number)
                    {
                        Console.WriteLine(Guess + " Is Too Low");
                    }
                    Guesses++;

                }
                Console.WriteLine("Number: " + Number);
                Console.WriteLine("Congrats");
                Console.WriteLine("Guesses: " + Guesses);
                Console.WriteLine("Would You Like To Play Again? (Y/N) : ");
                Response = Console.ReadLine();
                Response = Response.ToUpper();

                if (Response == "Y")
                {
                    PlayAgain = true;
                }
                else
                {
                    PlayAgain = false;
                }
            }
            Console.WriteLine("ok fuck off and enjoy this garbage code");
                Console.ReadKey();
        }
    }
}
