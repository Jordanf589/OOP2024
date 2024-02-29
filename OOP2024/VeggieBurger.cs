using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2024
{
    public class VeggieBurger : Burger
    {
        string mushroom = "Mushroom";

        public override string getPatty()
        {
            return mushroom;
        }
    }
}
