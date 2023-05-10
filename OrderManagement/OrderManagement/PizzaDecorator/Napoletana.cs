using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.PizzaDecorator
{
    public class Napoletana : IPizza
    {
        public string GetDescription() => "Pizza Napoletana";
        public int GetCost() => 3;
    }
}
