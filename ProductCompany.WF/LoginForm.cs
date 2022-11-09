using ProductCompany.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductCompany.WF
{
    public partial class LoginForm : Form
    {
        protected readonly IAuthManager manager;

        public LoginForm(IAuthManager manager)
        {
            InitializeComponent();
            this.manager = manager;
        }

        private void dtLogin_Click(object sender, EventArgs e)
        {
            doLogin();
        }

        private void doLogin()
        {
            if (manager.Login(textUserName.Text, textPassword.Text))
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }
        }

        private void textPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                doLogin();
            }
        }
    }
}
