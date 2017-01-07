using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Hik.Communication.Scs.Communication.EndPoints.Tcp;
using Hik.Communication.ScsServices.Client;
using DeliveryPizzaLib.Driver;

namespace DriverApp
{
    public class DriverPresenter : IDriverClient, IDriverPresenter
    {
        private const int INVALID_DRIVER_ID = -1;
        private const string defaultIP = "127.0.0.1";
        private const int defaultPort = 10047;

        private IScsServiceClient<IDriverServer> _scsClient;
        private IDriverServer _server;

        private LinkedList<IDriverConnectionListener> _connectionListeners;
        private IDriverOrderListener _orderListener;

        private int _driverId = INVALID_DRIVER_ID;

        public DriverPresenter()
        {
            _connectionListeners = new LinkedList<IDriverConnectionListener>();
        }

        void IDriverPresenter.RegisterDriver(int driverID)
        {
            try
            {
                _driverId = driverID;

                DriverClient listener = new DriverClient(this);
                _scsClient = ScsServiceClientBuilder.CreateClient<IDriverServer>(
                    new ScsTcpEndPoint(defaultIP, defaultPort), listener);
                _scsClient.Connect();

                _server = _scsClient.ServiceProxy;

                if (_driverId != INVALID_DRIVER_ID)
                {
                    _server.RegisterDriver(_driverId, 0);
                    NotifyConnected();
                }
                else
                {
                    _scsClient = null;
                    NotifyDisconnected();
                }
            }

            catch (Exception)
            {
                _scsClient = null;
                NotifyDisconnected();
            }
        }

        void IDriverPresenter.UnregisterDriver()
        {
            if (_scsClient != null)
            {
                _server.UnregisterDriver(_driverId);
                _scsClient.Disconnect();
                _scsClient = null;

                NotifyDisconnected();
            }
        }

        void IDriverPresenter.OnPizzaDelivered()
        {
            if (_scsClient != null)
            {
                _server.Delivered(_driverId);
            }
        }
        void IDriverPresenter.AddConnectionListener(IDriverConnectionListener connectionListener)
        {
            _connectionListeners.AddLast(connectionListener);
        }

        void IDriverPresenter.RemoveConnectionListener(IDriverConnectionListener connectionListener)
        {
            _connectionListeners.Remove(connectionListener);
        }

        void IDriverPresenter.SetOrderListener(IDriverOrderListener orderListener)
        {
            _orderListener = orderListener;
        }

        void NotifyConnected()
        {
            foreach (IDriverConnectionListener listener in _connectionListeners)
            {
                listener.OnConnected();
            }
        }

        void NotifyDisconnected()
        {
            foreach (IDriverConnectionListener listener in _connectionListeners)
            {
                listener.OnDisconnected();
            }
        }

        void IDriverClient.OnOrderReceived()
        {
            if (_scsClient != null && _driverId != INVALID_DRIVER_ID)
            {
                Route route = _server.GetRoute(_driverId);

                if (route != null && _orderListener != null)
                {
                    _orderListener.OnOrderReceived(route);
                }

            }
        }
    }

    public class DriverClient : IDriverClient
    {
        IDriverClient Client;
        public DriverClient(IDriverClient client)
        {
            Client = client;
        }
        public void OnOrderReceived()
        {
            Client.OnOrderReceived();
        }
    }
}
