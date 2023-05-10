using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.PizzaDecorator
{
    public class IntegralDecorator:DecoratorPattern
    {
        public IntegralDecorator(IPizza pizza) : base(pizza) 
        {
            _name = "Integrale";
            _price = 1;
        }
    }
}
