using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Monster : Character
    {
        //fields
        private int _minDamage;
        //propfull tab tab is a quick way to make a field and a property at the same time
        //properties
        public int MaxDamage { get; set; }
        public string Description { get; set; }

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {                
                if (value > 0 && value <= MaxDamage)
                {
                    _minDamage = value;
                }//if
                else
                {
                    _minDamage = 1;
                }//else
            }//set
        }//mindamange

        //constructors
        public Monster()
        {

        }

        public Monster(string name, int life, int maxLife, int hitChance, int block, int minDamage,
            int maxDamage, string description)
        {
            //maxlife and maxdamage have to come before life and mindamage respectively
            Name = name;            
            MaxLife = maxLife;
            HitChance = hitChance;
            Block = block;            
            MaxDamage = maxDamage;
            Description = description;
            MinDamage = minDamage;
            Life = life;
        }//FQCTOR

        //methods

        public override string ToString()
        {
            return string.Format("\n****MONSTER****\n" +
                "{0}\nLife: {1} of {2}\nDamage: {3} to {4}\nBlock: {5}\nDescription:\n{6}\n",
                Name,
                Life,
                MaxLife,
                MinDamage,
                MaxDamage,
                Block,
                Description);
        }//tostring

        public override int CalcDamage()
        {
            Random rand = new Random();
            return rand.Next(MinDamage, MaxDamage + 1);
            
        }//calcdamage


    }//class
}//namespace
