using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Inventory
    {
        
        int baseDamage = 5;
        float gold = 0.00f;
        float minGold = 0.00f;

        public void Menu()
        {
            string choice = "";
            string weaponEquipped = "A";
 

            while (choice != "0")
            {
                //Display Menu
                Console.WriteLine("\nMenu");
                Console.WriteLine("0: Exit");
                Console.WriteLine("1: Equip Weapon");
                Console.WriteLine("2: Unequip Weapon");
                Console.WriteLine("3: Add gold");
                Console.WriteLine("4: Subtract gold");

                //Grab input
                choice = Console.ReadLine();
                Console.WriteLine("");
                if (choice == "1")
                {
                    EquipWeapon();
                    weaponEquipped = "B";
                }
                else if (choice == "2" && weaponEquipped == "B")
                {
                    UnEquipWeapon();
                    weaponEquipped = "A";
                }
                else if(choice == "3")
                {
                    Console.WriteLine("How much gold?");
                    float addedGold = Convert.ToSingle(Console.ReadLine());
                    AddGold(addedGold);
                }
                else if(choice == "4" && minGold == 0.00f)
                {

                    Console.WriteLine("How much gold?");
                    float subtractedGold = Convert.ToSingle(Console.ReadLine());
                    if (gold - subtractedGold > minGold)
                    {
                        SubtractGold(subtractedGold);
                    }
                    else if(gold - subtractedGold <= minGold)
                    {
                        Console.WriteLine("Invalid operation.");
                    }
                }
            }
        }

        public void EquipWeapon()
        {
            Console.WriteLine("Equipped a weapon!");
            baseDamage = 15;
            Console.WriteLine("Damage: " + baseDamage);
        }

        public void UnEquipWeapon()
        {
            Console.WriteLine("Unequipped a weapon!");
            baseDamage = 5;
            Console.WriteLine("Damage: " + baseDamage);
        }
        public void AddGold(float amount)
        {           
            Console.WriteLine("Got " + amount + " gold!");
            gold += amount;
            Console.WriteLine("Gold: " + gold);
        }
        public void SubtractGold(float amount)
        {
            Console.WriteLine("Lost " + amount + " gold!");
            gold -= amount;
            Console.WriteLine("Gold: " + gold);
        }
    }
}
