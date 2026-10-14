using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_6
{
    public abstract class GameCharacter
    {
        private string _name;
        public string Name {  get { return _name; } 

        set { _name = value; } }
        protected int Health;
        public int health
        {
            get { return Health; }

            set { Health = value; }
        }
        public GameCharacter(string name, int health)
        {
            _name = name;
            if (health >= 0 && health<= 100) { Health = health; }
        }
       public abstract void UseSpecialAbility();
       public virtual void TakeDamage(int amount)
        { 
        }
        public void Heal()
        {
            Health += 10;
            if (Health > 100) { Health = 100; }
            Console.WriteLine($"new health = {Health}");
        }
        public void Heal(int amount)
        {
            Health += amount;
            if (Health > 100) { Health = 100; }
            Console.WriteLine($"new health = {Health}");
        }


    }

    
}
