using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Scene
    {
        private string _name;
        private string _description;
        private int _north;
        private int _south;
        private int _west;
        private int _east;
        public string _hidden;

        public Scene(string name, int northId, int southId, int westId, int eastId, string description)
        {
            _name = name;
            _description = description;
            _north = northId;
            _south = southId;
            _west = westId;
            _east = eastId;
            _hidden = "Nothing was found.";
        }

        public Scene(string name, int northId, int southId, int westId, int eastId, string description, string hidden)
        {
            _name = name;
            _description = description;
            _north = northId;
            _south = southId;
            _west = westId;
            _east = eastId;
            _hidden = hidden;
        }

        //Return name
        public string GetName()
        {
            return _name;
        }

        //Return description
        public string GetDescription()
        {
            return _description;
        }

        //Gets the users choice
        public int ChooseExit()
        {
            string choice = "";

            while (choice != "N" && choice != "S" && choice != "W" && choice != "E")
            {
                //Ask for user's input
                Console.WriteLine("Which direcrion are you moving? (N/S/W/E)");
                choice = Console.ReadLine();
                //Set it to caps
                choice = choice.ToUpper();
            }
            if (choice == "N")
            {
                return _north;
            }
            else if (choice == "S")
            {
                return _south;
            }
            else if (choice == "W")
            {
                return _west;
            }
            else if (choice == "E")
            {
                return _east;
            }
            else
            {
                //If given invalid choice, gives a -1
                return -1;
            }
        }
        public string GetHidden()
        {
            return _hidden;
        }
    }
}
