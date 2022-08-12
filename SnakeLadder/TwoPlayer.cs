using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    internal class TwoPlayer
    {
        public void DieRoll()
        {
            int Position1 = 0;
            int Position2 = 0;
            bool ladder = false; /// If ladder= true. Player gets chance to roll die again
            var track1 = new List<int>(); // to track position of first player after every roll
            var track2 = new List<int>(); // to track position of second player after every roll
            Console.WriteLine("Heyy! Welcome to Snake and Ladder Game");
            Console.WriteLine("Please enter first player name");
            string FName = Console.ReadLine();
            Console.WriteLine("Please enter second player name");
            string SName = Console.ReadLine();


            int count = 0;
            while (Position1 < 100 && Position2 < 100)
            {
                count++;


                (Position1, ladder) = roll(Position1);
                track1.Add(Position1);
                if (Position1 <= 100)
                {
                    while (ladder)
                    {

                        (Position1, ladder) = roll(Position1);
                        if (Position1 < 100)
                        {
                            track1.Add(Position1);
                        }
                    }
                }
                (Position2, ladder) = roll(Position2);
                track2.Add(Position2);
                if (Position2 <= 100)
                {
                    while (ladder)
                    {

                        (Position2, ladder) = roll(Position2);
                        if (Position2 < 100)
                        {
                            track2.Add(Position2);
                        }
                    }
                }
                //  Console.WriteLine("First player position is: " +Position1 ); // to   print position after every roll die
                //  Console.WriteLine("Second player position is: " + Position2); // to   print position after every roll die

            }
            Console.WriteLine(FName + " has below positions");
            foreach (int i in track1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine(SName + " has below positions");
            foreach (int j in track2)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Total iterations are:  " + count);
            Console.WriteLine("{0} position is: {1}", FName, Position1);
            Console.WriteLine("{0} position is: {1}", SName, Position2);
            if (Position1 == 100)
            {
                Console.WriteLine(FName + " wins");
            }
            else if (Position2 == 100)
            {
                Console.WriteLine(SName + " wins");
            }




        }

        public (int, bool) roll(int position)
        {
            int Position = position;
            bool ladder = false; // to chech the ladder if ladder loopcontine
            Random r = new Random();
            int dieroll = r.Next(1, 7);
            Random r1 = new Random();
            int option = r1.Next(1, 4);
            // track[index] = dieroll;

            switch (option)
            {
                case 1:
                    //Console.WriteLine("No Play");
                    ladder = false;
                    break;
                case 2:
                    //Console.WriteLine("Ladder");
                    if (Position + dieroll <= 100)
                    {
                        Position += dieroll;
                    }
                    ladder = true;
                    break;
                case 3:
                    // Console.WriteLine("Snake");
                    if ((Position - dieroll >= 0))
                    {
                        Position -= dieroll;
                    }
                    if ((Position - dieroll < 0))
                    {
                        Position = 0;
                    }
                    ladder = false;
                    break;
            }
            return (Position, ladder);
        }
    }
}
