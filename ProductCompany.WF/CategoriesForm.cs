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
    public partial class CategoriesForm : Form
    {
        private readonly IProductCompanyManager manager;
        private List<CategoryDTO> categories;

        public CategoriesForm(IProductCompanyManager manager)
        {
            InitializeComponent();
            this.manager = manager;
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            this.categories = new List<CategoryDTO>();
            categories.AddRange(manager.GetListOfCategories());

            BindingList<CategoryDTO> blCategories = new BindingList<CategoryDTO>(categories);
            bsManagerCategories.DataSource = blCategories;

            navManagerCategories.BindingSource = bsManagerCategories;
            dqvManagerCategories.DataSource = bsManagerCategories;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Are you sure?", "Delete product", MessageBoxButtons.OKCancel))
            {
                manager.DeleteCategoryByID(((CategoryDTO)bsManagerCategories.Current).CategoryID);
            }
            RefreshGrid();
        }

        private void ShowEdit(CategoryDTO category = null)
        {
            EditCategoryForm ediCategoryForm = new EditCategoryForm(manager, category);

            var res = ediCategoryForm.ShowDialog();
            if (DialogResult.OK == res || DialogResult.Cancel == res)
            {
                RefreshGrid();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            ShowEdit();
        }


        private void dqvManagerProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowEdit(categories[e.RowIndex]);
        }
    }
}

    

