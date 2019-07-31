using System;
using System.Collections.Generic;
using System.Text;

namespace VoyagerProject
{
    class Story
    {
        public void StoryIntro()
        {
            Console.WriteLine("\tThe year is humans have been attempting to make contact with an alien force\nthat was seen through the Voyager probe." +
                              " Humanity has continued to push out signals\nin order to make contact however no response has been received…");
                                // have text type to the screen and fade away after a specific amount of time.
            Console.WriteLine("The story begins with our nameless hero waking up startled to the sound of the city he lives in being destroyed by an unknown force.");
            Console.WriteLine("The character throws on the closest clothes that he has and stumbles out of his apartment.");
            Console.WriteLine("The character goes into the elevator in his apartment building and hears the elevator music playing" 
                                + "while the sound of alien bombs and weapons can be heard in the background. ");
            Console.WriteLine("The elevator door opens and the hero sees a friendly military spacecraft landing directly in front of the main lobby.");
            Console.WriteLine("The hero runs to the craft, large stencil text marks the name of the ship, “Hermes”."
                                + "The back hatch of the Hermes opens and soldiers run out of the back of the craft barking orders and charging their weapons.");
            Console.WriteLine("The hero stops one of the soldiers.The soldier turns and faces our hero the soldiers rank and name is Colonel Donaldson. Clearly a battle worn individual with a massive scar crossed his face.");
            Console.WriteLine("Colonel Donaldson yells to the hero");
            Console.WriteLine("“What are you doing here!?”");
            //break time between text
            Console.Write("“you have to get the hell out of the city!”");
            //break time
            Console.Write("“two blocks from here there is a Federation ship leaving the city, if self-preservation is your goal, I suggest you be on it.”");

            //User has choice to steal Hermes or follow Donaldson's advise.
            Console.WriteLine("What will you choose: type 1- Steal the Hermes or 2-Take Colonels advise");
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
