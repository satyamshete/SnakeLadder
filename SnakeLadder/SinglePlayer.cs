using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    internal class SinglePlayer
    {
        public void SinglePlayerGame()
        {
            /////////////////////////////Singlr player/////////////////
            int Position = 0;
            Console.WriteLine("Heyy! Welcome to Snake and Ladder Game");
            Console.WriteLine("Enter the Player name");
            string Name = Console.ReadLine();
            int index = 0; /// tobreak the loop
            int count = 0; // to chcek iterations
            var track = new List<int>();

            while (index >= 0)
            {
                count++;
                Random r = new Random();
                int dieroll = r.Next(1, 7);
                Random r1 = new Random();
                int option = r1.Next(1, 4);


                switch (option)
                {
                    case 1:
                        //Console.WriteLine("No Play");
                        break;
                    case 2:
                        //Console.WriteLine("Ladder");
                        if (Position + dieroll <= 100)
                        {
                            Position += dieroll;
                        }
                        if (Position == 100)
                        {
                            index = -1;
                        }
                        break;
                    case 3:

                        Position -= dieroll;
                        if ((Position - dieroll < 0))
                        {
                            Position = 0;
                        }
                        break;


                }
                track.Add(Position);


                //Console.WriteLine("Your updated position is: " + Position);




            }
            Console.WriteLine();
            Console.WriteLine("Your positioms after every die roll are: ");
            foreach (int i in track)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Heyy " + Name + " You won and you have rolled the dice " + count + " times");
        }
    }
}
