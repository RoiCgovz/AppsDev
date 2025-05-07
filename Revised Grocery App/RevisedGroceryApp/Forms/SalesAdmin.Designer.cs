namespace RevisedGroceryApp
{
    partial class SalesAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.invreportsTableAdapter = new RevisedGroceryApp.grocerydbDataSet1TableAdapters.invreportsTableAdapter();
            this.titleName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.accActionPanel = new System.Windows.Forms.Panel();
            this.accBtn = new System.Windows.Forms.Label();
            this.grocerydbDataSet1 = new RevisedGroceryApp.grocerydbDataSet1();
            this.grocerydbDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invreportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesRepDtaGrdVw = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.xBtn = new System.Windows.Forms.Label();
            this.grocerydbDataSet5 = new RevisedGroceryApp.grocerydbDataSet5();
            this.salesdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesdetailsTableAdapter = new RevisedGroceryApp.grocerydbDataSet5TableAdapters.salesdetailsTableAdapter();
            this.grocerydbDataSet8 = new RevisedGroceryApp.grocerydbDataSet8();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesTableAdapter = new RevisedGroceryApp.grocerydbDataSet8TableAdapters.salesTableAdapter();
            this.salesdetailidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesdetailssaleidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesDetailstotalsaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.accActionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grocerydbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grocerydbDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invreportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesRepDtaGrdVw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grocerydbDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesdetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grocerydbDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // invreportsTableAdapter
            // 
            this.invreportsTableAdapter.ClearBeforeFill = true;
            // 
            // titleName
            // 
            this.titleName.AutoSize = true;
            this.titleName.BackColor = System.Drawing.Color.Transparent;
            this.titleName.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleName.ForeColor = System.Drawing.SystemColors.Control;
            this.titleName.Location = new System.Drawing.Point(433, 54);
            this.titleName.Name = "titleName";
            this.titleName.Size = new System.Drawing.Size(147, 65);
            this.titleName.TabIndex = 68;
            this.titleName.Text = "Sales";
            this.titleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = global::RevisedGroceryApp.Properties.Resources.Adobe_Express___file__2_1;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(64, 22);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(52, 57);
            this.pictureBox7.TabIndex = 64;
            this.pictureBox7.TabStop = false;
            // 
            // accActionPanel
            // 
            this.accActionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.accActionPanel.Controls.Add(this.button1);
            this.accActionPanel.Location = new System.Drawing.Point(837, 54);
            this.accActionPanel.Name = "accActionPanel";
            this.accActionPanel.Size = new System.Drawing.Size(151, 36);
            this.accActionPanel.TabIndex = 66;
            this.accActionPanel.Visible = false;
            // 
            // accBtn
            // 
            this.accBtn.AutoSize = true;
            this.accBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.accBtn.Location = new System.Drawing.Point(867, 26);
            this.accBtn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.accBtn.Name = "accBtn";
            this.accBtn.Size = new System.Drawing.Size(83, 25);
            this.accBtn.TabIndex = 62;
            this.accBtn.Text = "Account";
            // 
            // grocerydbDataSet1
            // 
            this.grocerydbDataSet1.DataSetName = "grocerydbDataSet1";
            this.grocerydbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grocerydbDataSet1BindingSource
            // 
            this.grocerydbDataSet1BindingSource.DataSource = this.grocerydbDataSet1;
            this.grocerydbDataSet1BindingSource.Position = 0;
            // 
            // invreportsBindingSource
            // 
            this.invreportsBindingSource.DataMember = "invreports";
            this.invreportsBindingSource.DataSource = this.grocerydbDataSet1BindingSource;
            // 
            // salesRepDtaGrdVw
            // 
            this.salesRepDtaGrdVw.AllowUserToAddRows = false;
            this.salesRepDtaGrdVw.AllowUserToDeleteRows = false;
            this.salesRepDtaGrdVw.AutoGenerateColumns = false;
            this.salesRepDtaGrdVw.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.salesRepDtaGrdVw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salesRepDtaGrdVw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.salesRepDtaGrdVw.ColumnHeadersHeight = 30;
            this.salesRepDtaGrdVw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salesdetailidDataGridViewTextBoxColumn,
            this.salesdetailssaleidDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.salesDetailstotalsaleDataGridViewTextBoxColumn});
            this.salesRepDtaGrdVw.DataSource = this.salesdetailsBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.salesRepDtaGrdVw.DefaultCellStyle = dataGridViewCellStyle5;
            this.salesRepDtaGrdVw.GridColor = System.Drawing.Color.White;
            this.salesRepDtaGrdVw.Location = new System.Drawing.Point(153, 165);
            this.salesRepDtaGrdVw.Name = "salesRepDtaGrdVw";
            this.salesRepDtaGrdVw.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salesRepDtaGrdVw.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.salesRepDtaGrdVw.Size = new System.Drawing.Size(694, 372);
            this.salesRepDtaGrdVw.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(12, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 37);
            this.label6.TabIndex = 65;
            this.label6.Text = "<";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xBtn
            // 
            this.xBtn.AutoSize = true;
            this.xBtn.BackColor = System.Drawing.Color.Transparent;
            this.xBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.xBtn.ForeColor = System.Drawing.Color.White;
            this.xBtn.Location = new System.Drawing.Point(961, 22);
            this.xBtn.Name = "xBtn";
            this.xBtn.Size = new System.Drawing.Size(27, 30);
            this.xBtn.TabIndex = 63;
            this.xBtn.Text = "X";
            this.xBtn.Click += new System.EventHandler(this.xBtn_Click);
            // 
            // grocerydbDataSet5
            // 
            this.grocerydbDataSet5.DataSetName = "grocerydbDataSet5";
            this.grocerydbDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesdetailsBindingSource
            // 
            this.salesdetailsBindingSource.DataMember = "salesdetails";
            this.salesdetailsBindingSource.DataSource = this.grocerydbDataSet5;
            // 
            // salesdetailsTableAdapter
            // 
            this.salesdetailsTableAdapter.ClearBeforeFill = true;
            // 
            // grocerydbDataSet8
            // 
            this.grocerydbDataSet8.DataSetName = "grocerydbDataSet8";
            this.grocerydbDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "sales";
            this.salesBindingSource.DataSource = this.grocerydbDataSet8;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // salesdetailidDataGridViewTextBoxColumn
            // 
            this.salesdetailidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.salesdetailidDataGridViewTextBoxColumn.DataPropertyName = "salesdetailid";
            this.salesdetailidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.salesdetailidDataGridViewTextBoxColumn.Name = "salesdetailidDataGridViewTextBoxColumn";
            this.salesdetailidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salesdetailssaleidDataGridViewTextBoxColumn
            // 
            this.salesdetailssaleidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.salesdetailssaleidDataGridViewTextBoxColumn.DataPropertyName = "salesdetails_saleid";
            this.salesdetailssaleidDataGridViewTextBoxColumn.HeaderText = "Sales ID";
            this.salesdetailssaleidDataGridViewTextBoxColumn.Name = "salesdetailssaleidDataGridViewTextBoxColumn";
            this.salesdetailssaleidDataGridViewTextBoxColumn.ReadOnly = true;
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
            // SalesAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1000, 640);
            this.Controls.Add(this.titleName);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.accActionPanel);
            this.Controls.Add(this.accBtn);
            this.Controls.Add(this.salesRepDtaGrdVw);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.xBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesAdmin";
            this.Text = "xxxxxxxx";
            this.Load += new System.EventHandler(this.SalesAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.accActionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grocerydbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grocerydbDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invreportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesRepDtaGrdVw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grocerydbDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesdetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grocerydbDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private grocerydbDataSet1TableAdapters.invreportsTableAdapter invreportsTableAdapter;
        private System.Windows.Forms.Label titleName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Panel accActionPanel;
        private System.Windows.Forms.Label accBtn;
        private grocerydbDataSet1 grocerydbDataSet1;
        private System.Windows.Forms.BindingSource grocerydbDataSet1BindingSource;
        private System.Windows.Forms.BindingSource invreportsBindingSource;
        private System.Windows.Forms.DataGridView salesRepDtaGrdVw;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label xBtn;
        private grocerydbDataSet5 grocerydbDataSet5;
        private System.Windows.Forms.BindingSource salesdetailsBindingSource;
        private grocerydbDataSet5TableAdapters.salesdetailsTableAdapter salesdetailsTableAdapter;
        private grocerydbDataSet8 grocerydbDataSet8;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private grocerydbDataSet8TableAdapters.salesTableAdapter salesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesdetailidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesdetailssaleidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesDetailstotalsaleDataGridViewTextBoxColumn;
    }
}