using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Defense_Item : Item
    {
        private int _defense = 5;
        public int Defense
        {
            get
            {
                return _defense;
            }
        }
        public Defense_Item(string newName, int newDefense, int newWeight)
        {
            itemName = newName;
            _defense = newDefense;
            itemWeight = newWeight;
        }
    }
}
