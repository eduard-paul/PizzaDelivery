﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryPizzaLib.Driver
{
    [Serializable]
    public class Route
    {
        public int[] _pointIndexes;
        public int pizzaType;

        public Route(int[] pointIndexes)
        {
            _pointIndexes = pointIndexes;
        }

        public Route() {}

        public Route Concat(Route route)
        {
            int[] res = _pointIndexes.Concat(route._pointIndexes).ToArray();
            return new Route(res);
        }

        public override string ToString()
        {
            string s = "PT: " + pizzaType + " Route: [";
            foreach (int n in _pointIndexes)
            {
                s += n + ", ";
            }

            return s.Remove(s.Length - 2) + "]"; 
        }
    }
}
