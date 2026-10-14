using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_6
{
    internal class Wizard : GameCharacter
    {
        public Wizard(string name, int health) : base(name, health)
        {
            Name = name;
            Health = health;
        }
        public override void UseSpecialAbility()
        {
            Console.WriteLine("The Wizard uses magic!");
        }
        public override void TakeDamage(int amount)
        {
            Health = Health - amount;
        }

    }
}
