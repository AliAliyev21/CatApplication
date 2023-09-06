using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ApplicationCat
{
    public partial class CatHouse
    {
        public CatHouse(int capacity)
        {
            cats = new Cat[capacity];
            catCount = 0;
        }

        public Cat[] GetCats()
        {
            return cats;
        }

        public void AddCat(Cat cat)
        {
            if (catCount < cats.Length)
            {
                cats[catCount] = cat;
                Console.WriteLine($"{cat.Name} has been added to the cat house.");
                catCount++;
            }
            else
            {
                Console.WriteLine("Cat house is full. Cannot add more cats");
            }
        }

        public void RemoveCat(string catName)
        {
            for (int i = 0; i < catCount; i++)
            {
                if (cats[i].Name == catName)
                {
                    for (int j = i; j < catCount - 1; j++)
                    {
                        cats[j] = cats[j + 1];
                    }
                    cats[catCount - 1] = null;
                    catCount--;
                    Console.WriteLine($"{catName} has been removed from the cat house");
                    return;
                }
            }

            Console.WriteLine($"{catName} is not in the cat house");
        }

        public double GetTotalMass()
        {
            double totalMass = 0;

            foreach (Cat cat in cats)
            {
                if (cat != null)
                {
                    totalMass += cat.Mass;
                }
            }
            return totalMass;
        }

        public double GetTotalConsume()
        {
            double totalConsume = 0;

            foreach (Cat cat in cats)
            {
                if (cat != null && cat.Meal != null)
                {
                    totalConsume += 5;
                }
            }
            return totalConsume;
        }

        public void EatAllCats()
        {
            foreach (Cat cat in cats)
            {
                if (cat != null)
                {
                    cat.Eat();
                }
            }
        }

        public void PlayAllCats()
        {
            foreach (Cat cat in cats)
            {
                if (cat != null)
                {
                    cat.Play();
                }
            }
        }

        public void SleepAllCats()
        {
            foreach (Cat cat in cats)
            {
                if (cat != null)
                {
                    cat.Sleep();
                }
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t= > = > = >Welcome to the cat house< = < = < =");
            for (int i = 0; i < catCount; i++)
            {
                cats[i]?.Show();
            }
            Console.ResetColor();
        }
    }
}

