using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.PizzaDecorator
{
    public class Margherita : IPizza
    {
        public string GetDescription() => "Pizza Margherita";
        public int GetCost() => 7;
    }
}
