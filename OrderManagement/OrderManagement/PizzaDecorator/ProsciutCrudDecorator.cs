using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OrderManagement.PizzaDecorator
{
    public class ProsciutCrudDecorator: DecoratorPattern
    {
        public ProsciutCrudDecorator(IPizza pizza) : base(pizza)
        {
            _name = "Prosciutto Crudo ";
            _price = 1;
        }
    }
}
