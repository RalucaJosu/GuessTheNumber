using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
			int newRng = rng.Next(0, 100);

			Console.WriteLine("Enter a number:");
			string input = Console.ReadLine();
			int newInput = int.Parse(input);

			while (newInput != newRng)
			{
				if (newInput < newRng)
				{
					Console.WriteLine("The number is too small, please enter another one:");
					input = Console.ReadLine();
					newInput = int.Parse(input);
				}
				else if (newInput > newRng)
				{
					Console.WriteLine("The number is too big, please enter another one:");
					input = Console.ReadLine();
					newInput = int.Parse(input);
				}
				if (newInput == newRng)
				{
					Console.WriteLine("You guessed the number");
					Console.ReadLine();
				}
			}
			
        }
            
    }
}

