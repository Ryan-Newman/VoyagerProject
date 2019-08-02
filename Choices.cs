using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace VoyagerProject
{
    class Choices
    {
        public void Choice()
        {
            Game playerChoices = new Game();
            Dice dice = new Dice();

            ChoiceSpaceShip();

        }

        public void ChoiceSpaceShip()
        {
           // Console.WriteLine("What Choice will you make?");// The user will make a choice left or right // Later this project will have a selector button
            string stealShip = "Steal The Ship!";
            string takeCover = "Take Cover";
            Button(stealShip, takeCover);
            if (stealShip == "chance")
            {
                Safe safe = new Safe();
                safe.SafeToSpaceStation(); // Goes to Safe class and calls the dialogue for the safe adventure
            }
            else if (takeCover == "safe")
            {
                Chance chance = new Chance();
                //dice.RngDice(choice);
                chance.ChanceToSpaceStation();
            }
        }

        public void ChoiceProxima()
        {
            string asteroidBelt = "Press Spacebar to Push through the asteroid belt";
            string escortScientist = "Press Enter to escort the scientist";
            Button(asteroidBelt, escortScientist);
            if (asteroidBelt == "left")
            {
                Safe safe = new Safe();
                safe.SafeToProxima(); // Goes to Safe class and calls the dialogue for the safe adventure
            }
            else if (escortScientist == "right")
            {
                Chance chance = new Chance();
                //dice.RngDice(choice);
                chance.ChanceToProxima();
            }
        }

        public void ChoiceTrappist()
        {
            Console.WriteLine("What Choice will you make?");// The user will make a choice left or right // Later this project will have a selector button
            string choice = Console.ReadLine();
            if (choice == "left")
            {
                Safe safe = new Safe();
                safe.SafeToTrappist(); // Goes to Safe class and calls the dialogue for the safe adventure
            }
            else if (choice == "right")
            {
                Chance chance = new Chance();
                //dice.RngDice(choice);
                chance.ChanceToTrappist();
            }
        }

        public void ChoiceHD()
        {
            Console.WriteLine("What Choice will you make?");// The user will make a choice left or right // Later this project will have a selector button
            string choice = Console.ReadLine();
            if (choice == "left")
            {
                Safe safe = new Safe();
                safe.SafeToHD(); // Goes to Safe class and calls the dialogue for the safe adventure
            }
            else if (choice == "right")
            {
                Chance chance = new Chance();
                //dice.RngDice(choice);
                chance.ChanceToHD();
            }
        }

        public void ChoiceWolf()
        {
            Console.WriteLine("What Choice will you make?");// The user will make a choice left or right // Later this project will have a selector button
            string choice = Console.ReadLine();
            if (choice == "left")
            {
                Safe safe = new Safe();
                safe.SafeToWolf(); // Goes to Safe class and calls the dialogue for the safe adventure
            }
            else if (choice == "right")
            {
                Chance chance = new Chance();
                //dice.RngDice(choice);
                chance.ChanceToWolf();
            }
        }

        public void ChoiceKapteyn()
        {
            Console.WriteLine("What Choice will you make?");// The user will make a choice left or right // Later this project will have a selector button
            string choice = Console.ReadLine();
            if (choice == "left")
            {
                Safe safe = new Safe();
                safe.SafeToKapteyn(); // Goes to Safe class and calls the dialogue for the safe adventure
            }
            else if (choice == "right")
            {
                Chance chance = new Chance();
                //dice.RngDice(choice);
                chance.ChanceToKapteyn();
            }
        }

        public void ChoiceTouCentauri()
        {
            Console.WriteLine("What Choice will you make?");// The user will make a choice left or right // Later this project will have a selector button
            string choice = Console.ReadLine();
            if (choice == "left")
            {
                Safe safe = new Safe();
                safe.SafeToTouCentauri(); // Goes to Safe class and calls the dialogue for the safe adventure
            }
            else if (choice == "right")
            {
                Chance chance = new Chance();
                //dice.RngDice(choice);
                chance.ChanceToTouCentauri();
            }
        }

        public void ChoiceEarth()
        {
            Console.WriteLine("What Choice will you make?");// The user will make a choice left or right // Later this project will have a selector button
            string choice = Console.ReadLine();
            if (choice == "left")
            {
                Safe safe = new Safe();
                safe.SafeToEarth(); // Goes to Safe class and calls the dialogue for the safe adventure
            }
            else if (choice == "right")
            {
                Chance chance = new Chance();
                //dice.RngDice(choice);
                chance.ChanceToEarth();
            }
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
                        Console.BackgroundColor = ConsoleColor.Blue;
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
                    
                    Thread.Sleep(1000);
                    Safe safe = new Safe();
                    safe.SafeToSpaceStation(); // Goes to Safe class and calls the dialogue for the safe adventure
                }
                else if (ckey.Key == ConsoleKey.Enter && menu[index] == chanceButton) //!!! Make Enter do the selection !!!
                {
                    
                    Thread.Sleep(1000);
                    Chance chance = new Chance();
                    //dice.RngDice(choice);
                    chance.ChanceToSpaceStation();
                }


                Console.Clear(); // !!!Bug!!! Erases the former text line
            } while (ckey.Key != ConsoleKey.Escape);
        }


    }
}
        