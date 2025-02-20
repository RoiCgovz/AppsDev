namespace GroceryAppWindowsForm
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Label();
            this.maximizeBtn = new System.Windows.Forms.PictureBox();
            this.minimizeBtn = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(97)))), ((int)(((byte)(190)))));
            this.panel1.Controls.Add(this.maximizeBtn);
            this.panel1.Controls.Add(this.minimizeBtn);
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 47);
            this.panel1.TabIndex = 0;
            // 
            // exitBtn
            // 
            this.exitBtn.AutoSize = true;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(990, 6);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(27, 30);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.Text = "X";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // maximizeBtn
            // 
            this.maximizeBtn.Image = global::GroceryAppWindowsForm.Properties.Resources.images;
            this.maximizeBtn.Location = new System.Drawing.Point(941, 6);
            this.maximizeBtn.Name = "maximizeBtn";
            this.maximizeBtn.Size = new System.Drawing.Size(29, 30);
            this.maximizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maximizeBtn.TabIndex = 2;
            this.maximizeBtn.TabStop = false;
            this.maximizeBtn.Click += new System.EventHandler(this.maximizeBtn_Click);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Image = global::GroceryAppWindowsForm.Properties.Resources.Adobe_Express___file;
            this.minimizeBtn.Location = new System.Drawing.Point(892, 6);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(32, 30);
            this.minimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizeBtn.TabIndex = 1;
            this.minimizeBtn.TabStop = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 538);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exitBtn;
        private System.Windows.Forms.PictureBox minimizeBtn;
        private System.Windows.Forms.PictureBox maximizeBtn;
    }
}

