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

                CSVProcessor.ImportCSV("../../../datafiles/WineList.csv", wineItems);

                choice = ui.GetUserInput();

                while (choice != 4)
                {
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
                    if (choice == 2)
                    {
                        Console.WriteLine(collection.ListSearch(ui.SearchList(), wineItems));
                    }
                    if (choice == 3)
                    {
                        // Add item to wine list here
                    }

                    choice = ui.GetUserInput();
                }
            }
        }
    }
}
