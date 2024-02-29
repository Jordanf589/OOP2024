using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2024
{
    public class CheeseBurger : Burger
    {
        public string Cheese = "Cheese";

        public string getCheese()
        {
            return Cheese;
        }
        public string AddCheddar()
        {
            this.Cheese = "Cheddar";
            return this.Cheese;
        }
    }
}
