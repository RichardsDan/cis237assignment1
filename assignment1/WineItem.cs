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
    class WineItem
    {
        //*******************************
        //        Backing Fields
        //*******************************
        private string _wineId;
        private string _wineDesc;
        private string _winePack;

        //*******************************
        //          Properties
        //*******************************
        public string WineId
        {
            get { return _wineId; }
            set { _wineId = value; }
        }
        public string WineDesc
        {
            get { return _wineDesc; }
            set { _wineDesc = value; }
        }
        public string WinePack
        {
            get { return _winePack; }
            set { _winePack = value; }
        }

        //*******************************
        //        Constructors
        //*******************************
        public WineItem()
        {
            // Empty Constructor
        }

        public WineItem(string wineId, string wineDesc, string winePack)
        {
            this._wineId = wineId;
            this._wineDesc = wineDesc;
            this._winePack = winePack;
        }

        //*******************************
        //            Methods
        //*******************************
        public override string ToString()
        {
            WineItemCollection collection = new WineItemCollection();
            return collection.WineToString(_wineId, _wineDesc, _winePack);
        }
    }
}
