﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace VoyagerProject
{
    class Safe
    {
        Story nextStory = new Story();

        public void CallSafe(string safeNext)
        {
            Player sPlayer = new Player();
            switch (safeNext)

            {
                case "Take Cover":
                    SafeToSpaceStation();
                    break;
                case "Travel directly to Proxima":
                    SafeToProxima();
                    sPlayer.SafeWarp(4.2);
                    break;
                case "Escort the scientist":
                    SafeToTrappist();
                    sPlayer.SafeWarp(4.2);
                    break;
                case "Travel HD":
                    SafeToHD();
                    break;
                case "Safe path to Wolf":
                    SafeToWolf();
                    break;
                case "Safe path to Kapteyn":
                    SafeToKapteyn();
                    break;               
                //case "Safe path to Earth":
                //    SafeToEarth();
                //    break;
               
            }
        }

        public void SafeToSpaceStation()
        {
            string SafeSSOne = " hero- “Roger that Colonel, thank you” ";
            nextStory.TypeEffect(SafeSSOne, 50);

            string SafeSSTwo = " Donaldson- “Don’t thank me just run!”";
            nextStory.TypeEffect(SafeSSTwo, 50);

            string SafeSSThree = " Not a moment later a glowing ball lands next to our hero and Donaldson and \n " +
                                  "detonates on impact.";
            nextStory.TypeEffect(SafeSSThree, 50);
            Thread.Sleep(1);
            Console.Clear();

            string SafeSSFour = "......";
            nextStory.TypeEffect(SafeSSFour, 50);

            string SafeSSFive = " The hero wakes up in the back of a humvee. A shell casing falls down the hero’s shirt  ";
            nextStory.TypeEffect(SafeSSFive, 50);

            string SafeSSSix = " The hero panics trying to let the casing fall through.";
            nextStory.TypeEffect(SafeSSSix, 50);

            string SafeSSSeven = " * Hero thinks * “well, I am up now!”";
            nextStory.TypeEffect(SafeSSSeven, 50);

            string SafeSSEight = " * Colonel Donaldson looks back at the hero * \n " +
                                   "“Glad to see you’re still alive” if you want to keep it that way take this \n \n " +
                                   "*hands the hero a rifle* \n " +
                                   " start lighting up anything with more than two eyes!";
            nextStory.TypeEffect(SafeSSEight, 50);

            string SafeSSNine = "* Hero Thinks * “At least my conscription if finally paying off.”";
            nextStory.TypeEffect(SafeSSNine, 50);

            string SafeSSTen = " The hero charges the weapon and begins firing ";
            nextStory.TypeEffect(SafeSSTen, 50);

            string SafeSSEleven = " * The invaders were massive and had multiple sets of eyes wrapping from temples to their brows, \n" +
                                    " but their anatomy didn’t differ much from ours. \n" +
                                    " They appeared opaque, covered with an body armor that armor piercing rounds were unable to penetrate. ";
            nextStory.TypeEffect(SafeSSEleven, 50);

            string SafeSSTwelve = " The hero looks at the glowing barrel on the Humvees turret.. Better not let up.";
            nextStory.TypeEffect(SafeSSTwelve, 50);

            string SafeSSThirteen = "Donaldson – “Alright its gonna get a bit bumpy, we are only 6 mins out from the airfield!”";
            nextStory.TypeEffect(SafeSSThirteen, 50);

            string SafeSSFourteen = "Donaldson-“Satellite imagery shows that this area is crawling with Kurops”";
            nextStory.TypeEffect(SafeSSFourteen, 50);

            string SafeSSFifteen = " hero- “Kurops”?";
            nextStory.TypeEffect(SafeSSFifteen, 50);

            string SafeSSSixteen = "Donaldson- “you know…The things your killing”";
            nextStory.TypeEffect(SafeSSSixteen, 50);

            string SafeSSSeventeen = "* The machine gun stops spooling… *";
            nextStory.TypeEffect(SafeSSSeventeen, 50);

            string SafeSSEighteen = "...The hero looks and finds the gunner KIA ";
            nextStory.TypeEffect(SafeSSEighteen, 50);

            string SafeSSNineteen = "Donaldson – “Get that gun back up!”";
            nextStory.TypeEffect(SafeSSNineteen, 50);

            string SafeSSTwenty = "The hero move the gunners body to the side and gets behind the gun.";
            nextStory.TypeEffect(SafeSSTwenty, 50);

            string SafeSSTwentyOne = "Donaldson - “Switch that gun to Gauss were about to hit the airfield!”";
            nextStory.TypeEffect(SafeSSTwentyOne, 50);


            string SafeSSTwentytwo = "Hero thinks- “I’ve never used the Gauss cannon before is it the red or green button?” ";
            nextStory.TypeEffect(SafeSSTwentytwo, 50);
            // give the player a choice that will be correct regardless

            string SafeSSTwentythree = "Donaldson –“We’ve got to catch that ship!”";
            nextStory.TypeEffect(SafeSSTwentythree, 50);


            string SafeSSTwentyfour = "The hero sees a massive ship in the distance beginning its departure procedures with the bay ramp still open.";
            nextStory.TypeEffect(SafeSSTwentyfour, 50);


            string SafeSSTwentyfive = "The Humvee engine roars as the governor kicks in ";
            nextStory.TypeEffect(SafeSSTwentyfive, 50);


            string SafeSSTwentysix = "Donaldson- “Come on! Faster!”";
            nextStory.TypeEffect(SafeSSTwentysix, 50);


            string SafeSSTwentyseven = " * The shuttle engines begin to glow brighter. *";
            nextStory.TypeEffect(SafeSSTwentyseven, 50);


            string SafeSSTwentyeight = "Donaldson - “Come on! We can make it!”";
            nextStory.TypeEffect(SafeSSTwentyeight, 50);


            string SafeSSTwentynine = "* Hero thinks * “we arnt gonna make it” ";
            nextStory.TypeEffect(SafeSSTwentynine, 50);


            string SafeSSThirty = " * The shuttle begins to raise the bay ramp and the engines begin to grow brighter bring the shuttle to a hover. *";
            nextStory.TypeEffect(SafeSSThirty, 50);


            string SafeSSThirtyone = "The Vehicle diagnostic chimes on..\n" +
                                     " * Caution Engine Temperature, Caution Engine Temperature, Caution Engine Temperature *";
            nextStory.TypeEffect(SafeSSThirtyone, 50);


            string SafeSSThirtytwo = "* Donaldson wedges his rifle between the gas pedal and the seat and begins making his way onto the hood of the Humvee. *";
            nextStory.TypeEffect(SafeSSThirtytwo, 50);


            string SafeSSThirtythree = "Donaldson- “This is the only way were making it on!… We have to jump!”";
            nextStory.TypeEffect(SafeSSThirtythree, 50);


            string SafeSSThirtyfour = "* The hero presses himself out of the turret and onto the roof of the Humvee. * ";
            nextStory.TypeEffect(SafeSSThirtyfour, 50);


            string SafeSSThirtyfive = "The door to the shuttle begins rising faster";
            nextStory.TypeEffect(SafeSSThirtyfive, 50);


            string SafeSSThirtysix = "Donaldson- “ On my mark!”";
            nextStory.TypeEffect(SafeSSThirtysix, 50);


            string SafeSSThirtyseven = "* The Humvee Barrels towards the shuttle the rear bay continues to close * ";
            nextStory.TypeEffect(SafeSSThirtyseven, 50);


            string SafeSSThirtyeight = "Donaldson- “3…..2……1..JUMP!”";
            nextStory.TypeEffect(SafeSSThirtyeight, 50);
            Console.Clear();

            string SafeSSThirtynine = "......";
            nextStory.TypeEffect(SafeSSThirtynine, 50);


            string SafeSSFourty = " * The hero wakes up in what appears to be a hospital bed. *";
            nextStory.TypeEffect(SafeSSFourty, 50);


            string SafeSSFourtyone = "* Donaldson is standing at the foot of the bed. *";
            nextStory.TypeEffect(SafeSSFourtyone, 50);


            string SafeSSFourtytwo = "Donaldson-  “Glad to see you’re still alive” if you want to keep it that way take these\n" +
                                     " *hands hero a handful of pills*";
            nextStory.TypeEffect(SafeSSFourtytwo, 50);


            string SafeSSFourtythree = " * A man in a lab coat enters his ID says, \"Usk\" *";
            nextStory.TypeEffect(SafeSSFourtythree, 50);


            string SafeSSFourtyfour = "“Colonel you sure do know how to make an entrance ”";
            nextStory.TypeEffect(SafeSSFourtyfour, 50);


            string SafeSSFourtyfive = " * Usk looks at the hero. *";
            nextStory.TypeEffect(SafeSSFourtyfive, 50);


            string SafeSSFourtysix = "Usk- “Where did you come from?” ";
            nextStory.TypeEffect(SafeSSFourtysix, 50);


            string SafeSSFourtyseven = "* Donaldson cuts the hero off *  “Out of the city, Usk. Helped me shoot my way out and get back to the Space Station.” ";
            nextStory.TypeEffect(SafeSSFourtyseven, 50);


            string SafeSSFourtyeight = " Usk approaches, “ a creature of opportunity…” \"  * looks to Donaldson *  “Colonel may I speak with you?\"";
            nextStory.TypeEffect(SafeSSFourtyeight, 50);


            string SafeSSFourtynine = " The two leave the room.";
            nextStory.TypeEffect(SafeSSFourtynine, 50);
            Console.Clear();

            string SafeSSFifty = "........";
            nextStory.TypeEffect(SafeSSFifty, 50);
            nextStory.StorySpaceStation();


        }
        public void SafeToProxima()
        {
            string safeToProxima = "\nAfter speaking with the governer, a scientist approaches you on the side, and asks you to try out her prototype sheild.\n";
            Console.WriteLine(safeToProxima);
            nextStory.StoryProxima();
        }
        public void SafeToTrappist()
        {
            string safeToTrappist = "\nYou are at Trappist, the planet of pure barter. Good or Evil, doesn't matter on Trappist, they just want to do some business!\n";
            Console.WriteLine(safeToTrappist);
            nextStory.StoryTrappist();
        }
        public void SafeToHD()
        {
            string safeToHD = "Dummy Text Trappist";
            Console.WriteLine(safeToHD);
            nextStory.StoryHD();
        }
        public void SafeToWolf()
        {
            string safeToWolf = "Dummy Text Trappist";
            Console.WriteLine(safeToWolf);
            nextStory.StoryWolf();
        }
        public void SafeToKapteyn()
        {
            string safeToKapteyn = "Dummy Text Kapteyn";
            Console.WriteLine(safeToKapteyn);
            nextStory.StoryKapteyn();
        }
       
       
    }
}
