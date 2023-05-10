using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.PizzaDecorator
{
    public abstract class DecoratorPattern : IPizza
    {
        private readonly IPizza _pizza;

        protected string _name = "";
        protected int _price = 0;

        public DecoratorPattern(IPizza pizza)
        {
            _pizza = pizza;
        }


        public string GetDescription() => $"{_pizza.GetDescription()} {_name}";

        public int GetCost() => (int)(_pizza.GetCost() + _price);
    }
}
