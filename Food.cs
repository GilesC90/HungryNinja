using System;

namespace HungryNinja
{
    public class Food
    {
        public string Name {get; set;}
        public int Calories {get; set;}
        // Foods can be Spicy and/or Sweet
        public bool IsSpicy {get; set;} 
        public bool IsSweet {get; set;} 
        // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet

        public Food (string name, int calories, bool isSpicy, bool isSweet)
        {
            Name = name;
            Calories = calories;
            IsSpicy = isSpicy;
            IsSweet = isSweet;
        }
        public override string ToString()
        {
            return @$"
            Name:         {Name}
            Calories:     {Calories}
            Is it spicy?: {IsSpicy}
            Is it sweet?: {IsSweet}
            ";
        }
    }
}