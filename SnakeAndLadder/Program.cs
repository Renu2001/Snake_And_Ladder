using System.Numerics;
using System.Threading.Channels;

namespace SnakeAndLadder
{
    internal class Program
    {
        int initial_position;
        int number;
        int count ;

        Random rnd = new Random();
        public Program()
        {
            this.initial_position = 0;
            this.count = 0;
        }
        static Program()
        {
            Console.WriteLine("!!! SNAKE AND LADDER GAME !!!");

        }

        public int RollDie(string player)
        {
            Console.WriteLine("\n");
            Console.WriteLine($"{player} playing......");
            number = rnd.Next(1, 7);
            Console.WriteLine("Number on Die is  " + number);
            Options(player);
            this.count++;
            return number;
        }

        public void Options(string player)
        {
            int option = rnd.Next(1, 4);

            switch (option)
            {
                case 1:
                    Console.WriteLine("No Play");
                    Console.WriteLine($"Current Position of {player} : " + initial_position);
                    break;
                case 2:
                    initial_position = initial_position + number;
                    if (initial_position > 100)
                        initial_position = initial_position - number;
                    Console.WriteLine("Ladder");
                    Console.WriteLine($"Current Position of {player} : " + initial_position);
                    if (initial_position == 100)
                        break;
                    else
                        RollDie(player);
                    break;
                case 3:
                    initial_position = initial_position - number;
                    if (initial_position < 0)
                        initial_position = 0;
                    Console.WriteLine("Snake");
                    Console.WriteLine($"Current Position of {player} : " + initial_position);
                    break;

            }
            


        }
        static void Main(string[] args)
        {
            
            Program player1 = new Program();
            Program player2 = new Program();


            while (player1.initial_position < 100 && player2.initial_position < 100)
            {
                
                player1.RollDie("Player 1");

                if (player1.initial_position != 100)
                    player2.RollDie("Player 2");
                else 
                    break;
               
                    

            }
            Console.WriteLine("\n");
            if (player1.initial_position == player2.initial_position)
            {
                Console.WriteLine("\n");
                if (player1.count > player2.count)
                    Console.WriteLine("WINNER IS Player 1 !!!!");
                else
                    Console.WriteLine("WINNER IS Player 2 !!!!");
            }
            else if(player1.initial_position == 100)
                Console.WriteLine("WINNER IS Player 1 !!!!");
            else
                Console.WriteLine("WINNER IS Player 2 !!!!");

            Console.WriteLine("\n");
            Console.WriteLine("Total Counts of Dice Played by players");
            Console.WriteLine("Count of Dice of player 1: " + player1.count);
            Console.WriteLine("Count of Dice of player 2: " + player2.count);
        }

    }
}

