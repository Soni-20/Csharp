using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthNameFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number from (1-12) to find the Month:");
                int monthNumber = Convert.ToInt32(Console.ReadLine());
                switch (monthNumber)
                {
                    case 1:
                        Console.WriteLine($"{monthNumber} : January");
                        break;
                    case 2:
                        Console.WriteLine($"{monthNumber} : February");
                        break;
                    case 3:
                        Console.WriteLine($"{monthNumber} : March");
                        break;
                    case 4:
                        Console.WriteLine($"{monthNumber} : April");
                        break;
                    case 5:
                        Console.WriteLine($"{monthNumber} : May");
                        break;
                    case 6:
                        Console.WriteLine($"{monthNumber} : June");
                        break;
                    case 7:
                        Console.WriteLine($"{monthNumber} : July");
                        break;
                    case 8:
                        Console.WriteLine($"{monthNumber} : August");
                        break;
                    case 9:
                        Console.WriteLine($"{monthNumber} : September");
                        break;
                    case 10:
                        Console.WriteLine($"{monthNumber} : October");
                        break;
                    case 11:
                        Console.WriteLine($"{monthNumber} : November");
                        break;
                    case 12:
                        Console.WriteLine($"{monthNumber} : December");
                        break;
                    default:
                        Console.WriteLine("Error:Invalid number");
                        break;
                }
            }
            catch (FormatException formatexception)
            {
                Console.WriteLine("Error:Invalid input .please enter a numeric value + FormatException.Message");
            }
        }
    }
}
