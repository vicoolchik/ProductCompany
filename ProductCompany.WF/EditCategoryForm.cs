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
    public partial class EditCategoryForm : Form
    {
        private readonly IProductCompanyManager manager;
        private CategoryDTO category;
        public EditCategoryForm(IProductCompanyManager manager, CategoryDTO category)
        {
            InitializeComponent();
            this.manager = manager;
            this.category = category;
            if (category != null)
            {
                tpAdd.Enabled = false;
            }
            if (category == null)
            {
                tpUpdate.Enabled = false;
            }
            UpdateForm();
        }
        private void UpdateForm()
        {
            if (category != null)
            {
                tbDescriptionUpdate.Text = category.Description.ToString();
                tbNameUpdate.Text = category.CategoryName.ToString();
            }
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            if (category != null)
            {
                UpdateProperties();
            }
            if (category == null)
            {
                category = new CategoryDTO();
                SetProperties();
                manager.AddCategory(category);
            }
            DialogResult = DialogResult.OK;
        }
        private void SetProperties()
        {
            category.Description = tbDescription.Text;
            category.CategoryName = tbName.Text;
        }
        private void UpdateProperties()
        {
            category.Description = tbDescriptionUpdate.Text;
            category.CategoryName = tbNameUpdate.Text;
            manager.UpdateCategoryyByID(category, category.CategoryID);
        }
    }
}
