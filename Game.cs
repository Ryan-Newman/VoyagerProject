using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace VoyagerProject
{
    class Game
    {
        public void GameStart()
        {
            Story intro = new Story();
            intro.StoryIntro();
            Choices firstPath = new Choices();
            firstPath.Choice();
        }
       
        public int RngDice(int dice)
        {
            string luck;            
            Random rng = new Random();
            dice = rng.Next(1, 6);
            switch(dice)
            {
                case 1:
                    Console.Write("the worst");
                    break;
                case 2:
                    Console.Write("bad");
                    break;
                case 3:
                    Console.Write("kinda bad");
                    break;
                case 4:
                    Console.Write("kinda good");
                    break;
                case 5:
                    Console.Write("good");
                    break;
                case 6:
                    Console.Write("the best");
                    break;
            }
            return dice;

        }
    }
}
