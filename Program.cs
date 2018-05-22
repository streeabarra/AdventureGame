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
        private static string[] items = { "one", "two", "three" };
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
            Console.ForegroundColor = ConsoleColor.White;
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
                    Console.ReadKey();
                    return false;
                case "no":
                    Console.WriteLine("Goodbye!");
                    Console.ReadKey();
                    return false;
                default:
                    Console.WriteLine("Please say yes or no.");
                    Console.ReadKey();
                    return true;
            }
        }
        private static bool Room1()
        {
            Console.Clear();
            Console.WriteLine("You are in some room, what are your actions?");

            Console.WriteLine("1) Look at a book " +
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
                    Console.ReadKey();
                    return true;
                case "2":
                    Console.WriteLine("The door is made of wood, and it has a handle\n" +
                        "\nGo Back");
                    Console.ReadKey();
                    return true;
                case "3":
                    Console.WriteLine("You jump around, like an idiot. As expected.\n" +
                        "\nGo Back");
                    Console.ReadKey();
                    return true;
                case "4":
                    bool room2 = true;
                    while (room2)
                    {
                        room2 = Room2();
                    }
                    Console.ReadKey();
                    return false;
                default:
                    Console.WriteLine("Please select one of the options");
                    Console.ReadKey();
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
                    bool room3 = true;
                    while (room3)
                    {
                        room3 = Room3();
                    }
                    Console.ReadKey();
                    return false;
                case "2":
                    bool room4 = true;
                    while (room4)
                    {
                        room4 = Room4();
                    }
                    Console.ReadKey();
                    return false;
                case "3":
                    bool room1 = true;
                    while (room1)
                    {
                        room1 = Room1();
                    }
                    Console.ReadKey();
                    return false;
            }
            return false;
        }
        private static bool Room3()
        {
            // in this room find a key!
            Console.Clear();
            Console.WriteLine("Wow, another room.\n" +
                "\n1) Look at the table" +
                "\n2) Get out of this boring room");

            Console.Write("\nOption: ");
            string result = Console.ReadLine();

            Console.Clear();

            switch (result)
            {
                case "1":
                    Key();
                    break;
                case "2":
                    bool room2 = true;
                    while (room2)
                    {
                        room2 = Room2();
                    }
                    Console.ReadKey();
                    return false;
                default:
                    Console.WriteLine("Please select one of the options");
                    Console.ReadKey();
                    return true;
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
            return false;
        }
        private static bool Room5()
        {
            // somehow get a puzzle?
            return false;
        }
        private static bool Room6()
        {
            //end of the game
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
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" on the table.");
            Console.Write("\n\nTake the key?" +
                "\nOption: ");
            string choice = Console.ReadLine();
            choice = choice.ToLower();
                Console.Clear();

                switch (choice)
                {
                    case "yes":
                        Console.Write("You picked up the ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("key");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("!");
                        key = true;
                        Console.ReadKey();
                        Room3();
                        break;
                    case "no":
                        Console.Write("You leave the ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("key");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" on the table.");
                        key = false;
                        Console.ReadKey();
                        Room3();
                        break;
                    default:
                        Console.WriteLine("Please select one of the options.");
                        Console.ReadKey();
                        Key();
                        break;
                }
            }
            else
            {
                Console.Write("The table is empty, you already took the ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("key");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(".");
                Console.ReadKey();
                key = true;
                Room3();
            }
        }
    }
}
