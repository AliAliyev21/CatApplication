using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ApplicationCat
{
    public partial class Customer
    {
        public string Name { get; set; } = "Unknown";
        public string Address { get; set; } = "Unknown";
        public string Email { get; set; } = "Unknown";
        public Cat[] Cats { get; set; }

        public Customer(string name, string address, string email, Cat[] cats)
        {
            Name = name;
            Address = address;
            Email = email;
            Cats = cats;
        }

        public Customer()
        {
            Cats = null;
        }

        public void AdoptCat(Cat cat)
        {
            if (Cats == null)
            {
                Cats = new Cat[1];
                Cats[0] = cat;
            }
            else
            {
                int currentCount = Cats.Length;
                Cat[] newCats = new Cat[currentCount + 1];
                for (int i = 0; i < currentCount; i++)
                {
                    newCats[i] = Cats[i];
                }
                newCats[currentCount] = cat;
                Cats = newCats;
            }
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"{Name} has adopted a cat named {cat.Name}");
            Console.ResetColor();
        }
    }
}
