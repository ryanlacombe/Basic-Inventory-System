using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Monster
    {
        private string _name;
        private int _health;
        private int _damage;
        private int _maxhealth;

        public Monster(string monsterName, int monsterHealth, int monsterDamage)
        {
            _name = monsterName;
            _health = monsterHealth;
            _maxhealth = monsterHealth;
            _damage = monsterDamage;
        }
        public string GetName()
        {
            return _name;
        }
        public int GetDamage()
        {
            return _damage;
        }
        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                _health = value;
                if (_health > _maxhealth)
                {
                    _health = _maxhealth;
                }
                else if (_health < 0)
                {
                    _health = 0;
                }
            }
        }
        public void Print()
        {
            Console.WriteLine(_name);
            Console.WriteLine(_health);
            Console.WriteLine(_damage);
        }
        public void Fight(Monster target)
        {
            if(Health <= 0)
            {
                return;
            }
            //Gets damage of current monster
            int damage = GetDamage();
            //Subracting damage from target health 
            target.Health = target.Health - damage;
            Console.WriteLine(GetName() + " attacks " + target.GetName() + "! It takes " + damage + " damage!");
        }
        public void Fight(Monster[] targets)
        {
            if(Health <= 0)
            {
                return;
            }
            bool validInput = false;
            while(!validInput)
            {
                Console.WriteLine("\nWho will " + GetName() + " fight?");
                for (int i = 0; i < targets.Length; i++)
                {
                    Monster currentTarget = targets[i];
                    Console.WriteLine((i) + ": " + currentTarget.GetName());
                }

                string input = Console.ReadLine();
                int choice = Convert.ToInt32(input);
                if(choice >= 0 && choice < targets.Length)
                {
                    validInput = true;
                    Fight(targets[choice]);
                }
            }
        }
    }
}
