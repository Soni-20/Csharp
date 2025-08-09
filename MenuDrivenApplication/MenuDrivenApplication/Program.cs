using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MenuDrivenApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int choice;
                do
                {
                    Console.WriteLine("===========MENU===========");
                    Console.WriteLine("1.View Profile");
                    Console.WriteLine("2.Edit Settings");
                    Console.WriteLine("3.View Profile");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Profile:soni,Age:15,place:kollam");
                            break;
                        case 2:
                            Console.WriteLine("Settings Updated Successfully!");
                            break;
                        case 3:
                            Console.WriteLine("Exit the program");
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }

                } while (choice != 3);
            }
            catch (FormatException formatexception)
            {
                Console.WriteLine("Error:Invalid number\" + formatexception.Message");
            }
        }
    }
}
