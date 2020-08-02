using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_GuessColor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the color. You have 5 tries.");
            Console.WriteLine("To finish program type - exit.");

            const int maxAttempt = 5;
            int attempt = 0;
            string color = "red";

            while (attempt < maxAttempt)
            {
                attempt++;
                Console.WriteLine("Try {0}:", attempt);

                string value = Console.ReadLine();
                if (value == "exit")
                {
                    break;

                }
                if (value != color)
                {
                    continue;
                }

                Console.WriteLine("Greetings! You guessed from the {0} try!", attempt);
                break;
            }
            Console.WriteLine("End of the game!");
            Console.ReadKey();
        }
    }
}
