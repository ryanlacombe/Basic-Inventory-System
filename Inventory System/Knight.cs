using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Knight : Character
    {
        public Knight(string name) : base(name)
        {
            _health = 300;
            _mana = 50;
            _strength = 7;
            _dexterity = 5;
            _wisdom = 3;
        }
    }
}
