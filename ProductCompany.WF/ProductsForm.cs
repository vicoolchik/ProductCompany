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
    public partial class ProductsForm : Form
    {
        private readonly IProductCompanyManager manager;
        private List<ProductDTO> products;
        private List<DataGridViewCell> cells;
        private DataGridViewColumn column;

        public ProductsForm(IProductCompanyManager manager)
        {
            InitializeComponent();
            this.manager = manager;
            Binding();
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            this.products = new List<ProductDTO>();
            foreach (var category in FilterProdyctsForm.categories)
            {                
                products.AddRange(manager.GetListOfProductsByCategoryID(category.CategoryID));
            }

            BindingList<ProductDTO> blProducts = new BindingList<ProductDTO>(products);
            bsManagerProducts.DataSource = blProducts;

            navManagerProducts.BindingSource = bsManagerProducts;
            dqvManagerProducts.DataSource = bsManagerProducts;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK==MessageBox.Show("Are you sure?","Delete product", MessageBoxButtons.OKCancel))
            {
                manager.DeleteProductByID(((ProductDTO)bsManagerProducts.Current).ProductID);
            }
            RefreshGrid();
        }

        private void ShowEdit(ProductDTO product = null)
        {
            EditProductForm editProductForm = new EditProductForm(manager, product);

            var res = editProductForm.ShowDialog();
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
            ShowEdit(products[e.RowIndex]);
        }

        private List<DataGridViewCell> GetCell(string searchText, DataGridView dataGridView, int columnIndex)
        {
            List<DataGridViewCell> cells = new List<DataGridViewCell>();
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[columnIndex].Value != null && searchText == row.Cells[columnIndex].Value.ToString())
                {
                    cells.Add(row.Cells[columnIndex]);
                }
            }

            return cells;
        }

        private void GetColumn()
        {
            column = new DataGridViewColumn();
            foreach (DataGridViewColumn col in dqvManagerProducts.Columns)
            {
                if (col.HeaderText == cbColumn.SelectedValue.ToString())
                {
                    column = col;
                    break;
                }
            }
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            GetColumn();
            if (cells != null)
            {
                foreach (var cell in cells)
                {
                    cell.Style = new DataGridViewCellStyle { ForeColor = Color.Black };
                }
            }           

            if (e.KeyChar == (char)Keys.Enter)
            {
                cells = GetCell(tbSearch.Text, dqvManagerProducts, column.Index);
                if (cells.Count != 0)
                {
                    foreach (var cell in cells)
                    {
                        cell.Style = new DataGridViewCellStyle { ForeColor = Color.Olive };
                    }
                }
                else
                {
                    MessageBox.Show("Еhere is no result found");
                }
            }
        }

        private void Binding()
        {
            List<string> headerText = new List<string>();

            foreach(DataGridViewColumn col in dqvManagerProducts.Columns)
            {
                headerText.Add(col.HeaderText);
            }

            cbColumn.DataSource = headerText;
        }

        private void btSort_Click(object sender, EventArgs e)
        {
            this.dqvManagerProducts.Sort(column, ListSortDirection.Ascending);
        }


    }
}
