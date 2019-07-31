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
            string choice1 = "";
            string choice2 = "";
            
            string choice;
            Console.WriteLine("Go left or right?");
            choice = Console.ReadLine();
            if (choice == "left")
            {


            }
            else if (choice == "right")
            {
               
             //   Console.WriteLine($"You have {dice.RngDice(choice1)} luck");
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
