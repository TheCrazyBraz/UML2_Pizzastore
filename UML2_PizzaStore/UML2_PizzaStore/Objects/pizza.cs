using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace UML2_PizzaStore.Objects
{
    public class pizza
    {
        toppings t0 = new toppings(" ");
        toppings t1 = new toppings("Cheese");
        toppings t2 = new toppings("Tomato Sauce,");
        toppings t3 = new toppings("Ham,");
        toppings t4 = new toppings("Pepperoni,");
        toppings t5 = new toppings("Pineapple,");
        toppings t6 = new toppings("Lettuce,");
        public List<toppings> ToppingMenu()
        {
            List<toppings> toppingList = new List<toppings>();
            toppingList.Add(t0);
            toppingList.Add(t1);
            toppingList.Add(t2);
            toppingList.Add(t3);
            toppingList.Add(t4);
            toppingList.Add(t5);
            toppingList.Add(t6);

            return toppingList;
        }

        public string toppingFinder(int i)
        {

            List<toppings> toppingList = ToppingMenu();
            string output = string.Join("," , toppingList[i]);

            return output;
        }
        public void printToppings()
        {
            List<toppings> toppingMenu = ToppingMenu();

            foreach(toppings t in toppingMenu)
            {
                Console.WriteLine(t);
            }
        }

        public string _name;
        public double _price;

        public pizza(string name = "Null", double price = 0)
        {
            _name = name;
            _price = price;



        }
        public override string ToString()
        {
            return _name.ToString()  +  " - Price: " + _price.ToString();
        }
    }

}
