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
        public string WineToString(string id, string desc, string pack)
        {
            return (id.PadRight(7) + desc.PadRight(60) + pack);
        }

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
                wineItems[index] = new WineItem(ui.GetWineID(), ui.GetWineDesc(), ui.GetWinePack());

                Console.WriteLine(wineItems[index]);
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine("Unable to add item to list.");
                Console.WriteLine(e);
            }
        }
    }
}
