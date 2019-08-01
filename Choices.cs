using System;
using System.Collections.Generic;
using System.Text;

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
            Console.WriteLine("What Choice will you make?");// The user will make a choice left or right // Later this project will have a selector button
            string choice = Console.ReadLine();
            if (choice == "left")
            {
                Safe safe = new Safe();
                safe.SafeToProxima(); // Goes to Safe class and calls the dialogue for the safe adventure
            }
            else if (choice == "right")
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

                }

                ckey = Console.ReadKey();

                if (ckey.Key == ConsoleKey.DownArrow)
                {
                    if (index == menu.Length - 1)
                    {
                        index = 0;
                    }
                }
                else
                {
                    index++;
                }

                if (ckey.Key == ConsoleKey.UpArrow)
                {
                    if (index <= 0)
                    {
                        index = menu.Length - 1;
                    }
                }
                
                if(ckey.Key == ConsoleKey.Enter && index == 0)
                    {
                        Safe safe = new Safe();
                        safe.SafeToSpaceStation(); // Goes to Safe class and calls the dialogue for the safe adventure
                    }
                else if(ckey.Key == ConsoleKey.Enter && index > 0)
                    {
                        Chance chance = new Chance();
                        //dice.RngDice(choice);
                        chance.ChanceToSpaceStation();
                    }
                    else
                    { index--; }

                Console.Clear(); // !!!Bug!!! Erases the former text line
            } while (ckey.Key != ConsoleKey.Escape);
        }


    }
}
            //Console.Clear();
            //Boolean running = true;
            //Console.CursorVisible = false;
            //int select = 0;
            //List<Tuple<int, int, string, Boolean>> options = new List<Tuple<int, int, string, Boolean>>
            //{
            //    new Tuple<int,int,string,Boolean>(0,0,chanceButton,true),
            //    new Tuple<int,int,string,Boolean>(0,1,safeButton,false),
            //};
            //while (running == true)
            //{
            //    foreach(Tuple<int,int,string,Boolean> tupe in options)
            //    {
            //        if (tupe.Item4 == true)
            //        {
            //            select = options.FindIndex(t => tupe.Item3 == tupe.Item3);
            //            Console.SetCursorPosition(tupe.Item1, tupe.Item2);
            //            Console.ForegroundColor = ConsoleColor.Black;
            //            Console.BackgroundColor = ConsoleColor.White;
            //            Console.Write(tupe.Item3);

            //        }
            //        else if(tupe.Item4 == false)
            //        {
            //            Console.SetCursorPosition(tupe.Item1, tupe.Item2);
            //            Console.ForegroundColor = ConsoleColor.White;
            //            Console.BackgroundColor = ConsoleColor.Black;
            //            Console.Write(tupe.Item3);
            //        }
            //    }
            //    Console.SetCursorPosition(options[0].Item1, options[0].Item2);
            //    Console.ForegroundColor = ConsoleColor.White;
            //    Console.BackgroundColor = ConsoleColor.Black;
            //    Console.Write("");

            //    string input = Console.ReadKey().Key.ToString();
            //    if (input == "LeftArrow" && select > 0)
            //    {
            //        options[select] = new Tuple<int, int, string, bool>(options[select].Item1, options[select].Item2, options[select].Item3, false);
            //        select -= 1;
            //        options[select] = new Tuple<int, int, string, bool>(options[select].Item1, options[select].Item2, options[select].Item3, true);
            //    }
            //    else if (input == "LeftArrow" && select == 0)
            //    {
            //        options[select] = new Tuple<int, int, string, bool>(options[select].Item1, options[select].Item2, options[select].Item3, false);
            //        select += 1;
            //        options[select] = new Tuple<int, int, string, bool>(options[select].Item1, options[select].Item2, options[select].Item3, true);

            //    }
            //    if (input == "RightArrow" && select < 1)
            //    {
            //        options[select] = new Tuple<int, int, string, bool>(options[select].Item1, options[select].Item2, options[select].Item3, false);
            //        select += 1;
            //        options[select] = new Tuple<int, int, string, bool>(options[select].Item1, options[select].Item2, options[select].Item3, true);
            //    }
            //    else if (input == "RightArrow" && select == 1)
            //    {
            //        options[select] = new Tuple<int, int, string, bool>(options[select].Item1, options[select].Item2, options[select].Item3, false);
            //        select -= 1;
            //        options[select] = new Tuple<int, int, string, bool>(options[select].Item1, options[select].Item2, options[select].Item3, true);

            //    }
            //    if (input == "Enter" && select == 0)
            //    {
            //        chanceButton = "CHANCE";
                   
                    
            //    }
            //    if (input == "Enter" && select == 1)
            //    {
            //        safeButton = "SAFE";
                   
            //    }
