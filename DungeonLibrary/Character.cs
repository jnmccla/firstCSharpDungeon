using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public abstract class Character
    {
        //The abstract modifier indcates that the thing beiing modified has an incomplete implementation
        //It can be used with classes, methods, or properties.
        //Use the abstract modifier in a class declaration to indicate that the class is intended to only
        //be a base (parent) class of other classes.

        private int _life;

        public string Name { get; set; }
        public int MaxLife { get; set; }
        public int HitChance { get; set; }
        public int Block { get; set; }
        public int Life
        {
            get { return _life; }
            set
            {
                if (value <= MaxLife)
                {
                    _life = value;
                }//if
                else
                {
                    _life = MaxLife;
                }//else
            }//set
        }//life

        //There is no need to create a CTOR here because this class is abstract. 
        //You will NEVER make a Character.

        public virtual int CalcBlock()
        {
            //The virtual keyword allows this method to be overridden
            return Block;
        }//calcblock

        //mini lab make CalcHitChance() return HitChance
        //Make it override-able

        public virtual int CalcHitChance()
        {
            return HitChance;
        }//calchitchance

        public virtual int CalcDamage()
        {
            return 0;
        }//calcdamage

    }//class
}//namespace
