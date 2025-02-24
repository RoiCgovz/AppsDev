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
            this.receiptUserControl1 = new GroceryAppWindowsForm.receiptUserControl();
            this.cart1 = new GroceryAppWindowsForm.Cart();
            this.SuspendLayout();
            // 
            // receiptUserControl1
            // 
            this.receiptUserControl1.Location = new System.Drawing.Point(13, 13);
            this.receiptUserControl1.Name = "receiptUserControl1";
            this.receiptUserControl1.Size = new System.Drawing.Size(589, 544);
            this.receiptUserControl1.TabIndex = 0;
            // 
            // cart1
            // 
            this.cart1.Location = new System.Drawing.Point(13, 13);
            this.cart1.Name = "cart1";
            this.cart1.Size = new System.Drawing.Size(590, 622);
            this.cart1.TabIndex = 1;
            // 
            // CartOrReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 571);
            this.Controls.Add(this.cart1);
            this.Controls.Add(this.receiptUserControl1);
            this.Name = "CartOrReceipt";
            this.Text = "CartOrReceipt";
            this.ResumeLayout(false);

        }

        #endregion

        private receiptUserControl receiptUserControl1;
        private Cart cart1;
    }
}