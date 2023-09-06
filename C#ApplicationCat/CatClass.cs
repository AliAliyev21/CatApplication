using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ApplicationCat
{
    public partial class Cat
    {
        public string Name { get; set; } = "Unknown";
        public double Energy { get; set; } = 100;
        public double Mass { get; set; } = 5;
        public string Meal { get; set; } = "Unknown";
        public bool IsSleep { get; set; } = false;
        public int SleepHours { get; set; } = 0;
        public string Breed { get; set; } = "Unknown";
        public bool IsHungry { get; set; } = false;
        public int HungryLevel { get; set; } = 50;
        public string Color { get; set; } = "Unknown";

        public Cat(string name, double energy,
            double mass, string meal, bool ısSleep,
            int sleepHours, string breed, bool ısHungry,
            int hungryLevel, string color)
        {
            Name = name;
            Energy = energy;
            Mass = mass;
            Meal = meal;
            IsSleep = ısSleep;
            SleepHours = sleepHours;
            Breed = breed;
            IsHungry = ısHungry;
            HungryLevel = hungryLevel;
            Color = color;
        }

        public Cat() { }  
    }
}
