using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace VoyagerProject
{
    class Chance
    {
        Story nextStory = new Story();
        Planet dice = new Planet();

        public void CallChance(string chanceNext)
        {
            switch (chanceNext)

            {
                case "Steal The Ship!":
                    ChanceToSpaceStation();
                    break;
                case "Answer the distress call":                   
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
                //case "\nChance path to Earth":
                //    ChanceToEarth();
                //    break;
               
                  
            }
        }

        public void ChanceToSpaceStation()
        {
            Story story = new Story();

            string ChanceSSOne="The hero watches as Colonel Donaldson and his men run towards the sound of battle. \n";
            story.TypeEffect(ChanceSSOne, 50);


            string ChanceSSTwo = "hero thinks*- “I doubt the Colonel will mind if I borrow the Hermes”\n";
            story.TypeEffect(ChanceSSTwo, 50);

            string ChanceSSThree = " * enters the rear hatch and moves quickly to the cockpit. \n";
            story.TypeEffect(ChanceSSThree, 50);

            string ChanceSSFour = " Shaking from adrenaline the hero tries to get the ship off the ground, \n" +
                                  " but is it the red button or green switch? ";
            story.TypeEffect(ChanceSSFour, 50);

            //artificial choice both buttons will strat the craft.

            string ChanceSSFive = "* The ship begins hovering.\n";
            story.TypeEffect(ChanceSSFive, 50);

            string ChanceSSSix = " hero thinks- “At least my Conscription if finally paying off. ”\n";
            story.TypeEffect(ChanceSSSix, 50);

            string ChanceSSSeven = " The hero points the ship to the sky and launches. \n";
            story.TypeEffect(ChanceSSSeven, 50);

            string ChanceSSEight = ".....\n";
            story.TypeEffect(ChanceSSEight, 50);

            string ChanceSSNine = " A familiar voice comes over the radio \n";
            story.TypeEffect(ChanceSSNine, 50);

            string ChanceSSTen = " After traveling for an hour the radio begins to crackle with life.\n";
            story.TypeEffect(ChanceSSTen, 50);

            string ChanceSSEleven = "Donaldson- “You son of * fizz fizzzzz * I tell you how to save yourself \n " +
                                    "and you steal *fizz fizzzzz* ship to thank me?! ”\n";
            story.TypeEffect(ChanceSSEleven, 50);

            string ChanceSSTwelve = "“I’ll ..crackle.. you a choice return the Hermes to the Icarus Space Station... \n " +
                               "or I will launch a … fizz fizzzzz… missile your way and introduce you to the vacuum of space”\n";
            story.TypeEffect(ChanceSSTwelve, 50);

            string ChanceSSThirteen = "Hero thinks*- “Should I gun it? I could make it out of the solar system before the Colonel \n" +
                                      " could even push the launch button?  \n";
            story.TypeEffect(ChanceSSThirteen, 50);
            Console.Clear();

            string ChanceSSFourteen = ".......\n";
            story.TypeEffect(ChanceSSFourteen, 50);

            string ChanceSSFifteen = "* Grabs the hand mic *, “We’ll do it your way Colonel. \n " +
                                  "Setting course for the Icarus.”\n";
            story.TypeEffect(ChanceSSFifteen, 50);

            string ChanceSSSixteen = "...\n";
            story.TypeEffect(ChanceSSSixteen, 50);

            string ChanceSSSeventeen = " The hero reaches the station and begins docking procedures.\n";
            story.TypeEffect(ChanceSSSeventeen, 50);

            string ChanceSSEighteen = "A voice comes over the Hermes PA, “Docking procedure commencing please step away from the airlock”\n ";
            story.TypeEffect(ChanceSSEighteen, 50);

            string ChanceSSNineteen = " * The final whistles of air rushing into the vacuum sound *\n";
            story.TypeEffect(ChanceSSNineteen, 50);

            string ChanceSSTwenty = " hero thinks, “I should have just pushed it to warp 9 and made the jump to the Wolf system ”\n";
            story.TypeEffect(ChanceSSTwenty, 50);

            string ChanceSSTwentyone = " The airlock opens and Donaldson rushes through the door and grabs the hero by the neck.\n";
            story.TypeEffect(ChanceSSTwentyone, 50);

            string ChanceSSTwentytwo = " Donaldson- “I should kill you right now! \n" +
                               " I lost a man trying to fight our way back to the fleet because of your little stunt!”\n";
            story.TypeEffect(ChanceSSTwentytwo, 50);

            string ChanceSSTwentythree = "“yeah.... should have warped”\n";
            story.TypeEffect(ChanceSSTwentythree, 50);

            string ChanceSSTwentyfour = "A man in a lab coat rounds the corner and stares at the Colonel.\n";
            story.TypeEffect(ChanceSSTwentyfour, 50);

            string ChanceSSTwentyfive = " “Colonel.. I think, at this moment, we can use just about all the friends we can get” \n";
            story.TypeEffect(ChanceSSTwentyfive, 50);

            string ChanceSSTwentysix = " * The Colonel releases his grip *, “This traitor stole my ship, Usk” points at the hero “you’re lucky I haven’t ejected you into space”\n";
            story.TypeEffect(ChanceSSTwentysix, 50);

            
            nextStory.StorySpaceStation();
        }
        public void ChanceToProxima()
        {
            string chanceProxima = "The government of Proxima has asked you to to go to Trappist, risking your ship through asteroid belt.";
            Console.WriteLine(chanceProxima);
            //RNG Result
            nextStory.StoryProxima();
        }
        public void ChanceToTrappist()
        {
            string chanceTrappist = "\nYou here some talk about a lucrative asteroid just outside Trappist on the way towards HD\nYou decide the potential is worth the visit!\n";
            Console.WriteLine(chanceTrappist);
            nextStory.StoryTrappist();
        }
        public void ChanceToHD()
        {
            string chanceHD = "\nYou found the scroll on HD in the hidden chest you stumbled over,\nit has coordinates to ancient space ship with untapped goodies. What could go wrong?!?";
            Console.WriteLine(chanceHD);
            nextStory.StoryHD();
        }
        public void ChanceToWolf()
        {
            string chanceWolf = "\nYou decided to take on the enemy planet of Wolf, on the way to Wolf you run into the moon of Wolf, named GuardDog.\nGuardDog wants to barter, for the right price you can trade for the destroyer weapon!\n";
            Console.WriteLine(chanceWolf);
            nextStory.StoryWolf();
        }
        public void ChanceToKapteyn()
        {
            string chanceKapteyn = "\nThe planet Kapteyn is a resort, but to gain access you must have the right items, otherwise you will be kicked off the planet.\n";
            Console.WriteLine(chanceKapteyn);
            nextStory.StoryKapteyn();
        }
       
      
    }
}
