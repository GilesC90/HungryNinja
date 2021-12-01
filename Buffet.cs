using System;
using System.Collections.Generic;

namespace HungryNinja
{
    public class Buffet
    {
        public List<Food> Menu {get; set; } = new List<Food>();
         
        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food ("Cheese Pizza", 450, false, false),
                new Food ("Pesto Pizza", 550, false, false),
                new Food ("Bourbon Wings", 750, true, true),
                new Food ("Chili Cheese Fries", 1199, false, false),
                new Food ("Cheesecake", 600, false, true),
                new Food ("Brownie Ice Cream", 850, false, true),
                new Food ("Oreo Cheesecake Cake", 1199, false, true)
            };
        }
         
        public Food Serve()
        {
            Random rand = new Random();
            var temp = Menu[rand.Next(Menu.Count)];
            System.Console.WriteLine(temp);
            return temp;
        }
    }


}