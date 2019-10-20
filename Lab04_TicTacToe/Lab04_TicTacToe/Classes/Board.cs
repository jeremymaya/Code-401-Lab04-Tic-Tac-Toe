using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
    class Board
    {
		/// <summary>
		/// Tic Tac Toe Gameboard states
		/// </summary>
		public string[,] GameBoard = new string[,]
		{
			{"1", "2", "3"},
			{"4", "5", "6"},
			{"7", "8", "9"},
		};


		public void DisplayBoard()
		{
            for (int row = 0; row < GameBoard.GetLength(0); row++)
            {
                for (int column = 0; column < GameBoard.GetLength(1); column++)
                {
                    Console.Write($"|{GameBoard[row, column]}|");
                }
                Console.WriteLine("");
            }
		}
	}
}
