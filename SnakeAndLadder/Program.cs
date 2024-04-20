namespace SnakeAndLadder
{
    internal class Program
    {
        int initial_position;
        int number;

        Random rnd = new Random();
        public Program()
        {
            initial_position = 0;
        }
        
        public int RollDie()
        {
                number = rnd.Next(1, 7);
                Console.WriteLine("Number on Die is  " + number);
                Options();
                Console.WriteLine("Current Position: " + initial_position);
                return number;
        }

        public void Options()
        {
            int option = rnd.Next(1,4);

            switch (option)
            {
                case 1:
                    Console.WriteLine("No Play");
                    Console.WriteLine(initial_position);
                    break;
                case 2:
                    initial_position= initial_position + number;
                    Console.WriteLine(initial_position);
                    Console.WriteLine("Ladder");
                    break;
                case 3:
                    initial_position = initial_position - number;
                    Console.WriteLine(initial_position);
                    Console.WriteLine("Snake");
                    break;
                
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            
                program.RollDie();
            
            
            
        }
    }
}
