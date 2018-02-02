using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    //Make it public so it is accessible outside the project.
    public sealed class Player : Character
        //The sealed keyword indicates that this class cannot be used as a base class for other classes
    {
        //fields
        //since we will be using automatic properties, we only have to create fields for properties
        //that will have business rules
        //private int _life;
        //private List<string> _inventory;

        //properties
        //Automatic properties are a shortcut that allows you to create a shortened version of a public property.
        //They have an OPEN getter and setter (there can be no business rules).
        //These automatically create fields for you at runtime.
        public string Title { get; set; }
        //public string Name { get; set; }
        //public int MaxLife { get; set; }
        //public int HitChance { get; set; }
        //public int Block { get; set; }
        public Race CharacterRace { get; set; }
        public Weapon EquippedWeapon { get; set; }
        public List<string> Inventory { get; set; }

        //public List<string> Inventory
        //{
        //    get { return _inventory; }
        //    set
        //    { _inventory = Inventory.Add(" ")}; }

        //You cannot have business rules on automatic properties.

        //public int Life
        //{
        //    get { return _life; }
        //    set
        //    {
        //        if (value <= MaxLife)
        //        {
        //            _life = value;
        //        }//if
        //        else
        //        {
        //            _life = MaxLife;
        //        }//else
        //    }//set
        //}//life



        //constructors

        public Player(string title, string name, Race characterRace, Weapon equippedWeapon, int maxLife, int life, 
            int block, int hitChance, List<string> inventory)
        {
            //since life depends on maxLife, it needs to come after maxLife
            Title = title;
            Name = name;
            CharacterRace = characterRace;
            EquippedWeapon = equippedWeapon;
            MaxLife = maxLife;
            Life = life;
            Block = block;
            HitChance = hitChance;
            Inventory = inventory;
        }//FQCTOR
        public Player()
        {

        }
        //methods

        public override string ToString()
        {
            //return base.ToString();
            string description = "";

            switch (CharacterRace)
            {
                case Race.CityElf:
                    description = "A short elf with large eyes and pointed ears.\n" +
                        "More stout than your Dalish bretheren.";

                    break;
                case Race.DalishElf:
                    description = "A short elf with large eyes and pointed ears.\n" +
                        "Your vallaslin (religious face tattoo) sets you apart from your city bretheren.";
                    break;
                case Race.Dwarf:
                    description = "A dwarf. Shorter than the other races and stocky.";
                    break;
                case Race.Human:
                    description = "A human. Average in height and build compared to other races.";
                    break;
                case Race.Qunari:
                    description = "A qunari with large ram-like horns. Tall and muscular.\n" + 
                        "You still follow the Qun, your religion/culture.";
                    break;
                case Race.TalVashothQunari:
                    description = "A qunari with large ram-like horns. Tall and muscular.\n" +
                        "You abandoned the Qun, your species' religion/culture.";
                    break;                
            }//switch

            return string.Format("\nName: {7} {0}\nDescription: {6}\nLife: {1} of {2}\nHit Chance: {3}\n" +
                "Weapon:\n{4}\nBlock: {5}",
                Name, 
                Life, 
                MaxLife, 
                HitChance, 
                EquippedWeapon, 
                Block,
                description,
                Title);

        }//override tostring

        //Override the CalcDamage() to the Players EquippedWeapon Properties of MinDamage and MaxDamage

        public override int CalcDamage()
        {
            Random rand = new Random();
            return rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
        }//calcdamage

        public override int CalcHitChance()
        {
            return base.CalcHitChance() + EquippedWeapon.BonusHitChance;
        }//calchitchance



    }//class
}//namepsace
