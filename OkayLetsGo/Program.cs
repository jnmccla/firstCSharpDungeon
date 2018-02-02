using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;//added
using WMPLib;//added
using DungeonMonsters;//added


namespace OkayLetsGo
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;

            WindowsMediaPlayer daoIntro = new WindowsMediaPlayer();
            daoIntro.URL = " C:\\Users\\Student\\Music\\LordSeeker.wav";
            daoIntro.controls.play();

            Console.Title = "o==(=====>A Dragon Age Inspired Dungeon Experience<=====)==o";
            //Console.WriteLine("Welcome to Thedas");
            string msg = "Welcome to Thedas";
            Console.WriteLine("{0," +
                ((Console.WindowWidth / 2) + msg.Length / 2) + "}", msg);

            

            Player player = CharacterCreation.Create();

            


            //TODO  create a player


            //Player player = new Player("Ser", "Sam", Race.DalishElf, sword, 20, 20, 15, 70);
            //TODO create a loop for the room
            bool exit = false;

            do
            {
                //TODO Write a () for showing a room description
                //TODO Add linebreaks
                Console.WriteLine(GetRoom());
                //Program.party_member.cur;

                //TODO Show a monster in the room
                Dragon d1 = new Dragon();
                Dragon d2 = new Dragon("Momma Dragon", 25, 25, 60, 20, 2, 8,
                    "A very large mother dragon. She is not pleased",
                    true);
                Dragon d3 = new Dragon(false);
                DarkSpawn ds1 = new DarkSpawn(1);
                DarkSpawn ds2 = new DarkSpawn();
                DarkSpawn ds3 = new DarkSpawn("Ogre", 24, 8, 24, 50, 30, 2,
                    "An ogre. Towering over double, maybe triple your height." +
                    " Blood drips from its weapons.", 2);

                List<Monster> monsters = new List<Monster>();
                monsters.Add(d1);
                monsters.Add(d1);
                monsters.Add(d1);
                monsters.Add(d1);
                monsters.Add(d1);
                monsters.Add(d2);
                monsters.Add(d3);
                monsters.Add(d3);
                monsters.Add(d3);
                monsters.Add(ds1);
                monsters.Add(ds1);
                monsters.Add(ds1);
                monsters.Add(ds1);
                monsters.Add(ds2);
                monsters.Add(ds2);
                monsters.Add(ds3);

                Loot[] loot =
                    {
                Loot.BlockPotion,
                Loot.EquippedWeaponPlus,
                Loot.HealthPotion,
                Loot.HitChancePotion,
                Loot.LifePotion,
                Loot.HealthPotion,
                Loot.HealthPotion,
                Loot.HealthPotion,
                Loot.BlockPotion,
                Loot.Nothing,
                Loot.Nothing,
                Loot.Nothing,
                Loot.Nothing
                  };//loot[]


                Random rand3 = new Random();
                int indexNbr = rand3.Next(loot.Length);
                Monster monster = monsters[rand3.Next(monsters.Capacity)];
                Console.WriteLine("\nIn this room: " + monster.Name);
                //Loot item = loot[indexNbr];
                //string l = "";

                //List<Loot> playerLoot = new List<Loot>();
                //List<string> showLoot = new List<string>();
                
                List<string> drop = new List<string>
            {
                "Block Potion",
                "Equipped Weapon Plus",
                "Health Potion",
                "Nothing",
            };//list loot
                //TODO Create a loop for the menu
                
                bool reload = false;
                List<string> showLoot = new List<string>();
                do
                {

                    //TODO Menu

                    Console.Write("\nChoose an ACTION:\n" +
                        "A) Attack\n" +
                        "R) RUN\n" +
                        "C) Character Info\n" +
                        "M) Monster Info\n" +
                        "I) Inventory\n" +
                        "X) Exit\n" +
                        "Enter your choice: ");
                    //TODO catch user's choice
                    string userChoice = Console.ReadLine().ToUpper();

                    Console.Clear();

                    switch (userChoice)
                    {
                        case "A":

                            //TODO Handle if Player wins
                            Combat.DoBattle(player, monster);
                            if (monster.Life <= 0)
                            {

                                Random rand = new Random();
                                int iNbr = rand.Next(4);
                                string item = drop[iNbr];
                                Console.WriteLine("\nYou defeated {0}!\n",
                                    monster.Name);
                                score += 1;

                                switch (item)
                                {

                                    case "Block Potion":
                                        Console.WriteLine("You got a block potion!");
                                        player.Inventory.Add("Block Potion");
                                        break;
                                    case "Equipped Weapon Plus":
                                        Console.WriteLine("You got Equipped Weapon Plus!");
                                        player.Inventory.Add("Better Weapon");
                                        break;
                                    case "Health Potion":
                                        Console.WriteLine("You got a health potion!");

                                        player.Inventory.Add("Health Potion");
                                        break;
                                    case "Nothing":
                                        Console.WriteLine("Bad luck! You didn't get anything!");
                                        break;
                                }//switch               
                                 //this is where you would add loot and experience

                                reload = true;
                            }//if monster is dead
                            break;
                        case "R":
                            Console.WriteLine("RUN AWAY!");
                        
                            Combat.DoAttack(monster, player);
                            reload = true;
                            break;
                        case "C":
                            Console.WriteLine("Character INFO");
                          
                            Console.WriteLine(player);
                            Console.WriteLine("Monsters Defeated: " + score);
                           
                            break;
                        case "M":
                            Console.WriteLine("Monster Info");
                          
                            Console.WriteLine(monster);
                            break;
                        case "I":
                            Console.WriteLine("Inventory");
                            foreach (string i in player.Inventory)
                            {
                                Console.WriteLine(i + "/n");
                            }//foreach
                            break;
                        case "X":
                            Console.WriteLine("Really? Okay. Bye.");
                            Console.WriteLine("Monsters Defeated: " + score);
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Try again.");
                            break;
                    }//switch on userChoice

                    //TODO Handle if player dies
                    if (player.Life <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("YOU DIED");
                        Console.ResetColor();
                        Console.WriteLine("Monsters Defeated: " + score);
                        exit = true;
                    }//if


                } while (!reload && !exit);




            } while (!exit);



        }//main

        private static string GetRoom()
        {
            string[] rooms =
            {
            "Unlike the flagstone common throughout the dungeon," +
            " this room is walled and floored with black marble veined with white." +
            "The ceiling is similarly marbled, but the thick pillars that hold it up are white.\n" +
            "A brown stain drips down one side of a nearby pillar.",

            "A dim bluish light suffuses this chamber, its source obvious at a glance.\n" +
            "Blue-glowing lichen and violet-glowing moss cling to the ceiling and spread across the floor.\n" +
            "It even creeps down and up each wall, as if the colonies on the floor and ceiling are growing " +
            "to meet each other.\nTheir source seems to be a glowing, narrow crack in the ceiling,\n " +
            "the extent of which you cannot gauge from your position.\nThe air in the room smells fresh and damp.",

             "As the door opens, it scrapes up frost from a floor covered in ice.\n" +
             "The room before you looks like an ice cave.\nA tunnel wends its way through solid ice, " +
             "and huge icicles and pillars of frozen water block your vision of its \nfarthest reaches.",

             "Burning torches in iron sconces line the walls of this room, lighting it brilliantly.\n" +
             "At the room's center lies a squat stone altar, its top covered in recently spilled blood.\n" +
             "A channel in the altar funnels the blood down its side to the floor where it fills grooves " +
             "in the floor that trace some kind of pattern or symbol around the altar.\n" +
             "Unfortunately, you can't tell what it is from your vantage point.",

             "You open the door and a draft from deeper in the dungeon snuffs out your torch.\n" +
             "You struggle to relight it in the eerie blue glow of the lyrium veins winding through the room.\n" +
             "Your torch flickers to life, casting new wavering shadows.\n" +
             "But as your flame steadies, one shadow still moves quickly and is growing bigger.",

             "The walls are scorched with fire and water drips from a still-melting ice blast.\n" +
             "Broken staves and swords and bows and bones line the floor making a crunch with each step.\n" +
             "You wince at a particularly loud one when something lunges out at you.",

             "This room is rather... squishy. Spiderwebs cling to the walls and large cacoon-like sacks hang from"+
             " the ceiling.\nSome of them look like they're wriggling, but you're sure that's your eyes" +
             " playing tricks on you.\nYou're having a harder and harder time getting your boots unstuck from" +
             "... whatever is covering the floor.\nStill, you try to move quickly before whatever made this" +
             " nest returns.",

             "The room glows red from the veins of corrupted lyrium that worm through stone walls.\n" +
             "You carefully avoid the crystals jutting out of the ground as you make your way to the other side.\n" +
             "Before you even make it half way, you hear the unnatural groans of something that has been in\n" +
             " this room far too long. You ready your weapon and prepare to attack.",

             "Broken wooden crates are stacked against the walls and the whole room smells of bad ale.\n" +
             "In the middle of the room is the rotting body of the poor fool who thought to use this as their \n" +
             "smuggling den. Upon further study, it's obvious their wounds weren't man-made.\nOr if they were, " +
             "definitely not by one in full possession of their mind.\nBest be on guard, either way."

            };

            Random rand = new Random();

            int indexNbr = rand.Next(rooms.Length);

            string room = rooms[indexNbr];

            return room;

        }//GetRoom

        //private static string GetLoot()
        //{
        //    Loot[] loot =
        //    {
        //        Loot.BlockPotion,
        //        Loot.EquippedWeaponPlus,
        //        Loot.HealthPotion,
        //        Loot.HitChancePotion,
        //        Loot.LifePotion,
        //        Loot.HealthPotion,
        //        Loot.HealthPotion,
        //        Loot.HealthPotion,
        //        Loot.BlockPotion,
        //        Loot.Nothing,
        //        Loot.Nothing,
        //        Loot.Nothing,
        //        Loot.Nothing
        //    };//loot[]

        //    Random rand = new Random();
        //    int indexNbr = rand.Next(loot.Length);

        //    Loot item = loot[indexNbr];
        //    string l = "";
        //    List<Loot> playerLoot = new List<Loot>();
        //    Player player = new Player();
        //    switch (item)
        //    {
        //        case Loot.HealthPotion:
        //            l = "Health Potion\nUse this item to regain health";
        //            playerLoot.Add(Loot.HealthPotion);
        //            showLoot.Add("Health Potion");
        //            break;
        //        case Loot.HitChancePotion:
        //            l = "Hit Chance Potion\nUse this item to permanently increase your Hit Chance";
        //            playerLoot.Add(Loot.HitChancePotion);
        //            showLoot.Add("Hit Chance Potion");
        //            break;
        //        case Loot.BlockPotion:
        //            l = "Block Potion\nUse this item to permanently increase your Block";
        //            playerLoot.Add(Loot.BlockPotion);
        //            showLoot.Add("Block Potion");
        //            break;
        //        case Loot.LifePotion:
        //            l = "Life Potion\nUse this item to permanently increase your Max Health";
        //            playerLoot.Add(Loot.LifePotion);
        //            showLoot.Add("Life Potion");
        //            break;
        //        case Loot.EquippedWeaponPlus:
        //            l = "weapon upgrade\nYour current weapon now has better stats!";

        //            player.EquippedWeapon.BonusHitChance += rand3.Next(1, 11);
        //            player.EquippedWeapon.MaxDamage += rand3.Next(1, 6);
        //            player.EquippedWeapon.MinDamage += rand3.Next(4);
        //            break;
        //        case Loot.Nothing:
        //            l = "Nothing!";
        //            break;
        //    }//switch

        //    return l;

        //}//getloot





    }//class
}//namespace
