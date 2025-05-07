namespace RevisedGroceryApp
{
    partial class NewItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sliBreTxtBox = new System.Windows.Forms.TextBox();
            this.newItemMinItem = new System.Windows.Forms.Button();
            this.newItemAddBtn = new System.Windows.Forms.Button();
            this.newItemProdLbl = new System.Windows.Forms.Label();
            this.newItemStockLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(24, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 145);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // sliBreTxtBox
            // 
            this.sliBreTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sliBreTxtBox.Location = new System.Drawing.Point(73, 214);
            this.sliBreTxtBox.Multiline = true;
            this.sliBreTxtBox.Name = "sliBreTxtBox";
            this.sliBreTxtBox.Size = new System.Drawing.Size(50, 35);
            this.sliBreTxtBox.TabIndex = 8;
            this.sliBreTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // newItemMinItem
            // 
            this.newItemMinItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newItemMinItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newItemMinItem.ForeColor = System.Drawing.Color.Black;
            this.newItemMinItem.Location = new System.Drawing.Point(25, 214);
            this.newItemMinItem.Name = "newItemMinItem";
            this.newItemMinItem.Size = new System.Drawing.Size(42, 35);
            this.newItemMinItem.TabIndex = 9;
            this.newItemMinItem.Text = "-";
            this.newItemMinItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.newItemMinItem.UseVisualStyleBackColor = true;
            // 
            // newItemAddBtn
            // 
            this.newItemAddBtn.BackColor = System.Drawing.Color.Transparent;
            this.newItemAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newItemAddBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newItemAddBtn.ForeColor = System.Drawing.Color.Black;
            this.newItemAddBtn.Location = new System.Drawing.Point(130, 214);
            this.newItemAddBtn.Name = "newItemAddBtn";
            this.newItemAddBtn.Size = new System.Drawing.Size(42, 35);
            this.newItemAddBtn.TabIndex = 10;
            this.newItemAddBtn.Text = "+";
            this.newItemAddBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.newItemAddBtn.UseVisualStyleBackColor = false;
            // 
            // newItemProdLbl
            // 
            this.newItemProdLbl.AutoSize = true;
            this.newItemProdLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newItemProdLbl.ForeColor = System.Drawing.Color.Black;
            this.newItemProdLbl.Location = new System.Drawing.Point(50, 12);
            this.newItemProdLbl.Name = "newItemProdLbl";
            this.newItemProdLbl.Size = new System.Drawing.Size(102, 20);
            this.newItemProdLbl.TabIndex = 11;
            this.newItemProdLbl.Text = "(placeholder)";
            this.newItemProdLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newItemStockLbl
            // 
            this.newItemStockLbl.AutoSize = true;
            this.newItemStockLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newItemStockLbl.ForeColor = System.Drawing.Color.Black;
            this.newItemStockLbl.Location = new System.Drawing.Point(20, 262);
            this.newItemStockLbl.Name = "newItemStockLbl";
            this.newItemStockLbl.Size = new System.Drawing.Size(113, 21);
            this.newItemStockLbl.TabIndex = 12;
            this.newItemStockLbl.Text = "(Placeholder)";
            // 
            // NewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.newItemStockLbl);
            this.Controls.Add(this.newItemProdLbl);
            this.Controls.Add(this.sliBreTxtBox);
            this.Controls.Add(this.newItemMinItem);
            this.Controls.Add(this.newItemAddBtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "NewItem";
            this.Size = new System.Drawing.Size(195, 308);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox sliBreTxtBox;
        private System.Windows.Forms.Button newItemMinItem;
        private System.Windows.Forms.Button newItemAddBtn;
        private System.Windows.Forms.Label newItemProdLbl;
        private System.Windows.Forms.Label newItemStockLbl;
    }
}
