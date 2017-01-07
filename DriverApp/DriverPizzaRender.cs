using DeliveryPizzaLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverApp
{
    class DriverPizzaRender : IPizzaRender
    {
        private int _pizzaType;

        public DriverPizzaRender(int pizzaType)
        {
            _pizzaType = pizzaType;
        }

        string IPizzaRender.Render()
        {
            return _pizzaType.ToString();
        }
    }
}
