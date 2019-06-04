using System;
using System.Collections.Generic;

namespace Hungry_Ninja
{
    class Program
    {
        class Food
        {
            public string Name;
            public int Calories;
            // Foods can be Spicy and/or Sweet
            public bool IsSpicy;
            public bool IsSweet;
            // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet

            public Food(string n, int cal, bool spicy, bool sweet)
            {
                Name = n;
                Calories = cal;
                IsSpicy = spicy;
                IsSweet = sweet;
            }
        }

        class Buffet
        {
            public List<Food> Menu;

            public Buffet()
            {
                Menu = new List<Food>()
                {
                new Food("Donut", 200, false, true),
                new Food("Creme",  100, false, true),
                new Food("Chocolate", 300, false, true),
                new Food("Tiramisu", 100, false, true),
                new Food("Ice Cream", 100, false, true),
                new Food("Gelato", 200, false, true),
                };
            }

            public Food Serve()
            {
                Random rand = new Random();
                Food item = Menu[rand.Next(0, Menu.Count)];
                return item;
            }
        }

        class Ninja
        {
            public int calorieIntake;
            public List<Food> FoodHistory;

            public Boolean ans = false;

            public Boolean isFull
            {
                get
                {
                    return ans;
                }
            }

            public Ninja()
            {
                FoodHistory = new List<Food>()
                {
                };

                calorieIntake = 0;
                ans = false;

            }
            public void Eat(Food item)
            {
                if (calorieIntake < 1200)
                {
                    calorieIntake += item.Calories;
                    FoodHistory.Add(item);
                    System.Console.WriteLine(item.Name + " " + item.Calories + " " + item.IsSpicy + " " + item.IsSweet);
                    System.Console.WriteLine("Ninja's Calorie Intake : " + calorieIntake);
                }

                else
                {
                    System.Console.WriteLine("Ninja is too full!");
                }
            }
        }




        static void Main(string[] args)
        {
            Buffet myBuffet = new Buffet();
            myBuffet.Serve();
            Ninja Ninja1 = new Ninja();
            Ninja1.Eat(myBuffet.Serve());
            Ninja1.Eat(myBuffet.Serve());
            Ninja1.Eat(myBuffet.Serve());
            Ninja1.Eat(myBuffet.Serve());
            Ninja1.Eat(myBuffet.Serve());
            Ninja1.Eat(myBuffet.Serve());
            Ninja1.Eat(myBuffet.Serve());
            Ninja1.Eat(myBuffet.Serve());
            Ninja1.Eat(myBuffet.Serve());
        }
    }
}
