using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();


            StartGame();
        }

        static void StartGame()
        {
            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner.
            
            Player p1 = new Player();
            p1.Marker = "X";
            p1.Name = "Bob";
            p1.IsTurn = true;

            Player p2 = new Player();
            p2.Marker = "O";
            p2.Name = "Tom";
            Game game = new Game(p1, p2);

            game.Board.DisplayBoard();

            game.Play();
        }
    }
}
