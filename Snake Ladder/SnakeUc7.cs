﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Ladder
{
    class SnakeUc7
    {
        public const int snakeKillValue = 1;    //constant value to provide the snake kill
        public const int ladderValue = 5;        //constant value to provide the ladder
        public const int winningpossitoin = 100;   //constant value to provide the chart value
        public const int totalNumOfPlayer = 2;      //new added here total number of player

        public void UC7()
        {
            int countPossi = 0;
            int totalCount = 0;
            int countLadder = 0;
            int snakeKill = 0;

            int roll = 0;
            while (roll <= totalNumOfPlayer && roll <= winningpossitoin) //to find Only the 2 player
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
                    Console.WriteLine("Got the Ladder,Please Play Again..");   // if ladder is find then play again  
                }
                else
                {      
                    totalCount = countPossi + rollDiaValue;
                    Console.WriteLine("Total Count is:" + totalCount);
                }
                roll++;  //incrementing roll value here
            }
            int numOfDia = totalCount * totalNumOfPlayer;
            Console.WriteLine("Number of times dia plyad:" + numOfDia + " " + "Every dia Possition" + totalCount);
            //display the each Num of dia and possition 
        }
    }
}
