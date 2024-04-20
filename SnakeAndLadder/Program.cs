namespace SnakeAndLadder
{
    internal class Program
    {
        int initial_position;

        public Program()
        {
            initial_position = 0;
        }
        
        public int RollDie()
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 6);
            Console.WriteLine(number);
            return number;
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.RollDie();

        }
    }
}
