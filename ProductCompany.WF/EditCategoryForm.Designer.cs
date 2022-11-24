
namespace ProductCompany.WF
{
    partial class EditCategoryForm
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
            this.btCancel = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.tcEdit = new System.Windows.Forms.TabControl();
            this.tpUpdate = new System.Windows.Forms.TabPage();
            this.tbDescriptionUpdate = new System.Windows.Forms.TextBox();
            this.lbDescriptionUpdate = new System.Windows.Forms.Label();
            this.tbNameUpdate = new System.Windows.Forms.TextBox();
            this.lbNameUpdate = new System.Windows.Forms.Label();
            this.tpAdd = new System.Windows.Forms.TabPage();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.tcEdit.SuspendLayout();
            this.tpUpdate.SuspendLayout();
            this.tpAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Location = new System.Drawing.Point(12, 165);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(130, 37);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Location = new System.Drawing.Point(270, 165);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(130, 38);
            this.btSave.TabIndex = 4;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // tcEdit
            // 
            this.tcEdit.Controls.Add(this.tpUpdate);
            this.tcEdit.Controls.Add(this.tpAdd);
            this.tcEdit.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcEdit.Location = new System.Drawing.Point(0, 0);
            this.tcEdit.Name = "tcEdit";
            this.tcEdit.SelectedIndex = 0;
            this.tcEdit.Size = new System.Drawing.Size(413, 159);
            this.tcEdit.TabIndex = 5;
            // 
            // tpUpdate
            // 
            this.tpUpdate.Controls.Add(this.tbDescriptionUpdate);
            this.tpUpdate.Controls.Add(this.lbDescriptionUpdate);
            this.tpUpdate.Controls.Add(this.tbNameUpdate);
            this.tpUpdate.Controls.Add(this.lbNameUpdate);
            this.tpUpdate.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpUpdate.Location = new System.Drawing.Point(4, 35);
            this.tpUpdate.Name = "tpUpdate";
            this.tpUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tpUpdate.Size = new System.Drawing.Size(405, 120);
            this.tpUpdate.TabIndex = 0;
            this.tpUpdate.Text = "Update";
            this.tpUpdate.UseVisualStyleBackColor = true;
            // 
            // tbDescriptionUpdate
            // 
            this.tbDescriptionUpdate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescriptionUpdate.Location = new System.Drawing.Point(162, 56);
            this.tbDescriptionUpdate.Name = "tbDescriptionUpdate";
            this.tbDescriptionUpdate.Size = new System.Drawing.Size(197, 33);
            this.tbDescriptionUpdate.TabIndex = 11;
            // 
            // lbDescriptionUpdate
            // 
            this.lbDescriptionUpdate.AutoSize = true;
            this.lbDescriptionUpdate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescriptionUpdate.Location = new System.Drawing.Point(16, 63);
            this.lbDescriptionUpdate.Name = "lbDescriptionUpdate";
            this.lbDescriptionUpdate.Size = new System.Drawing.Size(121, 26);
            this.lbDescriptionUpdate.TabIndex = 9;
            this.lbDescriptionUpdate.Text = "Description";
            // 
            // tbNameUpdate
            // 
            this.tbNameUpdate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNameUpdate.Location = new System.Drawing.Point(162, 12);
            this.tbNameUpdate.Name = "tbNameUpdate";
            this.tbNameUpdate.Size = new System.Drawing.Size(197, 33);
            this.tbNameUpdate.TabIndex = 5;
            // 
            // lbNameUpdate
            // 
            this.lbNameUpdate.AutoSize = true;
            this.lbNameUpdate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameUpdate.Location = new System.Drawing.Point(18, 19);
            this.lbNameUpdate.Name = "lbNameUpdate";
            this.lbNameUpdate.Size = new System.Drawing.Size(68, 26);
            this.lbNameUpdate.TabIndex = 4;
            this.lbNameUpdate.Text = "Name";
            // 
            // tpAdd
            // 
            this.tpAdd.Controls.Add(this.tbDescription);
            this.tpAdd.Controls.Add(this.lbDescription);
            this.tpAdd.Controls.Add(this.tbName);
            this.tpAdd.Controls.Add(this.lbName);
            this.tpAdd.Location = new System.Drawing.Point(4, 35);
            this.tpAdd.Name = "tpAdd";
            this.tpAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdd.Size = new System.Drawing.Size(405, 120);
            this.tpAdd.TabIndex = 1;
            this.tpAdd.Text = "Add";
            this.tpAdd.UseVisualStyleBackColor = true;
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescription.Location = new System.Drawing.Point(177, 52);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(197, 33);
            this.tbDescription.TabIndex = 10;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(19, 59);
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
            // EditCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 222);
            this.Controls.Add(this.tcEdit);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btCancel);
            this.Name = "EditCategoryForm";
            this.Text = "EditCategoryForm";
            this.tcEdit.ResumeLayout(false);
            this.tpUpdate.ResumeLayout(false);
            this.tpUpdate.PerformLayout();
            this.tpAdd.ResumeLayout(false);
            this.tpAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TabControl tcEdit;
        private System.Windows.Forms.TabPage tpUpdate;
        private System.Windows.Forms.TextBox tbDescriptionUpdate;
        private System.Windows.Forms.Label lbDescriptionUpdate;
        private System.Windows.Forms.TextBox tbNameUpdate;
        private System.Windows.Forms.Label lbNameUpdate;
        private System.Windows.Forms.TabPage tpAdd;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbName;
    }
}