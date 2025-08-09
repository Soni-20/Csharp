using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Random random = new Random();
                Console.WriteLine("Enter the target number:");
                int targetnumber = Convert.ToInt32(Console.ReadLine());
                while (guessnumber != targetnumber) ;
                {
                    Console.WriteLine("Enter the number to Guess:");
                    guessnumber = Convert.ToInt32(Console.ReadLine());
                    if (guessnumber < targetnumber)
                    {
                        Console.WriteLine("Guess number is too low! Try again");
                    }
                    else if (guessnumber > targetnumber)
                    {
                        Console.WriteLine("Guess number is too high! Try again");
                    }
                    else
                    {
                        Console.WriteLine("Congragulations! you guessed the number");
                    } 
                } 
            }
            catch (FormatException formatexception)
            {
                Console.WriteLine("Error:Invalid number\" + formatexception.Message");
            }
            finally
            {
                Console.WriteLine("program finished");
                Console.ReadKey();
            }
        }
    }
}
