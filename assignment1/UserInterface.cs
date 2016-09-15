// Daniel Richards
// CIS 237
// 9/15/2016
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class UserInterface
    {
        public int StartMenu()
        {
            string input = "";

            while (input != "1" && input != "2")
            {
                Console.WriteLine("Would you like to load the wine list?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No (Exit)");

                input = Console.ReadLine();

                if (input != "1" && input != "2")
                {
                    Invalidinput();
                }
                else
                {
                    if (input != "1")
                    {
                        Console.WriteLine("Exiting Program");
                    }
                }
            }
            return Int32.Parse(input);
        }

        public int GetUserInput()
        {
            this.PrintMenu();

            string input = Console.ReadLine();

            while (input != "1" && input != "2" && input != "3" && input != "4")
            {
                Invalidinput();
                this.PrintMenu();
            }
            return Int32.Parse(input);
        }

        private void PrintMenu()
        {
            Console.WriteLine("1. Print List");
            Console.WriteLine("2. Search for item");
            Console.WriteLine("3. Add item to list");
            Console.WriteLine("4. Exit");
        }

        private void Invalidinput()
        {
            Console.WriteLine("That is not a valid entry");
            Console.WriteLine("Please enter a valid entry");
            Console.WriteLine();
        }
    }
}
