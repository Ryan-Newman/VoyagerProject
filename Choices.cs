using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

 
namespace VoyagerProject
{
    class Choices
    {
        public  void ClearLine() // deletes the last writeline 
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }
        public void Choice()
        {
            Game playerChoices = new Game();
            Game dice = new Game();

            ChoiceSpaceShip();

        }

        public void ChoiceSpaceShip()
        {
            string stealShip = "Steal The Ship!";
            string takeCover = "Take Cover";
            Button(stealShip, takeCover);
        }

        public void ChoiceSpaceStation()
        {
            string distressCall = "Answer the distress call";
            string travelToProxima = "Travel directly to Proxima";
            Button(distressCall, travelToProxima);           
        }

        public void ChoiceProxima()
        {
            string asteroidBelt = "Push through the asteroid belt";
            string escortScientist = "Escort the scientist";
            Button(asteroidBelt, escortScientist);
            
        }

        public void ChoiceTrappist()
        {
            string chancePathHD = "Investigate abandoned mine on asteroid";
            string safePathHD = "Travel HD";
            Button(chancePathHD, safePathHD);
        }

        public void ChoiceHD()
        {
            string chancePathWolf = "Chance path to Wolf";
            string safePathWolf = "Safe path to Wolf";
            Button(chancePathWolf, safePathWolf);
        }

        public void ChoiceWolf()
        {
            string chancePathKapteyn = "Chance path to Kapteyn";
            string safePathKapteyn = "Safe path to Kapteyn";
            Button(chancePathKapteyn, safePathKapteyn);
        }

        public void ChoiceKapteyn()
        {
            Game game = new Game();
            game.GameEnd();
          
        }               

       

        public void Button(string chanceButton, string safeButton)
        {
            int index = 0;

            string[] menu = new string[] { chanceButton, safeButton };

            ConsoleKeyInfo ckey;
            string selection;
            Console.CursorVisible = false;
            do
            {
                for (int i = 0; i < menu.Length; i++)
                {
                    if (i == index)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine(menu[i]);
                    }

                    else
                    {
                        Console.WriteLine(menu[i]);
                    }
                    Console.ResetColor();
                        selection = menu[i];

                }

                ckey = Console.ReadKey();

                if (ckey.Key == ConsoleKey.DownArrow)
                {
                    if (index == menu.Length - 1)
                    {
                        index = 0;
                       // Console.BackgroundColor = ConsoleColor.Blue;
                    }

                    else
                    {
                        index++;
                       
                    }
                }

                 if (ckey.Key == ConsoleKey.UpArrow)
                {
                    if (index == 0)
                    {
                        index = menu.Length - 1;
                        
                    }
                    else
                    {
                        index--;
                    }
                }
                if(ckey.Key == ConsoleKey.Enter && menu[index]  == safeButton)
                {                  
                    Safe safe = new Safe();
                    safe.CallSafe(safeButton); // Goes to Safe class and calls the dialogue for the safe adventure
                }
                else if (ckey.Key == ConsoleKey.Enter && menu[index] == chanceButton) 
                {
                    //for(int i = 0; i < 3; i++) // Commented out so the screen size remains the same throughout the entire game.!!!!!!!!!!!!!!!!!!!!John
                    //{
                    //    Console.SetWindowSize(1,1);
                    //    Thread.Sleep(50);
                    //    Console.SetWindowSize(100, 25);
                    //}
                    Chance chance = new Chance();
                    Planet dice = new Planet();
                   // dice.RngDice();
                    chance.CallChance(chanceButton);
                   
                }


                ClearLine() ;
            } while (ckey.Key != ConsoleKey.Escape);
        }


    }
}
        