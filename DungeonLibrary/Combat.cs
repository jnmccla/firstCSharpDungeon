using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DungeonLibrary
{
    public class Combat
    {
        public static void DoAttack(Character attacker, Character defender)
        {
            //get a random number from 1 - 100 as a dice roll
            Random rand = new Random();
            int diceRoll = rand.Next(1, 101);
            Thread.Sleep(25);

            if (diceRoll <= (attacker.CalcHitChance() - defender.CalcBlock()))
            {
                //if the attack hit, calculate damage
                int damageDealt = attacker.CalcDamage();
                //assign damage 
                defender.Life -= damageDealt;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} hit {1} for {2} damage!",
                    attacker.Name,
                    defender.Name,
                    damageDealt);
                Console.ResetColor();

            }//if
            else
            {
                Console.WriteLine("{0} missed!",
                    attacker.Name);
            }//else

        }//doattack
        
        public static void DoBattle(Player player, Monster monster)
        {
            DoAttack(player, monster);

            if (monster.Life > 0)
            {
                DoAttack(monster, player);
            }//if

        }//dobattle


    }//class
}//namespace
