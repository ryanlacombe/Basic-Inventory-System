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

            string name = "";
            string choice = "";

            Console.WriteLine("What is the Hero's name?");
            name = Console.ReadLine();
            while(choice != "1" && choice != "2" && choice != "3")
            {
                //Job Choice Menu
                Console.WriteLine("\nChoose a job:");
                Console.WriteLine("1: Knight");
                Console.WriteLine("2: Rogue");
                Console.WriteLine("3: Mage");
                choice = Console.ReadLine();
            }
            Character hero;
            if (choice == "1")
            {
                hero = new Knight(name);
            }
            else if (choice == "2")
            {
                hero = new Rogue(name);
            }
            else if (choice == "3")
            {
                hero = new Mage(name);
            }
            else
            {
                hero = new Character(name);
            }
            hero.Print();

            //Character companion1 = new Rogue(name);
            //Character companion2 = new Mage(name);
            //companion1.Print();
            //companion2.Print();

            hero.Experience = 100;

            int[] testArray = new int[4];

            testArray[0] = 1;
            testArray[1] = 3;
            testArray[2] = 5;
            testArray[3] = 7;

            int[] testArray2 = { 2, 4, 6, 8 };

            string[] stringArray = new string[3];

            //Character[] party = { hero, companion1, companion1};

            Console.ReadKey();
        }
    }
}
