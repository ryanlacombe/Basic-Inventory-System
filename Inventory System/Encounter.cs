using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Encounter
    {
        private Monster[] _goodMonsters;
        private Monster[] _badMonsters;

        public Encounter(Monster[] team1, Monster[] team2)
        {
            _goodMonsters = team1;
            _badMonsters = team2;
        }
        public void Print()
        {
            //Cycles through good monsters and prints
            for (int i = 0; i < _goodMonsters.Length; i++)
            {
                Monster currentMonster = _goodMonsters[i];
                currentMonster.Print();
            }
            //Cycles through bad monsters and prints
            for (int i = 0; i < _badMonsters.Length; i++)
            {
                Monster currentMonster = _badMonsters[i];
                currentMonster.Print();
            }
        }
        public void BeginRound()
        {
            //Cycles through good monsters
            for (int i = 0; i < _goodMonsters.Length; i++)
            {
                Monster currentMonster = _goodMonsters[i];
                currentMonster.Fight(_badMonsters);
            }
            //Cycles through bad monsters
            for (int i = 0; i < _badMonsters.Length; i++)
            {
                Monster currentMonster = _badMonsters[i];
                currentMonster.Fight(_goodMonsters);
            }
        }
    }
}
