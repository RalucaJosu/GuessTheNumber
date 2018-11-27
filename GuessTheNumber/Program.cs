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
            int r = rng.Next(0, 100);

            string input;
            Console.WriteLine("Enter a number:");
            input = Console.ReadLine();
            int nr = int.Parse(input);
            if (nr == r)
            {
                Console.WriteLine("You guessed the numebr!");
            }
            else {
                while (nr != r)
                {
                    if (nr < r)
                    {
                        Console.WriteLine("The number is too small, please enter another one:");
                        input = Console.ReadLine();
                        nr = int.Parse(input);
                    }
                    else
                    {
                        Console.WriteLine("The number is too big, please enter another one:");
                        input = Console.ReadLine();
                        nr = int.Parse(input);
                    }
                }
            }
            }
            
        }
    }

