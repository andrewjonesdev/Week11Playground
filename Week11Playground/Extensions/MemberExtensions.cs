using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week11Playground.Models;
using Week11Playground.Models.Entities;

namespace Week11Playground.Extensions
{
    public static class MemberExtensions
    {
        public static string FightMember(this Member yourself, Member enemyMember)
        {
            if (yourself.Bounty > enemyMember.Bounty)
            {
                Console.WriteLine($"{yourself.Name} Defeated {enemyMember.Name} !");
                //ExtendedFightLogicMethod
                return $"{yourself.Name} Defeated {enemyMember.Name} !";
            }
            else if (yourself.Bounty == enemyMember.Bounty)
            {
                Console.WriteLine($"{enemyMember.Name} Defeated {yourself.Name} !");
                return $"{yourself.Name} and {enemyMember.Name} had a draw!";
            }
            else
            {
                Console.WriteLine($"{enemyMember.Name} Defeated {yourself.Name} !");
                return $"{enemyMember.Name} Defeated {yourself.Name} !";
            }

        }
        public static void SayHi(this Member yourself)
        {
            Console.WriteLine($"{yourself.Name} said Hi!");

        }
    }
}