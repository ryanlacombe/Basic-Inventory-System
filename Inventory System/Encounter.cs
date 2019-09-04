using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Encounter 
    {
        private Creature[] _goodMonsters;
        private Creature[] _badMonsters;

        public Encounter(Creature[] team1, Creature[] team2)
        {
            _goodMonsters = team1;
            _badMonsters = team2;
        }
        public void Print()
        {
            //Cycles through good monsters and prints
            for (int i = 0; i < _goodMonsters.Length; i++)
            {
                Creature currentMonster = _goodMonsters[i];
                currentMonster.Print();
            }
            //Cycles through bad monsters and prints
            for (int i = 0; i < _badMonsters.Length; i++)
            {
                Creature currentMonster = _badMonsters[i];
                currentMonster.Print();
            }
        }
        public void BeginRound()
        {
            //Cycles through good monsters
            for (int i = 0; i < _goodMonsters.Length; i++)
            {
                Creature currentMonster = _goodMonsters[i];
                currentMonster.Fight(_badMonsters);
            }
            //Cycles through bad monsters
            for (int i = 0; i < _badMonsters.Length; i++)
            {
                Creature currentMonster = _badMonsters[i];
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
                    Creature currentMonster = _goodMonsters[i];
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
                    Creature currentMonster = _badMonsters[i];
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
                    if(goodAlive)
                    {
                        //Give Exp to each character
                        foreach (Creature cr in _goodMonsters)
                        {
                            if (cr is Character)
                            {
                                Character ch = (Character)cr;
                                ch.Experience += GetTotalExp(_badMonsters);
                            }
                        }
                    }
                    else if(badAlive)
                    {
                        //Give Exp to each character
                        foreach (Creature cr in _badMonsters)
                        {
                            if (cr is Character)
                            {
                                Character ch = (Character)cr;
                                ch.Experience += GetTotalExp(_goodMonsters);
                            }
                        }
                    }
                }
            }
        }
        public int GetTotalExp(Creature[] team)
        {
            int totalExp = 0;
            for(int i = 0; i < team.Length; i++)
            {
                totalExp += team[i].GetExp();
            }

            return totalExp;
        }
    }
}
