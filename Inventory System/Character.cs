using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Character
    {
        private string _name = "";
        private int _exp = 0;
        private int _level = 1;
        private int[] _requiredExp = { 100, 150, 230, 355 };

        protected int _health = 100;
        protected int _mana = 100;
        protected int _strength = 5;
        protected int _dexterity = 5;
        protected int _wisdom = 5;

        public Character(string name)
        {
            _name = name;
        }

        public string Name()
        {
            return _name;
        }

        public void Print()
        {
            Console.WriteLine(_name);
            Console.WriteLine("Level: " + _level);
            Console.WriteLine("Experience: " + _exp);
            Console.WriteLine("Health: " + _health);
            Console.WriteLine("Mana: " + _mana);
            Console.WriteLine("Strength: " + _strength);
            Console.WriteLine("Dexterity: " + _dexterity);
            Console.WriteLine("Wisdom: " + _wisdom);
            Console.WriteLine("");
        }

        public int Experience
        {
            get
            {
                return _exp;
            }
            set
            {
                _exp = value;
                Console.WriteLine(_name + " gamined experience and now has " + _exp);
                if(_level <= _requiredExp.Length)
                {
                    if (_exp >= _requiredExp[_level - 1])
                    {
                        _level++;
                        Console.WriteLine(_name + " gained a level! They are now level " + _level);
                    }
                }
            }
        }
    }
}
