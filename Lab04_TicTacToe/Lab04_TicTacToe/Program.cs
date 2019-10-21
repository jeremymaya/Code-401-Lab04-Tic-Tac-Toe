using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool continuePlaying = true;

            while (continuePlaying)
            {
                continuePlaying = GameSetup();
            }
        }

        /// <summary>
        /// Setups and runs a tic-tac-toe game by creating two player instances and a game instance with the player instances
        /// </summary>
        /// <returns>boolean</returns>
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

            Console.WriteLine("");
            Console.WriteLine("Would you like to play again? (y/n)");

            switch (Console.ReadLine())
            {
                case "y":
                    return true;
                case "n":
                    return false;
            }
            return false;
        }
    }
}
