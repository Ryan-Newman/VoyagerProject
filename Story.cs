﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace VoyagerProject
{
    class Story
    {
        Choices storyChoice = new Choices();
        Planet planet = new Planet();
        Player player = new Player();

        public void TypeEffect(string storyIntro, int sleepTime)
        {
            foreach (char a in storyIntro)
            {
                Thread.Sleep(sleepTime);
                Console.Write(a);
            }

        }

        public void StoryIntro()
        {
            string storyIntroOne = "\tThe year is 2020 humans have been attempting to make contact with an alien force\nthat was seen through the Voyager probe." +
                                     " Humanity has continued to push out signals\nin order to make contact however no response has been received… \n";
            TypeEffect(storyIntroOne, 10);
            // have text type to the screen and fade away after a specific amount of time.
            Console.Clear();


            string storyIntroTwo = "The Story Begins with our nameless hero waking up\n startled to the sound of the city he lives in being destroyed by an unknown force. \n";
            TypeEffect(storyIntroTwo, 1);
            // Sizing(3, 4);

            string storyIntroThree = "The hero throws on the closest clothes that he has and stumbles out of his apartment. \n";
            TypeEffect(storyIntroThree, 1);

            string storyIntroFour = "The character goes into the elevator in his apartment building and hears the elevator music playing"
                                + "while the sound of alien bombs and weapons can be heard in the background. \n ";
            TypeEffect(storyIntroFour, 1);

            string storyIntroFive = "The elevator door opens and the hero sees a friendly military spacecraft landing directly in front of the main lobby. \n";
            TypeEffect(storyIntroFive, 1);

            string storyIntroSix = "The hero runs to the craft, large stencil text marks the name of the ship, “Hermes”.\n"
                                   + "The back hatch of the Hermes opens and soldiers run out of the back of the craft barking orders and charging their weapons.\n";
            TypeEffect(storyIntroSix, 1);

            string storyIntroSeven = " The hero stops one of the soldiers.The soldier turns and faces our hero the soldiers rank and name is Colonel Donaldson.\nClearly a battle worn individual with a massive scar crossed his face. \n";
            TypeEffect(storyIntroSeven, 1);

            string storyIntroEight = " Colonel Donaldson yells to the hero \n";
            TypeEffect(storyIntroEight, 1);
            Thread.Sleep(1);

            string storyIntroNine = "“ What are you doing here!?”\n";
            TypeEffect(storyIntroNine, 1);
            Thread.Sleep(1);

            string storyIntroTen = "“ you have to get the hell out of the city!” \n";
            TypeEffect(storyIntroTen, 1);
            Thread.Sleep(1);

            string storyIntroEleven = "“ two blocks from here there is a Federation ship leaving the city, if self-preservation is your goal, I suggest you be on it.”\n";
            TypeEffect(storyIntroEleven, 1);

            storyChoice.ChoiceSpaceShip();
        }

        public void StorySpaceStation()
        {
            Console.Clear();

            string storySpaceStation = "You are at the spacestation!\n";
            TypeEffect(storySpaceStation, 50);

            string storySpaceStationOne = "*Door opens*\n";
            TypeEffect(storySpaceStationOne, 50);

            string storySpaceStationTwo = "Donaldson-“Come with us.”\n";
            TypeEffect(storySpaceStationTwo, 50);

            string storySpaceStationThree = "*The hero stands up and begins walking alongside Dr. Usk and Colonel Donaldson.*\n";
            TypeEffect(storySpaceStationThree, 50);

            string storySpaceStationFour = "Usk- “Tell me, have you ever piloted a Spacecraft before?”\n";
            TypeEffect(storySpaceStationFour, 50);

            string storySpaceStationFive = "Hero-“ I was a pilo… ”\n";
            TypeEffect(storySpaceStationFive, 50);

            string storySpaceStationSix = "Donaldson- “Cut to the chase, we ran the ID we found in your neural lace. You were a fighter pilot callsign Voyager”\n";
            TypeEffect(storySpaceStationSix, 50);

            string storySpaceStationSeven = "Hero- “Why does any of this matter?”\n";
            TypeEffect(storySpaceStationSeven, 50);

            string storySpaceStationEight = "Donaldson- “It matters because as a species we have a serious problem on our hands and you as Usk so eloquently put it, “are a creature of opportunity””\n";
            TypeEffect(storySpaceStationEight, 50);

            string storySpaceStationNine = "Usk- “What the colonel is trying to say is, we need your help.”\n";
            TypeEffect(storySpaceStationNine, 50);

            string storySpaceStationTen = "Usk- “10 minutes after the initial invasion Kurop enemy forces began targeting all military installations globally with weapons that we have not seen before. ”\n ";
            TypeEffect(storySpaceStationTen, 50);

            string storySpaceStationEleven = "Donaldson- “The force is scattered to the winds and besides myself you’re one of few remaining fighter pilots we have contact with.”\n";
            TypeEffect(storySpaceStationEleven, 50);

            string storySpaceStationTwelve = "“……….”\n";
            TypeEffect(storySpaceStationTwelve, 50);

            string storySpaceStationThirteen = "Hero- “What do you need me to do?”\n";
            TypeEffect(storySpaceStationThirteen, 50);

            string storySpaceStationFourteen = "Donaldson –“The Kurops have EMP weapons that are capable of chewing right through our shielding our coms with the other colonies has been DOA for the past 8 hours”\n";
            TypeEffect(storySpaceStationFourteen, 50);

            string storySpaceStationFifteen = "Usk- “We need you to travel to the outer colonies spread the word of Earth’s invasion, enlist all the help you can and retrieve the supplies necessary to make a Havok tactical nuclear device.”\n";
            TypeEffect(storySpaceStationFifteen, 50);

            string storySpaceStationSixteen = "Hero- “You know this will take me years, even with the warp technology we have”\n";
            TypeEffect(storySpaceStationSixteen, 50);

            string storySpaceStationSeventeen = "Usk- “The technology you know of… “\n";
            TypeEffect(storySpaceStationSeventeen, 50);

            string storySpaceStationEighteen = "Usk- “We are outfitting the craft you arrived on with the newest propulsion technology. One of your many Compensations will be age reversal therapy to the youngest age you wish upon your return.”\n";
            TypeEffect(storySpaceStationEighteen, 50);

            string storySpaceStationNineteen = "Hero- “When will my ship be ready?”\n";
            TypeEffect(storySpaceStationNineteen, 50);

            string storySpaceStationTwenty = "*Donaldson and Usk in unison*- “Now.”\n";
            TypeEffect(storySpaceStationTwenty, 50);

            string storySpaceStationTwentyone = "“………”\n";
            TypeEffect(storySpaceStationTwentyone, 50);

            string storySpaceStationTwentytwo = "*The hero makes his way to the Spacecraft*\n";
            TypeEffect(storySpaceStationTwentytwo, 50);

            string storySpaceStationTwentythree = "*Men load valuable cargo and supplies into the cargo bay*\n";
            TypeEffect(storySpaceStationTwentythree, 50);

            string storySpaceStationTwentyfour = "*Usk approaches*\n";
            TypeEffect(storySpaceStationTwentyfour, 50);

            string storySpaceStationTwentyfive = "Usk- “Supplies are distributed and we have given you assets to trade with the outer colonies in order to make purchases and enlist help. Your first stop will be the Proxima Centauri system.”\n";
            TypeEffect(storySpaceStationTwentyfive, 50);

            string storySpaceStationTwentysix = "*Usk hands the hero a helmet*\n";
            TypeEffect(storySpaceStationTwentysix, 50);

            string storySpaceStationTwentyseven = "Usk- “We will be with you throughout your journey”\n";
            TypeEffect(storySpaceStationTwentyseven, 50);

            string storySpaceStationTwentyEight = "*The hero shakes Usk’s hand and makes his way onto the craft*\n";
            TypeEffect(storySpaceStationTwentyEight, 50);

            string storySpaceStationTwentynine = "*The hero puts the helmet on, the coms crackle on with the Colonels voice*\n";
            TypeEffect(storySpaceStationTwentynine, 50);

            string storySpaceStationThirty = "Donaldson-“God speed Voyager”\n";
            TypeEffect(storySpaceStationThirty, 50);

            string storySpaceStationThirtyone = "“…………””\n";
            TypeEffect(storySpaceStationThirtyone, 50);
            Console.Clear();

            string storySpaceStationThirtytwo = "It has been two days since the Voyager departed the Icarus. \n " +
                                                "preparing the ship and acclimating to cryosleep the Voyager is now ready to travel.”\n";
            TypeEffect(storySpaceStationThirtytwo, 50);

            string storySpaceStationThirtythree = "Voyager- “Usk? How fast can I get to Proxima Centauri? ”\n";
            TypeEffect(storySpaceStationThirtythree, 50);

            string storySpaceStationThirtyfour = "Usk- “With the current propulsion device we installed on your craft you will be able to consistently travel at 1.4 Warp Factor.\n" +
                                                 " This is assuming the devise is not damaged and is operating at 100% capacity. It is imperative that you take care of the ships engine \n" +
                                                 " one wrong move could drop the propulsion devices efficiency and have you traveling through space your entire life. \n " +
                                                 "You need to return to us before you reach the age of 60. Once you reach 60 we will no longer be able to reverse the aging process. ”\n";
            TypeEffect(storySpaceStationThirtyfour, 50);

            string storySpaceStationThirtyfive = "*distress beacon begins ringing*\n";
            TypeEffect(storySpaceStationThirtyfive, 50);

            string storySpaceStationThirtysix = "Voyager- “I’m picking up a distress beacon should I go and check it out? \n " +
                                                 "There may be free loot and someone to help or should I stay on course?”\n";
            TypeEffect(storySpaceStationThirtysix, 50);



            planet.PlanetStory(storySpaceStation);
            storyChoice.ChoiceSpaceStation();
        }

        public void StoryProxima()
        {
            Console.Clear();
            planet.RngDice(4.3);


            string storyProxima = "You are at Proxima! \n";

           


            string storyProximaOne = "*Cryotube hisses from air rushing in* \n ";
            TypeEffect(storyProximaOne, 50);

            string storyProximaTwo = "*The Voyager arrives to Proxima Centauri and begins landing on the habitable planet. * \n ";
            TypeEffect(storyProximaTwo, 50);

            string storyProximaThree = "Usk *through intercom*- “we see you have arrived to the Proxima Centauri solar system \n" +
                                       " since you’re still in the inner realm goods will not be worth as much. \n I suggest you wait to sell your goods when you get to planets on the outer realm. \n ”";
            TypeEffect(storyProximaThree, 50);

            string storyProximaFour = "Usk-“Once you are ready to leave the planet, be sure to find Senator Howards  and explain Earth’s need for help.” \n";
            TypeEffect(storyProximaFour, 50);

            //Bartering start here

            string storyProximaFive = "Senator Howard- “Good Afternoon, we have been expecting you. I understand that you are here to talk about an attack on Earth?” I can assure you that any assistance you need we will provide it. \n" +
                                      " As you travel through the universe and alert the other colonies of the attack on Earth, we will provide shelter and food for any man or woman that you enlist to help. You should travel to the Trappist system next. Speak with General Jimenez he will be able to assist you with providing the largest number of bodies for the current battle. \n " +
                                        "There are two ways you can get to Trappist. There is an Asteroid belt between our two planets. Our scientists have been working on a prototype shield that should let you pass through the Asteroid belt unharmed. Or you can take the risk and navigate yourself through, and who knows you may find parts for your ship of loot from those that were…less successful the choice is yours.”\n";
            TypeEffect(storyProximaFive, 50);



            Console.WriteLine("\n");
            //Barter();
            player.Age(4.2);
            Console.WriteLine("\n");
            player.Inventory(0);
            player.MerchantResources();
            planet.PlanetStory(storyProxima);
            storyChoice.ChoiceProxima();
        }
        public void Barter()
            {
            player.BuySell("Buy", "Sell", 2);

            }


    public void StoryTrappist()
        {
            Console.Clear();
            planet.RngDice(39.72);


            string storyTrappist = "You are at Trappist! \n";

            string storyTrappistOne = "*Cryotube hisses from air rushing in* \n";
            TypeEffect(storyTrappistOne, 50);

            string storyTrappistTwo = "*The Voyager arrives to Trappist50-e and begins landing on the habitable planet. * \n ";
            TypeEffect(storyTrappistTwo, 50);

            string storyTrappistThree = "Usk *through intercom*- “we see you have arrived to the Trappist solar system \n you are now in the outer realm goods will sell for a higher rate, but will also be more expensive \n I suggest you sell your goods if you can spare them to make profit to spend when you return to the inner colonies ” \n";
            TypeEffect(storyTrappistThree, 50);

            string storyTrappistFour = "Usk-“Once you are ready to leave the planet, be sure to find Gen Jimenez and explain Earth’s need for help.” \n";
            TypeEffect(storyTrappistFour, 50);

            //Bartering start here

            string storyTrappistFive = "General Jimenez - “We have been expecting you.I understand that you are here to talk about an attack on Earth ?” I can assure you that if you require an army we will provide one.\n" +
                                      "As we prepare to send the soldier to Proxima Centurai in order to stage them and prepare them for war, you should travel to the HD20794 system Governor Bristol is a woman with many different connections and knows quite a bit more about the universe than most. Speak with her she will be able to provide you with information that will aid in Earth’s salvation\n " +
                                        "There are two ways you can get to HD20794.Take the straight path at your ships normal warp factor. Or you can take the risk and navigate yourself to an old abandon mine that is inside of an asteroid that’s trajectory is going in the same direction as the HD system I will leave the choice to you.” \n";

            TypeEffect(storyTrappistFive, 50);
            

            Console.WriteLine("\n");
            Console.WriteLine(storyTrappist);
            storyChoice.ChoiceTrappist();
            player.MerchantResources();
        }

        
                
        public void StoryHD()
        {
            Console.Clear();
            planet.RngDice(44.18);


            string storyHD = "You are at HD! \n";

            string storyHDOne = "*Cryotube hisses from air rushing in \n*";
            TypeEffect(storyHDOne, 50);

            string storyHDTwo = "*The Voyager arrives to HD-20794-d and begins landing on the habitable planet. *\n ";
            TypeEffect(storyHDTwo, 50);

            string storyHDThree = "Usk *through intercom*- “we see you have arrived to the HD-20794-d solar system \n you’re returning to the inner realm goods at this distance are good to sell but prices can be competative to buy as well”\n";
            TypeEffect(storyHDThree, 50);

            string storyHDFour = "Usk-“Once you are ready to leave the planet, be sure to find Governor Bristol and explain Earth’s need for help.” \n";
            TypeEffect(storyHDFour, 50);

            //Bartering start here



            string storyHDFive = " “Good Afternoon, we have been expecting you. I understand that you are here to talk about an attack on Earth ?” I can assure you that any information you need I will provide it. \n" +
                                      " As you travel through the universe and alert the other colonies of the attack on Earth, you should travel to the Wolf50069 system next there is a secret military facility that has a number of weapons that can be used to fight this war. Speak with Captain Ward he will be able to assist you with providing the largest number of guns and ammunition I hear they are working with another organization to develop a superior weapon as well.\n " +
                                        "There are two ways you can get to Wolf. You can take the long route to the planet I only recommend this option since there are constant skirmishes between the rebels and the Federation. By going to wolf you risk getting engaged in a dogfight there are plenty of destroyed ships and who knows you may find parts for your ship of loot from those that were not so lucky in battle.” \n";
            TypeEffect(storyHDFive, 50);
           




            Console.WriteLine("\n");
            planet.PlanetStory(storyHD);
            storyChoice.ChoiceHD();
        }       
        
        public void StoryWolf()
        {
            Console.Clear();
            planet.RngDice(23.44);


            string storyWolf = "You are at the Wolf outpost \n";

            string storyWolfOne = "*Cryotube hisses from air rushing in* \n";
            TypeEffect(storyWolfOne, 50);

            string storyWolfTwo = "*The Voyager arrives to Wolf1069 and begins landing at the military's secret outpost. * \n";
            TypeEffect(storyWolfTwo, 50);

            string storyWolfThree = "Usk *through intercom*- “we see you have arrived to the Wolf1069 solar system \n being that this outpost is secret not many visitors come through. You should be able to get a good price on your goods and should be able to pick up weapons and ammo at a good rate.”\n ";
            TypeEffect(storyWolfThree, 50);

            string storyWolfFour = "Usk-“Once you are ready to leave the planet, be sure to find Captain Ward and explain Earth’s need for help.”\n";
            TypeEffect(storyWolfFour, 50);
            
            
            //Bartering start here


            string storyWolfFive = "“Good Afternoon, we have been expecting you. I understand that you are here to talk about an attack on Earth?” I can assure you that any information and weapons you need I will provide it. \n" +
                                      " As you travel to Kapteyn and alert them of the attack on Earth, Speak with Mr. Elliot he will be able to assist you with providing the Havoc tactical nuke. This bomb will be more than capable for taking out the Kurop mothership that is on its way to Earth!\n " +
                                        "There are two ways you can get to Kapteyn. There is a moon close by that you can slingshot your ship off if it is done right you will be able to travel faster, if not you will waste time. If you’re not a risk taker you can take the longer route and just push your ship to its normal warp speed.\n";

            TypeEffect(storyWolfFive, 50);




            Console.WriteLine("\n");
            planet.PlanetStory(storyWolf);
            storyChoice.ChoiceWolf();
        }
        
        public void StoryKapteyn()
        {
            Console.Clear();
            planet.RngDice(18.97);


            string storyKapteyn = "You are on Kapteyn, cheif! \n";

            string storyKapteynOne = "*Cryotube hisses from air rushing in* \n";
            TypeEffect(storyKapteynOne, 50);

            string storyKapteynTwo = "*The Voyager arrives to Kapteyn-b and begins landing at the habitable planet * \n ";
            TypeEffect(storyKapteynTwo, 50);

            string storyKapteynThree = "Usk *through intercom*- “we see you have arrived to the Kapteyn solar system \n This planet is well within the inner colonies, so purchasing goods should be easy. This is your last objective befor you head back to Earth make sure you purchase as many goods as possible to aid in the fight!”\n";
            TypeEffect(storyKapteynThree, 50);

            string storyKapteynFour = "Usk-“Once you are ready to leave the planet, be sure to find Mr. Elliot he has been waiting for you and will provide you with the havoc tactical nuke.” \n";
            TypeEffect(storyKapteynFour, 50);


            //Bartering start here


            string storyKapteynFive = "“Good Afternoon, I have been expecting you. I have heard about your journey and am excited to meet you. I understand you are looking for a weapon to destroy the Kurop mothership.You are in luck.We have just the weapon.It is called the havoc tactical nuke and it took years to develop.\n" +
                                      " As you travel to back Earth with the nuke please be careful not to damage the device, I will alert Proxima and they will begin pushing the large gathering of troops to earth to fight the Kurops on the ground.\n " +
                                        "If you are willing to take a risk, we have an experimental warp drive that may push your ship faster back to Earth. Or you can take the safe route and just push your ship to its normal warp speed.”\n";
            TypeEffect(storyKapteynFive, 50);




            Console.WriteLine("\n");
            planet.PlanetStory(storyKapteyn);
            planet.RngDice(11.9);

            Console.Clear();

            string storyEarthEndOne = "Cryotube hisses from air rushing in \n";
            TypeEffect(storyEarthEndOne, 50);

            string storyEarthEndTwo = "*Immediately after awakening the ship is rattled by a massive explosion. \n";
            TypeEffect(storyEarthEndTwo, 50);

            string storyEarthEndThree = "The Voyager jumps from the chamber and into the cockpit* \n ";
            TypeEffect(storyEarthEndThree, 50);

            string storyEarthEndFour = "The battle between the humans and the Kurops rages.\n";
            TypeEffect(storyEarthEndFour, 50);

            string storyEarthEndFive = "In the distance the Kurop mothership can be seen preparing its primary weapon to fire on Earth.";
            TypeEffect(storyEarthEndFive, 50);

            string storyEarthEndSix = "There is no time to think, The Voyager boosts over to the mothership the havoc nuke is onboard and there is no time for the Voyager to make it back to the Icarus.";
            TypeEffect(storyEarthEndSix, 50);
            string storyEarthEndSeven = "*The Voyager knows what needs to be done. ";
            TypeEffect(storyEarthEndSeven, 50);

            string storyEarthEndEight = "The Voyager runs to the cargo bay to arm the havoc and then sprints back to the cockpit";
            TypeEffect(storyEarthEndEight, 50);

            string storyEarthEndNine = "The Voyager is now directly underneath the motherships superweapon";
            TypeEffect(storyEarthEndNine, 50);

            string storyEarthEndTen = " The Voyager plots the ships course to directly impact the superweapon. ";
            TypeEffect(storyEarthEndTen, 50);

            string storyEarthEndEleven = " The Voyager sets the warp drive to 1.4 *";
            TypeEffect(storyEarthEndEleven, 50);

            string storyEarthEndTwelve = "......";
            TypeEffect(storyEarthEndTwelve, 50);


            Console.Clear();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Clear();



            storyChoice.ChoiceKapteyn(); 
        }
    }
}
