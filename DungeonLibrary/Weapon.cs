using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Weapon
    {
        //fields
        private string _name;
        private int _minDamage;//needs business rule so gets set last
        private int _maxDamage;
        private int _bonusHitChance;
        private bool _isTwoHanded;

        //properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }//name
        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }//maxdamage
        public int BonusHitChance
        {
            get { return _bonusHitChance; }
            set { _bonusHitChance = value; }
        }//bonushitchance
        public bool IsTwoHanded
        {
            get { return _isTwoHanded; }
            set { _isTwoHanded = value; }
        }//istwohanded
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                //Can't be more than MaxDamage and cannot be less than 1
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

        public Weapon()
        {

        }//defalut ctor

        public Weapon(string name, int minDamage, int maxDamage, int bonusHitChance, bool isTwoHanded)
        {
            //If properties rely on other properties, the other properties must be set first
            Name = name;
            MaxDamage = maxDamage;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;
            MinDamage = minDamage;
        }//FQCTOR

        //methods

        public override string ToString()
        {
            //return base.ToString();
            return string.Format("{0}\t{1} to {2} damage\nBonus Hit: {3}\t{4}",
                Name,
                MinDamage,
                MaxDamage,
                BonusHitChance,
                IsTwoHanded == true ? "Two-handed" : "One-handed");
        }//override tostring




    }//class
}//namespace
