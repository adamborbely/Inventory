using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory
{
    [Serializable()]
    public class CDProduct : Product
    {
        private int _numOfTracks;
        public int NumOfTracks { get { return _numOfTracks; } set { } }
        public CDProduct() { }
        public CDProduct(string name, int price, int tracks)
        {
            _name = name;
            _price = price;
            _numOfTracks = tracks;
        }
    }
}
