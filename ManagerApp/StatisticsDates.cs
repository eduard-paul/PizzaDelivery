using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeliveryPizzaLib.Manager;

namespace ManagerApp
{
    public partial class StatisticsDates : Form, IStatisticsView
    {
        public StatisticsDates()
        {
            InitializeComponent();
        }

        DateTime? IStatisticsView.GetStartDate()
        {
            return dateTimeStart.Value;
        }

        DateTime? IStatisticsView.GetEndDate()
        {
            return dateTimeEnd.Value;
        }

        void IStatisticsView.SetStatistics(Statistics statistics)
        {
            listViewStatistics.Items.Clear();
            listViewStatistics.Items.AddRange(StatisticsViewBase.GenerateItems(statistics));
        }
    }
}
