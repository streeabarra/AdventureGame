using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Program
    {
        private static string characterName;
        private static bool key = false;

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your character's name: \n");
            Console.Write("Name: ");
            characterName = Console.ReadLine();

            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.Write("Hello ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{characterName}");
            Console.ResetColor();
            Console.Write("! Welcome to the game! Ready to start?");
            Console.Write("\n\nYes / No: ");
            string result = Console.ReadLine();
            result = result.ToLower();

            Console.Clear();

            switch (result)
            {
                case "yes":
                    bool room1 = true;
                    while (room1)
                    {
                        room1 = Room1();
                    }
                    Console.ReadLine();
                    return false;
                case "no":
                    Console.WriteLine("Goodbye!");
                    Console.ReadLine();
                    Environment.Exit(0);
                    return false;
                default:
                    Console.WriteLine("Please say yes or no.");
                    Console.ReadLine();
                    return true;
            }
        }
        private static bool Room1()
        {
            Console.Clear();
            Console.WriteLine("You are in some room, what are your actions?");

            Console.WriteLine("\n1) Look at a book " +
                "\n2) Look at the door " +
                "\n3) Jump like an idiot " +
                "\n4) Go to Room 2");
            Console.Write("\nOption: ");
            string result = Console.ReadLine();

            Console.Clear();

            switch (result)
            {
                case "1":
                    Console.WriteLine("That is a dank ass book\n" +
                        "\nGo Back");
                    Console.ReadLine();
                    return true;
                case "2":
                    Console.WriteLine("The door is made of wood, and it has a handle\n" +
                        "\nGo Back");
                    Console.ReadLine();
                    return true;
                case "3":
                    Console.WriteLine("You jump around, like an idiot. As expected.\n" +
                        "\nGo Back");
                    Console.ReadLine();
                    return true;
                case "4":
                    bool room2 = true;
                    while (room2)
                    {
                        room2 = Room2();
                    }
                    Console.ReadLine();
                    return false;
                default:
                    Console.WriteLine("Please select one of the options");
                    Console.ReadLine();
                    return true;
            }
        }
        private static bool Room2()
        {
            Console.Clear();
            Console.WriteLine("This is the second room" +
                "\n\n1) Go to Room3" +
                "\n2) Go to Room4" +
                "\n3) Go back to Room1");
            Console.Write("\nOption: ");
            string result = Console.ReadLine();

            Console.Clear();
            
            switch (result)
            {
                case "1":
                    Room3();
                    break;
                case "2":
                    Room4();
                    break;
                case "3":
                    Room1();
                    break;
                default:
                    Console.WriteLine("Please select one of the options.");
                    Console.ReadLine();
                    Room2();
                    break;
            }
            return false;
        }
        private static bool Room3()
        {
            // in this room find a key!
            Console.Clear();
            Console.WriteLine("Wow, another room.\n" +
                "\n1) Look at the table" +
                "\n2) Get out of this boring room\n");

            Console.Write("Option: ");
            string result = Console.ReadLine();

            Console.Clear();

            switch (result)
            {
                case "1":
                    Key();
                    break;
                case "2":
                    Room2();
                    break;
                default:
                    Console.WriteLine("Please select one of the options");
                    Console.ReadLine();
                    Room3();
                    break;
            }

            return false;
        }
        private static bool Room4()
        {
            //locked door room!
            Console.Clear();
            Console.WriteLine("This sure is a room! There's some stuff in here.\n" +
                "\n1) Look around" +
                "\n2) Look at roof" +
                "\n3) Go back to Room2" +
                "\n4) Go to Room5");
            Console.Write("\nOption: ");
            string result = Console.ReadLine();

            Console.Clear();

            switch (result)
            {
                case "1":
                    Console.WriteLine("Nothing yet");
                    Console.ReadLine();
                    Room4();
                    break;
                case "2":
                    Console.WriteLine("Nothing yet");
                    Console.ReadLine();
                    Room4();
                    break;
                case "3":
                    Room2();
                    Console.ReadLine();
                    break;
                case "4":
                    Console.Clear();
                    if (key == false)
                    {
                        Console.WriteLine("You try the door, but find it locked.");
                        Console.ReadLine();
                        Room4();
                    }
                    else if (key == true)
                    {
                        Console.Write("You use the ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("key");
                        Console.ResetColor();
                        Console.Write(" on the door, and it unlocks. You proceed!");
                        Console.ReadLine();
                        Room5();
                    }
                    break;
                default:
                    Console.WriteLine("Please select one of the options.");
                    Console.ReadLine();
                    Room4();
                    break;
            }
            return false;
        }
        private static bool Room5()
        {
            // somehow get a puzzle?
            Console.Clear();
            Console.WriteLine("You made it to room 5!" +
                "\nNothing else here yet, sorry!");
            Console.ReadLine();
            Environment.Exit(0);
            return false;
        }
        private static bool Room6()
        {
            //end of the game
            Console.WriteLine("Get the fuck outta here");
            Console.ReadLine();
            Environment.Exit(0);
            return false;
        }
        private static void Key()
        {
            Console.Clear();
            
            if (key == false)
            { 
            Console.Write("There's a ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("key");
            Console.ResetColor();
            Console.Write(" on the table.");
            Console.Write("\n\nTake the key?\n" +
                "\nYes / No: ");
            string choice = Console.ReadLine();
            choice = choice.ToLower();
                Console.Clear();

                switch (choice)
                {
                    case "yes":
                        Console.Write("You picked up the ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("key");
                        Console.ResetColor();
                        Console.Write("!");
                        key = true;
                        Console.ReadLine();
                        Room3();
                        break;
                    case "no":
                        Console.Write("You leave the ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("key");
                        Console.ResetColor();
                        Console.Write(" on the table.");
                        key = false;
                        Console.ReadLine();
                        Room3();
                        break;
                    default:
                        Console.WriteLine("Please select one of the options.");
                        Console.ReadLine();
                        Key();
                        break;
                }
            }
            else
            {
                Console.Write("The table is empty, you already took the ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("key");
                Console.ResetColor();
                Console.Write(".");
                Console.ReadLine();
                key = true;
                Room3();
            }
        }
    }
}
