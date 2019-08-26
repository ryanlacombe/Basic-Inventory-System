using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Inventory
    {
        
        private int _baseDamage = 5;
        private float _gold = 0.00f;
        private float _minGold = 0.00f;
        private string _weaponName = "";
        private int _maxWeight = 50;
        private int _weaponWeight = 0;
        private int _baseDefense = 2;
        private string _armorName = "";
        private int _armorWeight = 0;
        private int _potionPrice = 15;
        private int _potionNum = 0;
        private int _weaponDamage = 5;
        private int _armorDefense = 2;
        private Attack_Item wep1 = new Attack_Item("Dagger", 5, 2);
        private Attack_Item wep2 = new Attack_Item("Sword", 10, 5);
        private Attack_Item wep3 = new Attack_Item("Mace", 12, 7);
        private Attack_Item wep4 = new Attack_Item("Greatsword", 20, 15);
        private Attack_Item[] weaponArray = new Attack_Item[10];

        public Inventory()
        {

        }
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
                    if (_weaponWeight < _maxWeight)
                    {
                        EquipWeapon();
                    }
                    else if (_weaponWeight > _maxWeight)
                    {
                        Console.WriteLine("Too much weight! Unequip something before proceeding!");
                    }
                }
                else if (choice == "2" && _weaponName != "Fists")
                {
                    UnEquipWeapon();
                }
                else if(choice == "3")
                {
                    Console.WriteLine("How much gold?");
                    float addedGold = Convert.ToSingle(Console.ReadLine());
                    AddGold(addedGold);
                }
                else if(choice == "4" && _minGold == 0.00f)
                {

                    Console.WriteLine("How much gold?");
                    float subtractedGold = Convert.ToSingle(Console.ReadLine());
                    if (_gold - subtractedGold >= _minGold)
                    {
                        SubtractGold(subtractedGold);
                    }
                    else if(_gold - subtractedGold < _minGold)
                    {
                        Console.WriteLine("Invalid operation.");
                    }
                }
                else if (choice == "5")
                {
                    if (_weaponWeight + _armorWeight < _maxWeight)
                    {
                        EquipArmor();
                    }
                    else if (_weaponWeight + _armorWeight > _maxWeight)
                    {
                        Console.WriteLine("Too much weight! Unequip something before proceeding!");
                    }
                }
                else if (choice == "6" && _armorName != "Unarmored")
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

            while (weaponChoice != "0" && _weaponWeight + _armorWeight <= _maxWeight)
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
                    _weaponName = "Dagger";
                    _weaponDamage = _baseDamage + 5;
                    Console.WriteLine("Damage: " + _weaponDamage);
                    _weaponWeight = 2;
                    weaponChoice = "0";
                }
                else if (weaponChoice == "2")
                {
                    _weaponName = "Sword";
                    _weaponDamage = _baseDamage + 10;
                    Console.WriteLine("Damage: " + _weaponDamage);
                    _weaponWeight = 5;
                    weaponChoice = "0";
                }
                else if(weaponChoice == "3")
                {
                    _weaponName = "Mace";
                    _weaponDamage = _baseDamage + 12;
                    Console.WriteLine("Damage: " + _weaponDamage);
                    _weaponWeight = 7;
                    weaponChoice = "0";
                }
                else if (weaponChoice == "4")
                {
                    _weaponName = "Greatsword";
                    _weaponDamage = _baseDamage + 20;
                    Console.WriteLine("Damage: " + _weaponDamage);
                    _weaponWeight = 15;
                    weaponChoice = "0";
                }
            }
        }

        public void UnEquipWeapon()
        {
            Console.WriteLine("Unequipped " + _weaponName + "!");
            _baseDamage = 5;
            Console.WriteLine("Damage: " + _baseDamage);
            _weaponName = "Fists";
        }
        public void AddGold(float amount)
        {           
            Console.WriteLine("Got " + amount + " gold!");
            _gold += amount;
            Console.WriteLine("Gold: " + _gold);
        }
        public void SubtractGold(float amount)
        {
            Console.WriteLine("Lost " + amount + " gold!");
            _gold -= amount;
            Console.WriteLine("Gold: " + _gold);
        }
        public void EquipArmor()
        {
            string armorChoice = "";
            
            //Sub Menu Display
            while (armorChoice != "0" && _armorWeight + _weaponWeight <= _maxWeight)
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
                    _armorName = "Robes";
                    _armorDefense = _baseDefense + 2;
                    Console.WriteLine("Defense: " + _armorDefense);
                    _armorWeight = 4;
                    armorChoice = "0";
                }
                else if (armorChoice == "2")
                {
                    _armorName = "Leather Armor";
                    _armorDefense = _baseDefense + 5;
                    Console.WriteLine("Defense: " + _armorDefense);
                    _armorWeight = 6;
                    armorChoice = "0";
                }
                else if (armorChoice == "3")
                {
                    _armorName = "Chainmail";
                    _armorDefense = _baseDefense + 8;
                    Console.WriteLine("Defense: " + _armorDefense);
                    _armorWeight = 14;
                    armorChoice = "0";
                }
                else if (armorChoice == "4")
                {
                    _armorName = "Plate Armor";
                    _armorDefense = _baseDefense + 16;
                    Console.WriteLine("Defense: " + _armorDefense);
                    _armorWeight = 20;
                    armorChoice = "0";
                }
            }
        }
        public void UnEquipArmor()
        {
            Console.WriteLine("Unequipped " + _armorName + "!");
            Console.WriteLine("Defense: " + _baseDefense);
            _armorName = "Unarmored";
        }
        public void BuyPotion()
        {
            if (_gold >= _potionPrice)
            {
                Console.WriteLine("How many potions will you buy?");
                //Input
                int buyNum = Convert.ToInt32(Console.ReadLine());
                if (_gold >= _potionPrice * buyNum)
                {
                    Console.WriteLine("You buy " + buyNum + " potions.");
                    _potionNum = _potionNum + buyNum;
                    Console.WriteLine("Current Number of Potions: " + _potionNum);
                    _gold = _gold - (_potionPrice * buyNum);
                    Console.WriteLine("Remaining Gold: " + _gold);
                }
                else if (_gold < _potionPrice * buyNum)
                {
                    Console.WriteLine("You don't have enough gold to buy that many potions.");
                }
            }
            else if (_gold < _potionPrice)
            {
                Console.WriteLine("You don't have enough gold to buy a potion.");
            }
        }
        public void DrinkPotion()
        {
            if (_potionNum > 0)
            {

                Console.WriteLine("You drink a potion!");
                _potionNum--;
                Console.WriteLine("Current Number of Potions: " + _potionNum);
            }
            else if (_potionNum <= 0)
            {
                Console.WriteLine("You don't have any potions to drink!");
            }
        }
        public int Damage()
        {
            return _weaponDamage;
        }
        public int Defense()
        {
            return _armorDefense;
        }
    }
}
