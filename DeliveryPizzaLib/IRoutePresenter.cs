using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryPizzaLib
{
    public interface IRoutePresenter
    {
        String GetPizza();
        String GetRouteToBase();
        String GetRouteToAddress();
        String GetFullRoute();
    }
}
