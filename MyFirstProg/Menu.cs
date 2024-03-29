﻿namespace MyFirstProg
{
    internal class Menu
    {
        GameEngine gameEngine = new();
        internal void ShowMenu(string name, DateTime date)
        {
            Console.WriteLine("--------------------------------------------------");
            Console.Clear();
            Console.WriteLine($"Hello {name.ToUpper()}. It is {date.DayOfWeek}. This is your math game.");
            Console.WriteLine("Press any key to show the menu");
            Console.ReadLine();
            Console.WriteLine("\n");

            var isGameOn = true;


            do
            {
                Console.Clear();
                Console.WriteLine($@"What game would you like to play today? Choose from the options below:
                V - View Previous Games
                A - Addition
                S - Subtraction
                M - Multiplication
                D - Division
                Q - Quit the program
                ");

                Console.WriteLine("--------------------------------------------------");

                var gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {

                    case "v":
                        Helpers.GetGames();
                        break;

                    case "a":
                        gameEngine.AdditionGame("Addition game");
                        break;

                    case "s":
                        gameEngine.SubtractionGame("Subtraction game");
                        break;


                    case "m":
                        gameEngine.MultiplicationGame("Multiplication game");
                        break;

                    case "d":
                        gameEngine.DivisionGame("Divison game");
                        break;

                    case "q":
                        Console.WriteLine("Quitting the game");
                        isGameOn = false;
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;

                }
            } while (isGameOn);


        }
    }
}
