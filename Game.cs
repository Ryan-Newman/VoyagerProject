using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace VoyagerProject
{
    class Game
    {
        public void GameStart()
        {
            Story intro = new Story();
            intro.StoryIntro();
            Choices firstPath = new Choices();
            firstPath.Choice();
        }
       
       
    }
}
