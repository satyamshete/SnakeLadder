namespace SnakeLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake Ladder Game");
            Console.WriteLine("Press 1 for Single Player");
            Console.WriteLine("Press 2 for Multi Pllayer");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    SinglePlayer singlePlayer = new SinglePlayer();
                    singlePlayer.SinglePlayerGame();
                    break;
                case 2:
                    TwoPlayer twoPlayer = new TwoPlayer();
                    twoPlayer.DieRoll();
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
        }
    }
}