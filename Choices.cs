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
            Console.WriteLine("What Choice will you make?");// The user will make a choice left or right // Later this project will have a selector button
            string choice = Console.ReadLine();
            if (choice == "left")
            {
                Safe safe = new Safe();
                safe.SafeToSpaceStation(); // Goes to Safe class and calls the dialogue for the safe adventure
            }
            else if (choice == "right")
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

        public string Chance(string chance)//Chance Path
        {

            return chance;
        }

        public string Safe(string safe)//Safe Path
        {

            return safe;
        }


    }
}
