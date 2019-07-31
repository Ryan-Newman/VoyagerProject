using System;
using System.Collections.Generic;
using System.Text;

namespace VoyagerProject
{
    class Chance
    {
        
        public void ChanceToSpaceStation()
        {
            Story story = new Story();

            string ChanceSSOne="Hero watches as Colonel Donaldson and his men run towards the sound of battle.";
            story.TypeEffect(ChanceSSOne, 50);


            string ChanceSSTwo = "Hero thinks- “I doubt the Colonel will mind if I borrow the Hermes”";


            string ChanceSSThree = " * enters the rear hatch and moves quickly to the cockpit.";


            string ChanceSSFour = " Shaking from adrenaline the hero tries to get the ship off the ground, but is it the red button or green switch? ";


            //artificial choice both buttons will strat the craft.
            string ChanceSSFive = "* The ship begins hovering.";


            string ChanceSSSix = " Hero thinks- “At least my Conscription if finally paying off. ”";


            string ChanceSSSeven = " The hero points the ship to the sky and launches. ";


            string ChanceSSEight = ".....";


            string ChanceSSNine = " A familiar voice comes over the radio ";


            string ChanceSSTen = " After traveling for an hour the radio begins to crackle with life.";


            string ChanceSSEleven = "Donaldson- “You son of * fizz fizzzzz * I tell you how to save yourself and you steal *fizz fizzzzz* ship to thank me?! ”";


        }
        public void ChanceToProxima()
        {

        }
        public void ChanceToTrappist()
        {

        }
        public void ChanceToHD()
        {

        }
        public void ChanceToWolf()
        {

        }
        public void ChanceToKapteyn()
        {

        }
        public void ChanceToTouCentauri()
        {

        }
        public void ChanceToEarth()
        {

        }
    }
}
