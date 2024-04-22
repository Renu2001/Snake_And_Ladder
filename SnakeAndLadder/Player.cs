using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Player
    {
         string player_name;
         int initial_position;
         int number;
         int count;

        public Player() { }
        public Player(string name)
        {
            this.player_name = name;
            this.initial_position = 0;
            this.count = 0;
        }

        Random rnd = new Random();
        public int RollDie(string player)
        {
            Console.WriteLine("\n");
            Console.WriteLine($"{player} is playing......");
            number = rnd.Next(1, 7);
            Console.WriteLine("Number on Die is :  " + number);
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
                    Console.WriteLine($"Current Position of {player} is : " + initial_position);
                    break;
                case 2:
                    initial_position += number;
                    if (initial_position > 100)
                        initial_position -= number;
                    Console.WriteLine("Ladder");
                    Console.WriteLine($"Current Position of {player} is : " + initial_position);
                    if (initial_position == 100)
                        break;
                    else
                        RollDie(player);
                    break;
                case 3:
                    initial_position -= number;
                    if (initial_position < 0)
                        initial_position = 0;
                    Console.WriteLine("Snake");
                    Console.WriteLine($"Current Position of {player} is : " + initial_position);
                    break;

            }

            


        }
        public void PlayGame(Player player1, Player player2)
        {
            while (player1.initial_position < 100 && player2.initial_position < 100)
            {

                player1.RollDie(player1.player_name);

                if (player1.initial_position != 100)
                    player2.RollDie(player2.player_name);
                else
                    break;

            }

            Console.WriteLine("\n");
            if (player1.initial_position == player2.initial_position)
            {
                Console.WriteLine("\n");
                if (player1.count > player2.count)
                    Console.WriteLine($"WINNER IS {player1.player_name} !!!!");
                else
                    Console.WriteLine($"WINNER IS {player2.player_name} !!!!");
            }
            else if (player1.initial_position == 100)
                Console.WriteLine($"WINNER IS {player1.player_name} !!!!");
            else
                Console.WriteLine($"WINNER IS {player2.player_name} !!!!");

            Console.WriteLine("\n");
            Console.WriteLine("Total Counts of Dice Played by players");
            Console.WriteLine($"Count of Dice of {player1.player_name} : " + player1.count);
            Console.WriteLine($"Count of Dice of {player2.player_name} : " + player2.count);
        }

    }
    
}
