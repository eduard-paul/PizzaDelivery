using DeliveryPizzaLib;
using DeliveryPizzaLib.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverApp
{
    public class RoutePresenter : IRoutePresenter
    {
        private Route _route;

        public RoutePresenter(Route route)
        {
            _route = route;
        }

        string IRoutePresenter.GetPizza()
        {
            return _route.pizzaType.ToString();
        }

        string IRoutePresenter.GetRouteToBase()
        {
            return GetRoutePath(0, FindBasePosition() - 1);
        }

        string IRoutePresenter.GetRouteToAddress()
        {
            return GetRoutePath(FindBasePosition(), _route._pointIndexes.Length-1);
        }

        string IRoutePresenter.GetFullRoute()
        {
            return GetRoutePath(0, _route._pointIndexes.Length - 1);
        }

        string GetRoutePath(int from, int to)
        {
            String path = "";
            int baseIndex = FindBasePosition();

            for (int i = from; i <= to; i++)
            {
                path += _route._pointIndexes[i];
                if (i < to)
                {
                    path += "; ";
                }
            }

            return path;
        }

        int FindBasePosition()
        {
            int prev = -1;
            int index = 0;
            foreach(int point in _route._pointIndexes)
            {
                if (point == prev)
                {
                    return index;
                }
                prev = point;
                index++;
            }
            return -1;
        }
    }
}
