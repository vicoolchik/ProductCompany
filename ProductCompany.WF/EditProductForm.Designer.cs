
namespace ProductCompany.WF
{
    partial class EditProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tcEdit = new System.Windows.Forms.TabControl();
            this.tpUpdate = new System.Windows.Forms.TabPage();
            this.tpAdd = new System.Windows.Forms.TabPage();
            this.bsSuppliers = new System.Windows.Forms.BindingSource(this.components);
            this.bsCategories = new System.Windows.Forms.BindingSource(this.components);
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.cbDiscontinuedUpdate = new System.Windows.Forms.CheckBox();
            this.tbUnitPriceUpdate = new System.Windows.Forms.TextBox();
            this.lbDiscontinuedUpdate = new System.Windows.Forms.Label();
            this.lbUnitPriceUpdate = new System.Windows.Forms.Label();
            this.lbDiscontinued = new System.Windows.Forms.Label();
            this.cbDiscontinued = new System.Windows.Forms.CheckBox();
            this.tbUnitsOnOnder = new System.Windows.Forms.TextBox();
            this.tbUnitsInStock = new System.Windows.Forms.TextBox();
            this.tbUnitPrice = new System.Windows.Forms.TextBox();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.cbSuppliers = new System.Windows.Forms.ComboBox();
            this.lbSupplier = new System.Windows.Forms.Label();
            this.lbCategoryID = new System.Windows.Forms.Label();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.lbUnitsInStock = new System.Windows.Forms.Label();
            this.lbUnitsOnOnder = new System.Windows.Forms.Label();
            this.tcEdit.SuspendLayout();
            this.tpUpdate.SuspendLayout();
            this.tpAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // tcEdit
            // 
            this.tcEdit.Controls.Add(this.tpUpdate);
            this.tcEdit.Controls.Add(this.tpAdd);
            this.tcEdit.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcEdit.Location = new System.Drawing.Point(1, 2);
            this.tcEdit.Name = "tcEdit";
            this.tcEdit.SelectedIndex = 0;
            this.tcEdit.Size = new System.Drawing.Size(413, 379);
            this.tcEdit.TabIndex = 0;
            // 
            // tpUpdate
            // 
            this.tpUpdate.Controls.Add(this.tbUnitPriceUpdate);
            this.tpUpdate.Controls.Add(this.cbDiscontinuedUpdate);
            this.tpUpdate.Controls.Add(this.lbDiscontinuedUpdate);
            this.tpUpdate.Controls.Add(this.lbUnitPriceUpdate);
            this.tpUpdate.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpUpdate.Location = new System.Drawing.Point(4, 35);
            this.tpUpdate.Name = "tpUpdate";
            this.tpUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tpUpdate.Size = new System.Drawing.Size(405, 340);
            this.tpUpdate.TabIndex = 0;
            this.tpUpdate.Text = "Update";
            this.tpUpdate.UseVisualStyleBackColor = true;
            // 
            // tpAdd
            // 
            this.tpAdd.Controls.Add(this.cbSuppliers);
            this.tpAdd.Controls.Add(this.cbCategories);
            this.tpAdd.Controls.Add(this.tbUnitPrice);
            this.tpAdd.Controls.Add(this.tbUnitsInStock);
            this.tpAdd.Controls.Add(this.tbUnitsOnOnder);
            this.tpAdd.Controls.Add(this.tbDescription);
            this.tpAdd.Controls.Add(this.cbDiscontinued);
            this.tpAdd.Controls.Add(this.lbDescription);
            this.tpAdd.Controls.Add(this.lbDiscontinued);
            this.tpAdd.Controls.Add(this.lbUnitsOnOnder);
            this.tpAdd.Controls.Add(this.lbUnitsInStock);
            this.tpAdd.Controls.Add(this.lbUnitPrice);
            this.tpAdd.Controls.Add(this.lbCategoryID);
            this.tpAdd.Controls.Add(this.lbSupplier);
            this.tpAdd.Controls.Add(this.tbName);
            this.tpAdd.Controls.Add(this.lbName);
            this.tpAdd.Location = new System.Drawing.Point(4, 35);
            this.tpAdd.Name = "tpAdd";
            this.tpAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdd.Size = new System.Drawing.Size(405, 340);
            this.tpAdd.TabIndex = 1;
            this.tpAdd.Text = "Add";
            this.tpAdd.UseVisualStyleBackColor = true;
            // 
            // bsSuppliers
            // 
            this.bsSuppliers.DataSource = typeof(ProductСompany.DTO.SupplierDTO);
            // 
            // bsCategories
            // 
            this.bsCategories.DataSource = typeof(ProductСompany.DTO.CategoryDTO);
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescription.Location = new System.Drawing.Point(177, 280);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(197, 33);
            this.tbDescription.TabIndex = 10;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(19, 287);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(121, 26);
            this.lbDescription.TabIndex = 8;
            this.lbDescription.Text = "Description";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(177, 10);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(197, 33);
            this.tbName.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(19, 21);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(68, 26);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name";
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Location = new System.Drawing.Point(268, 391);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(130, 38);
            this.btSave.TabIndex = 1;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Location = new System.Drawing.Point(12, 393);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(130, 37);
            this.btCancel.TabIndex = 2;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // cbDiscontinuedUpdate
            // 
            this.cbDiscontinuedUpdate.AutoSize = true;
            this.cbDiscontinuedUpdate.Location = new System.Drawing.Point(154, 63);
            this.cbDiscontinuedUpdate.Name = "cbDiscontinuedUpdate";
            this.cbDiscontinuedUpdate.Size = new System.Drawing.Size(18, 17);
            this.cbDiscontinuedUpdate.TabIndex = 2;
            this.cbDiscontinuedUpdate.UseVisualStyleBackColor = true;
            // 
            // tbUnitPriceUpdate
            // 
            this.tbUnitPriceUpdate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUnitPriceUpdate.Location = new System.Drawing.Point(154, 16);
            this.tbUnitPriceUpdate.Name = "tbUnitPriceUpdate";
            this.tbUnitPriceUpdate.Size = new System.Drawing.Size(162, 33);
            this.tbUnitPriceUpdate.TabIndex = 3;
            // 
            // lbDiscontinuedUpdate
            // 
            this.lbDiscontinuedUpdate.AutoSize = true;
            this.lbDiscontinuedUpdate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiscontinuedUpdate.Location = new System.Drawing.Point(7, 58);
            this.lbDiscontinuedUpdate.Name = "lbDiscontinuedUpdate";
            this.lbDiscontinuedUpdate.Size = new System.Drawing.Size(137, 26);
            this.lbDiscontinuedUpdate.TabIndex = 1;
            this.lbDiscontinuedUpdate.Text = "Discontinued";
            // 
            // lbUnitPriceUpdate
            // 
            this.lbUnitPriceUpdate.AutoSize = true;
            this.lbUnitPriceUpdate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUnitPriceUpdate.Location = new System.Drawing.Point(7, 23);
            this.lbUnitPriceUpdate.Name = "lbUnitPriceUpdate";
            this.lbUnitPriceUpdate.Size = new System.Drawing.Size(105, 26);
            this.lbUnitPriceUpdate.TabIndex = 0;
            this.lbUnitPriceUpdate.Text = "Unit Price";
            // 
            // lbDiscontinued
            // 
            this.lbDiscontinued.AutoSize = true;
            this.lbDiscontinued.Location = new System.Drawing.Point(19, 254);
            this.lbDiscontinued.Name = "lbDiscontinued";
            this.lbDiscontinued.Size = new System.Drawing.Size(137, 26);
            this.lbDiscontinued.TabIndex = 7;
            this.lbDiscontinued.Text = "Discontinued";
            // 
            // cbDiscontinued
            // 
            this.cbDiscontinued.AutoSize = true;
            this.cbDiscontinued.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDiscontinued.Location = new System.Drawing.Point(177, 254);
            this.cbDiscontinued.Name = "cbDiscontinued";
            this.cbDiscontinued.Size = new System.Drawing.Size(18, 17);
            this.cbDiscontinued.TabIndex = 9;
            this.cbDiscontinued.UseVisualStyleBackColor = true;
            // 
            // tbUnitsOnOnder
            // 
            this.tbUnitsOnOnder.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUnitsOnOnder.Location = new System.Drawing.Point(177, 209);
            this.tbUnitsOnOnder.Name = "tbUnitsOnOnder";
            this.tbUnitsOnOnder.Size = new System.Drawing.Size(197, 33);
            this.tbUnitsOnOnder.TabIndex = 11;
            // 
            // tbUnitsInStock
            // 
            this.tbUnitsInStock.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUnitsInStock.Location = new System.Drawing.Point(177, 170);
            this.tbUnitsInStock.Name = "tbUnitsInStock";
            this.tbUnitsInStock.Size = new System.Drawing.Size(197, 33);
            this.tbUnitsInStock.TabIndex = 12;
            // 
            // tbUnitPrice
            // 
            this.tbUnitPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUnitPrice.Location = new System.Drawing.Point(177, 131);
            this.tbUnitPrice.Name = "tbUnitPrice";
            this.tbUnitPrice.Size = new System.Drawing.Size(197, 33);
            this.tbUnitPrice.TabIndex = 13;
            // 
            // cbCategories
            // 
            this.cbCategories.DataSource = this.bsCategories;
            this.cbCategories.DisplayMember = "CategoryName";
            this.cbCategories.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(177, 91);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(176, 33);
            this.cbCategories.TabIndex = 14;
            this.cbCategories.ValueMember = "CategoryID";
            // 
            // cbSuppliers
            // 
            this.cbSuppliers.DataSource = this.bsSuppliers;
            this.cbSuppliers.DisplayMember = "CompanyName";
            this.cbSuppliers.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSuppliers.FormattingEnabled = true;
            this.cbSuppliers.Location = new System.Drawing.Point(177, 51);
            this.cbSuppliers.Name = "cbSuppliers";
            this.cbSuppliers.Size = new System.Drawing.Size(176, 33);
            this.cbSuppliers.TabIndex = 15;
            this.cbSuppliers.ValueMember = "SupplierID";
            // 
            // lbSupplier
            // 
            this.lbSupplier.AutoSize = true;
            this.lbSupplier.Location = new System.Drawing.Point(19, 61);
            this.lbSupplier.Name = "lbSupplier";
            this.lbSupplier.Size = new System.Drawing.Size(90, 26);
            this.lbSupplier.TabIndex = 2;
            this.lbSupplier.Text = "Supplier";
            // 
            // lbCategoryID
            // 
            this.lbCategoryID.AutoSize = true;
            this.lbCategoryID.Location = new System.Drawing.Point(19, 99);
            this.lbCategoryID.Name = "lbCategoryID";
            this.lbCategoryID.Size = new System.Drawing.Size(97, 26);
            this.lbCategoryID.TabIndex = 3;
            this.lbCategoryID.Text = "Category";
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Location = new System.Drawing.Point(19, 138);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(105, 26);
            this.lbUnitPrice.TabIndex = 4;
            this.lbUnitPrice.Text = "Unit price";
            // 
            // lbUnitsInStock
            // 
            this.lbUnitsInStock.AutoSize = true;
            this.lbUnitsInStock.Location = new System.Drawing.Point(19, 177);
            this.lbUnitsInStock.Name = "lbUnitsInStock";
            this.lbUnitsInStock.Size = new System.Drawing.Size(141, 26);
            this.lbUnitsInStock.TabIndex = 5;
            this.lbUnitsInStock.Text = "Units in stock";
            // 
            // lbUnitsOnOnder
            // 
            this.lbUnitsOnOnder.AutoSize = true;
            this.lbUnitsOnOnder.Location = new System.Drawing.Point(19, 216);
            this.lbUnitsOnOnder.Name = "lbUnitsOnOnder";
            this.lbUnitsOnOnder.Size = new System.Drawing.Size(152, 26);
            this.lbUnitsOnOnder.TabIndex = 6;
            this.lbUnitsOnOnder.Text = "Units on onder";
            // 
            // EditProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(410, 442);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tcEdit);
            this.Name = "EditProductForm";
            this.Text = "EditProductForm1";
            this.tcEdit.ResumeLayout(false);
            this.tpUpdate.ResumeLayout(false);
            this.tpUpdate.PerformLayout();
            this.tpAdd.ResumeLayout(false);
            this.tpAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcEdit;
        private System.Windows.Forms.TabPage tpUpdate;
        private System.Windows.Forms.TabPage tpAdd;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.BindingSource bsSuppliers;
        private System.Windows.Forms.BindingSource bsCategories;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.TextBox tbUnitPriceUpdate;
        private System.Windows.Forms.CheckBox cbDiscontinuedUpdate;
        private System.Windows.Forms.Label lbDiscontinuedUpdate;
        private System.Windows.Forms.Label lbUnitPriceUpdate;
        private System.Windows.Forms.ComboBox cbSuppliers;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.TextBox tbUnitPrice;
        private System.Windows.Forms.TextBox tbUnitsInStock;
        private System.Windows.Forms.TextBox tbUnitsOnOnder;
        private System.Windows.Forms.CheckBox cbDiscontinued;
        private System.Windows.Forms.Label lbDiscontinued;
        private System.Windows.Forms.Label lbUnitsOnOnder;
        private System.Windows.Forms.Label lbUnitsInStock;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.Label lbCategoryID;
        private System.Windows.Forms.Label lbSupplier;
    }
}