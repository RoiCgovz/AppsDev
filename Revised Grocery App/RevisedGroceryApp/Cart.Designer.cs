namespace RevisedGroceryApp
{
    partial class Cart
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
            this.cartPnl = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cartListBox = new System.Windows.Forms.ListBox();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.xBtn = new System.Windows.Forms.PictureBox();
            this.backBtn = new System.Windows.Forms.Label();
            this.checkoutBtn = new System.Windows.Forms.Button();
            this.cartPnl.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // cartPnl
            // 
            this.cartPnl.Controls.Add(this.panel2);
            this.cartPnl.Controls.Add(this.panel4);
            this.cartPnl.Controls.Add(this.panel5);
            this.cartPnl.Controls.Add(this.label1);
            this.cartPnl.Location = new System.Drawing.Point(11, 82);
            this.cartPnl.Name = "cartPnl";
            this.cartPnl.Size = new System.Drawing.Size(438, 447);
            this.cartPnl.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 15);
            this.panel2.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel4.Location = new System.Drawing.Point(0, 432);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(438, 15);
            this.panel4.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.cartListBox);
            this.panel5.Controls.Add(this.subtotalLabel);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(-1, 55);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(439, 398);
            this.panel5.TabIndex = 13;
            // 
            // cartListBox
            // 
            this.cartListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartListBox.ForeColor = System.Drawing.Color.Blue;
            this.cartListBox.FormattingEnabled = true;
            this.cartListBox.ItemHeight = 25;
            this.cartListBox.Location = new System.Drawing.Point(8, 37);
            this.cartListBox.Name = "cartListBox";
            this.cartListBox.Size = new System.Drawing.Size(426, 279);
            this.cartListBox.TabIndex = 5;
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.Location = new System.Drawing.Point(344, 333);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(74, 25);
            this.subtotalLabel.TabIndex = 3;
            this.subtotalLabel.Text = "$0.00";
            this.subtotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(438, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "QTY            DESCRIPTION            UNIT PRICE            AMOUNT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(246, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 52);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subtotal";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(175, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "CART";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.xBtn);
            this.panel1.Location = new System.Drawing.Point(11, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 80);
            this.panel1.TabIndex = 9;
            // 
            // xBtn
            // 
            this.xBtn.BackColor = System.Drawing.Color.Navy;
            this.xBtn.BackgroundImage = global::RevisedGroceryApp.Properties.Resources.Adobe_Express___file__1_;
            this.xBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.xBtn.Location = new System.Drawing.Point(399, 7);
            this.xBtn.Name = "xBtn";
            this.xBtn.Size = new System.Drawing.Size(20, 20);
            this.xBtn.TabIndex = 3;
            this.xBtn.TabStop = false;
            this.xBtn.Click += new System.EventHandler(this.xBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.AutoSize = true;
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(13, 4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(31, 32);
            this.backBtn.TabIndex = 14;
            this.backBtn.Text = "<";
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // checkoutBtn
            // 
            this.checkoutBtn.BackColor = System.Drawing.Color.Navy;
            this.checkoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkoutBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutBtn.ForeColor = System.Drawing.Color.White;
            this.checkoutBtn.Location = new System.Drawing.Point(136, 541);
            this.checkoutBtn.Name = "checkoutBtn";
            this.checkoutBtn.Size = new System.Drawing.Size(206, 44);
            this.checkoutBtn.TabIndex = 10;
            this.checkoutBtn.Text = "Proceed to Checkout";
            this.checkoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkoutBtn.UseVisualStyleBackColor = false;
            this.checkoutBtn.Click += new System.EventHandler(this.checkoutBtn_Click);
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 600);
            this.Controls.Add(this.checkoutBtn);
            this.Controls.Add(this.cartPnl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cart";
            this.cartPnl.ResumeLayout(false);
            this.cartPnl.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel cartPnl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListBox cartListBox;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox xBtn;
        private System.Windows.Forms.Label backBtn;
        private System.Windows.Forms.Button checkoutBtn;
    }
}