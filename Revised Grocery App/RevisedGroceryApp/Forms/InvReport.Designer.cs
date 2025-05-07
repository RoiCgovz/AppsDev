namespace RevisedGroceryApp.Forms
{
    partial class InvReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.titleName = new System.Windows.Forms.Label();
            this.salesRepDtaGrdVw = new System.Windows.Forms.DataGridView();
            this.invreportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grocerydbDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grocerydbDataSet1 = new RevisedGroceryApp.grocerydbDataSet1();
            this.label6 = new System.Windows.Forms.Label();
            this.xBtn = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.printPDFBtn = new System.Windows.Forms.Button();
            this.invreportsTableAdapter = new RevisedGroceryApp.grocerydbDataSet1TableAdapters.invreportsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.salesRepDtaGrdVw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invreportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grocerydbDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grocerydbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // titleName
            // 
            this.titleName.AutoSize = true;
            this.titleName.BackColor = System.Drawing.Color.Transparent;
            this.titleName.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleName.ForeColor = System.Drawing.SystemColors.Control;
            this.titleName.Location = new System.Drawing.Point(286, 51);
            this.titleName.Name = "titleName";
            this.titleName.Size = new System.Drawing.Size(434, 65);
            this.titleName.TabIndex = 60;
            this.titleName.Text = "Inventory Report";
            this.titleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // salesRepDtaGrdVw
            // 
            this.salesRepDtaGrdVw.AllowUserToAddRows = false;
            this.salesRepDtaGrdVw.AllowUserToDeleteRows = false;
            this.salesRepDtaGrdVw.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.salesRepDtaGrdVw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salesRepDtaGrdVw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.salesRepDtaGrdVw.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.salesRepDtaGrdVw.DefaultCellStyle = dataGridViewCellStyle2;
            this.salesRepDtaGrdVw.GridColor = System.Drawing.Color.White;
            this.salesRepDtaGrdVw.Location = new System.Drawing.Point(153, 162);
            this.salesRepDtaGrdVw.Name = "salesRepDtaGrdVw";
            this.salesRepDtaGrdVw.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salesRepDtaGrdVw.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.salesRepDtaGrdVw.Size = new System.Drawing.Size(694, 372);
            this.salesRepDtaGrdVw.TabIndex = 59;
            // 
            // invreportsBindingSource
            // 
            this.invreportsBindingSource.DataMember = "invreports";
            this.invreportsBindingSource.DataSource = this.grocerydbDataSet1BindingSource;
            // 
            // grocerydbDataSet1BindingSource
            // 
            this.grocerydbDataSet1BindingSource.DataSource = this.grocerydbDataSet1;
            this.grocerydbDataSet1BindingSource.Position = 0;
            // 
            // grocerydbDataSet1
            // 
            this.grocerydbDataSet1.DataSetName = "grocerydbDataSet1";
            this.grocerydbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(12, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 37);
            this.label6.TabIndex = 57;
            this.label6.Text = "<";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xBtn
            // 
            this.xBtn.AutoSize = true;
            this.xBtn.BackColor = System.Drawing.Color.Transparent;
            this.xBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.xBtn.ForeColor = System.Drawing.Color.White;
            this.xBtn.Location = new System.Drawing.Point(961, 19);
            this.xBtn.Name = "xBtn";
            this.xBtn.Size = new System.Drawing.Size(27, 30);
            this.xBtn.TabIndex = 55;
            this.xBtn.Text = "X";
            this.xBtn.Click += new System.EventHandler(this.xBtn_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = global::RevisedGroceryApp.Properties.Resources.Adobe_Express___file__2_1;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(64, 19);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(52, 57);
            this.pictureBox7.TabIndex = 56;
            this.pictureBox7.TabStop = false;
            // 
            // printPDFBtn
            // 
            this.printPDFBtn.BackColor = System.Drawing.Color.Black;
            this.printPDFBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printPDFBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printPDFBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.printPDFBtn.Location = new System.Drawing.Point(393, 562);
            this.printPDFBtn.Name = "printPDFBtn";
            this.printPDFBtn.Size = new System.Drawing.Size(224, 57);
            this.printPDFBtn.TabIndex = 61;
            this.printPDFBtn.Text = "Convert to PDF";
            this.printPDFBtn.UseVisualStyleBackColor = false;
            this.printPDFBtn.Click += new System.EventHandler(this.printPDFBtn_Click);
            // 
            // invreportsTableAdapter
            // 
            this.invreportsTableAdapter.ClearBeforeFill = true;
            // 
            // InvReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1000, 640);
            this.Controls.Add(this.printPDFBtn);
            this.Controls.Add(this.titleName);
            this.Controls.Add(this.salesRepDtaGrdVw);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.xBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InvReport";
            this.Text = "InvReport";
            this.Load += new System.EventHandler(this.InvReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesRepDtaGrdVw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invreportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grocerydbDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grocerydbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleName;
        private System.Windows.Forms.DataGridView salesRepDtaGrdVw;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label xBtn;
        private System.Windows.Forms.Button printPDFBtn;
        private System.Windows.Forms.BindingSource grocerydbDataSet1BindingSource;
        private grocerydbDataSet1 grocerydbDataSet1;
        private System.Windows.Forms.BindingSource invreportsBindingSource;
        private grocerydbDataSet1TableAdapters.invreportsTableAdapter invreportsTableAdapter;
    }
}