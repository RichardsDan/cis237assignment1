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
                WineItem[] wineItems = new WineItem[4000];
                CSVProcess CSVProcessor = new CSVProcess();
                WineItemCollection collection = new WineItemCollection();

                // Import WineList file
                CSVProcessor.ImportCSV("../../../datafiles/WineList.csv", wineItems);

                choice = ui.GetUserInput();

                // Menu will continue to appear after every action until user inputs 4
                while (choice != 4)
                {
                    // Prints wine list to screen if user presses 1
                    if (choice == 1)
                    {
                        foreach (WineItem wineItem in wineItems)
                        {
                            if (wineItem != null)
                            {
                              Console.WriteLine(wineItem.ToString());
                            }
                        }
                    }
                    // Allows user to search wine list if user presses 2
                    if (choice == 2)
                    {
                        Console.WriteLine(collection.ListSearch(ui.SearchList(), wineItems));
                    }
                    // Allows user to add item to wine list if user presses 3
                    if (choice == 3)
                    {
                        collection.AddToList(ui, wineItems);
                    }

                    // Gets user input for menu again
                    choice = ui.GetUserInput();
                }
            }
        }
    }
}
