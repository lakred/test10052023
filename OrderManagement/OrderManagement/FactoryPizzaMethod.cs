using CsvHelper;
using OrderManagement.PizzaDecorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    public class FactoryPizzaMethod
    {
        private IPizza HandleSingleExtra(string extra, IPizza pizza)
        {
            switch (extra)
            {
                case "Prosciutto Cotto":
                    return new ProsciutDecorator(pizza);
                case "Funghi":
                    return new ChampignonDecorator(pizza);
                case "Prosciutto Crudo":
                    return new ProsciutCrudDecorator(pizza);
                case "Ananas":
                    return new AnanasDecorator(pizza);
                default:
                    return pizza;
            }
        }

        private IPizza HandleMultipleExtras(string[] extrasi, IPizza pizza)
        {
            IPizza output = pizza;
            for (int i = 0; i < extrasi.Length; i++)
            {
                output = HandleSingleExtra(extrasi[i], output);
            }
            return output;
        }
        public  IPizza GetPizza(string order)
        {
            IPizza output = null;
            string[] inputs = order.Split(';');
            string[] inputi = new string[3];

            string basePizza = "";
            string doughPizza = "";
            string extra = "";

            for (int i = 0; i < inputs.Length; i++)
            {
                inputi[i] = inputs[i];
            }

            basePizza = inputi[0];
            doughPizza = inputi[1];
            extra = inputi[2];

            string[] extras = extra.Split(',');
            string[] extrasi = new string[extras.Length];
            for (int i = 0; i < extras.Length; i++)
            {
                extrasi[i] = extras[i];
            }
            int extrasCount= extras.Length;





            switch (basePizza)
            {
                case "Bianca":
                    switch (doughPizza)
                    {
                        case "Normale":
                            switch (extrasCount)
                            {
                                case 0:
                                    output = new PizzaBianca();
                                    break;
                                case 1:
                                    output = HandleSingleExtra(extrasi[0], new PizzaBianca());
                                    break;
                                default:
                                    output = HandleMultipleExtras(extrasi, new PizzaBianca());
                                    break;
                            }
                            break;
                        case "Integrale":
                            switch (extrasCount)
                            {
                                case 0:
                                    output = new IntegralDecorator(new PizzaBianca());
                                    break;
                                case 1:
                                    output = HandleSingleExtra(extrasi[0], new IntegralDecorator(new PizzaBianca()));
                                    break;
                                default:
                                    output = HandleMultipleExtras(extrasi, new IntegralDecorator(new PizzaBianca()));
                                    break;
                            }
                            break;
                    }
                    break;
                case "Margherita":
                    switch (doughPizza)
                    {
                        case "Normale":
                            switch (extras.Length)
                            {
                                case 0:
                                    output = new Margherita();
                                    break;
                                case 1:
                                    output = HandleSingleExtra(extras[0], new Margherita());
                                    break;
                                default:
                                    output = HandleMultipleExtras(extrasi, new Margherita());
                                    break;
                            }
                            break;
                        case "Integrale":
                            switch (extras.Length)
                            {
                                case 0:
                                    output = new IntegralDecorator(new Margherita());
                                    break;
                                case 1:
                                   output = HandleSingleExtra(extras[0], new IntegralDecorator(new Margherita()));
                                    break;
                                default:
                                    output = HandleMultipleExtras(extrasi, new IntegralDecorator(new Margherita()));
                                    break;
                            }
                            break;
                    }
                    break;
                case "Napoletana":
                    switch (doughPizza)
                    {
                        case "Normale":
                            switch (extras.Length)
                            {
                                case 0:
                                    output = new Napoletana();
                                    break;
                                case 1:
                                    output = HandleSingleExtra(extras[0], new Napoletana());
                                    break;
                                default:
                                    output = HandleMultipleExtras(extras, new Napoletana());
                                    break;
                            }
                            break;
                        case "Integrale":
                            switch (extras.Length)
                            {
                                case 0:
                                    output = new IntegralDecorator(new Napoletana());
                                    break;
                                case 1:
                                    output = HandleSingleExtra(extras[0], new IntegralDecorator(new Napoletana()));
                                    break;
                                default:
                                    output = HandleMultipleExtras(extras, new IntegralDecorator(new Napoletana()));
                                    break;
                            }
                            break;
                    }
                    break;

            }
            if (output != null)
            {
                Console.WriteLine($"{output.GetDescription()} price: {output.GetCost()}");
            }
            return output;
        }
    }
}
