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

            //Creates Monsters
            Monster monster1 = new Monster("Carbuncle", 30, 10);
            Monster monster2 = new Monster("Slime", 15, 5);
            Monster monster3 = new Monster("Carbuncle", 30, 10);
            Monster monster4 = new Monster("Slime", 15, 5);

            //Arrays Monsters
            Monster[] goodTeam = { monster1, monster2 };
            Monster[] badTeam = { monster3, monster4 };

            Encounter encounter = new Encounter(goodTeam, badTeam);
            encounter.Print();
            encounter.Start();

            Console.ReadKey();
            return;

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
                choice = "";
            }
            else if (choice == "2")
            {
                hero = new Rogue(name);
                choice = "";
            }
            else if (choice == "3")
            {
                hero = new Mage(name);
                choice = "";
            }
            else
            {
                hero = new Character(name);
                choice = "";
            }

            Character companion1 = new Rogue("Daniel");
            Character companion2 = new Mage("Tanis");

            while (choice != "0")
            {
                //Character Inventory Choice Menu
                Console.WriteLine("\nWhose Inventory are you opening?");
                Console.WriteLine("0: Exit");
                Console.WriteLine("1: " + hero.Name());
                Console.WriteLine("2: " + companion1.Name());
                Console.WriteLine("3: " + companion2.Name());
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    hero.Print();
                    hero.OpenInventory();
                }
                else if (choice == "2")
                {
                    companion1.Print();
                    companion1.OpenInventory();
                }
                else if (choice == "3")
                {
                    companion2.Print();
                    companion2.OpenInventory();
                }
            }

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
