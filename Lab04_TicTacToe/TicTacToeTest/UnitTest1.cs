using System;
using Xunit;
using static Lab04_TicTacToe.Program;
using Lab04_TicTacToe.Classes;

namespace TicTacToeTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestWinner()
        {
            Player playerOne = new Player();
            playerOne.Name = "Player 1";
            playerOne.Marker = "X";
            Player playerTwo = new Player();
            playerTwo.Name = "Player 2";
            playerTwo.Marker = "O";

            Game testGame = new Game(playerOne, playerTwo);

            testGame.Board.GameBoard = new string[,]
            {
                {"X", "2", "O"},
                {"X", "O", "6"},
                {"X", "8", "9"},
            };

            Assert.True(testGame.CheckForWinner(testGame.Board));
        }

        [Fact]
        public void SwitchesPlayer()
        {
            Player playerOne = new Player();
            playerOne.Name = "Player 1";
            playerOne.Marker = "X";
            Player playerTwo = new Player();
            playerTwo.Name = "Player 2";
            playerTwo.Marker = "O";

            Game testGame = new Game(playerOne, playerTwo);
            testGame.PlayerOne.IsTurn = true;
            testGame.SwitchPlayer();

            Assert.Equal(testGame.PlayerTwo, testGame.NextPlayer());
        }

        [Fact]
        public void CorrectIndex()
        {
            Position testPosition = Player.PositionForNumber(1);

            Assert.Equal(new int[] { 0, 0 }, new int[] { testPosition.Row, testPosition.Column });
        }

        [Fact]
        public void RendersGameBoardCorrectly()
        {
            Player playerOne = new Player();
            playerOne.Name = "Player 1";
            playerOne.Marker = "X";
            Player playerTwo = new Player();
            playerTwo.Name = "Player 2";
            playerTwo.Marker = "O";

            Game testGame = new Game(playerOne, playerTwo);

            string[,] testBoard = new string[,]
            {
                { "1", "4", "7"},
                { "2", "5", "8"},
                { "3", "6", "9"}
            };

            Assert.NotEqual(testBoard, testGame.Board.GameBoard);
        }
    }
}
