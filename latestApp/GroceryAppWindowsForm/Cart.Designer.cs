namespace GroceryAppWindowsForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.rTotalLabel = new System.Windows.Forms.Label();
            this.rTotaltextLable = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cartListBox = new System.Windows.Forms.ListBox();
            this.discountNum_Label = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.rTotalLabel);
            this.panel3.Controls.Add(this.rTotaltextLable);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Location = new System.Drawing.Point(0, 450);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(590, 78);
            this.panel3.TabIndex = 6;
            // 
            // rTotalLabel
            // 
            this.rTotalLabel.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTotalLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rTotalLabel.Location = new System.Drawing.Point(344, 25);
            this.rTotalLabel.Name = "rTotalLabel";
            this.rTotalLabel.Size = new System.Drawing.Size(225, 28);
            this.rTotalLabel.TabIndex = 1;
            this.rTotalLabel.Text = "$0.00";
            this.rTotalLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rTotaltextLable
            // 
            this.rTotaltextLable.AutoSize = true;
            this.rTotaltextLable.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTotaltextLable.ForeColor = System.Drawing.SystemColors.InfoText;
            this.rTotaltextLable.Location = new System.Drawing.Point(3, 25);
            this.rTotaltextLable.Name = "rTotaltextLable";
            this.rTotaltextLable.Size = new System.Drawing.Size(151, 28);
            this.rTotaltextLable.TabIndex = 0;
            this.rTotaltextLable.Text = "Receipt Total";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 15);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(0, 528);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 15);
            this.panel1.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.cartListBox);
            this.panel4.Controls.Add(this.discountNum_Label);
            this.panel4.Controls.Add(this.subtotalLabel);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(0, 55);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(587, 398);
            this.panel4.TabIndex = 8;
            // 
            // cartListBox
            // 
            this.cartListBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartListBox.FormattingEnabled = true;
            this.cartListBox.ItemHeight = 21;
            this.cartListBox.Location = new System.Drawing.Point(8, 37);
            this.cartListBox.Name = "cartListBox";
            this.cartListBox.Size = new System.Drawing.Size(569, 298);
            this.cartListBox.TabIndex = 5;
            // 
            // discountNum_Label
            // 
            this.discountNum_Label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountNum_Label.Location = new System.Drawing.Point(522, 362);
            this.discountNum_Label.Name = "discountNum_Label";
            this.discountNum_Label.Size = new System.Drawing.Size(60, 25);
            this.discountNum_Label.TabIndex = 4;
            this.discountNum_Label.Text = "0%";
            this.discountNum_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.Location = new System.Drawing.Point(456, 343);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(121, 25);
            this.subtotalLabel.TabIndex = 3;
            this.subtotalLabel.Text = "$0.00";
            this.subtotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(589, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "QTY            DESCRIPTION               UNIT PRICE                     AMOUNT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(363, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 52);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subtotal\r\nDiscount";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(262, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "CART";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label1);
            this.Name = "Cart";
            this.Size = new System.Drawing.Size(590, 543);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label rTotalLabel;
        private System.Windows.Forms.Label rTotaltextLable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox cartListBox;
        private System.Windows.Forms.Label discountNum_Label;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
