using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Ladder
{
    class SnakeUc4
    {
        public const int snakeKillValue = 1;  //constant value to provide the snake kill
        public const int ladderValue = 5;     //constant value to provide the ladder
        public const int totalChartValue = 100; //new add here total number char value

        public void UC4()
        {
            int countPossi = 0;
            int totalCount = 0;
            int countLadder = 0;
            int snakeKill = 0;

            for (int roll = 0; roll <= totalChartValue; roll++)
            {
                Console.WriteLine("Roll Die..");
                Random random = new Random();
                int rollDiaValue = random.Next(1, 6);

                if (rollDiaValue == snakeKillValue)
                {
                    snakeKill = rollDiaValue - snakeKillValue;
                    Console.WriteLine("Snake is killed" + snakeKill);
                }
                else if (rollDiaValue == ladderValue)
                {
                    countLadder = rollDiaValue + ladderValue;
                    Console.WriteLine("Ladder increment possition:" + countLadder);
                }
                else
                {      
                    totalCount = countPossi + rollDiaValue;
                    Console.WriteLine("Total Count is:" + totalCount);
                }
            }
        }
    }   
}
