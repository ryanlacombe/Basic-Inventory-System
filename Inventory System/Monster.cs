using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Monster : Creature
    {
        private string _name;
        private int _damage;

        public Monster(string monsterName, int monsterHealth, int monsterDamage)
        {
            _name = monsterName;
            _health = monsterHealth;
            _maxhealth = monsterHealth;
            _damage = monsterDamage;
        }
        public override string GetName()
        {
            return _name;
        }
        public override int GetDamage()
        {
            return _damage;
        }
        public override void Print()
        {
            Console.WriteLine(_name);
            Console.WriteLine(_health);
            Console.WriteLine(_damage);
        }
        public override void Fight(Creature target)
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
        public override void Fight(Creature[] targets)
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
                    Creature currentTarget = targets[i];
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
