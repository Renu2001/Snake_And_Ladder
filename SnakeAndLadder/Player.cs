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
        public void PlayGame(Player[] players)
        {

            bool won = false;
            while (true)
                {
              
                for (int i = 0; i < players.Length; i++)
                    {
                        Player curr = players[i];
                       curr.RollDie(curr.player_name);
                        if(curr.initial_position == 100)
                        {
                            Console.WriteLine($"WINNER IS {curr.player_name} !!!!");
                            won = true;
                            break;
                        }

                    }
                if(won == true)
                {
                    break;
                }

                }

                Console.WriteLine("\n");
                Console.WriteLine("Total Counts of Dice Played by players");
                for(int j = 0; j < players.Length; j++)
                {
                    Console.WriteLine($"Count of Dice of {players[j].player_name} : " + players[j].count);

                }

            

        }

    }
    
}
