using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace VoyagerProject
{
    class Chance
    {
        Story nextStory = new Story();

        public void CallChance(string chanceNext)
        {
            switch (chanceNext)

            {
                case "Steal The Ship!":
                    ChanceToProxima();
                    break;
                case "Push through the asteroid belt":
                    ChanceToTrappist();
                    break;
                case "Investigate abandoned mine on asteroid":
                    ChanceToHD();
                    break;
                case "Chance path to Wolf":
                    ChanceToWolf();
                    break;
                case "Chance path to Kapteyn":
                    ChanceToKapteyn();
                    break;               
                case "Chance path to Earth":
                    ChanceToEarth();
                    break;
                //case "Chance path to Earth":
                  //  break;
                  
            }
        }

        public void ChanceToSpaceStation()
        {
            Story story = new Story();

            string ChanceSSOne="The hero watches as Colonel Donaldson and his men run towards the sound of battle.";
            story.TypeEffect(ChanceSSOne, 50);


            string ChanceSSTwo = "hero thinks*- “I doubt the Colonel will mind if I borrow the Hermes”";
            story.TypeEffect(ChanceSSTwo, 50);

            string ChanceSSThree = " * enters the rear hatch and moves quickly to the cockpit.";
            story.TypeEffect(ChanceSSThree, 50);

            string ChanceSSFour = " Shaking from adrenaline the hero tries to get the ship off the ground, \n" +
                                  " but is it the red button or green switch? ";
            story.TypeEffect(ChanceSSFour, 50);

            //artificial choice both buttons will strat the craft.

            string ChanceSSFive = "* The ship begins hovering.";
            story.TypeEffect(ChanceSSFive, 50);

            string ChanceSSSix = " hero thinks- “At least my Conscription if finally paying off. ”";
            story.TypeEffect(ChanceSSSix, 50);

            string ChanceSSSeven = " The hero points the ship to the sky and launches. ";
            story.TypeEffect(ChanceSSSeven, 50);

            string ChanceSSEight = ".....";
            story.TypeEffect(ChanceSSEight, 50);

            string ChanceSSNine = " A familiar voice comes over the radio ";
            story.TypeEffect(ChanceSSNine, 50);

            string ChanceSSTen = " After traveling for an hour the radio begins to crackle with life.";
            story.TypeEffect(ChanceSSTen, 50);

            string ChanceSSEleven = "Donaldson- “You son of * fizz fizzzzz * I tell you how to save yourself \n " +
                                    "and you steal *fizz fizzzzz* ship to thank me?! ”";
            story.TypeEffect(ChanceSSEleven, 50);

            string ChanceSSTwelve = "“I’ll ..crackle.. you a choice return the Hermes to the Icarus Space Station... \n " +
                               "or I will launch a … fizz fizzzzz… missile your way and introduce you to the vacuum of space”";
            story.TypeEffect(ChanceSSTwelve, 50);

            string ChanceSSThirteen = "Hero thinks*- “Should I gun it? I could make it out of the solar system before the Colonel \n" +
                                      " could even push the launch button?  ";
            story.TypeEffect(ChanceSSThirteen, 50);
            Console.Clear();

            string ChanceSSFourteen = ".......";
            story.TypeEffect(ChanceSSFourteen, 150);

            string ChanceSSFifteen = "* Grabs the hand mic *, “We’ll do it your way Colonel. \n " +
                                  "Setting course for the Icarus.”";
            story.TypeEffect(ChanceSSFifteen, 50);

            string ChanceSSSixteen = "...";
            story.TypeEffect(ChanceSSSixteen, 150);

            string ChanceSSSeventeen = " The hero reaches the station and begins docking procedures.";
            story.TypeEffect(ChanceSSSeventeen, 50);

            string ChanceSSEighteen = "A voice comes over the Hermes PA, “Docking procedure commencing please step away from the airlock” ";
            story.TypeEffect(ChanceSSEighteen, 50);

            string ChanceSSNineteen = " * The final whistles of air rushing into the vacuum sound *";
            story.TypeEffect(ChanceSSNineteen, 50);

            string ChanceSSTwenty = " hero thinks, “I should have just pushed it to warp 9 and made the jump to the Wolf system ”";
            story.TypeEffect(ChanceSSTwenty, 50);

            string ChanceSSTwentyone = " The airlock opens and Donaldson rushes through the door and grabs the hero by the neck.";
            story.TypeEffect(ChanceSSTwentyone, 20);

            string ChanceSSTwentytwo = " Donaldson- “I should kill you right now! \n" +
                               " I lost a man trying to fight our way back to the fleet because of your little stunt!”";
            story.TypeEffect(ChanceSSTwentytwo, 50);

            string ChanceSSTwentythree = "“yeah.... should have warped”";
            story.TypeEffect(ChanceSSTwentythree, 70);

            string ChanceSSTwentyfour = "A man in a lab coat rounds the corner and stares at the Colonel.";
            story.TypeEffect(ChanceSSTwentyfour, 50);

            string ChanceSSTwentyfive = " “Colonel.. I think, at this moment, we can use just about all the friends we can get” ";
            story.TypeEffect(ChanceSSTwentyfive, 50);

            string ChanceSSTwentysix = " * The Colonel releases his grip *, “This traitor stole my ship, Usk” points at the hero “you’re lucky I haven’t ejected you into space”";
            story.TypeEffect(ChanceSSTwentysix, 50);

        }
        public void ChanceToProxima()
        {
            string chanceProxima = "Dummy Text Spacestation chance";
            Console.WriteLine(chanceProxima);
            nextStory.StoryTrappist();
        }
        public void ChanceToTrappist()
        {
            string chanceTrappist = "Dummy Text Trappist chance";
            Console.WriteLine(chanceTrappist);
            nextStory.StoryHD();
        }
        public void ChanceToHD()
        {
            string chanceHD = "Dummy Text HD chance";
            Console.WriteLine(chanceHD);
            nextStory.StoryWolf();
        }
        public void ChanceToWolf()
        {
            string chanceWolf = "Dummy text Wolf chance";
            Console.WriteLine(chanceWolf);
            nextStory.StoryKapteyn();
        }
        public void ChanceToKapteyn()
        {
            string chanceKapteyn = "Dummy text Kapteyn chance";
            Console.WriteLine(chanceKapteyn);
            nextStory.StoryEarth();
        }
       
        public void ChanceToEarth()
        {
            string chanceEarth = "There's No Place Like Home!";
            Console.WriteLine(chanceEarth);
        }
    }
}
