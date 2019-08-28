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
        public void Start()
        {
            Console.WriteLine("\nEncounter Starts.");
            bool stillFighting = true;
            while(stillFighting)
            {
                //Check if team 1 is alive
                bool goodAlive = true;
                for(int i = 0; i < _goodMonsters.Length; i++)
                {
                    Monster currentMonster = _goodMonsters[i];
                    if(currentMonster.Health > 0)
                    {
                        goodAlive = true;
                        break;
                    }
                    else if(currentMonster.Health <= 0)
                    {
                        goodAlive = false;
                    }
                }
                //Check if team 2 is alive
                bool badAlive = true;
                for (int i = 0; i < _badMonsters.Length; i++)
                {
                    Monster currentMonster = _badMonsters[i];
                    if (currentMonster.Health > 0)
                    {
                        badAlive = true;
                        break;
                    }
                    else if (currentMonster.Health <= 0)
                    {
                        badAlive = false;
                    }
                }

                //If both team alive
                if (goodAlive == true && badAlive == true)
                {
                    //Return fight
                    stillFighting = true;
                    BeginRound();
                }
                else
                {
                    //End fight
                    stillFighting = false;
                }
                Print();
            }
        }
    }
}
