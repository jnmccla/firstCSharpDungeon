using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class GetLoot
    {
        


        public static string ItemDrops()
        {
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

            Loot item = loot[indexNbr];
            string l = "";

            List<Loot> playerLoot = new List<Loot>();
            List<string> showLoot = new List<string>();

          
            

           
            switch (item)
            {
                case Loot.HealthPotion:
                    l = "Health Potion\nUse this item to regain health";
                    playerLoot.Add(Loot.HealthPotion);
                    showLoot.Add("Health Potion");
                    break;
                case Loot.HitChancePotion:
                    l = "Hit Chance Potion\nUse this item to permanently increase your Hit Chance";
                    playerLoot.Add(Loot.HitChancePotion);
                    showLoot.Add("Hit Chance Potion");
                    break;
                case Loot.BlockPotion:
                    l = "Block Potion\nUse this item to permanently increase your Block";
                    playerLoot.Add(Loot.BlockPotion);
                    showLoot.Add("Block Potion");
                    break;
                case Loot.LifePotion:
                    l = "Life Potion\nUse this item to permanently increase your Max Health";
                    playerLoot.Add(Loot.LifePotion);
                    showLoot.Add("Life Potion");
                    break;
                //case Loot.EquippedWeaponPlus:
                //    l = "weapon upgrade\nYour current weapon now has better stats!";

                //    player.EquippedWeapon.BonusHitChance += rand3.Next(1, 11);
                //    player.EquippedWeapon.MaxDamage += rand3.Next(1, 6);
                //    player.EquippedWeapon.MinDamage += rand3.Next(4);
                //    break;
                case Loot.Nothing:
                    l = "Nothing!";
                    break;
            }//switch

            return l;

        }//getloot
    }//class
}//class
