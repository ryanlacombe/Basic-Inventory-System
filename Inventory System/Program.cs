using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inventory inventory = new Inventory();
            //inventory.Menu();

            Character hero = new Character("Rain");
            hero.Print();

            Character companion1 = new Character("Daniel");
            Character companion2 = new Character("Tannis");
            companion1.Print();
            companion2.Print();

            hero.Experience = 100;

            int[] testArray = new int[4];

            testArray[0] = 1;
            testArray[1] = 3;
            testArray[2] = 5;
            testArray[3] = 7;

            int[] testArray2 = { 2, 4, 6, 8 };

            string[] stringArray = new string[3];

            Character[] party = { hero, companion1, companion1};

            Console.ReadKey();
        }
    }
}
