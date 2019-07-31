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
            int choice1;
            int choice2 = 1;
            int playerLuck = dice.RngDice(choice2);
            string choice;
            Console.WriteLine("Go left or right?");
            choice = Console.ReadLine();
            if (choice == "left")
            {


            }
            else if (choice == "right")
            {
               
                Console.WriteLine($"You have {playerLuck} luck");
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
