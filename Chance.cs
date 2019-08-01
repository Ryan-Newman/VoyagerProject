using System;
using System.Collections.Generic;
using System.Text;

namespace VoyagerProject
{
    class Chance
    {
        Story nextStory = new Story();
        public void ChanceToSpaceStation()
        {

            Console.WriteLine("Hero watches as Colonel Donaldson and his men run towards the sound of battle.");
            Console.WriteLine("Hero thinks- “I doubt the Colonel will mind if I borrow the Hermes”");
            Console.WriteLine(" * enters the rear hatch and moves quickly to the cockpit.");
            Console.WriteLine(" Shaking from adrenaline the hero tries to get the ship off the ground, but is it the red button or green switch? ");
            //artificial choice both buttons will strat the craft.
            Console.WriteLine("* The ship begins hovering.");
            Console.WriteLine(" Hero thinks- “At least my Conscription if finally paying off. ”");
            Console.WriteLine(" The hero points the ship to the sky and launches. ");
            Console.WriteLine(".....");
            Console.WriteLine(" A familiar voice comes over the radio ");
            Console.WriteLine(" After traveling for an hour the radio begins to crackle with life.");
            Console.WriteLine("Donaldson- “You son of * fizz fizzzzz * I tell you how to save yourself and you steal *fizz fizzzzz* ship to thank me?! ”");
            nextStory.StoryProxima();

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
            nextStory.StoryTouCentauri();
        }
        public void ChanceToTouCentauri()
        {
            string chanceTouCentauri = "Dummy text TouCentauri chance";
            Console.WriteLine(chanceTouCentauri);
            nextStory.StoryEarth();
        }
        public void ChanceToEarth()
        {
            string chanceEarth = "There's No Place Like Home!";
            Console.WriteLine(chanceEarth);
        }
    }
}
