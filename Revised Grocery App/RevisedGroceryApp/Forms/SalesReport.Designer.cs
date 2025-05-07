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
            this.reportidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesrepsalesdetailidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesrepitemidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itempriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesreportsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.grocerydbDataSet4 = new RevisedGroceryApp.grocerydbDataSet4();
            this.salesreportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet3 = new RevisedGroceryApp.DataSet3();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.xBtn = new System.Windows.Forms.Label();
            this.salesreportsTableAdapter = new RevisedGroceryApp.DataSet3TableAdapters.salesreportsTableAdapter();
            this.salesreportsTableAdapter1 = new RevisedGroceryApp.grocerydbDataSet4TableAdapters.salesreportsTableAdapter();
            this.printPDFBtn = new System.Windows.Forms.Button();
            this.grocerydbDataSet9 = new RevisedGroceryApp.grocerydbDataSet9();
            this.salesreportsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.salesreportsTableAdapter2 = new RevisedGroceryApp.grocerydbDataSet9TableAdapters.salesreportsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.salesRepDtaGrdVw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesreportsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grocerydbDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesreportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grocerydbDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesreportsBindingSource2)).BeginInit();
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
            this.reportidDataGridViewTextBoxColumn,
            this.salesrepsalesdetailidDataGridViewTextBoxColumn,
            this.salesrepitemidDataGridViewTextBoxColumn,
            this.itempriceDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.salesRepDtaGrdVw.DataSource = this.salesreportsBindingSource2;
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
            // reportidDataGridViewTextBoxColumn
            // 
            this.reportidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.reportidDataGridViewTextBoxColumn.DataPropertyName = "reportid";
            this.reportidDataGridViewTextBoxColumn.HeaderText = "Report ID";
            this.reportidDataGridViewTextBoxColumn.Name = "reportidDataGridViewTextBoxColumn";
            this.reportidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salesrepsalesdetailidDataGridViewTextBoxColumn
            // 
            this.salesrepsalesdetailidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.salesrepsalesdetailidDataGridViewTextBoxColumn.DataPropertyName = "salesrep_salesdetailid";
            this.salesrepsalesdetailidDataGridViewTextBoxColumn.HeaderText = "Sales Details ID";
            this.salesrepsalesdetailidDataGridViewTextBoxColumn.Name = "salesrepsalesdetailidDataGridViewTextBoxColumn";
            this.salesrepsalesdetailidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salesrepitemidDataGridViewTextBoxColumn
            // 
            this.salesrepitemidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.salesrepitemidDataGridViewTextBoxColumn.DataPropertyName = "salesrep_itemid";
            this.salesrepitemidDataGridViewTextBoxColumn.HeaderText = "Item ID";
            this.salesrepitemidDataGridViewTextBoxColumn.Name = "salesrepitemidDataGridViewTextBoxColumn";
            this.salesrepitemidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itempriceDataGridViewTextBoxColumn
            // 
            this.itempriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itempriceDataGridViewTextBoxColumn.DataPropertyName = "itemprice";
            this.itempriceDataGridViewTextBoxColumn.HeaderText = "Item Price";
            this.itempriceDataGridViewTextBoxColumn.Name = "itempriceDataGridViewTextBoxColumn";
            this.itempriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salesreportsBindingSource1
            // 
            this.salesreportsBindingSource1.DataMember = "salesreports";
            this.salesreportsBindingSource1.DataSource = this.grocerydbDataSet4;
            // 
            // grocerydbDataSet4
            // 
            this.grocerydbDataSet4.DataSetName = "grocerydbDataSet4";
            this.grocerydbDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesreportsBindingSource
            // 
            this.salesreportsBindingSource.DataMember = "salesreports";
            this.salesreportsBindingSource.DataSource = this.dataSet3;
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // salesreportsTableAdapter
            // 
            this.salesreportsTableAdapter.ClearBeforeFill = true;
            // 
            // salesreportsTableAdapter1
            // 
            this.salesreportsTableAdapter1.ClearBeforeFill = true;
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
            // grocerydbDataSet9
            // 
            this.grocerydbDataSet9.DataSetName = "grocerydbDataSet9";
            this.grocerydbDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesreportsBindingSource2
            // 
            this.salesreportsBindingSource2.DataMember = "salesreports";
            this.salesreportsBindingSource2.DataSource = this.grocerydbDataSet9;
            // 
            // salesreportsTableAdapter2
            // 
            this.salesreportsTableAdapter2.ClearBeforeFill = true;
            // 
            // SalesReport
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
            this.Name = "SalesReport";
            this.Text = "SalesReport";
            this.Load += new System.EventHandler(this.SalesReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesRepDtaGrdVw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesreportsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grocerydbDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesreportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grocerydbDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesreportsBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleName;
        private System.Windows.Forms.DataGridView salesRepDtaGrdVw;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label xBtn;
        private DataSet3 dataSet3;
        private System.Windows.Forms.BindingSource salesreportsBindingSource;
        private DataSet3TableAdapters.salesreportsTableAdapter salesreportsTableAdapter;
        private grocerydbDataSet4 grocerydbDataSet4;
        private System.Windows.Forms.BindingSource salesreportsBindingSource1;
        private grocerydbDataSet4TableAdapters.salesreportsTableAdapter salesreportsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesrepsalesdetailidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesrepitemidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itempriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button printPDFBtn;
        private grocerydbDataSet9 grocerydbDataSet9;
        private System.Windows.Forms.BindingSource salesreportsBindingSource2;
        private grocerydbDataSet9TableAdapters.salesreportsTableAdapter salesreportsTableAdapter2;
    }
}