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
    class Player
    {
        public void Age(int currentAge,int travelTime)
        {
            currentAge = 18;
            travelTime = 0;
            int travelDistance = 0;
            double warpSpeed = 1.4; // John's Masterpiece!
            //travelTime = travelDistance + warpSpeed;

        }
        public int TravelTimeCalculation(int a)
        {
            double w = 1.4;
            double warpSpeedFormula = a + 0;//This is the warp speed formula
            int travelTimeCalculation;
            
            return travelTimeCalculation;
        }

        public void Planets()
        {
            var earthDist = 0.0;
            var earthToProximaDist = 4.2;
            var proximaToTrappistDist = 39.72;
            var trappistToHdDist = 44.18;
            var hdToWolfDist = 23.44;
            var wolfToKapteynDist = 18.97;
            var kapteynToEarthDist = 12.8;


            TravelTimeCalculation(earthToProximaDist);

        }
    }
}
