using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace VoyagerProject
{
    class Story
    {
        
        public void StoryIntro()
        {
            string storyIntroOne = "\tThe year is 2020 humans have been attempting to make contact with an alien force\nthat was seen through the Voyager probe." +
                                     " Humanity has continued to push out signals\nin order to make contact however no response has been received…";
            TypeEffect(storyIntroOne, 70);
            // have text type to the screen and fade away after a specific amount of time.
            Console.Clear();

           
            string storyIntroTwo = "\nThe Story Begins with our nameless hero waking up startled to the sound of the city he lives in being destroyed by an unknown force.";
            TypeEffect(storyIntroTwo, 50);
            // Sizing(3, 4);

            string storyIntroThree = "\nThe hero throws on the closest clothes that he has and stumbles out of his apartment.";
            TypeEffect(storyIntroThree, 50);

            string storyIntroFour = "\nThe character goes into the elevator in his apartment building and hears the elevator music playing" 
                                + "while the sound of alien bombs and weapons can be heard in the background. ";
            TypeEffect(storyIntroFour, 50);

            string storyIntroFive = "\nThe elevator door opens and the hero sees a friendly military spacecraft landing directly in front of the main lobby.";
            TypeEffect(storyIntroFive, 50);

            string storyIntroSix = "\nThe hero runs to the craft, large stencil text marks the name of the ship, “Hermes”."
                                   + "The back hatch of the Hermes opens and soldiers run out of the back of the craft barking orders and charging their weapons.";
            TypeEffect(storyIntroSix, 50);

            string storyIntroSeven = "\n The hero stops one of the soldiers.The soldier turns and faces our hero the soldiers rank and name is Colonel Donaldson. Clearly a battle worn individual with a massive scar crossed his face.";
            TypeEffect(storyIntroSeven, 50);

            string storyIntroEight = "\n Colonel Donaldson yells to the hero";
            TypeEffect(storyIntroEight, 50);
            Thread.Sleep(1000);

            string storyIntroNine = "“\n What are you doing here!?”";
            TypeEffect(storyIntroNine, 0);
            Thread.Sleep(1000);

            string storyIntroTen = "“\n you have to get the hell out of the city!”";
            TypeEffect(storyIntroTen, 30);
            Thread.Sleep(1000);

            string storyIntroEleven = "“\n two blocks from here there is a Federation ship leaving the city, if self-preservation is your goal, I suggest you be on it.”";
            TypeEffect(storyIntroEleven, 40);





            Console.WriteLine("");
        }

        //private void Sizing(int v1, int v2)
        //{
        //    for (int i = 0; i < 30; i++)
        //    {
        //        Console.SetWindowSize(v1, v2);
        //        Console.SetWindowSize(v1 * (i + 1), v2 * (i + 1));


        //    }
        //}

        public void TypeEffect(string storyIntro, int sleepTime)
        {
            foreach (char a in storyIntro)
            {                
                Thread.Sleep(sleepTime);
                Console.Write(a);
            }
         
        }

        public void StorySpaceStation()
        {

        }
        public void StoryProxima()
        {

        }
        public void StoryTrappist()
        {

        }
        public void HD()
        {

        }
        public void Wolf()
        {

        }
        public void Kapteyn()
        {

        }
        public void TouCentauri()
        {

        }
        public void Earth()
        {

        }
    }
}
