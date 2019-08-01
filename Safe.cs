using System;
using System.Collections.Generic;
using System.Text;

namespace VoyagerProject
{
    class Safe
    {
        Story nextStory = new Story();

        public void SafeToSpaceStation()
        {            
            string safeSpaceStation = "Dummy Text SpaceStation";
            Console.WriteLine(safeSpaceStation);
            nextStory.StoryProxima();
        }
        public void SafeToProxima()
        {
            string safeToProxima = "Dummy Text Proxima";
            Console.WriteLine(safeToProxima);
            nextStory.StoryTrappist();
        }
        public void SafeToTrappist()
        {
            string safeToTrappist = "Dummy Text Trappist";
            Console.WriteLine(safeToTrappist);
            nextStory.StoryHD();
        }
        public void SafeToHD()
        {
            string safeToHD = "Dummy Text Trappist";
            Console.WriteLine(safeToHD);
            nextStory.StoryWolf();
        }
        public void SafeToWolf()
        {
            string safeToWolf = "Dummy Text Trappist";
            Console.WriteLine(safeToWolf);
            nextStory.StoryKapteyn();
        }
        public void SafeToKapteyn()
        {
            string safeToKapteyn = "Dummy Text Kapteyn";
            Console.WriteLine(safeToKapteyn);
            nextStory.StoryTouCentauri();
        }
        public void SafeToTouCentauri()
        {
            string safeToTouCentauri = "Dummy Text TouCentauri";
            Console.WriteLine(safeToTouCentauri);
            nextStory.StoryEarth();
        }
        public void SafeToEarth()
        {
            string safeToEarth = "Home will never be the same again!";
            Console.WriteLine(safeToEarth);
        }
    }
}
