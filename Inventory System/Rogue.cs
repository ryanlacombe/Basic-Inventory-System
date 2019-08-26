using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Rogue : Character
    {
        public Rogue(string name) : base(name)
        {
            _health = 150;
            _mana = 70;
            _strength = 4;
            _dexterity = 8;
            _wisdom = 4;
        }
    }
}
