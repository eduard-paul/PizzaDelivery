using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverApp
{
    public interface IDriverPresenter
    {
        void RegisterDriver(int driverID);

        void UnregisterDriver();

        void OnPizzaDelivered();

        void AddConnectionListener(IDriverConnectionListener connectionListener);

        void RemoveConnectionListener(IDriverConnectionListener connectionListener);

        void SetOrderListener(IDriverOrderListener orderListener);
    }
}
