using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_6;

namespace task_6
{
    internal interface ICollectible
    {
       void Collect();
    }
}
public class HealthPotion: ICollectible
{
    public string PotionName {  get; set; }

   public void Collect()
    {
        Console.WriteLine("Health Potion collected!");
    }

    public void Use(GameCharacter character, string amountText)
    {
        try
        {
            int converted_amount = Convert.ToInt32(amountText);
            character.Heal(converted_amount);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input! Please enter a number.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("The number is outside the int range.");
        }
    }
}
