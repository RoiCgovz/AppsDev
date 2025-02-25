namespace GroceryAppWindowsForm
{
    partial class CartOrReceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartOrReceipt));
            this.closeButton = new System.Windows.Forms.Button();
            this.bckLbl = new System.Windows.Forms.Label();
            this.cartCtrl = new GroceryAppWindowsForm.Cart();
            this.receiptCtrl = new GroceryAppWindowsForm.receiptUserControl();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.White;
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.Location = new System.Drawing.Point(571, 5);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(32, 33);
            this.closeButton.TabIndex = 4;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // bckLbl
            // 
            this.bckLbl.AutoSize = true;
            this.bckLbl.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bckLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bckLbl.Location = new System.Drawing.Point(12, 1);
            this.bckLbl.Name = "bckLbl";
            this.bckLbl.Size = new System.Drawing.Size(38, 40);
            this.bckLbl.TabIndex = 6;
            this.bckLbl.Text = "<";
            this.bckLbl.Click += new System.EventHandler(this.bckLbl_Click);
            // 
            // cartCtrl
            // 
            this.cartCtrl.Location = new System.Drawing.Point(12, 45);
            this.cartCtrl.Name = "cartCtrl";
            this.cartCtrl.Size = new System.Drawing.Size(590, 543);
            this.cartCtrl.TabIndex = 5;
            // 
            // receiptCtrl
            // 
            this.receiptCtrl.Location = new System.Drawing.Point(13, 44);
            this.receiptCtrl.Name = "receiptCtrl";
            this.receiptCtrl.Size = new System.Drawing.Size(589, 544);
            this.receiptCtrl.TabIndex = 0;
            // 
            // CartOrReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 590);
            this.Controls.Add(this.bckLbl);
            this.Controls.Add(this.cartCtrl);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.receiptCtrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CartOrReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CartOrReceipt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private receiptUserControl receiptCtrl;
        private System.Windows.Forms.Button closeButton;
        private Cart cartCtrl;
        private System.Windows.Forms.Label bckLbl;
    }
}