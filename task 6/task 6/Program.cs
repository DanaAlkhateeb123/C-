using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_6
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Warrior war = new Warrior("dana",50);
            Wizard wiz = new Wizard("sara", 50);
            GameCharacter[] GC = { war, wiz };
            for (int i = 0; i < GC.Length; i++)
            {
                GC[i].UseSpecialAbility();
            }
            war.TakeDamage(10);
            wiz.TakeDamage(10);

            Console.WriteLine(war.health);
            Console.WriteLine(wiz.health);

            war.Heal();
            war.Heal(5);

            wiz.Heal();
            wiz.Heal(5);

            HealthPotion h = new HealthPotion();
            h.PotionName = "Health Potion";
            h.Collect();

            h.Use(wiz, "5");   

            h.Use(wiz, "abc");


        }
    }
}
