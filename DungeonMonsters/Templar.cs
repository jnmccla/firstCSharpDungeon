using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;


namespace DungeonMonsters
{
    public class Templar : Monster
    {
        public bool IsPlayerMagic { get; set; }

        public Templar()
        {

        }

        public Templar(string name, int life, int maxLife, int hitChance, int block, int minDamage,
            int maxDamage, string description)
            :base(name, life, maxLife, hitChance, block, minDamage, maxDamage, description)
        {

        }//FQCTOR

        //public override int CalcDamage()
        //{
        //    if ()
        //    {

        //    }
        //    return base.CalcDamage();
        //}

    }//class
}//namespace
