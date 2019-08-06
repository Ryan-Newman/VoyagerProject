using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace VoyagerProject
{
    class Story
    {
        Choices storyChoice = new Choices();
        Planet pStories = new Planet();
        public void TypeEffect(string storyIntro, int sleepTime)
        {
            foreach (char a in storyIntro)
            {
                    Thread.Sleep(sleepTime);
                    Console.Write(a);                
            }
           
        }
        
        public void StoryIntro()
        {
            string storyIntroOne = "\tThe year is 2020 humans have been attempting to make contact with an alien force\nthat was seen through the Voyager probe." +
                                     " Humanity has continued to push out signals\nin order to make contact however no response has been received…";
            TypeEffect(storyIntroOne, 1);
            // have text type to the screen and fade away after a specific amount of time.
            Console.Clear();


            string storyIntroTwo = "\nThe Story Begins with our nameless hero waking up\n startled to the sound of the city he lives in being destroyed by an unknown force.";
            TypeEffect(storyIntroTwo, 1);
            // Sizing(3, 4);

            string storyIntroThree = "\nThe hero throws on the closest clothes that he has and stumbles out of his apartment.";
            TypeEffect(storyIntroThree, 1);

            string storyIntroFour = "\nThe character goes into the elevator in his apartment building and hears the elevator music playing"
                                + "while the sound of alien bombs and weapons can be heard in the background. ";
            TypeEffect(storyIntroFour, 1);

            string storyIntroFive = "\nThe elevator door opens and the hero sees a friendly military spacecraft landing directly in front of the main lobby.";
            TypeEffect(storyIntroFive, 1);

            string storyIntroSix = "\nThe hero runs to the craft, large stencil text marks the name of the ship, “Hermes”.\n"
                                   + "The back hatch of the Hermes opens and soldiers run out of the back of the craft barking orders and charging their weapons.";
            TypeEffect(storyIntroSix, 1);

            string storyIntroSeven = "\n The hero stops one of the soldiers.The soldier turns and faces our hero the soldiers rank and name is Colonel Donaldson.\nClearly a battle worn individual with a massive scar crossed his face.";
            TypeEffect(storyIntroSeven, 1);

            string storyIntroEight = "\n Colonel Donaldson yells to the hero";
            TypeEffect(storyIntroEight, 1);
            Thread.Sleep(1000);

            string storyIntroNine = "“\n What are you doing here!?”\n";
            TypeEffect(storyIntroNine, 1);
            Thread.Sleep(1000);

            string storyIntroTen = "“\n you have to get the hell out of the city!\n”";
            TypeEffect(storyIntroTen, 30);
            Thread.Sleep(1000);

            string storyIntroEleven = "“\n two blocks from here there is a Federation ship leaving the city, if self-preservation is your goal, I suggest you be on it.”\n";
            TypeEffect(storyIntroEleven, 40);
                       
            storyChoice.ChoiceSpaceShip();
        }     

        public void StorySpaceStation()
        {

            string storySpaceStation = "\nYou are at the spacestation!\n";
            TypeEffect(storySpaceStation, 30);

            //string storySpaceStationOne = "*Door opens*";
            //TypeEffect(storySpaceStationOne, 50);

            //string storySpaceStationTwo = "Donaldson-“Come with us.”";
            //TypeEffect(storySpaceStationTwo, 50);

            //string storySpaceStationThree = "*The hero stands up and begins walking alongside Dr. Usk and Colonel Donaldson.*";
            //TypeEffect(storySpaceStationThree, 50);

            //string storySpaceStationFour = "Usk- “Tell me, have you ever piloted a Spacecraft before?”";
            //TypeEffect(storySpaceStationFour, 50);

            //string storySpaceStationFive = "Hero-“ I was a pilo… ”";
            //TypeEffect(storySpaceStationFive, 50);

            //string storySpaceStationSix = "Donaldson- “Cut to the chase, we ran the ID we found in your neural lace. You were a fighter pilot callsign Voyager”";
            //TypeEffect(storySpaceStationSix, 50);

            //string storySpaceStationSeven = "Hero- “Why does any of this matter?”";
            //TypeEffect(storySpaceStationSeven, 50);

            //string storySpaceStationEight = "Donaldson- “It matters because as a species we have a serious problem on our hands and you as Usk so eloquently put it, “are a creature of opportunity””";
            //TypeEffect(storySpaceStationEight, 50);

            //string storySpaceStationNine = "Usk- “What the colonel is trying to say is, we need your help.”";
            //TypeEffect(storySpaceStationNine, 50);

            //string storySpaceStationTen = "Usk- “10 minutes after the initial invasion Kurop enemy forces began targeting all military installations globally with weapons that we have not seen before. ” ";
            //TypeEffect(storySpaceStationTen, 50);

            //string storySpaceStationEleven = "Donaldson- “The force is scattered to the winds and besides myself you’re one of few remaining fighter pilots we have contact with.”";
            //TypeEffect(storySpaceStationEleven, 50);

            //string storySpaceStationTwelve = "“……….”";
            //TypeEffect(storySpaceStationTwelve, 50);

            //string storySpaceStationThirteen = "Hero- “What do you need me to do?”";
            //TypeEffect(storySpaceStationThirteen, 50);

            //string storySpaceStationFourteen = "Donaldson –“The Kurops have EMP weapons that are capable of chewing right through our shielding our coms with the other colonies has been DOA for the past 8 hours”";
            //TypeEffect(storySpaceStationFourteen, 50);

            //string storySpaceStationFifteen = "Usk- “We need you to travel to the outer colonies spread the word of Earth’s invasion, enlist all the help you can and retrieve the supplies necessary to make a Havok tactical nuclear device.”";
            //TypeEffect(storySpaceStationFifteen, 50);

            //string storySpaceStationSixteen = "Hero- “You know this will take me years, even with the warp technology we have”";
            //TypeEffect(storySpaceStationSixteen, 50);

            //string storySpaceStationSeventeen = "Usk- “The technology you know of… “";
            //TypeEffect(storySpaceStationSeventeen, 50);

            //string storySpaceStationEighteen = "Usk- “We are outfitting the craft you arrived on with the newest propulsion technology. One of your many Compensations will be age reversal therapy to the youngest age you wish upon your return.”";
            //TypeEffect(storySpaceStationEighteen, 50);

            //string storySpaceStationNineteen = "Hero- “When will my ship be ready?”";
            //TypeEffect(storySpaceStationNineteen, 50);

            //string storySpaceStationTwenty = "*Donaldson and Usk in unison*- “Now.”";
            //TypeEffect(storySpaceStationTwenty, 50);

            //string storySpaceStationTwentyone = "“………”";
            //TypeEffect(storySpaceStationTwentyone, 50);

            //string storySpaceStationTwentytwo = "*The hero makes his way to the Spacecraft*";
            //TypeEffect(storySpaceStationTwentytwo, 50);

            //string storySpaceStationTwentythree = "*Men load valuable cargo and supplies into the cargo bay*";
            //TypeEffect(storySpaceStationTwentythree, 50);

            //string storySpaceStationTwentyfour = "*Usk approaches*";
            //TypeEffect(storySpaceStationTwentyfour, 50);

            //string storySpaceStationTwentyfive = "Usk- “Supplies are distributed and we have given you assets to trade with the outer colonies in order to make purchases and enlist help. Your first stop will be the Proxima Centauri system.”";
            //TypeEffect(storySpaceStationTwentyfive, 50);

            //string storySpaceStationTwentysix = "*Usk hands the hero a helmet*";
            //TypeEffect(storySpaceStationTwentysix, 50);

            //string storySpaceStationTwentyseven = "Usk- “We will be with you throughout your journey”";
            //TypeEffect(storySpaceStationTwentyseven, 50);

            //string storySpaceStationTwentyEight = "*The hero shakes Usk’s hand and makes his way onto the craft*";
            //TypeEffect(storySpaceStationTwentyEight, 50);

            //string storySpaceStationTwentynine = "*The hero puts the helmet on, the coms crackle on with the Colonels voice*";
            //TypeEffect(storySpaceStationTwentynine, 50);

            //string storySpaceStationThirty = "Donaldson-“God speed Voyager”";
            //TypeEffect(storySpaceStationThirty, 50);

            //string storySpaceStationThirtyone = "“…………””";
            //TypeEffect(storySpaceStationThirtyone, 50);
            //Console.Clear();

            //string storySpaceStationThirtytwo = "It has been two days since the Voyager departed the Icarus. \n " +
            //                                    "preparing the ship and acclimating to cryosleep the Voyager is now ready to travel.”";
            //TypeEffect(storySpaceStationThirtytwo, 50);

            //string storySpaceStationThirtythree = "Voyager- “Usk? How fast can I get to Proxima Centauri? ”";
            //TypeEffect(storySpaceStationThirtythree, 50);

            //string storySpaceStationThirtyfour = "Usk- “With the current propulsion device we installed on your craft you will be able to consistently travel at 1.4 Warp Factor.\n" +
            //                                     " This is assuming the devise is not damaged and is operating at 100% capacity. It is imperative that you take care of the ships engine \n" +
            //                                     " one wrong move could drop the propulsion devices efficiency and have you traveling through space your entire life. \n " +
            //                                     "You need to return to us before you reach the age of 60. Once you reach 60 we will no longer be able to reverse the aging process. ”";
            //TypeEffect(storySpaceStationThirtyfour, 50);

            //string storySpaceStationThirtyfive = "*distress beacon begins ringing*";
            //TypeEffect(storySpaceStationThirtyfive, 50);

            //string storySpaceStationThirtysix = "Voyager- “I’m picking up a distress beacon should I go and check it out? \n " +
            //                                     "There may be free loot and someone to help or should I stay on course?”";
            //TypeEffect(storySpaceStationThirtysix, 50);

            //Choice is given to go to distress beacon or remain on course 

            pStories.PlanetStory(storySpaceStation);
            storyChoice.ChoiceSpaceStation();
        }
        public void StoryProxima()
        {
            string storyProxima = "You are at Proxima!";
            pStories.PlanetStory(storyProxima);
            pStories.InGameItems(3, 250, 70, 100, 100);
            pStories.PlanetDistance(39.72);
            storyChoice.ChoiceProxima();
        }
        public void StoryTrappist()
        {
            string storyTrappist = "You are at Trappist!";
            Console.WriteLine(storyTrappist);
            pStories.InGameItems(3, 250, 70, 100, 100);
            pStories.PlanetDistance(44.18);
            storyChoice.ChoiceTrappist();
        }
        public void StoryHD()
        {
            string storyHD = "You are at HD!";
            pStories.PlanetStory(storyHD);
            pStories.InGameItems(3, 250, 70, 100, 100);
            pStories.PlanetDistance(23.44);
            storyChoice.ChoiceHD();
        }
        public void StoryWolf()
        {
            string storyWolf = "You are at Wolf! HowHowHowllllll!";
            pStories.PlanetStory(storyWolf);
            pStories.InGameItems(3, 250, 70, 100, 100);
            pStories.PlanetDistance(18.97);
            storyChoice.ChoiceWolf();
        }
        public void StoryKapteyn()
        {
            string storyKapteyn = "You are on Kapteyn, cheif!";
            pStories.PlanetStory(storyKapteyn);
            pStories.InGameItems(3, 250, 70, 100, 100);
            pStories.PlanetDistance(12.8);
            storyChoice.ChoiceKapteyn(); 
        }
        
      

    }
}
