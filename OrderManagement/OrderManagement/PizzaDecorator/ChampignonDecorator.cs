using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OrderManagement.PizzaDecorator
{
    public class ChampignonDecorator: DecoratorPattern
    {
        public ChampignonDecorator(IPizza pizza) : base(pizza)
        {
            _name = "Funghi";
            _price = 1;
        }
    }
}
