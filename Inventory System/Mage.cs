using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Mage : Character
    {
        public Mage(string name) : base(name)
        {
            _health = 90;
            _maxhealth = 90;
            _mana = 200;
            _strength = 3;
            _dexterity = 5;
            _wisdom = 8;
        }
    }
}
