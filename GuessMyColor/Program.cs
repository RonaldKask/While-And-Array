using System;

namespace GuessMyColor
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int computerNumber = rnd.Next(1, 4);


            bool rightGuess = false;

            while(!rightGuess)
            {
                Console.WriteLine("What's my colour?");
                string userInput = Console.ReadLine().ToLower();

                if (computerNumber == 1 && userInput == "red")
                {
                    Console.WriteLine("That's my colour!");
                    rightGuess = true;
                }else if (computerNumber == 2 && userInput == "green")
                {
                    Console.WriteLine("That's my colour!");
                    rightGuess = true;
                }else if (computerNumber == 3 && userInput == "blue")
                {
                    Console.WriteLine("That's my colour!");
                    rightGuess = true;
                }else
                {
                    Console.WriteLine("Try again.");
                }
            }
        }
    }
}
