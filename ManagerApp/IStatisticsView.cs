using DeliveryPizzaLib.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerApp
{
    public interface IStatisticsView
    {
        DateTime? GetStartDate();
        DateTime? GetEndDate();

        void SetStatistics(Statistics statistics);

        void Show();
        void Hide();
    }
}
