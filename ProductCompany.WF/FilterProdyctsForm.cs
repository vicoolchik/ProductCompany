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
    public partial class FilterProdyctsForm : Form
    {
        private readonly IProductCompanyManager manager;
        public static List<CategoryDTO> categories;
        public FilterProdyctsForm(IProductCompanyManager manager)
        {
            
            InitializeComponent();
            this.manager = manager;
            BindCheckedListBoxCategory();
            
        }

        private void UpdateForm()
        {
            BindCheckedListBoxCategory();
            List<int> categoriesId = manager.GetListOfCategories().Select(a => a.CategoryID).ToList();
        }

        private List<CategoryDTO> SetCategories()
        {
            categories = new List<CategoryDTO>();
            foreach (var item in checkedListBoxCategory.CheckedItems)
            {
                categories.Add((CategoryDTO)item);
            }
            return categories;
        }

        private void BindCheckedListBoxCategory()
        {
            BindingList<CategoryDTO> categories = new BindingList<CategoryDTO>(manager.GetListOfCategories());
            bsCategoty.DataSource = categories;
            checkedListBoxCategory.DataSource = bsCategoty;
            checkedListBoxCategory.DisplayMember = "CategoryName";
            checkedListBoxCategory.ValueMember = "CategoryID";
        }

        private void pictureArrowToProductsForm_Click(object sender, EventArgs e)
        {
            SetCategories();
            DialogResult = DialogResult.OK;
        }
    }
}
