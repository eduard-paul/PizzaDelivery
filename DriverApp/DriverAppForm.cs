using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DeliveryPizzaLib.Driver;
using DeliveryPizzaLib;

namespace DriverApp
{
    public partial class DriverAppForm : Form, IDriverConnectionListener, IDriverOrderListener
    {
        private const int INVALID_DRIVER_ID = -1;

        private IDriverPresenter _presenter;

        private bool _logoutInProgress = false;

        Route _route;

        public DriverAppForm(IDriverPresenter presenter)
        {
            InitializeComponent();

            labelStatus.Text = "Свободен";
            pizzaType.Text = "";
            routeToBase.Text = "";
            routeToAddress.Text = "";

            _presenter = presenter;
            _presenter.AddConnectionListener(this);
            _presenter.SetOrderListener(this);
        }

        void IDriverOrderListener.OnOrderReceived(Route route)
        {
            _route = route;

            Invoke(new OrderReceivedDelegate(OnOrderReceivedInternal));
        }

        void IDriverConnectionListener.OnConnected()
        {
            //stub
        }

        void IDriverConnectionListener.OnDisconnected()
        {
            Invoke(new OnDisconnectedDelegate(onDisconnectedInternal));
        }

        private void btnDelivered_Click(object sender, EventArgs e)
        {
            _presenter.OnPizzaDelivered();

            _route = null;
            OnOrderReceivedInternal();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            _logoutInProgress = true;
            _presenter.UnregisterDriver();
        }

        public delegate void OrderReceivedDelegate();
        public delegate void OnDisconnectedDelegate();

        private void OnOrderReceivedInternal()
        {
            if (_route == null)
            {
                labelStatus.Text = "Свободен";
                pizzaType.Text = "";
                routeToBase.Text = "";
                routeToAddress.Text = "";
            }
            else
            {
                IRoutePresenter rp = new RoutePresenter(_route);
                labelStatus.Text = "доставка";
                pizzaType.Text = rp.GetPizza();
                routeToBase.Text = rp.GetRouteToBase();
                routeToAddress.Text = rp.GetRouteToAddress();
            }
        }

        private void onDisconnectedInternal()
        {
            if (_logoutInProgress)
            {
                Close();
            }
            else
            {
                MessageBox.Show("Соединение с сервером разорвано", "Ошибка соединения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
    }
}
