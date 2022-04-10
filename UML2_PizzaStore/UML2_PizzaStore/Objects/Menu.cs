using System;
using System.Collections.Generic;
using System.Text;

namespace UML2_PizzaStore.Objects
{
    public class Menu
    {
        public List<pizza> pizzaMenu = new List<pizza>();


        public void printMenu()
        {
            int i = 0;
            foreach (pizza p in pizzaMenu)
            {

                Console.WriteLine(i + ": " + p);
                i++;

            }
        }
        public void deletePizza(int number)
        {
            pizzaMenu.RemoveAt(number);
        }
        public void existingMenu()
        {
            pizzaMenu.Add(new pizza("asnæs", 79));
            pizzaMenu.Add(new pizza("venus", 75));
            pizzaMenu.Add(new pizza("glumsø", 79));
            pizzaMenu.Add(new pizza("napoli", 76));
            pizzaMenu.Add(new pizza("vesuvo", 67));
            pizzaMenu.Add(new pizza("capricciosa", 72));
            pizzaMenu.Add(new pizza("torino", 83));
            pizzaMenu.Add(new pizza("alloro", 72));
            pizzaMenu.Add(new pizza("jamaica", 70));
            pizzaMenu.Add(new pizza("venesia", 75));
            pizzaMenu.Add(new pizza("matador", 77));
            pizzaMenu.Add(new pizza("genova", 79));
            pizzaMenu.Add(new pizza("juventus", 75));
            pizzaMenu.Add(new pizza("parma", 76));
            pizzaMenu.Add(new pizza("palermo", 65));
            pizzaMenu.Add(new pizza("italiana", 70));
            pizzaMenu.Add(new pizza("vegetar pizza", 69));
            pizzaMenu.Add(new pizza("milan", 79));
            pizzaMenu.Add(new pizza("viella", 75));
            pizzaMenu.Add(new pizza("hvidløgsbrød", 49));
        }
        public void addPizza(string name, int price)
        {
            var newPizza = new pizza(name, price);
            pizzaMenu.Add(newPizza);
        }

        public void searchPizza(string value)
        {
            int i = 0;
            foreach (pizza p in pizzaMenu)
            {
                if (i >= pizzaMenu.Count)
                { }
                else {
                    if (pizzaMenu[i]._name.Contains(value))
                    {
                        Console.WriteLine(i + ": " + p);
                    }
                    i++;
                }
            }
        }


        public void priceFinder(int index, int price)
        {
            pizzaMenu[index]._price = price;

        }

        public void nameFinder(int index, string name)
        {
            pizzaMenu[index]._name = name;

        }



        public Menu()
        {
            existingMenu();
        }
    }
}
