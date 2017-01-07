using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Hik.Communication.ScsServices.Service;
using DeliveryPizzaLib.Manager;

namespace ServerApp
{
    class ManagerServer : ScsService, IManagerServer
    {
        IDatabase database = null;

        public ManagerServer(IDatabase database)
        {
            this.database = database;
        }

        Statistics IManagerServer.GetStatistics(DateTime? dateBegin, DateTime? dateEnd)
        {
            Console.WriteLine("GetStatistics");
            if (database != null)
            {
                List<Order> orders = null;
                if (dateBegin == null && dateEnd == null)
                {
                    orders = database.getAll();
                }
                else if (dateBegin != null && dateBegin == null)
                {
                    orders = database.getAfter(dateBegin.Value);
                }
                else if (dateBegin == null && dateEnd != null)
                {
                    orders = database.getBefore(dateEnd.Value);
                }
                else
                {
                    orders = database.getBetween(dateBegin.Value, dateEnd.Value);
                }
                return new Statistics(orders.ToArray());
            }
            return new Statistics();
        }

        Recommendations IManagerServer.GetRecommendations()
        {
            Console.WriteLine("GetRecommendations");
            KeyValuePair<int,int>[] rpms = new KeyValuePair<int,int>[3];
            rpms[0] = new KeyValuePair<int, int>(0,1);
            rpms[1] = new KeyValuePair<int, int>(3,7);
            rpms[2] = new KeyValuePair<int, int>(60, 31);
            return new Recommendations(rpms);
        }
    }
}
