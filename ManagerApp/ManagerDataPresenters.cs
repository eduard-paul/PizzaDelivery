using DeliveryPizzaLib;
using DeliveryPizzaLib.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerApp
{
    class ManagerDataPresenters
    {
        public IPizzaRender getPizzaRender(Order order)
        {
            return new ManagerPizzaRender(order.PizzaType);
        }

        public IDriverRender getDriverRender(Order order)
        {
            return new ManagerDriverRender(order.DriverId);
        }

        public IAddressRender getFilialAddressRender(Order order)
        {
            return new ManagerAddressRender(order.BranchILocationId);
        }

        public IAddressRender getFilialAddressRender(int branchId)
        {
            return new ManagerAddressRender(branchId);
        }

        public IAddressRender getDeliveryAddressRender(Order order)
        {
            return new ManagerAddressRender(order.LocationId);
        }


        class ManagerPizzaRender : IPizzaRender
        {
            private int? _pizzaType;

            public ManagerPizzaRender(int? pizzaType)
            {
                _pizzaType = pizzaType;
            }

            string IPizzaRender.Render()
            {
                return _pizzaType == null ? "-" : _pizzaType.Value.ToString();
            }
        }

        class ManagerDriverRender : IDriverRender
        {
            private int? _driver;

            public ManagerDriverRender(int? driver)
            {
                _driver = driver;
            }

            string IDriverRender.Render()
            {
                return _driver == null ? "-" : _driver.Value.ToString();
            }
        }

        class ManagerAddressRender : IAddressRender
        {
            private int? _address;

            public ManagerAddressRender(int? address)
            {
                _address = address;
            }

            string IAddressRender.Render()
            {
                return _address == null ? "-" : _address.Value.ToString();
            }
        }
    }
}
