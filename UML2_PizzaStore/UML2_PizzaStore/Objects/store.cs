using System;
using System.Collections.Generic;
using System.Text;

namespace UML2_PizzaStore.Objects
{
    public class store
    {

        public void run()
        {
            Menu m = new Menu();
            bool running = true;

            while (running)
            {

                Console.Clear();
                Console.WriteLine("Main Menu");
                Console.WriteLine("Options:");
                Console.WriteLine("1: Create Pizza");
                Console.WriteLine("2: Display Menu");
                Console.WriteLine("3: Delete Pizza");
                Console.WriteLine("4: Modify Pizza");
                Console.WriteLine("5: Search the menu");
                Console.WriteLine();
                string choice = Console.ReadLine();

                const string optionCreatePizza = "1";
                const string optionDisplayMenu = "2";
                const string optionDeletePizza = "3";
                const string optionModifyPizza = "4";
                const string optionSearchMenu = "5";

                if (choice == optionCreatePizza)
                {
                    Console.Clear();
                    Console.WriteLine("What is the name of the pizza?");
                    string name = Console.ReadLine();
                    int i = 0;


                    Console.Clear();

                    while (i == 0) {
                        Console.WriteLine("What is the price?");
                        string priceStr = Console.ReadLine();
                        int price;
                        if (int.TryParse(priceStr, out price))
                            if (price > 0) {
                                m.addPizza(name, price);
                                i++;
                            } else
                            {
                                Console.Clear();
                                Console.WriteLine($"Illegal price, try again.");
                            }
                    }
                    Console.Clear();
                    Console.WriteLine($"New Pizza {name} created.");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    continue;
                }
                if (choice == optionDisplayMenu)
                {
                    Console.Clear();
                    m.printMenu();

                    Console.WriteLine("Press any key to Continue");
                    Console.ReadKey();

                    continue;
                }
                if (choice == optionDeletePizza)
                {
                    Console.Clear();

                    m.printMenu();
                    Console.WriteLine("Which pizza do you want to delete? (Number)");

                    string numberStr = Console.ReadLine();
                    int number;
                    if (int.TryParse(numberStr, out number))

                        m.deletePizza(number);

                    Console.WriteLine("Pizza deleted");

                    Console.WriteLine("Press any key to Continue");
                    Console.ReadKey();

                    continue;
                }
                if (choice == optionModifyPizza)
                {
                    Console.Clear();

                    //Write code below
                    m.printMenu();
                    Console.WriteLine("What pizza do you want to edit?");

                    string numberStr = Console.ReadLine();
                    int number;
                    if (int.TryParse(numberStr, out number))

                    Console.Clear();
                    Console.WriteLine("What part do you want to edit?");
                    Console.WriteLine("1: Pizza Name");
                    Console.WriteLine("2: Pizza Price");

                    string optionChoice = Console.ReadLine();

                    string optionNameEdit = "1";
                    string optionPriceEdit = "2";

                    if (optionChoice == optionNameEdit)
                    {
                        Console.Clear();
                        Console.WriteLine("What should the new name be?");
                        string name = Console.ReadLine();

                        m.nameFinder(number, name);
                    }
                    if (optionChoice == optionPriceEdit) 
                    {
                        int i = 0;
                        while (i == 0) 
                        {
                            Console.Clear();
                            Console.WriteLine("What should the new price be?");
                            string priceStr = Console.ReadLine();
                            int price;
                            if (int.TryParse(priceStr, out price))

                            if (price > 0) 
                            {
                                m.priceFinder(number, price);
                                    i++;
                            } 
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Illegal price, try again");
                            }
                        }
                    }
                    

                    
                    Console.WriteLine("Press any key to Continue");
                    Console.ReadKey();

                    continue;
                }
                if (choice == optionSearchMenu)
                {
                    Console.Clear();
                    Console.WriteLine("What do you want to find?");

                    string search = Console.ReadLine();

                    m.searchPizza(search);

                    Console.WriteLine("Press any key to Continue");
                    Console.ReadKey();

                    continue;
                }
            }
        }
        public store()
        {
            run();
        }
    }
}
