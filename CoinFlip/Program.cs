using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            int coin;
            string userGuess;
            string coinDescription;
            Random rng = new Random();

            // Query the user
            Console.Write("Enter your guess- Heads or Tails (H or T)");
            userGuess = Console.ReadLine();

            //get a random number for coin flip
            coin = rng.Next(0, 2);
            if (coin == 1)
            { coinDescription = "Heads"; }
            else
            {
                coinDescription = "Tails";
            }

            if ((coin == 0 && userGuess == "T" )|| (coin ==1 && userGuess == "H"))
            {
                Console.WriteLine("The coin flip was {0}, you win!!",coinDescription);
            }
          
            else
            {
               
                    Console.WriteLine("The coin flip was {0}, you lose", coinDescription);
                
            }
            Console.ReadLine();
        }
    }
}
