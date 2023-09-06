namespace C_ApplicationCat
{
    public class Program
    {
        static public void ShowAllMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t= > = > = >Menyu< = < = < =");
            Console.WriteLine("1.Client\t\t\t   2.Owner");
            Console.WriteLine("\t\t  3.Exit");
            Console.ResetColor();
        }

        static public void ClientMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t= > = > = >Client Menyu< = < = < =");
            Console.WriteLine("1.Show All the cats\t\t\t    2.Buy a cat");
            Console.WriteLine("\t\t\t    3.Back");
            Console.ResetColor();
        }

        static public void OwnerMenu()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\t= > = > = >Owner Menyu< = < = < =");
            Console.WriteLine("View Cats at Home       [1]");
            Console.WriteLine("View Cats in the Store  [2]");
            Console.WriteLine("Feed the cat            [3]");
            Console.WriteLine("Play with the cat       [4]");
            Console.WriteLine("Put the cat to sleep    [5]");
            Console.WriteLine("Back                    [6]");
            Console.ResetColor();
        }

        static void Main(string[] args)
        {
            Cat cat1 = new Cat("Luna", 100, 5, "Fish", false, 0, "Siamese", true, 50, "White");
            Cat cat2 = new Cat("Oliver", 60, 5, "Chicken", false, 0, "Persian", false, 50, "Gray");
            Cat cat3 = new Cat("Milo", 90, 6, "Beef", false, 0, "Maine Coon", true, 50, "Brown");

            Cat[] cats = { cat1, cat2, cat3 };

            CatHouse house = new CatHouse(cats, cats.Length);
            CatShop shop = new CatShop(cats, cats.Length);
            Customer customer = new Customer();

            foreach (Cat cat in cats)
            {
                house.AddCat(cat);
                shop.AddCat(cat);
            }
            Console.Clear();

            while (true)
            {
                ShowAllMenu();
                Console.Write("Enter the choice : ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        ClientMenu();

                        string clientChoice = Console.ReadLine();

                        switch (clientChoice)
                        {
                            case "1":
                                shop.Show();
                                break;
                            case "2":
                                shop.Show();
                                Console.Write("Please enter the name of the cat you want to buy : ");
                                string catName = Console.ReadLine();

                                Cat selectedCat = null;

                                foreach (Cat cat in shop.GetCats())
                                {
                                    if (cat != null && cat.Name != null && cat.Name.Equals(catName, StringComparison.OrdinalIgnoreCase))
                                    {
                                        selectedCat = cat;
                                        customer.AdoptCat(selectedCat);
                                        Console.Clear();
                                        break;
                                    }
                                }

                                if (selectedCat != null)
                                {
                                    Console.WriteLine("Received Cat Information");
                                    selectedCat.Show();
                                }
                                else
                                {
                                    Console.WriteLine("Cat not found");
                                }
                                break;
                            case "3":
                                Console.WriteLine("Back to the main menu");
                                break;

                            default:
                                Console.WriteLine("Invalid selection, please try again");
                                break;
                        }
                        break;
                    case "2":
                        OwnerMenu();
                        while (true)
                        {
                            string ownerChoice = Console.ReadLine();

                            switch (ownerChoice)
                            {
                                case "1":
                                    Console.Clear();
                                    house.Show();
                                    OwnerMenu();
                                    break;

                                case "2":
                                    shop.Show();
                                    break;

                                case "3":
                                    Console.Write("Enter the cat's name to feed: ");
                                    string feedCatName = Console.ReadLine();
                                    foreach (Cat cat in house.GetCats())
                                    {
                                        if (cat != null && cat.Name.Equals(feedCatName, StringComparison.OrdinalIgnoreCase))
                                        {
                                            cat.Eat();
                                            break;
                                        }
                                    }

                                    break;

                                case "4":
                                    Console.Write("Enter the cat's name to play: ");
                                    string playCatName = Console.ReadLine();
                                    foreach (Cat cat in house.GetCats())
                                    {
                                        if (cat != null && cat.Name.Equals(playCatName, StringComparison.OrdinalIgnoreCase))
                                        {
                                            cat.Play();
                                            break;
                                        }
                                    }
                                    break;

                                case "5":
                                    Console.Write("Enter the cat's name to put to sleep: ");
                                    string sleepCatName = Console.ReadLine();
                                    foreach (Cat cat in house.GetCats())
                                    {
                                        if (cat != null && cat.Name.Equals(sleepCatName, StringComparison.OrdinalIgnoreCase))
                                        {
                                            cat.Sleep();
                                            break;
                                        }
                                    }
                                    break;

                                case "6":
                                    Console.WriteLine("Returning to the main menu.");
                                    break;

                                default:
                                    Console.WriteLine("Invalid selection, please try again");
                                    break;
                            }

                            if (ownerChoice == "6")
                                break;
                        }
                        break;
                    case "3":
                        Console.WriteLine("Exiting the program.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }
    }
}