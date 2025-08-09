using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace CollatzConjecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive number:");
            int num=Convert.ToInt32(Console.ReadLine());
            if (num <= 0)
            {
                Console.WriteLine("please enter a positive number");
            }
            Console.WriteLine("Sequence:");
            int steps = 0;
            while (num !=1) {
                Console.Write($"{num}\t");
                if (num % 2 == 0)
                {
                    num = num / 2;
                }
                else {
                    num = (3 * num) + 1;
                }
                    steps++;
            
            }
            Console.WriteLine("1");
            Console.Write("Total steps:"+steps);
        }
    }
}
