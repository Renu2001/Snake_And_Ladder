using System.Numerics;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SnakeAndLadder
{
    internal class Program 
    {

        public void StartGame()
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Welcome to Snake and Ladder Game");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.Write("Enter Player 1 Name : ");
            string playername1 = Console.ReadLine();
            Console.Write("Enter Player 2 Name : ");
            string playername2 = Console.ReadLine();

            Player player1 = new Player(playername1);
            Player player2 = new Player(playername2);

            player1.PlayGame(player1, player2);
            Console.WriteLine("\n");
            Console.WriteLine("Do you want to play again? type yes or no");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "yes":
                    StartGame();
                    break;
                case "no":
                    Console.WriteLine("Thanks for playing the game ....");
                    break;


            }
        }
        static void Main(string[] args)
        {
            Program game = new Program();
            game.StartGame();
        }   

    }
}