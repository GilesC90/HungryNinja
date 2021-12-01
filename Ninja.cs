using System;
using System.Collections.Generic;

namespace HungryNinja
{
    public class Ninja
    {
        private int caloricIntake;
        public List<Food> FoodHistory;
        // add a constructor
        public Ninja()
        {
            caloricIntake = 0;
            FoodHistory = new List<Food>();
        }
        // add a public "getter" property called "IsFull"
        public bool IsFull 
        {
            get
            {
                return caloricIntake > 1200;
            }
        }
         
        // build out the Eat method
        public bool Eat (Food item)
        {
            if(!IsFull)
            {
                caloricIntake += item.Calories;
                FoodHistory.Add(item);
                System.Console.WriteLine($"Ninja really like {item.Name}");
            }
            else
            {
                System.Console.WriteLine("Ninja can't eat another bite.");
            }
            return IsFull;
        }
    }


}