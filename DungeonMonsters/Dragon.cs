using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace DungeonMonsters
{
    public class Dragon : Monster
    {
        public bool IsScaly { get; set; }
        public Dragon(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage,
            string description, bool isScaly)
            :base(name, life, maxDamage, hitChance, block, minDamage, maxDamage, description)
        {
            IsScaly = isScaly;
        }//FQCTOR

        public Dragon()
        {
            MaxLife = 6;
            MaxDamage = 4;
            Name = "Baby dragon";
            Life = 6;
            HitChance = 30;
            Block = 20;
            MinDamage = 1;
            Description = "Just a baby. But the mom must be around here somewhere...";
            IsScaly = false;

        }//babydragon
        public Dragon(bool isScaly)
        {
            MaxLife = 15;
            MaxDamage = 6;
            Name = "Adolescent Dragon";
            Life = 15;
            HitChance = 50;
            Block = 30;
            MinDamage = 2;
            Description = "Not quite an adult, but much more dangerous than a baby dragon";
            IsScaly = isScaly;
        }//adolescent

        public override string ToString()
        {
            return base.ToString() + (IsScaly ? "It looks scaly" : "It looks defenseless") ;
        }//tostring

        public override int CalcBlock()
        {
            int calculatedBlock = Block;
            if (IsScaly)
            {
                calculatedBlock += calculatedBlock / 2;
            }//if
            return calculatedBlock;
        }//calcblock

    }//class
}//namespace
