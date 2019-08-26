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
        int weaponWeight = 0;
        int baseDefense = 2;
        string armorName = "";
        int armorWeight = 0;
        int potionPrice = 15;
        int potionNum = 0;

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
                Console.WriteLine("5: Equip Armor");
                Console.WriteLine("6: Unequip Armor");
                Console.WriteLine("7: Buy Potion");
                Console.WriteLine("8: Drink Potion");

                //Grab input
                choice = Console.ReadLine();
                Console.WriteLine("");
                if (choice == "1")
                {
                    if (weaponWeight < maxWeight)
                    {
                        EquipWeapon();
                    }
                    else if (weaponWeight > maxWeight)
                    {
                        Console.WriteLine("Too much weight! Unequip something before proceeding!");
                    }
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
                else if (choice == "5")
                {
                    if (weaponWeight + armorWeight < maxWeight)
                    {
                        EquipArmor();
                    }
                    else if (weaponWeight + armorWeight > maxWeight)
                    {
                        Console.WriteLine("Too much weight! Unequip something before proceeding!");
                    }
                }
                else if (choice == "6" && armorName != "Unarmored")
                {
                    UnEquipArmor();
                }
                else if (choice == "7")
                {
                    BuyPotion();
                }
                else if (choice == "8")
                {
                    DrinkPotion();
                }
            }
        }

        public void EquipWeapon()
        {
            string weaponChoice = "";
            int weaponDamage = 0;

            while (weaponChoice != "0" && weaponWeight + armorWeight <= maxWeight)
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
                    weaponChoice = "0";
                }
                else if (weaponChoice == "2")
                {
                    weaponName = "Sword";
                    weaponDamage = baseDamage + 10;
                    Console.WriteLine("Damage: " + weaponDamage);
                    weaponWeight = 5;
                    weaponChoice = "0";
                }
                else if(weaponChoice == "3")
                {
                    weaponName = "Mace";
                    weaponDamage = baseDamage + 12;
                    Console.WriteLine("Damage: " + weaponDamage);
                    weaponWeight = 7;
                    weaponChoice = "0";
                }
                else if (weaponChoice == "4")
                {
                    weaponName = "Greatsword";
                    weaponDamage = baseDamage + 20;
                    Console.WriteLine("Damage: " + weaponDamage);
                    weaponWeight = 15;
                    weaponChoice = "0";
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
        public void EquipArmor()
        {
            string armorChoice = "";
            int armorDefense = 0;
            
            //Sub Menu Display
            while (armorChoice != "0" && armorWeight + weaponWeight <= maxWeight)
            {
                Console.WriteLine("Which armor are you equipping?");
                Console.WriteLine("");
                Console.WriteLine("0: Exit");
                Console.WriteLine("1: Robes");
                Console.WriteLine("2: Leather Armor");
                Console.WriteLine("3: Chainmail");
                Console.WriteLine("4: Plate Armor");

                //Get Sub Menu Input
                armorChoice = Console.ReadLine();

                if (armorChoice == "1")
                {
                    armorName = "Robes";
                    armorDefense = baseDefense + 2;
                    Console.WriteLine("Defense: " + armorDefense);
                    armorWeight = 4;
                    armorChoice = "0";
                }
                else if (armorChoice == "2")
                {
                    armorName = "Leather Armor";
                    armorDefense = baseDefense + 5;
                    Console.WriteLine("Defense: " + armorDefense);
                    armorWeight = 6;
                    armorChoice = "0";
                }
                else if (armorChoice == "3")
                {
                    armorName = "Chainmail";
                    armorDefense = baseDefense + 8;
                    Console.WriteLine("Defense: " + armorDefense);
                    armorWeight = 14;
                    armorChoice = "0";
                }
                else if (armorChoice == "4")
                {
                    armorName = "Plate Armor";
                    armorDefense = baseDefense + 16;
                    Console.WriteLine("Defense: " + armorDefense);
                    armorWeight = 20;
                    armorChoice = "0";
                }
            }
        }
        public void UnEquipArmor()
        {
            Console.WriteLine("Unequipped " + armorName + "!");
            Console.WriteLine("Defense: " + baseDefense);
            armorName = "Unarmored";
        }
        public void BuyPotion()
        {
            if (gold >= potionPrice)
            {
                Console.WriteLine("How many potions will you buy?");
                //Input
                int buyNum = Convert.ToInt32(Console.ReadLine());
                if (gold >= potionPrice * buyNum)
                {
                    Console.WriteLine("You buy " + buyNum + " potions.");
                    potionNum = potionNum + buyNum;
                    Console.WriteLine("Current Number of Potions: " + potionNum);
                    gold = gold - (potionPrice * buyNum);
                    Console.WriteLine("Remaining Gold: " + gold);
                }
                else if (gold < potionPrice * buyNum)
                {
                    Console.WriteLine("You don't have enough gold to buy that many potions.");
                }
            }
            else if (gold < potionPrice)
            {
                Console.WriteLine("You don't have enough gold to buy a potion.");
            }
        }
        public void DrinkPotion()
        {
            if (potionNum > 0)
            {

                Console.WriteLine("You drink a potion!");
                potionNum--;
                Console.WriteLine("Current Number of Potions: " + potionNum);
            }
            else if (potionNum <= 0)
            {
                Console.WriteLine("You don't have any potions to drink!");
            }
        }
    }
}
