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
    public partial class ManagerForm : Form, IManagerView
    {
        private IManagerPresenter _presenter;
        private StatisticsFull _statisticsTabFull;
        private StatisticsDates _statisticsTabDates;
        private IStatisticsView _currentForm;

        private Statistics _statistics;
        private Recommendations _recommendations;

        public ManagerForm()
        {
            InitializeComponent();
            initStatisticsForms();

            cbStatisticsOutTemplate.Items.Add("Вся статистика");
            cbStatisticsOutTemplate.Items.Add("Вывод по датам");
            cbStatisticsOutTemplate.SelectedIndex = 0;

            _presenter = new ManagerPresenter(this);
        }

        public void OnStatisticsUpdate(Statistics stat)
        {
            if (stat != null)
            {
                _statistics = stat;
                Invoke(new UpdateStatisticsDelegate(OnUpdateStatisticsInternal));
            }
        }

        public void OnRecommendationsUpdate(Recommendations recommend)
        {
            if (recommend != null)
            {
                _recommendations = recommend;
                Invoke(new UpdateRecommendationsDelegate(OnUpdateRecomendationsInternal));
            }
        }

        private void cbStatisticsOutTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = cbStatisticsOutTemplate.SelectedIndex;
            switch (idx)
            {
                case 0:
                    ShowForm(_statisticsTabFull);
                    break;

                case 1:
                    ShowForm(_statisticsTabDates);
                    break;
            }
        }

        private void initStatisticsForms()
        {
            _statisticsTabFull = new StatisticsFull();
            _statisticsTabFull.TopLevel = false;
            _statisticsTabFull.Parent = splitContainer1.Panel1;
            _statisticsTabFull.Dock = DockStyle.Fill;

            _statisticsTabDates = new StatisticsDates();
            _statisticsTabDates.TopLevel = false;
            _statisticsTabDates.Parent = splitContainer1.Panel1;
            _statisticsTabDates.Dock = DockStyle.Fill;
        }

        private void ShowForm(IStatisticsView formToShow)
        {
            if (_currentForm != null)
            {
                _currentForm.Hide();
            }
            _currentForm = formToShow;
            _currentForm.SetStatistics(_statistics);
            _currentForm.Show();
        }

        private void btnUpdateStatistics_Click(object sender, EventArgs e)
        {
            DateTime? startDate = _currentForm.GetStartDate();
            DateTime? endDate = _currentForm.GetEndDate();

            _presenter.GetStatistics(startDate, endDate);
        }

        private void btnLoadRecomendations_Click(object sender, EventArgs e)
        {
            _presenter.OnGetRecommendations();
        }

        public delegate void UpdateStatisticsDelegate();
        public delegate void UpdateRecommendationsDelegate();

        private void OnUpdateStatisticsInternal()
        {
            if (_statistics != null && _currentForm != null)
            {
                _currentForm.SetStatistics(_statistics);
            }
        }

        private void OnUpdateRecomendationsInternal()
        {
            listViewRecomendations.Items.Clear();
            if (_recommendations != null)
            {
                ManagerDataPresenters presenters = new ManagerDataPresenters();

                foreach (KeyValuePair<int, int> pair in _recommendations.GetReplacements())
                {
                    string[] row = {
                        presenters.getFilialAddressRender(pair.Key).Render(),
                        presenters.getFilialAddressRender(pair.Value).Render()
                    };

                    ListViewItem item = new ListViewItem(row);
                    listViewRecomendations.Items.Add(item);
                }
            }
        }
    }
}
