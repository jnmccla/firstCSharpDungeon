using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class CharacterCreation
    {
        public static Player Create()
        {
            List<Weapon> w = new List<Weapon>();
            Weapon sword = new Weapon("Short Sword", 3, 8, 20, false);
            Weapon axe = new Weapon("Battle Axe", 2, 6, 18, true);
            Weapon bow = new Weapon("Long Bow", 1, 5, 23, true);
            Weapon magic = new Weapon("Magic Blast", 1, 6, 25, false);
            Weapon dagger = new Weapon("Dagger", 3, 5, 27, false);
            w.Add(sword);
            w.Add(axe);
            w.Add(bow);
            w.Add(magic);
            w.Add(dagger);
            Random rand2 = new Random();

            


            Player player = new Player();
            Console.WriteLine("Enter your title:\nExamples: Ser, Sir, Lord, Lady");
            player.Title = Console.ReadLine();
            Console.Write("Enter your name: ");
            player.Name = Console.ReadLine();
            bool chooseRace = true;

            

            while (chooseRace)
            {
                Console.Write("Choose a race:\n1) Dalish Elf\n2) City Elf\n3) Human\n4) Dwarf\n5) Qunari\n" +
                "6) Tal Vashoth Qunari\n");
                string playerRace = Console.ReadLine().ToUpper();

                switch (playerRace)
                {
                    //max life hit chance block
                    case "1":
                    case "DALISH ELF":
                    case "DE":
                    case "DALISH":

                        Console.WriteLine("A short elf with large eyes and pointed ears.\n" +
                        "Your vallaslin (religious face tattoo) sets you apart from your city bretheren.\n" +
                        "Choose this race?");
                        string chooseDalish = Console.ReadLine().ToUpper();
                        switch (chooseDalish)
                        {
                            case "Y":
                            case "YES":
                            case "SURE":
                            case "OKAY":
                            case "HELL YEAH":
                            case "YEAH":
                                chooseRace = false;
                                player.CharacterRace = Race.DalishElf;
                                Console.WriteLine("You are now a Dalish Elf");
                                player.MaxLife = rand2.Next(15, 21);
                                player.Life = player.MaxLife;
                                player.HitChance = rand2.Next(60, 76);
                                player.Block = rand2.Next(15, 20);
                                break;
                            case "NO":
                            case "N":
                            case "NAH":
                            case "NO WAY":
                            case "NEVERMIND":
                            case "NOPE":
                                Console.Clear();
                                break;
                            default:
                                Console.WriteLine("I'm going to assume that you said you want this race." +
                                    " You are now a Dalish Elf.");
                                chooseRace = false;
                                break;
                        }//chosen race switch


                        break;
                    case "2":
                    case "CITY ELF":
                    case "CITY":
                    case "C":

                        Console.WriteLine("A short elf with large eyes and pointed ears.\n" +
                        "More stout than your Dalish bretheren.\n" +
                       "Choose this race?");
                        string chooseCity = Console.ReadLine().ToUpper();
                        switch (chooseCity)
                        {
                            case "Y":
                            case "YES":
                            case "SURE":
                            case "OKAY":
                            case "HELL YEAH":
                            case "YEAH":
                                chooseRace = false;
                                player.CharacterRace = Race.CityElf;
                                Console.WriteLine("You are now a City Elf");
                                player.MaxLife = rand2.Next(17, 24);
                                player.Life = player.MaxLife;
                                player.HitChance = rand2.Next(55, 71);
                                player.Block = rand2.Next(15, 22);
                                break;
                            case "NO":
                            case "N":
                            case "NAH":
                            case "NO WAY":
                            case "NEVERMIND":
                            case "NOPE":
                                Console.Clear();
                                break;
                            default:
                                Console.WriteLine("I'm going to assume that you said you want this race." +
                                    " You are now a City Elf.");
                                chooseRace = false;
                                break;
                        }//chosen race switch

                        break;
                    case "3":
                    case "HUMAN":
                    case "H":
                        Console.WriteLine("A human. Average in height and build compared to other races.\n" +
                       "Choose this race?");
                        string chooseHuman = Console.ReadLine().ToUpper();
                        switch (chooseHuman)
                        {
                            case "Y":
                            case "YES":
                            case "SURE":
                            case "OKAY":
                            case "HELL YEAH":
                            case "YEAH":
                                chooseRace = false;
                                player.CharacterRace = Race.Human;
                                Console.WriteLine("You are now a Human");
                                player.MaxLife = rand2.Next(15, 26);
                                player.Life = player.MaxLife;
                                player.HitChance = rand2.Next(50, 76);
                                player.Block = rand2.Next(15, 31);
                                break;
                            case "NO":
                            case "N":
                            case "NAH":
                            case "NO WAY":
                            case "NEVERMIND":
                            case "NOPE":
                                Console.Clear();
                                break;
                            default:
                                Console.WriteLine("I'm going to assume that you said you want this race." +
                                    " You are now a Human.");
                                chooseRace = false;
                                break;
                        }//chosen race switch

                        break;
                    case "4":
                    case "DWARF":
                    case "D":
                        Console.WriteLine("A dwarf. Shorter than the other races and stocky. Can't use magic.\n" +
                     "Choose this race?");
                        string chooseDwarf = Console.ReadLine().ToUpper();
                        switch (chooseDwarf)
                        {
                            case "Y":
                            case "YES":
                            case "SURE":
                            case "OKAY":
                            case "HELL YEAH":
                            case "YEAH":
                                chooseRace = false;
                                player.CharacterRace = Race.Dwarf;
                                Console.WriteLine("You are now a Dwarf");
                                player.MaxLife = rand2.Next(18, 26);
                                player.Life = player.MaxLife;
                                player.HitChance = rand2.Next(45, 70);
                                player.Block = rand2.Next(20, 33);
                                break;
                            case "NO":
                            case "N":
                            case "NAH":
                            case "NO WAY":
                            case "NEVERMIND":
                            case "NOPE":
                                Console.Clear();
                                break;
                            default:
                                Console.WriteLine("I'm going to assume that you said you want this race." +
                                    " You are now a Dwarf.");
                                chooseRace = false;
                                break;
                        }//chosen race switch

                        break;
                    case "5":
                    case "QUNARI":
                    case "Q":
                        Console.WriteLine("A qunari with large ram-like horns. Tall and muscular.\n" +
                        "You still follow the Qun, your religion/culture and cannot use magic.\n" +
                  "Choose this race?");
                        string chooseQunari = Console.ReadLine().ToUpper();
                        switch (chooseQunari)
                        {
                            case "Y":
                            case "YES":
                            case "SURE":
                            case "OKAY":
                            case "HELL YEAH":
                            case "YEAH":
                                chooseRace = false;
                                player.CharacterRace = Race.Qunari;
                                Console.WriteLine("You are now a Qunari");
                                player.MaxLife = rand2.Next(18, 25);
                                player.Life = player.MaxLife;
                                player.HitChance = rand2.Next(55, 69);
                                player.Block = rand2.Next(18, 26);
                                break;
                            case "NO":
                            case "N":
                            case "NAH":
                            case "NO WAY":
                            case "NEVERMIND":
                            case "NOPE":
                                Console.Clear();
                                break;
                            default:
                                Console.WriteLine("I'm going to assume that you said you want this race." +
                                    " You are now a Qunari.");
                                chooseRace = false;
                                break;
                        }//chosen race switch

                        break;
                    case "6":
                    case "TAL VASHOTH QUNARI":
                    case "TALVASHOTH QUNARI":
                    case "T":
                    case "TV":
                    case "TVQ":
                    case "TQ":
                        Console.WriteLine("A qunari with large ram-like horns. Tall and muscular.\n" +
                        "You abandoned the Qun, your species' religion/culture and can use magic.\n" +
                   "Choose this race?");
                        string chooseTalVashoth = Console.ReadLine().ToUpper();
                        switch (chooseTalVashoth)
                        {
                            case "Y":
                            case "YES":
                            case "SURE":
                            case "OKAY":
                            case "HELL YEAH":
                            case "YEAH":
                                chooseRace = false;
                                player.CharacterRace = Race.TalVashothQunari;
                                Console.WriteLine("You are now a Tal Vashoth Qunari");
                                player.MaxLife = rand2.Next(17, 30);
                                player.Life = player.MaxLife;
                                player.HitChance = rand2.Next(53, 74);
                                player.Block = rand2.Next(17, 28);
                                break;
                            case "NO":
                            case "N":
                            case "NAH":
                            case "NO WAY":
                            case "NEVERMIND":
                            case "NOPE":
                                Console.Clear();
                                break;
                            default:
                                Console.WriteLine("I'm going to assume that you said you want this race." +
                                    " You are now a Tal Vashoth Qunari.");
                                chooseRace = false;
                                break;
                        }//chosen race switch

                        break;
                    //case "7":
                    //case "INFO":
                    //case "RACE":
                    //case "VIEW":
                    //case "VIEW RACE INFO":
                    //case "VRI":
                    //case "V":
                    //case "I":
                    //    Console.WriteLine();
                    //    break;
                    default:
                        Console.WriteLine("That is not an option.");
                        break;
                }//switch
            }//while

            bool chooseWeapon = true;

            do
            {
                Console.WriteLine("Choose a weapon:\n");
                foreach (Weapon weap in w)
                {
                    Console.WriteLine(weap + "\n");
                }//foreach
                string chosenWeapon = Console.ReadLine().ToUpper();


                switch (chosenWeapon)
                {
                    case "S":
                    case "SWORD":
                    case "SS":
                    case "SHORT SWORD":
                        player.EquippedWeapon = sword;
                        chooseWeapon = false;
                        break;
                    case "A":
                    case "AXE":
                    case "BATTLE AXE":
                    case "BA":
                        player.EquippedWeapon = axe;
                        chooseWeapon = false;
                        break;
                    case "B":
                    case "BOW":
                    case "LONG BOW":
                    case "LB":
                        player.EquippedWeapon = bow;
                        chooseWeapon = false;
                        break;
                    case "MAGIC":
                    case "M":
                    case "MAGIC BLAST":
                    case "MB":
                        if (player.CharacterRace == Race.Dwarf)
                        {
                            Console.WriteLine("Sorry, dwarves can't use magic! Choose again!");
                        }//if
                        else if (player.CharacterRace == Race.Qunari)
                        {
                            Console.WriteLine("Sorry, your culture prevents you from performing magic. Choose again!");
                        }
                        else
                        {
                            player.EquippedWeapon = magic;
                            chooseWeapon = false;
                        }
                        break;
                    case "DAGGER":
                    case "D":
                        player.EquippedWeapon = dagger;
                        chooseWeapon = false;
                        break;
                    default:
                        Console.WriteLine("That is not an option.");
                        break;
                }//switch
            } while (chooseWeapon);

            

            return player;

        }//creation

    }//class
}//namespace
