using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Program
    {
        public static Random random = new Random();
        static void Main(string[] args)
        {

            Monster monster1 = new Monster("Carbuncle", 30, 10, 50);
            Console.WriteLine("Health: " + monster1.Health);

            Spellbook spellbook = new Spellbook(2);

            spellbook.Page1(monster1);
            Console.WriteLine("Health: " + monster1.Health);
            spellbook.Page2(monster1);
            Console.WriteLine("Health: " + monster1.Health);

            void Flame(Creature target)
            {
                target.Health -= 15;
                Console.WriteLine("Flame deals 15 damage to " + target.GetName());
            }
            spellbook.Page1 = Flame;
            spellbook.Page1(monster1);
            Console.WriteLine("Health: " + monster1.Health);
            void Cure(Creature target)
            {
                target.Health += 10;
                Console.WriteLine("Cure heals 10 damage to " + target.GetName());
            }
            spellbook.Page2 = Cure;
            spellbook.Page2(monster1);
            Console.WriteLine("Health: " + monster1.Health);

            spellbook.Page1 += Spellbook.Cure;
            spellbook.Page1(monster1);
            Console.WriteLine("Health: " + monster1.Health);

            spellbook.book[0] = Flame;
            spellbook.book[1] = Spellbook.Cure;
            spellbook.book[0](monster1);
            Console.WriteLine("Health: " + monster1.Health);

            Console.ReadKey();

            return;
            //Character test = new Character("Test");
            //Console.WriteLine(test.GetDamage());



            //Inventory inventory = new Inventory();
            //inventory.Menu();

            string name = "";
            string choice = "";

            Console.WriteLine("What is the Hero's name?");
            name = Console.ReadLine();
            while (choice != "1" && choice != "2" && choice != "3")
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

            /*
            while (choice != "0")
            {
                //Character Inventory Choice Menu
                Console.WriteLine("\nWhose Inventory are you opening?");
                Console.WriteLine("0: Exit");
                Console.WriteLine("1: " + hero.GetName());
                Console.WriteLine("2: " + companion1.GetName());
                Console.WriteLine("3: " + companion2.GetName());
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    hero.Print();
                    hero.OpenInventory();
                    Console.WriteLine(hero.GetDamage());
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
            */

            //Creates Monsters
            //Monster monster1 = new Monster("Carbuncle", 30, 10, 50);
            Monster monster2 = new Monster("Slime", 15, 5, 50);

            //Arrays Monsters
            Creature[] goodTeam = { hero, companion1, companion2 };
            Creature[] badTeam = { monster1, monster2 };
            Creature[] emptyTeam = { };

            //Creates Scenes
            //0: Courtyard
            //1: Castle Gate
            //2: Graveyard
            //3: Village
            Scene scene1 = new Scene("Courtyard", 1, 3, 2, -1, emptyTeam, "The courtyard is wide. A number of nobles mill about the garden. There are exits to the north, south, and west.");
            Scene scene2 = new Scene("Castle Gate", -1, 0, -1, -1, emptyTeam, "The massive gate of the Castle is currently closed. You can only leave to the south.");
            Scene scene3 = new Scene("Graveyard", 3, -1, -1, 0, badTeam, "The graveyard is earily quiet. Many graves are in disrepair and have dead flowers. There exits to the east and north.");
            Scene scene4 = new Scene("Village", 0, 2, -1, -1, emptyTeam, "The village is bustling with activity. Many shops line the streets and most have criers advertising their wares. There are exits to the south and north.");

            Scene[] scenes = { scene1, scene2, scene3, scene4 };
            Map map = new Map(0, scenes, goodTeam);

            /*
            map.PrintCurrentScene();
            map.CurrentSceneID = 1;
            map.PrintCurrentScene();
            map.CurrentSceneID = 2;
            map.PrintCurrentScene();
            map.CurrentSceneID = 3;
            map.PrintCurrentScene();
            map.CurrentSceneID = 4;
            */

            map.Menu();

            hero.Print();
            companion1.Print();
            companion2.Print();


            Console.ReadKey();

            return;
        }
    }
}
