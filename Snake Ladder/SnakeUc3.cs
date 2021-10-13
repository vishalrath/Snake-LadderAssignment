using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Ladder
{
    class SnakeUc3
    {

        public void check()
        {
            Random die = new Random();
            int getNum = die.Next(1, 7);

            Console.WriteLine("display the die number:" + getNum);

            //int Is_Present = 1;
            Random random = new Random();
            int input = random.Next(0, 2);
            switch (input)
                    {
                case 0:

                    Console.WriteLine("player the same possion");
                    break;

                case 1:
                    Console.WriteLine("Ladder the player move ahed the recive position");
                    break;
                default:
                    Console.WriteLine("snake the player move behind by possition receive");
                        break;
            }
        }
    }

}
