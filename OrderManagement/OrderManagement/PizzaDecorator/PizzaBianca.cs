using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.PizzaDecorator
{
    public class PizzaBianca:IPizza
    {
        public string GetDescription() => "Pizza Bianca";
        public int GetCost() => 5;
    }
}
