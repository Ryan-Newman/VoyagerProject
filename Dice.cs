using System;
using System.Collections.Generic;
using System.Text;

namespace VoyagerProject
{
    class Dice
    {
        public int RngDice(string luck)
        {

            Random rng = new Random();
            int dice = rng.Next(1, 6);
            switch (dice)
            {
                case 1:
                    luck = dice.ToString("the worst");
                    break;
                case 2:
                    luck = dice.ToString("bad");
                    break;
                case 3:
                    luck = dice.ToString("kinda bad");
                    break;
                case 4:
                    luck = dice.ToString("kinda good");
                    break;
                case 5:
                    luck = dice.ToString("good");
                    break;
                case 6:
                    luck = dice.ToString("the best");
                    break;
            }
            Chance chanceluck = new Chance();
            
            Console.Write($"\nYour luck is {luck}");
            return dice;

        }
    }
}
