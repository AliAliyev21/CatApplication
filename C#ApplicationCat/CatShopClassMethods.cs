using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ApplicationCat
{
    public partial class CatShop
    {
        public CatShop(int capacity)
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
                Console.WriteLine($"{cat.Name} has been added to the cat shop.");
                catCount++;
            }
            else
            {
                Console.WriteLine("Cat shop is full. Cannot add more cats");
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
                    Console.WriteLine($"{catName} has been removed from the cat shop");
                    return;
                }
            }

            Console.WriteLine($"{catName} is not in the cat shop");
        }

        public double GetTotalMass()
        {
            double totalMass = 0;

            if (cats != null)
            {
                foreach (Cat cat in cats)
                {
                    if (cat != null)
                    {
                        totalMass += cat.Mass;
                    }
                }
            }
            return totalMass;
        }

        public double GetTotalConsume()
        {
            double totalConsume = 0;

            if (cats != null)
            {
                foreach (Cat cat in cats)
                {
                    if (cat != null && cat.Meal != null)
                    {
                        totalConsume += 5;
                    }
                }
            }
            return totalConsume;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\t= > = > = >Welcome to the cat shop< = < = < =");
            Console.ResetColor();
            for (int i = 0; i < catCount; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                cats[i]?.Show();
                Console.ResetColor();
            }
        }
    }
}
