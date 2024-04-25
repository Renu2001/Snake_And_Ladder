using System.Numerics;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SnakeAndLadder
{
    internal class Program 
    {
        
        int i;

        public void StartGame()
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Welcome to Snake and Ladder Game");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++");
           
            Player play = new Player();

            Console.WriteLine("How many players ");
            int playernumber= Convert.ToInt32(Console.ReadLine());
            List<Player> players = new List<Player>();
            for (int i = 0; i < playernumber; i++) 
            {
                Console.Write($"Enter Player {i+1} Name: ");
                string playername = Console.ReadLine();
                players.Add(new Player(playername));
            }

            play.PlayGame(players);

            Console.WriteLine("\n");
            Console.WriteLine("Do you want to play again? type yes or no");
            string choice = Console.ReadLine();
            switch (choice.ToLower())
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