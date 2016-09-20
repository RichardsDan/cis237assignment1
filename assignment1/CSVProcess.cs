// Daniel Richards
// CIS 237
// 9/20/2016
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment1
{
    class CSVProcess
    {
        // Imports file and places each wineItem in array
        public bool ImportCSV(string pathToCsvFile, WineItem[] wineItems)
        {
            StreamReader inputFile = null;

            try
            {
                string line;
                int counter = 0;
                inputFile = new StreamReader(pathToCsvFile);

                // Processes lines as long as inputFile has data
                while ((line = inputFile.ReadLine()) != null)
                {
                    ProcessLine(line, wineItems, counter++);
                }

                return true;
            }
            catch (Exception e)
            {
                // Error handler
                Console.WriteLine(e.ToString());
                Console.WriteLine();
                Console.WriteLine(e.StackTrace);

                return false;
            }
            // Ensures that inputFile is closed no matter what
            finally
            {
                if (inputFile != null)
                {
                    inputFile.Close();
                }
            }
        }

        public void ProcessLine(string line, WineItem[] wineItems, int index)
        {
            string[] parts = line.Split(',');

            string wineID = parts[0];
            string wineDesc = parts[1];
            string winePack = parts[2];

            wineItems[index] = new WineItem(wineID, wineDesc, winePack);
        }
    }
}
