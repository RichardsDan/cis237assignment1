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
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface ui = new UserInterface();

            int choice = ui.StartMenu();

            if (choice != 2)
            {
                // Handle CSV Processing here

                choice = ui.GetUserInput();

                while (choice != 4)
                {
                    if (choice == 1)
                    {
                        // Print wine list here
                    }
                    if (choice == 2)
                    {
                        // Search wine list here
                    }
                    if (choice == 3)
                    {
                        // Add item to wine list here
                    }
                }
            }
        }
    }
}
