using Lab04_TicTacToe.Classes;
using System;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuePlaying = true;

            while (continuePlaying)
            {
                continuePlaying = GameSetup();
            }
        }

        // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
        // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 

        public static bool GameSetup()
        {
            Console.Clear();
            Console.WriteLine("Tic-Tac-Toe Game");
            Console.WriteLine("");

            Player playerOne = new Player();
            Player playerTwo = new Player();

            Console.Write("Enter Player One Name: ");
            playerOne.Name = Console.ReadLine();
            playerOne.Marker = "X";

            Console.Write("Enter Player Two Name: ");
            playerTwo.Name = Console.ReadLine();
            playerTwo.Marker = "O";

            Console.WriteLine("");
            Game newGame = new Game(playerOne, playerTwo);

            newGame.Play();

            Console.WriteLine($"{newGame.Winner.Name} won the game!");
            Console.WriteLine("");
            Console.WriteLine($"{newGame.Winner.Name}, would you like to play again?");

            switch (Console.ReadLine())
            {
                case "Y":
                    return true;
                case "N":
                    return false;
            }
            return false;
        }
    }
}
