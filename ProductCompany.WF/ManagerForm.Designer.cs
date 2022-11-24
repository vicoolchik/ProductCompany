
namespace ProductCompany.WF
{
    partial class ManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.pictureArrowCategories = new System.Windows.Forms.PictureBox();
            this.pictureArrowProducts = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelCategories = new System.Windows.Forms.Label();
            this.label1Products = new System.Windows.Forms.Label();
            this.lbReturn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureArrowCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureArrowProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureArrowCategories
            // 
            this.pictureArrowCategories.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureArrowCategories.ErrorImage = null;
            this.pictureArrowCategories.Image = ((System.Drawing.Image)(resources.GetObject("pictureArrowCategories.Image")));
            this.pictureArrowCategories.InitialImage = null;
            this.pictureArrowCategories.Location = new System.Drawing.Point(160, 72);
            this.pictureArrowCategories.Name = "pictureArrowCategories";
            this.pictureArrowCategories.Size = new System.Drawing.Size(82, 38);
            this.pictureArrowCategories.TabIndex = 3;
            this.pictureArrowCategories.TabStop = false;
            this.pictureArrowCategories.Click += new System.EventHandler(this.pictureArrowCategories_Click);
            // 
            // pictureArrowProducts
            // 
            this.pictureArrowProducts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureArrowProducts.Image = ((System.Drawing.Image)(resources.GetObject("pictureArrowProducts.Image")));
            this.pictureArrowProducts.Location = new System.Drawing.Point(158, 116);
            this.pictureArrowProducts.Name = "pictureArrowProducts";
            this.pictureArrowProducts.Size = new System.Drawing.Size(84, 45);
            this.pictureArrowProducts.TabIndex = 4;
            this.pictureArrowProducts.TabStop = false;
            this.pictureArrowProducts.Click += new System.EventHandler(this.pictureArrowProducts_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(41, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(165, 39);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "Work with";
            // 
            // labelCategories
            // 
            this.labelCategories.AutoSize = true;
            this.labelCategories.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelCategories.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategories.Location = new System.Drawing.Point(12, 72);
            this.labelCategories.Name = "labelCategories";
            this.labelCategories.Size = new System.Drawing.Size(135, 31);
            this.labelCategories.TabIndex = 6;
            this.labelCategories.Text = "Categories";
            // 
            // label1Products
            // 
            this.label1Products.AutoSize = true;
            this.label1Products.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1Products.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Products.Location = new System.Drawing.Point(12, 116);
            this.label1Products.Name = "label1Products";
            this.label1Products.Size = new System.Drawing.Size(116, 31);
            this.label1Products.TabIndex = 7;
            this.label1Products.Text = "Products";
            // 
            // lbReturn
            // 
            this.lbReturn.AutoSize = true;
            this.lbReturn.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReturn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbReturn.Location = new System.Drawing.Point(14, 174);
            this.lbReturn.Name = "lbReturn";
            this.lbReturn.Size = new System.Drawing.Size(201, 19);
            this.lbReturn.TabIndex = 8;
            this.lbReturn.Text = "Return to the main window";
            this.lbReturn.Click += new System.EventHandler(this.lbReturn_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(249, 202);
            this.Controls.Add(this.lbReturn);
            this.Controls.Add(this.label1Products);
            this.Controls.Add(this.labelCategories);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureArrowProducts);
            this.Controls.Add(this.pictureArrowCategories);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureArrowCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureArrowProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureArrowCategories;
        private System.Windows.Forms.PictureBox pictureArrowProducts;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelCategories;
        private System.Windows.Forms.Label label1Products;
        private System.Windows.Forms.Label lbReturn;
    }
}