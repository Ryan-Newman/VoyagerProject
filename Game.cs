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
        Grid grid = new Grid();
        public void GameStart()
        {
            Story intro = new Story();
            grid.GridStart();
            intro.StoryIntro();
            Choices firstPath = new Choices();
            firstPath.Choice();
        }
        public void GameEnd()
        {
            string ending = "You have returned to earth and it will never be the same! You have one last mission,\nAttack and destroy planet wolf!!!";
            //if(resources < 3)
            //{
            //string badEnding = "The attack on Wolf goes wrong, they have too many warriors,\nEarth was not prepared, which destroyed it!";
            //}
            //else
            //{
            //string goodEnding = "The attack was successful! Wolf is no longer a threat!\nEarth is better than it's ever been!";
            //}
            Console.WriteLine(ending);
            System.Environment.Exit(0);
        }
        
    }
 
    class Planet
    {
        Player player = new Player();
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
        public void RngDice(double planetdist)
        {
            Story storyPlanet = new Story();

            int worstLuck, badLuck, kindaBadLuck, okLuck, goodLuck, bestLuck;
            worstLuck = -3;
            badLuck = -2;
            kindaBadLuck = -1;
            okLuck = 1;
            goodLuck = 2;
            bestLuck = 3;
            List<int> luck = new List<int>() {worstLuck, badLuck, kindaBadLuck, okLuck, goodLuck, bestLuck};
            Random rng = new Random();            
            int luckIndex = luck[rng.Next(luck.Count)];
            
            double badWarp = 1.3;
            double goodWarp = 1.5;
            
            Console.Clear();

            if (luckIndex < 1)
            {
                player.ChanceWarp(badWarp, planetdist);
                Console.WriteLine($"Your warp drive is operating at {badWarp}, and you have {luckIndex} item(s) taken from your inventory\n");
            }
            else
            {
               player.ChanceWarp(goodWarp, planetdist);
               Console.WriteLine($"Your warp drive is operating at {goodWarp}, and you have {luckIndex} added to your inventory");
            }
            
           // Console.WriteLine(luck[luckIndex]);
            
        }
       
    }
    class Player
    {
        public double Age(double travelTime)
        {
            double startAge = 18.0;


            double age = startAge + travelTime;
            if (travelTime > 59)
            {
                BadEnding();
            }
            int ageInt = Convert.ToInt32(age);
            return ageInt;
        }
        public void Resources(int plumbus, int gold, int ammo, int weapons, int water)
            {
            int startInvPlumbus = 1;
            int currentPlumInv = plumbus + startInvPlumbus;

            int startInvGold = 1;
            int currentGoldInv = gold + startInvGold;

            int startInvAmmo = 1;
            int currentAmmoInv = ammo + startInvAmmo;

            int startInvWeapons = 1;
            int currentWeaponInv = weapons + startInvWeapons;

            int startInvWater = 1;
            int currentWaterInv = water + startInvWater;
              
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
            double newAge = Age(cFinalResult);
            
            Console.WriteLine($"{cFinalResult} years have passed {newAge} years old");
            return cFinalResult;

        }
        public double SafeWarp(double sDistanceLY)
        {
            double sWarpFactor = 1.4;
            double sFinalResult = sDistanceLY / (Math.Pow(sWarpFactor, 10.0 / 3) + Math.Pow(10 - sWarpFactor, -11.0 / 3));
            double newAge = Age(sFinalResult);

            Console.WriteLine($"{sFinalResult} years have passed, you are {newAge} years old");
            return sFinalResult;
        }       
    }
}
