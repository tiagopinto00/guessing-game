using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace guessing_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            Início:
            Console.Clear();
            Console.WriteLine("------------ WELCOME ------------");
            Console.WriteLine("--- THIS IS THE GUESSING GAME ---");
            Console.WriteLine("---------------------------------");
            Console.WriteLine();
            Console.WriteLine("Try to guess which was the number generated in the interval of 0-100");
            Console.WriteLine();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1) START PLAYING ");
            Console.WriteLine("0) QUIT ");
            Console.WriteLine("---------------------------------");
            Console.WriteLine();
            Console.Write("Select an Option: ");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                default:
                    goto Início;
                case 1:
                    Guess();
                    goto Início;
                case 0:
                    break;
            }
        }

        private static void Guess()
        {
            bool win = true;

            Console.Clear();
            int counter = 1, guess = 0; 
            Random rnd = new Random();
            int num = rnd.Next(1, 100);
           

            while (win)
            {
                Console.Clear();
                Console.WriteLine(num); // Only for Testing Remove After
                Console.WriteLine(counter); // Only for Testing Remove After
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("PLEASE ONLY INSERT NUMBERS FROM 0 TO 100");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine();
                Console.Write("MAKE A GUESS: ");
                guess = int.Parse(Console.ReadLine());

                if (guess < 0 || guess > 100)
                {
                    Console.Clear();
                    Console.WriteLine("YOU INSERTED A NUMBER OUTSIDE OF THE AVAILABE RANGE!");
                    Console.WriteLine("<- <- <- TURNING BACK <- <- <-");
                    Console.ReadKey();
                }
                else if (num == guess && counter == 1)
                {
                    Console.Clear();
                    Console.WriteLine("!!! CONGRATULATIONS !!!");
                    Console.WriteLine("YOU WON AT THE FIRST TRY");
                    Console.Write("GO BACK TO MAIN MENU: ");
                    Console.ReadKey();
                    win = false;
                }
                else if (num == guess)
                {
                    Console.Clear();
                    Console.WriteLine($"YOU WIN AFTER {counter} TRIES :D");
                    Console.Write("GO BACK TO MAIN MENU: ");
                    Console.ReadKey();
                    win = false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("YOU FAILED TRY AGAIN");
                    Console.Write("CONTINUE: ");
                    Console.ReadKey();
                    counter++;
                }
               
            }

        }
    }
}
