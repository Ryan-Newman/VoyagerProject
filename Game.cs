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
        //public void InGameItems(int Plumbus, int Gold, int Ammo, int Weapons, int Water)
        //{
        //    Plumbus = 10;
        //    Gold = 500;
        //    Ammo = 100;
        //    Weapons = 200;
        //    Water = 50;
        //}
        public string PlanetStory(string planetStory)
        {
            return planetStory;
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
        Choices choice = new Choices();
        public void Inventory(int plumbus, int gold, int ammo, int weapons, int water)
            {
            List<int> money = new List<int> { 100 };
            List<int> plumbusInv = new List<int> { 1 };
            //plumbusInv.Add();
            List<int> goldInv = new List<int> { 1 };
            //goldInv.Add();
            List<int> ammoInv = new List<int> { 1 };
            //ammoInv.Add();
            List<int> weaponsInv = new List<int> { 1 };
            //weaponsInv.Add();
            List<int> waterInv = new List<int> { 1 };
            //waterInv.Add();
            Console.WriteLine("\nYou have");
            Console.WriteLine($"Money: {money.Sum()}\nPlumbus: {plumbusInv.Sum()}\nGold: {goldInv.Sum()}\nAmmo: {ammoInv.Sum()}\nWeapons: {weaponsInv.Sum()}\nWater: {waterInv.Sum()}");
            BuySell("\nBuy", "Sell");
            }
        public void BuySell(string buy, string sell)
        {
            int index = 0;

            string[] menu = new string[] { buy, sell };

            ConsoleKeyInfo ckey;
            string selection;
            Console.CursorVisible = false;
            do
            {
                for (int i = 0; i < menu.Length; i++)
                {
                    if (i == index)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine(menu[i]);
                    }

                    else
                    {
                        Console.WriteLine(menu[i]);
                    }
                    Console.ResetColor();
                    selection = menu[i];

                }

                ckey = Console.ReadKey();

                if (ckey.Key == ConsoleKey.DownArrow)
                {
                    if (index == menu.Length - 1)
                    {
                        index = 0;
                        // Console.BackgroundColor = ConsoleColor.Blue;
                    }

                    else
                    {
                        index++;

                    }
                }

                if (ckey.Key == ConsoleKey.UpArrow)
                {
                    if (index == 0)
                    {
                        index = menu.Length - 1;

                    }
                    else
                    {
                        index--;
                    }
                }
                if (ckey.Key == ConsoleKey.Enter && menu[index] == sell)
                {
                    Safe safe = new Safe();
                    safe.CallSafe(sell); // Goes to Safe class and calls the dialogue for the safe adventure
                }
                else if (ckey.Key == ConsoleKey.Enter && menu[index] == buy)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Console.SetWindowSize(1, 1);
                        Thread.Sleep(50);
                        Console.SetWindowSize(100, 25);
                    }
                    Chance chance = new Chance();
                    Planet dice = new Planet();
                    // dice.RngDice();
                    chance.CallChance(buy);
                }
                choice.ClearLine();
            } while (ckey.Key != ConsoleKey.Escape);
        }
        public double Age(double travelTime)
        {           
            List<double> addAge = new List<double>() { 18.0 };

            addAge.Add(travelTime);
            double ageSum = addAge.Sum();//Should add the su
           
            if (ageSum > 59.9)
            {
                BadEnding();
            }
            int ageSumInt = Convert.ToInt32(ageSum);
            Console.WriteLine($"\nYour age is {ageSum}");

            return ageSumInt;
        }
        

        public double ChanceWarp(double cWarpFactor, double cDistanceLY) // add dice roll to the warp factor, tolerance is 1.3, 1.4 , and 1.6
        {           
            double cFinalResult = cDistanceLY / (Math.Pow(cWarpFactor, 10.0 / 3) + Math.Pow(10 - cWarpFactor, -11.0 / 3));
            double newAge = Age(cFinalResult);
            
            Console.WriteLine($"{cFinalResult} years have passed, you are {newAge} years old");
            Age(cFinalResult);
            return cFinalResult;

        }
        public double SafeWarp(double sDistanceLY)
        {
            double sWarpFactor = 1.4;
            double sFinalResult = sDistanceLY / (Math.Pow(sWarpFactor, 10.0 / 3) + Math.Pow(10 - sWarpFactor, -11.0 / 3));
            double newAge = Age(sFinalResult);

            Console.WriteLine($"{sFinalResult} years have passed, you are {newAge} years old");
            Age(sFinalResult);
            return sFinalResult;
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
        public void MerchantResources(int plumbus, int gold, int ammo, int weapons, int water)
        {
            Random rng = new Random();
            int value = rng.Next(500);

            int plumbusVal = rng.Next(500);
            int goldVal = rng.Next(500);
            int ammoVal = rng.Next(500);
            int weaponsVal = rng.Next(500);
            int waterVal = rng.Next(500);

            Console.WriteLine($"\nThe value of plumbus: {plumbusVal}\nGold: {goldVal}\nAmmo: {ammoVal}\nWeapons: {weaponsVal}\nWater: {waterVal}\n");
            Console.WriteLine("Buy or Sell?");
            Inventory(plumbusVal, goldVal, ammoVal, weaponsVal, waterVal);
            
           

        }
    }
    
}
