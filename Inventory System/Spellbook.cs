using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    delegate void Spell(Creature target);

    class Spellbook
    {
        public Spell Page1;
        public Spell Page2;

        public Spell[] book;

        public Spellbook(int pages)
        {
            Page1 = BlankPage;
            Page2 = BlankPage;

            book = new Spell[pages];
            for (int i = 0; i < pages; i++)
            {
                book[i] = BlankPage;
            }
        }
        public void BlankPage(Creature target)
        {

        }
        public static void Cure(Creature target)
        {
            target.Health += 10;
            Console.WriteLine("Cure heals 10 damage to " + target.GetName());
        }
    }
}
