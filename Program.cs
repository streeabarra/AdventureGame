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
                    Console.WriteLine("Please say yes or no");
                    Console.ReadKey();
                    return true;
            }
        }
        private static bool Room1()
        {
            Console.Clear();
            Console.WriteLine("You are in some room, what are your actions?");

            Console.WriteLine("1) Look at a book");
            Console.WriteLine("2) Look at the door");
            Console.WriteLine("3) Jump like an idiot");
            Console.WriteLine("4) Go to Room 2");
            Console.Write("\nOption: ");
            string result = Console.ReadLine();

            Console.Clear();

            switch (result)
            {
                case "1":
                    Console.WriteLine("That is a dank ass book");
                    Console.ReadKey();
                    return true;
                case "2":
                    Console.WriteLine("The door is made of wood, and it has a handle");
                    Console.ReadKey();
                    return true;
                case "3":
                    Console.WriteLine("You jump around, like an idiot. As expected");
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
                    return true;
            }
        }
        private static bool Room2()
        {
            Console.Clear();
            Console.WriteLine("You made it to room 2!");
            Console.WriteLine("\nPress enter to exit");
            return false;
        }
    }
}
