namespace RevisedGroceryApp.Forms
{
    partial class SalesReport
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
            this.saleidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesdetailidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesDetailstotalsaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saledateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grocerydbDataSet12 = new RevisedGroceryApp.grocerydbDataSet12();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.xBtn = new System.Windows.Forms.Label();
            this.printPDFBtn = new System.Windows.Forms.Button();
            this.accActionPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.accBtn = new System.Windows.Forms.Label();
            this.salesReportTableAdapter = new RevisedGroceryApp.grocerydbDataSet12TableAdapters.SalesReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.salesRepDtaGrdVw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grocerydbDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.accActionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleName
            // 
            this.titleName.AutoSize = true;
            this.titleName.BackColor = System.Drawing.Color.Transparent;
            this.titleName.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleName.ForeColor = System.Drawing.SystemColors.Control;
            this.titleName.Location = new System.Drawing.Point(338, 53);
            this.titleName.Name = "titleName";
            this.titleName.Size = new System.Drawing.Size(322, 65);
            this.titleName.TabIndex = 53;
            this.titleName.Text = "Sales Report";
            this.titleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // salesRepDtaGrdVw
            // 
            this.salesRepDtaGrdVw.AllowUserToAddRows = false;
            this.salesRepDtaGrdVw.AllowUserToDeleteRows = false;
            this.salesRepDtaGrdVw.AutoGenerateColumns = false;
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
            this.salesRepDtaGrdVw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saleidDataGridViewTextBoxColumn,
            this.salesdetailidDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.salesDetailstotalsaleDataGridViewTextBoxColumn,
            this.saledateDataGridViewTextBoxColumn});
            this.salesRepDtaGrdVw.DataSource = this.salesReportBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.salesRepDtaGrdVw.DefaultCellStyle = dataGridViewCellStyle2;
            this.salesRepDtaGrdVw.GridColor = System.Drawing.Color.White;
            this.salesRepDtaGrdVw.Location = new System.Drawing.Point(153, 164);
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
            this.salesRepDtaGrdVw.Size = new System.Drawing.Size(694, 344);
            this.salesRepDtaGrdVw.TabIndex = 51;
            // 
            // saleidDataGridViewTextBoxColumn
            // 
            this.saleidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.saleidDataGridViewTextBoxColumn.DataPropertyName = "saleid";
            this.saleidDataGridViewTextBoxColumn.HeaderText = "Sales ID";
            this.saleidDataGridViewTextBoxColumn.Name = "saleidDataGridViewTextBoxColumn";
            this.saleidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salesdetailidDataGridViewTextBoxColumn
            // 
            this.salesdetailidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.salesdetailidDataGridViewTextBoxColumn.DataPropertyName = "salesdetailid";
            this.salesdetailidDataGridViewTextBoxColumn.HeaderText = "Sales Details ID";
            this.salesdetailidDataGridViewTextBoxColumn.Name = "salesdetailidDataGridViewTextBoxColumn";
            this.salesdetailidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salesDetailstotalsaleDataGridViewTextBoxColumn
            // 
            this.salesDetailstotalsaleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.salesDetailstotalsaleDataGridViewTextBoxColumn.DataPropertyName = "salesDetails_totalsale";
            this.salesDetailstotalsaleDataGridViewTextBoxColumn.HeaderText = "Total Sales";
            this.salesDetailstotalsaleDataGridViewTextBoxColumn.Name = "salesDetailstotalsaleDataGridViewTextBoxColumn";
            this.salesDetailstotalsaleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saledateDataGridViewTextBoxColumn
            // 
            this.saledateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.saledateDataGridViewTextBoxColumn.DataPropertyName = "saledate";
            this.saledateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.saledateDataGridViewTextBoxColumn.Name = "saledateDataGridViewTextBoxColumn";
            this.saledateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salesReportBindingSource
            // 
            this.salesReportBindingSource.DataMember = "SalesReport";
            this.salesReportBindingSource.DataSource = this.grocerydbDataSet12;
            // 
            // grocerydbDataSet12
            // 
            this.grocerydbDataSet12.DataSetName = "grocerydbDataSet12";
            this.grocerydbDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = global::RevisedGroceryApp.Properties.Resources.Adobe_Express___file__2_1;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(64, 21);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(52, 57);
            this.pictureBox7.TabIndex = 48;
            this.pictureBox7.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(12, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 37);
            this.label6.TabIndex = 49;
            this.label6.Text = "<";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xBtn
            // 
            this.xBtn.AutoSize = true;
            this.xBtn.BackColor = System.Drawing.Color.Transparent;
            this.xBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.xBtn.ForeColor = System.Drawing.Color.White;
            this.xBtn.Location = new System.Drawing.Point(961, 21);
            this.xBtn.Name = "xBtn";
            this.xBtn.Size = new System.Drawing.Size(27, 30);
            this.xBtn.TabIndex = 47;
            this.xBtn.Text = "X";
            this.xBtn.Click += new System.EventHandler(this.xBtn_Click);
            // 
            // printPDFBtn
            // 
            this.printPDFBtn.BackColor = System.Drawing.Color.Black;
            this.printPDFBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printPDFBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printPDFBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.printPDFBtn.Location = new System.Drawing.Point(374, 550);
            this.printPDFBtn.Name = "printPDFBtn";
            this.printPDFBtn.Size = new System.Drawing.Size(224, 57);
            this.printPDFBtn.TabIndex = 62;
            this.printPDFBtn.Text = "Convert to PDF";
            this.printPDFBtn.UseVisualStyleBackColor = false;
            this.printPDFBtn.Click += new System.EventHandler(this.printPDFBtn_Click);
            // 
            // accActionPanel
            // 
            this.accActionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.accActionPanel.Controls.Add(this.button1);
            this.accActionPanel.Location = new System.Drawing.Point(810, 57);
            this.accActionPanel.Name = "accActionPanel";
            this.accActionPanel.Size = new System.Drawing.Size(151, 36);
            this.accActionPanel.TabIndex = 68;
            this.accActionPanel.Visible = false;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // accBtn
            // 
            this.accBtn.AutoSize = true;
            this.accBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.accBtn.Location = new System.Drawing.Point(840, 29);
            this.accBtn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.accBtn.Name = "accBtn";
            this.accBtn.Size = new System.Drawing.Size(83, 25);
            this.accBtn.TabIndex = 67;
            this.accBtn.Text = "Account";
            this.accBtn.Click += new System.EventHandler(this.accBtn_Click);
            // 
            // salesReportTableAdapter
            // 
            this.salesReportTableAdapter.ClearBeforeFill = true;
            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1000, 640);
            this.Controls.Add(this.accActionPanel);
            this.Controls.Add(this.accBtn);
            this.Controls.Add(this.printPDFBtn);
            this.Controls.Add(this.titleName);
            this.Controls.Add(this.salesRepDtaGrdVw);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.xBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesReport";
            this.Text = "SalesReport";
            this.Load += new System.EventHandler(this.SalesReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesRepDtaGrdVw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grocerydbDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.accActionPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Panel accActionPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label accBtn;
        private grocerydbDataSet12 grocerydbDataSet12;
        private System.Windows.Forms.BindingSource salesReportBindingSource;
        private grocerydbDataSet12TableAdapters.SalesReportTableAdapter salesReportTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesdetailidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesDetailstotalsaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saledateDataGridViewTextBoxColumn;
    }
}