using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriverApp
{
    public partial class LoginForm : Form, IDriverConnectionListener
    {
        IDriverPresenter _presenter;

        public LoginForm(IDriverPresenter presenter)
        {
            InitializeComponent();

            authStatus.Text = "";

            _presenter = presenter;
            _presenter.AddConnectionListener(this);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            _presenter.RegisterDriver(GetDriverId());
        }

        public int GetDriverId()
        {
            if (driverCode.Text.Length > 0)
            {
                return Int32.Parse(driverCode.Text);
            }
            return 0;
        }

        public void OnConnected()
        {
            authStatus.Text = "Успешная авторизация";
            DialogResult = DialogResult.OK;
            Dispose();
        }

        public void OnDisconnected()
        {
            authStatus.Text = "Код не зарегистрирован";
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _presenter.RemoveConnectionListener(this);
        }
    }
}
