using ProductCompany.BusinessLogic.Interfaces;
using ProductСompany.DTO;
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
    public partial class EditProductForm : Form
    {
        private readonly IProductCompanyManager manager;
        private ProductDTO product;
        public EditProductForm(IProductCompanyManager manager, ProductDTO product)
        {
            InitializeComponent();
            this.manager = manager;
            this.product = product;
            if (product != null)
            {
                tpAdd.Enabled = false;
            }
            if (product == null)
            {
                tpUpdate.Enabled = false;
            }
            UpdateForm();
        }

        private void UpdateForm()
        {
            if (product == null)
            {
                Binding();
            }
            if (product != null)
            {
                tbUnitPriceUpdate.Text = product.UnitPrice.ToString();
                cbDiscontinuedUpdate.Checked = product.Discontinued;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (product != null)
            {
                UpdateProperties();
                tpAdd.Enabled = false;
            }
            if (product == null)
            {
                tpUpdate.Enabled = false;
                product = new ProductDTO();
                SetProperties();
                manager.AddProduct(product);
            }
            DialogResult = DialogResult.OK;
        }

        private void SetProperties()
        {
            product.CategoryID = int.Parse(cbCategories.SelectedValue.ToString());
            product.SupplierID = int.Parse(cbSuppliers.SelectedValue.ToString());
            product.ProductName = tbName.Text;
            product.UnitPrice = decimal.Parse(tbUnitPrice.Text);
            product.UnitsInStock = int.Parse(tbUnitsInStock.Text);
            product.UnitsOnOnder = int.Parse(tbUnitsOnOnder.Text);
            product.Description = tbDescription.Text;
            product.Discontinued = cbDiscontinued.Checked;
        }
        private void UpdateProperties()
        {
            product.UnitPrice = decimal.Parse(tbUnitPriceUpdate.Text);
            manager.UpdateProductByID(product, product.ProductID);
            if (cbDiscontinuedUpdate.Checked == false)
            {
                manager.BlockProductByID(product.ProductID);
            }
            
        }

        private void Binding()
        {
            BindingList<SupplierDTO> suppliers = new BindingList<SupplierDTO>(manager.GetAllSuppliers());
            bsSuppliers.DataSource = suppliers;

            BindingList<CategoryDTO> categories = new BindingList<CategoryDTO>(FilterProdyctsForm.categories);
           bsCategories.DataSource = categories;
        }
    }
}
