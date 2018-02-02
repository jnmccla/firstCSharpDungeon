using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace DungeonMonsters
{
    public class DarkSpawn : Monster
    {
        public int BlightDamage { get; set; }

        public DarkSpawn(string name, int maxLife, int maxDamage, int life,
            int hitChance, int block, int minDamage, string description,
            int blightDamage)
            :base(name, life, maxLife, hitChance, block, minDamage, maxDamage,
                 description)
        {
            BlightDamage = blightDamage;
        }//FQCTOR

        public DarkSpawn(int blightDamage)
        {
            MaxLife = 7;
            MaxDamage = 5;
            Name = "Hurlock";
            Life = 7;
            HitChance = 40;
            Block = 20;
            MinDamage = 2;
            Description = "A hurlock. The weakest of the Darkspawn, " +
                "but still very dagnerous";
            BlightDamage = blightDamage;
        }//hurlock
        public DarkSpawn()
        {
            MaxLife = 15;
            MaxDamage = 8;
            Name = "Genlock";
            Life = 15;
            HitChance = 60;
            Block = 30;
            MinDamage = 3;
            Description = "A genlock. Crafty magic users.";
            BlightDamage = 3;
        }//genlock
        public override int CalcDamage()
        {
            return base.CalcDamage() + BlightDamage;
        }//calcdamage

    }//class
}//namespace
