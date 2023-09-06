using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ApplicationCat
{
    public partial class Cat
    {
        public void Eat()
        {
            if (IsHungry)
            {
                Console.WriteLine($"{Name} is eating {Meal}");
                Energy += 5;
                Mass += 0.1;
                HungryLevel -= 10;
                IsHungry = false;

                if (HungryLevel < 0)
                {
                    HungryLevel = 0;
                }
            }
            else
            {
                Console.WriteLine($"{Name} is not hungry now");
            }
        }

        public void Play()
        {
            if (IsSleep)
            {
                Console.WriteLine($"{Name} is sleeping. Wait until it wakes up");
            }
            else
            {
                if (IsHungry)
                {
                    if (Energy <= 0)
                    {
                        Console.WriteLine($"{Name} has no energy left to play. Game over!");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"{Name} is playing");
                        Energy -= 5;
                        Mass -= 0.1;
                        HungryLevel += 5;
                    }
                }
                else
                {
                    Console.WriteLine($"{Name} is not hungry now");
                }
            }
        }

        public void Sleep()
        {
            if (IsHungry && Energy <= 5)
            {
                Console.WriteLine($"{Name} is too hungry to sleep. Please feed {Name} first");
            }
            else if (Energy <= 5)
            {
                Console.WriteLine($"{Name} is too tired and hungry. {Name} is going to sleep");
                IsSleep = true;
                SleepHours += 1;
                Energy += 10;
                HungryLevel += 5;
            }
            else
            {
                Console.WriteLine($"{Name} is not tired enough to sleep");
            }
        }

        public void Show()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Energy: {Energy}");
            Console.WriteLine($"Mass: {Mass}");
            Console.WriteLine($"Meal: {Meal}");
            Console.WriteLine($"IsSleep: {IsSleep}");
            Console.WriteLine($"SleepHours: {SleepHours}");
            Console.WriteLine($"Breed: {Breed}");
            Console.WriteLine($"IsHungry: {IsHungry}");
            Console.WriteLine($"HungryLevel: {HungryLevel}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine();
        }
    }
}

