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

        public Route(int[] pointIndexes)
        {
            _pointIndexes = pointIndexes;
        }

        public Route() {}
    }
}
