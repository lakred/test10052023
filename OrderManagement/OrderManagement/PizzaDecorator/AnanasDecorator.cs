using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OrderManagement.PizzaDecorator
{
    public class AnanasDecorator: DecoratorPattern
    {
        public AnanasDecorator(IPizza pizza) : base(pizza)
        {
            _name = "Ananas";
            if (pizza.GetDescription() == "Pizza Bianca")
            {
                _price = -5;
            }
            if (pizza.GetDescription() == "Pizza Margherita")
            {
                _price = -7;
            }
            if (pizza.GetDescription() == "Pizza Napoletana")
            {
                _price = -3;
            }
        }
    }
}
