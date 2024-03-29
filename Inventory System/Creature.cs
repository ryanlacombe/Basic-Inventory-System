﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Inventory_System
{
    class Creature
    {
        protected int _health = 20;
        protected int _maxhealth = 20;

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
        public virtual int GetDamage()
        {
            return 0;
        }
        public virtual string GetName()
        {
            return "";
        }
        public virtual int GetExp()
        {
            return 0;
        }
        public virtual void Print()
        {

        }
        public virtual void Fight(Creature target)
        {

        }
        public virtual void Fight(Creature[] targets)
        {

        }
        public virtual void CharacterSave(StreamWriter writer)
        {

        }
        public virtual void CharacterLoad(StreamReader reader)
        {

        }
    }
}
