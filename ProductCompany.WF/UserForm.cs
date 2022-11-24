using ProductCompany.BusinessLogic.Interfaces;
using ProductСompany.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace ProductCompany.WF
{
    public partial class UserForm : Form
    {
        private readonly IProductCompanyManager manager;
        private List<ProductDTO> products;
        public UserForm(IProductCompanyManager manager)
        {
            InitializeComponent();

            this.manager = manager;
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            products = manager.GetListOfProducts();

            BindingList<ProductDTO> blProducts = new BindingList<ProductDTO>(products);
            bsUserProducts.DataSource = blProducts;

            navUserProducts.BindingSource = bsUserProducts;
            dqvUserProducts.DataSource = bsUserProducts;
        }

        private void btSingout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (manager.EditAllowed(LoginForm.currentUser))
            {
                this.Hide();
                ManagerForm mf = new ManagerForm(manager);
               if(mf.ShowDialog() == DialogResult.OK)
                {
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("You do not have permission to edit");
            }
        }
    }
}
