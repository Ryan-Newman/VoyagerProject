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
        
    }
 
    class Planet
    {
        public void InGameItems(int Plumbus, int Gold, int Ammo, int Weapons, int Water)
        {
            Plumbus = 10;
            Gold = 500;
            Ammo = 100;
            Weapons = 200;
            Water = 50;
        }
        public string PlanetStory(string planetStory)
        {
            return planetStory;
        }
        public double PlanetDistance(double distanceTo)
        {

            //var earthDist = 0.0;
            //var earthToProximaDist = 4.2;
            //var proximaToTrappistDist = 39.72;
            //var trappistToHdDist = 44.18;
            //var hdToWolfDist = 23.44;
            //var wolfToKapteynDist = 18.97;
            //var kapteynToEarthDist = 12.8;
            return distanceTo;
        }
        public void RngDice()
        {

            Random rng = new Random();
            string worstLuck, badLuck, kindaBadLuck, okLuck, goodLuck, bestLuck ;
            //string dice = rng.Next(worstLuck, badLuck, kindaBadLuck, okLuck, goodLuck, bestLuck);
            worstLuck = "\nHorrible Luck! \nYou lost 3 resources and your warp drive is only operating at 1.3\n";
            badLuck = "\nBad Luck!\nYou lost 1 resource and your warp drive is only operating at 1.3\n";
            kindaBadLuck = "\nLuck isn't the best, Not the worst either!\nYou didn't loose any resources, but your warp drive is only operating at 1.3\n";
            okLuck = "\nA little luck is better than bad luck!\nYou didn't gain any resources, but your warp drive is boosted to 1.5!\n";
            goodLuck = "\nGood Luck strikes!\nYou've managed to gain an extra resource, and your warp drive is boosted to 1.5!\n";
            bestLuck = "\nUnstoppable! Best luck of any!\nYou gained 3 resources and your warp drive is boosted to 1.5!!!\n";

            List<string> luck = new List<string>() {worstLuck,badLuck,kindaBadLuck,okLuck,goodLuck,bestLuck };
            int luckIndex = rng.Next(luck.Count);


            Console.Clear();
            Console.WriteLine(luck[luckIndex]);

        }
    }
    class Player
    {
        public void HUD(int travelTime)
        {
            int startAge = 18;
            List<string> inventory = new List<string> { "Plumbus", "Gold", "Ammo", "Weapons", "Water" };
            

            travelTime += startAge;
            if(travelTime > 59)
            {
                BadEnding();
            }
            
            int travelDistance = 0;
            double warpSpeed = 1.4; // John's Masterpiece!
            //travelTime = travelDistance + warpSpeed;

        }

        private void BadEnding()
        {
            Story pullFromStory = new Story();
            string gameOver = "Game Over";

            string badending = "The Voyager looks down at wrinkled hands and realizes that the mission is over and that Humanity is destined for a dark future";
            pullFromStory.TypeEffect(badending, 50);
            Thread.Sleep(1000);
            Console.Clear();
            Console.SetCursorPosition((Console.WindowWidth - gameOver.Length) / 2, Console.CursorTop);
            
            Console.WriteLine(gameOver);
            pullFromStory.TypeEffect(gameOver, 1000);
        }

        public double ChanceWarp(double cWarpFactor, double cDistanceLY) // add dice roll to the warp factor, tolerance is 1.3, 1.4 , and 1.6
        {

            // add the dice roll here
            // Safe calls the default value

            // Chance calls the RNG value
            double cFinalResult = cDistanceLY / (Math.Pow(cWarpFactor, 10.0 / 3) + Math.Pow(10 - cWarpFactor, -11.0 / 3));
            return cFinalResult;

        }
        public double SafeWarp(double sDistanceLY)
        {
            double sWarpFactor = 1.4;
           
            double sFinalResult = sDistanceLY / (Math.Pow(sWarpFactor, 10.0 / 3) + Math.Pow(10 - sWarpFactor, -11.0 / 3));
            return sFinalResult;
        }       
    }
}
