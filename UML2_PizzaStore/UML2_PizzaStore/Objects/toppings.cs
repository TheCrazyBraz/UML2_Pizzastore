using System;
using System.Collections.Generic;
using System.Text;

namespace UML2_PizzaStore.Objects
{
    public class toppings
    {
        string _name;
        public toppings(string name){
            _name = name;

        }
        public override string ToString()
        {
            return _name.ToString();
        }
    }
 
}
