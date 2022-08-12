namespace SnakeLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake Ladder Game");
            Console.WriteLine("Press 1 for Single Player");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    SinglePlayer singlePlayer = new SinglePlayer();
                    singlePlayer.SinglePlayerGame();
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
        }
    }
}