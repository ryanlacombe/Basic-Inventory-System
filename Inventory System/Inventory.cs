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
        string weaponName = "";
        int maxWeight = 50;

        public void Menu()
        {
            string choice = "";
 

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
                }
                else if (choice == "2" && weaponName != "Fists")
                {
                    UnEquipWeapon();
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
                    if (gold - subtractedGold >= minGold)
                    {
                        SubtractGold(subtractedGold);
                    }
                    else if(gold - subtractedGold < minGold)
                    {
                        Console.WriteLine("Invalid operation.");
                    }
                }
            }
        }

        public void EquipWeapon()
        {
            string weaponChoice = "";
            int weaponDamage = 0;
            int weaponWeight = 0;

            while (weaponChoice != "0" && weaponWeight <= maxWeight)
            {
                //Sub Menu Display
                Console.WriteLine("Which weapon are you equiping?");
                Console.WriteLine("");
                Console.WriteLine("0: Exit to Menu");
                Console.WriteLine("1: Dagger");
                Console.WriteLine("2: Sword");
                Console.WriteLine("3: Mace");
                Console.WriteLine("4: Greatsword");

                //Get Sub Menu Input
                weaponChoice = Console.ReadLine();
                Console.WriteLine("");
                if(weaponChoice == "1")
                {
                    weaponName = "Dagger";
                    weaponDamage = baseDamage + 5;
                    Console.WriteLine("Damage: " + weaponDamage);
                    weaponWeight = 2;
                }
                else if (weaponChoice == "2")
                {
                    weaponName = "Sword";
                    weaponDamage = baseDamage + 10;
                    Console.WriteLine("Damage: " + weaponDamage);
                    weaponWeight = 5;
                }
                else if(weaponChoice == "3")
                {
                    weaponName = "Mace";
                    weaponDamage = baseDamage + 12;
                    Console.WriteLine("Damage: " + weaponDamage);
                    weaponWeight = 7;
                }
                else if (weaponChoice == "4")
                {
                    weaponName = "Greatsword";
                    weaponDamage = baseDamage + 20;
                    Console.WriteLine("Damage: " + weaponDamage);
                    weaponWeight = 15;
                }
            }
        }

        public void UnEquipWeapon()
        {
            Console.WriteLine("Unequipped " + weaponName + "!");
            baseDamage = 5;
            Console.WriteLine("Damage: " + baseDamage);
            weaponName = "Fists";
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
