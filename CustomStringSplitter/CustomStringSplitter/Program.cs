using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStringSplitter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input=Console.ReadLine();
            Console.WriteLine("Enter a delimiter");
            char delimiter = Console.ReadLine()[0];
            string currentword = "";
            string[] parts=new string[input.Length];
            int index = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == delimiter)
                {
                    parts[index] = currentword;
                    index++;
                    currentword = "";
                }
                else
                {
                    currentword += input[i];
                }
            }
            parts[index]=currentword;
            index++;
            Console.Write("The substring are:");
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(parts[i]);
            }
        }
    }
}
