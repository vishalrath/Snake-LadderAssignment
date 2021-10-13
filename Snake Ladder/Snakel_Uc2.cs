using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Ladder
{
    class Snakel_Uc2
    {

            public const int snakeKillValue = 1; //constant value to provide the snake kill
            public const int ladderValue = 5;       //constant value to provide the ladder

        public void UC2()
        {
            int Is_Present = 1;
            Random random = new Random();
            int empInput = random.Next(0, 2);
            if (Is_Present == empInput)
            {
                Console.WriteLine("Start the game your possition is: 0");
                int rollDiaValue = random.Next(1, 6);

                Console.WriteLine("you have a get number is:" + rollDiaValue);
            }
            else
            {
                Console.WriteLine(" play again");
            }
        }
     }
}
