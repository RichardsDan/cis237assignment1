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
    class WineItemCollection
    {
        // Formats wineItems for output to screen
        public string WineToString(string id, string desc, string pack)
        {
            return (id.PadRight(7) + desc.PadRight(60) + pack);
        }

        // Allows user to search wine list by wine ID, then outputs wine to screen if found.
        // Displays message if wineID is not found
        public string ListSearch(string wineSearch, WineItem[] wineItems)
        {
            foreach (WineItem wineItem in wineItems)
            {
                if (wineItem != null)
                {
                    if (wineItem.WineId == wineSearch)
                        return (Environment.NewLine + wineItem.ToString());
                }
            }

            return (Environment.NewLine + 
                "Selected wine could not be found" +
                Environment.NewLine);
        }

        // Allows user to add item to wine list, then searches wineItems array for an empty spot
        public void AddToList(UserInterface ui, WineItem[] wineItems)
        {
            int index = 0;

            try
            {
                foreach (WineItem wineitem in wineItems)
                {
                    if (wineitem != null)
                    {
                        index++;
                    }
                }
                // Prompts user to enter ID, Desc, and Pack, then adds new item to list
                wineItems[index] = new WineItem(ui.GetWineID(), ui.GetWineDesc(), ui.GetWinePack());

                Console.WriteLine(wineItems[index]);
            }
            // Error handler
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine("Unable to add item to list.");
                Console.WriteLine(e);
            }
        }
    }
}
