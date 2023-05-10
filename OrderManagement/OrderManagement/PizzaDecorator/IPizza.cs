﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.PizzaDecorator
{
    public interface IPizza
    {
        string GetDescription();
        int GetCost();

    }
}
