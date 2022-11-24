
namespace ProductCompany.WF
{
    partial class FilterProdyctsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterProdyctsForm));
            this.checkedListBoxCategory = new System.Windows.Forms.CheckedListBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.bsCategoty = new System.Windows.Forms.BindingSource(this.components);
            this.pictureArrowToProductsForm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsCategoty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureArrowToProductsForm)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBoxCategory
            // 
            this.checkedListBoxCategory.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxCategory.FormattingEnabled = true;
            this.checkedListBoxCategory.Location = new System.Drawing.Point(12, 69);
            this.checkedListBoxCategory.Name = "checkedListBoxCategory";
            this.checkedListBoxCategory.Size = new System.Drawing.Size(329, 179);
            this.checkedListBoxCategory.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(21, 22);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(306, 31);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Select a product category";
            // 
            // bsCategoty
            // 
            this.bsCategoty.DataSource = typeof(ProductСompany.DTO.CategoryDTO);
            // 
            // pictureArrowToProductsForm
            // 
            this.pictureArrowToProductsForm.Image = ((System.Drawing.Image)(resources.GetObject("pictureArrowToProductsForm.Image")));
            this.pictureArrowToProductsForm.Location = new System.Drawing.Point(284, 254);
            this.pictureArrowToProductsForm.Name = "pictureArrowToProductsForm";
            this.pictureArrowToProductsForm.Size = new System.Drawing.Size(100, 51);
            this.pictureArrowToProductsForm.TabIndex = 2;
            this.pictureArrowToProductsForm.TabStop = false;
            this.pictureArrowToProductsForm.Click += new System.EventHandler(this.pictureArrowToProductsForm_Click);
            // 
            // FilterProdyctsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(353, 299);
            this.Controls.Add(this.pictureArrowToProductsForm);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.checkedListBoxCategory);
            this.Name = "FilterProdyctsForm";
            this.Text = "FilterProdyctsByCategoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.bsCategoty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureArrowToProductsForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxCategory;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.BindingSource bsCategoty;
        private System.Windows.Forms.PictureBox pictureArrowToProductsForm;
    }
}