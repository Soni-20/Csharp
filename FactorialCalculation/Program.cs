using FactorialCalculation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Factorial factorial = new Factorial();
                Console.WriteLine("Enter the number:");
                int num = Convert.ToInt32(Console.ReadLine());
                factorial.number(num);
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
    

