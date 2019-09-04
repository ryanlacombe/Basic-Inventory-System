using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Inventory_System
{
    class Map
    {
        private int _currentLocation;
        private Scene[] _sceneList;

        public Map(int startingSceneID, Scene[] scenes)
        {
            _currentLocation = startingSceneID;
            _sceneList = scenes;
        }
        
        //Prints current scene
        public void PrintCurrentScene()
        {
            if (_currentLocation >= 0 && _currentLocation < _sceneList.Length)
            {
                Console.WriteLine("");
                Console.WriteLine(_sceneList[_currentLocation].GetName());
                Console.WriteLine(_sceneList[_currentLocation].GetDescription());
            }
            else
            {
                Console.WriteLine("\nError.");
            }
        }

        public int CurrentSceneID
        {
            get
            {
                return _currentLocation;
            }
            set
            {
                //If value is in range
                if(value >= 0 && value < _sceneList.Length)
                {
                    //Change to new scene
                    _currentLocation = value;
                }
                else
                {
                    //Print Error
                    Console.WriteLine("\nError.");
                }
            }
        }

        //Map menu
        public void Menu()
        {
            string choice = "";

            while (choice != "0")
            {
                //Prints Scene
                PrintCurrentScene();
                //Open Menu
                Console.WriteLine("\nMenu:");
                Console.WriteLine("0: Exit");
                Console.WriteLine("1: Travel");
                Console.WriteLine("2: Save");
                Console.WriteLine("3: Load");
                Console.WriteLine("4: Search");
                //Input
                choice = Console.ReadLine();
                if(choice == "1")
                {
                    Travel();
                }
                else if (choice == "2")
                {
                    Save("save.txt");
                }
                else if (choice == "3")
                {
                    Load("save.txt");
                }
                else if (choice == "4")
                {
                    Search();
                }
            }
        }
        public void Travel()
        {
            int destination = -1;

            //If current scene is valid, ask for player input for destination
            if(_currentLocation >= 0 && _currentLocation < _sceneList.Length)
            {
                destination = _sceneList[_currentLocation].ChooseExit();
            }
            //If destination is valid, move player there
            if(destination >= 0 && destination < _sceneList.Length)
            {
                CurrentSceneID = destination;
            }
            //If not valid, print error
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Unable to go in that direction. Choose another.");
            }
        }
        public void Search()
        {
            //If current scene is valid, search room
            if (_currentLocation >= 0 && _currentLocation < _sceneList.Length)
            {
                Console.WriteLine(_sceneList[_currentLocation].GetHidden());
            }
        }
        public void Save(string path)
        {
            //Creates a writer for file at path
            StreamWriter writer = File.CreateText(path);
            //Writes in same way as console
            writer.WriteLine(CurrentSceneID);
            //Closes
            writer.Close();
        }
        public void Load(string path)
        {
            if (File.Exists(path))
            {
                //Creates a reader for file at path
                StreamReader reader = File.OpenText(path);
                //Reads in same way as console
                CurrentSceneID = Convert.ToInt32(reader.ReadLine());
                //Closes
                reader.Close();
            }
            else
            {
                Console.WriteLine("No savefile found.");
            }
        }
    }
}
