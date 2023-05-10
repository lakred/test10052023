using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.PizzaDecorator
{
    public class ProsciutDecorator : DecoratorPattern
    {
        public ProsciutDecorator(IPizza pizza) : base(pizza)
        {
            _name = " Prosciutto cotto";
            _price = 1;
        }
    }
}
