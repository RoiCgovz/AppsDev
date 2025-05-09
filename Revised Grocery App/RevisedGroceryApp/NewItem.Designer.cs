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
            this.components = new System.ComponentModel.Container();
            this.newItemPictureBox = new System.Windows.Forms.PictureBox();
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.minusBtn = new System.Windows.Forms.Button();
            this.plusBtn = new System.Windows.Forms.Button();
            this.newItemNameLbl = new System.Windows.Forms.Label();
            this.newItemStockLbl = new System.Windows.Forms.Label();
            this.newItmPriLbl = new System.Windows.Forms.Label();
            this.roundedPanel1 = new RoundedPanel.RoundedPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.newItemPictureBox)).BeginInit();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // newItemPictureBox
            // 
            this.newItemPictureBox.Location = new System.Drawing.Point(34, 48);
            this.newItemPictureBox.Name = "newItemPictureBox";
            this.newItemPictureBox.Size = new System.Drawing.Size(268, 145);
            this.newItemPictureBox.TabIndex = 0;
            this.newItemPictureBox.TabStop = false;
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyTextBox.Location = new System.Drawing.Point(66, 211);
            this.qtyTextBox.Multiline = true;
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.Size = new System.Drawing.Size(50, 35);
            this.qtyTextBox.TabIndex = 8;
            this.qtyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // minusBtn
            // 
            this.minusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusBtn.ForeColor = System.Drawing.Color.Black;
            this.minusBtn.Location = new System.Drawing.Point(20, 211);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(42, 35);
            this.minusBtn.TabIndex = 9;
            this.minusBtn.Text = "-";
            this.minusBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minusBtn.UseVisualStyleBackColor = true;
            this.minusBtn.Click += new System.EventHandler(this.minusBtn_Click);
            // 
            // plusBtn
            // 
            this.plusBtn.BackColor = System.Drawing.Color.Transparent;
            this.plusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusBtn.ForeColor = System.Drawing.Color.Black;
            this.plusBtn.Location = new System.Drawing.Point(122, 211);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(42, 35);
            this.plusBtn.TabIndex = 10;
            this.plusBtn.Text = "+";
            this.plusBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.plusBtn.UseVisualStyleBackColor = false;
            this.plusBtn.Click += new System.EventHandler(this.plusBtn_Click);
            // 
            // newItemNameLbl
            // 
            this.newItemNameLbl.AutoSize = true;
            this.newItemNameLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newItemNameLbl.ForeColor = System.Drawing.Color.Black;
            this.newItemNameLbl.Location = new System.Drawing.Point(3, 15);
            this.newItemNameLbl.Name = "newItemNameLbl";
            this.newItemNameLbl.Size = new System.Drawing.Size(102, 20);
            this.newItemNameLbl.TabIndex = 11;
            this.newItemNameLbl.Text = "(placeholder)";
            this.newItemNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newItemStockLbl
            // 
            this.newItemStockLbl.AutoSize = true;
            this.newItemStockLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newItemStockLbl.ForeColor = System.Drawing.Color.Black;
            this.newItemStockLbl.Location = new System.Drawing.Point(16, 249);
            this.newItemStockLbl.Name = "newItemStockLbl";
            this.newItemStockLbl.Size = new System.Drawing.Size(113, 21);
            this.newItemStockLbl.TabIndex = 12;
            this.newItemStockLbl.Text = "(Placeholder)";
            // 
            // newItmPriLbl
            // 
            this.newItmPriLbl.AutoSize = true;
            this.newItmPriLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newItmPriLbl.ForeColor = System.Drawing.Color.Black;
            this.newItmPriLbl.Location = new System.Drawing.Point(111, 15);
            this.newItmPriLbl.Name = "newItmPriLbl";
            this.newItmPriLbl.Size = new System.Drawing.Size(56, 20);
            this.newItmPriLbl.TabIndex = 13;
            this.newItmPriLbl.Text = "(none)";
            this.newItmPriLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.White;
            this.roundedPanel1.BorderRadius = 30;
            this.roundedPanel1.Controls.Add(this.newItmPriLbl);
            this.roundedPanel1.Controls.Add(this.newItemPictureBox);
            this.roundedPanel1.Controls.Add(this.qtyTextBox);
            this.roundedPanel1.Controls.Add(this.newItemStockLbl);
            this.roundedPanel1.Controls.Add(this.plusBtn);
            this.roundedPanel1.Controls.Add(this.newItemNameLbl);
            this.roundedPanel1.Controls.Add(this.minusBtn);
            this.roundedPanel1.Location = new System.Drawing.Point(43, 22);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.RadiusButtonLeft = 30;
            this.roundedPanel1.RadiusButtonRight = 30;
            this.roundedPanel1.RadiusTopLeft = 30;
            this.roundedPanel1.RadiusTopRight = 30;
            this.roundedPanel1.Size = new System.Drawing.Size(172, 291);
            this.roundedPanel1.TabIndex = 14;
            this.roundedPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.roundedPanel1_Paint);
            // 
            // NewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.roundedPanel1);
            this.Name = "NewItem";
            this.Size = new System.Drawing.Size(259, 364);
            this.Load += new System.EventHandler(this.NewItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.newItemPictureBox)).EndInit();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox newItemPictureBox;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Label newItemNameLbl;
        private System.Windows.Forms.Label newItemStockLbl;
        private System.Windows.Forms.Label newItmPriLbl;
        private RoundedPanel.RoundedPanel roundedPanel1;
        public System.Windows.Forms.TextBox qtyTextBox;
    }
}
