using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2024
{
    public abstract class Burger
    {
        private string patty = "Beef";
        private string bun = "Plain Wheat";

        public virtual string getPatty()
        {
            return patty;
        }
        public string getBun()
        {
            return bun;
        }
        public string getBun(string optionone)
        {
            return optionone;
        }
        public string getBun(string optionone, string optiontwo)
        {
            return optionone + optiontwo;
        }
    }
}
