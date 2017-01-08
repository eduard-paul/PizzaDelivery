using DeliveryPizzaLib;
using DeliveryPizzaLib.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerApp
{
    public class StatisticsViewBase
    {
        public static ListViewItem[] GenerateItems(Statistics statistics)
        {
            List<ListViewItem> collection = new List<ListViewItem>();
            if (statistics != null)
            {
                String dateTimeFormat = "dd.MM.yyyy HH:mm";
                ManagerDataPresenters presenters = new ManagerDataPresenters();

                foreach (Order order in statistics.GetOrders())
                {
                    string[] row = {
                        order.OrderTime.ToString(dateTimeFormat),
                        order.DeliveredTime == null ? "null" : order.DeliveredTime.Value.ToString(dateTimeFormat),
                        presenters.getPizzaRender(order).Render(),
                        presenters.getDriverRender(order).Render(),
                        presenters.getFilialAddressRender(order).Render(),
                        presenters.getDeliveryAddressRender(order).Render()
                    };

                    ListViewItem item = new ListViewItem(row);
                    collection.Add(item);
                }
            }

            return collection.ToArray();
        }
    }
}
