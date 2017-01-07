using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerApp
{
    class DataBase : IDatabase
    {
        IDatabase dbImpl;
        Random _rnd;

        public DataBase()
        {
            dbImpl = this;
            _rnd = new Random();
        }

        void IDatabase.put(DeliveryPizzaLib.Manager.Order order)
        {
            // stub
        }

        List<DeliveryPizzaLib.Manager.Order> IDatabase.getAll()
        {
            // stub
            List<DeliveryPizzaLib.Manager.Order> orders = new List<DeliveryPizzaLib.Manager.Order>();
            for (int i = 0; i < 20; i++)
            {
                orders.Add(generateOrder());
            }

            return orders;
        }

        List<DeliveryPizzaLib.Manager.Order> IDatabase.getAfter(DateTime time)
        {
            // stub
            return dbImpl.getAll();
        }

        List<DeliveryPizzaLib.Manager.Order> IDatabase.getBefore(DateTime time)
        {
            // stub
            return dbImpl.getAll();
        }

        List<DeliveryPizzaLib.Manager.Order> IDatabase.getBetween(DateTime start, DateTime end)
        {
            // stub
            return dbImpl.getAll();
        }

        List<DeliveryPizzaLib.Manager.Order> IDatabase.getByDriverId(int id)
        {
            // stub
            return dbImpl.getAll();
        }

        List<DeliveryPizzaLib.Manager.Order> IDatabase.getByBranchId(int id)
        {
            // stub
            return dbImpl.getAll();
        }

        List<DeliveryPizzaLib.Manager.Order> IDatabase.getByPizzaType(int id)
        {
            // stub
            return dbImpl.getAll();
        }

        DeliveryPizzaLib.Manager.Order generateOrder()
        {
            DateTime ordered = DateTime.Now
                .AddDays(_rnd.Next(-7, -1))
                .AddHours(_rnd.Next(-23, -1))
                .AddMinutes(_rnd.Next(-59, -1))
                .AddSeconds(_rnd.Next(-59, -1));

            return new DeliveryPizzaLib.Manager.Order(
                ordered,                   // ordered
                ordered.AddMinutes(_rnd.Next(1, 59)).AddSeconds(_rnd.Next(1, 59)),    // delivered
                _rnd.Next(1, 20),                                          // driver ID
                _rnd.Next(1, 5),                                         // branch id
                _rnd.Next(1, 5),                                          // pizza type
                _rnd.Next(1, 1000)                                          // location id
                );
        }
    }
}
