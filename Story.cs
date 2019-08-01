using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace VoyagerProject
{
    class Story
    {
        Choices storyChoice = new Choices();
        private void TypeEffect(string storyIntro, int sleepTime)
        {
            foreach (char a in storyIntro)
            {
                    Thread.Sleep(sleepTime);
                    Console.Write(a);                
            }
           
        }
        
        public void StoryIntro()
        {
            string storyIntroOne = "\tThe year is humans have been attempting to make contact with an alien force\nthat was seen through the Voyager probe." +
                              " Humanity has continued to push out signals\nin order to make contact however no response has been received…";
            TypeEffect(storyIntroOne, 1);
            // have text type to the screen and fade away after a specific amount of time.
           
            string storyIntroTwo = "\nThe Story Begins with our nameless hero waking up startled to the sound of the city he lives in being destroyed by an unknown force.";
            TypeEffect(storyIntroTwo, 1);
           // Sizing(3, 4);
            string storyIntroThree = "\nThe character throws on the closest clothes that he has and stumbles out of his apartment.";
            TypeEffect(storyIntroThree, 2);
            string storyIntroFour = "\nThe character goes into the elevator in his apartment building and hears the elevator music playing" 
                                + "while the sound of alien bombs and weapons can be heard in the background. ";
            
            TypeEffect(storyIntroFour,5);
            string storyIntroFive = "\nThe elevator door opens and the hero sees a friendly military spacecraft landing directly in front of the main lobby.";
            TypeEffect(storyIntroFive, 3);
            string storyIntroSix = "\nThe hero runs to the craft, large stencil text marks the name of the ship, “Hermes”."
                 + "The back hatch of the Hermes opens and soldiers run out of the back of the craft barking orders and charging their weapons.";
            TypeEffect(storyIntroSix, 3);
           
            storyChoice.Choice(); //Goes to Choices class and prompts to go left or right
            
        }

        public void StorySpaceStation()
        {

            string storySpaceStation = "You are at the spacestation!";
            Console.WriteLine(storySpaceStation);
            storyChoice.ChoiceSpaceShip();
        }
        public void StoryProxima()
        {
            string storyProxima = "You are at Centauri Proxima!";
            Console.WriteLine(storyProxima);
            storyChoice.ChoiceProxima();
        }
        public void StoryTrappist()
        {
            string storyTrappist = "You are at Trappist!";
            Console.WriteLine(storyTrappist);
            storyChoice.ChoiceTrappist();
        }
        public void StoryHD()
        {
            string storyHD = "You are at HD!";
            Console.WriteLine(storyHD);
            storyChoice.ChoiceHD();
        }
        public void StoryWolf()
        {
            string storyWolf = "You are at Wolf! HowHowHowllllll!";
            Console.WriteLine(storyWolf);
            storyChoice.ChoiceWolf();
        }
        public void StoryKapteyn()
        {
            string storyKapteyn = "You are on Kapteyn, cheif!";
            Console.WriteLine(storyKapteyn);
            storyChoice.ChoiceKapteyn();
        }
        public void StoryTouCentauri()
        {
            string storyTouCentauri = "You are on Tou Centauri!";
            Console.WriteLine(storyTouCentauri);
            storyChoice.ChoiceTouCentauri();
        }
        public void StoryEarth()
        {
            string storyEarth = "Welcome Home!";
            Console.WriteLine(storyEarth);
           // storyChoice.ChoiceEarth();
        }
    }
}
