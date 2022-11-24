using ProductCompany.BusinessLogic.Interfaces;
using System;
using System.Windows.Forms;

namespace ProductCompany.WF
{
    public partial class ManagerForm : Form
    {
        private readonly IProductCompanyManager manager;
        public ManagerForm(IProductCompanyManager manager)
        {
            this.manager = manager;
            InitializeComponent();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            pictureArrowCategories.ImageLocation = @"C:\work\c#\ProductCompany\ProductCompany\ProductCompany.WF\Image\pngtree-arrow-green-icon-clipart-png-image_3141336.jpg";
            pictureArrowCategories.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void pictureArrowCategories_Click(object sender, EventArgs e)
        {
            CategoriesForm cf = new CategoriesForm(manager);
            cf.ShowDialog();
        }

        private void pictureArrowProducts_Click(object sender, EventArgs e)
        {
            FilterProdyctsForm fpf = new FilterProdyctsForm(manager);
            if (fpf.ShowDialog() == DialogResult.OK)
            {
                ProductsForm pf = new ProductsForm(manager);
                pf.ShowDialog();
            }
        }
        private void lbReturn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
