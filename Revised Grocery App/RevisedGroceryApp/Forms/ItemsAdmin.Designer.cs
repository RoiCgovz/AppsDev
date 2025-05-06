namespace RevisedGroceryApp
{
    partial class ItemsAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.accActionPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.xBtn = new System.Windows.Forms.Label();
            this.accBtn = new System.Windows.Forms.Label();
            this.dataSet1 = new RevisedGroceryApp.DataSet1();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter = new RevisedGroceryApp.DataSet1TableAdapters.itemsTableAdapter();
            this.itemsDtaGrdVw = new System.Windows.Forms.DataGridView();
            this.itemidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet2 = new RevisedGroceryApp.DataSet2();
            this.itemsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter1 = new RevisedGroceryApp.DataSet2TableAdapters.itemsTableAdapter();
            this.addBtn = new CuoreUI.Controls.cuiButton();
            this.titleName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.accActionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDtaGrdVw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = global::RevisedGroceryApp.Properties.Resources.Adobe_Express___file__2_1;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(60, 16);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(52, 57);
            this.pictureBox7.TabIndex = 38;
            this.pictureBox7.TabStop = false;
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
            // accActionPanel
            // 
            this.accActionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.accActionPanel.Controls.Add(this.button1);
            this.accActionPanel.Location = new System.Drawing.Point(833, 48);
            this.accActionPanel.Name = "accActionPanel";
            this.accActionPanel.Size = new System.Drawing.Size(151, 36);
            this.accActionPanel.TabIndex = 40;
            this.accActionPanel.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(8, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 37);
            this.label6.TabIndex = 39;
            this.label6.Text = "<";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xBtn
            // 
            this.xBtn.AutoSize = true;
            this.xBtn.BackColor = System.Drawing.Color.Transparent;
            this.xBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.xBtn.ForeColor = System.Drawing.Color.White;
            this.xBtn.Location = new System.Drawing.Point(957, 16);
            this.xBtn.Name = "xBtn";
            this.xBtn.Size = new System.Drawing.Size(27, 30);
            this.xBtn.TabIndex = 33;
            this.xBtn.Text = "X";
            this.xBtn.Click += new System.EventHandler(this.xBtn_Click);
            // 
            // accBtn
            // 
            this.accBtn.AutoSize = true;
            this.accBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.accBtn.Location = new System.Drawing.Point(863, 20);
            this.accBtn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.accBtn.Name = "accBtn";
            this.accBtn.Size = new System.Drawing.Size(83, 25);
            this.accBtn.TabIndex = 32;
            this.accBtn.Text = "Account";
            this.accBtn.Click += new System.EventHandler(this.accBtn_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "items";
            this.itemsBindingSource.DataSource = this.dataSet1;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // itemsDtaGrdVw
            // 
            this.itemsDtaGrdVw.AutoGenerateColumns = false;
            this.itemsDtaGrdVw.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.itemsDtaGrdVw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemsDtaGrdVw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.itemsDtaGrdVw.ColumnHeadersHeight = 30;
            this.itemsDtaGrdVw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemidDataGridViewTextBoxColumn,
            this.itemnameDataGridViewTextBoxColumn});
            this.itemsDtaGrdVw.DataSource = this.itemsBindingSource1;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.itemsDtaGrdVw.DefaultCellStyle = dataGridViewCellStyle8;
            this.itemsDtaGrdVw.GridColor = System.Drawing.Color.White;
            this.itemsDtaGrdVw.Location = new System.Drawing.Point(377, 154);
            this.itemsDtaGrdVw.Name = "itemsDtaGrdVw";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemsDtaGrdVw.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.itemsDtaGrdVw.Size = new System.Drawing.Size(475, 464);
            this.itemsDtaGrdVw.TabIndex = 41;
            this.itemsDtaGrdVw.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // itemidDataGridViewTextBoxColumn
            // 
            this.itemidDataGridViewTextBoxColumn.DataPropertyName = "itemid";
            this.itemidDataGridViewTextBoxColumn.HeaderText = "itemid";
            this.itemidDataGridViewTextBoxColumn.Name = "itemidDataGridViewTextBoxColumn";
            this.itemidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemnameDataGridViewTextBoxColumn
            // 
            this.itemnameDataGridViewTextBoxColumn.DataPropertyName = "itemname";
            this.itemnameDataGridViewTextBoxColumn.HeaderText = "itemname";
            this.itemnameDataGridViewTextBoxColumn.Name = "itemnameDataGridViewTextBoxColumn";
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsBindingSource1
            // 
            this.itemsBindingSource1.DataMember = "items";
            this.itemsBindingSource1.DataSource = this.dataSet2;
            // 
            // itemsTableAdapter1
            // 
            this.itemsTableAdapter1.ClearBeforeFill = true;
            // 
            // addBtn
            // 
            this.addBtn.CheckButton = false;
            this.addBtn.Checked = false;
            this.addBtn.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addBtn.CheckedForeColor = System.Drawing.Color.White;
            this.addBtn.CheckedImageTint = System.Drawing.Color.White;
            this.addBtn.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addBtn.Content = "Add";
            this.addBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.HoverBackground = System.Drawing.Color.Gray;
            this.addBtn.HoveredImageTint = System.Drawing.Color.White;
            this.addBtn.HoverForeColor = System.Drawing.Color.White;
            this.addBtn.HoverOutline = System.Drawing.Color.Empty;
            this.addBtn.Image = null;
            this.addBtn.ImageAutoCenter = true;
            this.addBtn.ImageExpand = new System.Drawing.Point(0, 0);
            this.addBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.addBtn.Location = new System.Drawing.Point(94, 355);
            this.addBtn.Name = "addBtn";
            this.addBtn.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.addBtn.NormalForeColor = System.Drawing.Color.White;
            this.addBtn.NormalImageTint = System.Drawing.Color.White;
            this.addBtn.NormalOutline = System.Drawing.Color.Empty;
            this.addBtn.OutlineThickness = 1.6F;
            this.addBtn.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.addBtn.PressedForeColor = System.Drawing.Color.White;
            this.addBtn.PressedImageTint = System.Drawing.Color.White;
            this.addBtn.PressedOutline = System.Drawing.Color.Empty;
            this.addBtn.Rounding = new System.Windows.Forms.Padding(8);
            this.addBtn.Size = new System.Drawing.Size(153, 45);
            this.addBtn.TabIndex = 44;
            this.addBtn.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // titleName
            // 
            this.titleName.AutoSize = true;
            this.titleName.BackColor = System.Drawing.Color.Transparent;
            this.titleName.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleName.ForeColor = System.Drawing.SystemColors.Control;
            this.titleName.Location = new System.Drawing.Point(441, 48);
            this.titleName.Name = "titleName";
            this.titleName.Size = new System.Drawing.Size(161, 65);
            this.titleName.TabIndex = 45;
            this.titleName.Text = "Items";
            this.titleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemsAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1000, 640);
            this.Controls.Add(this.titleName);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.itemsDtaGrdVw);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.accActionPanel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.xBtn);
            this.Controls.Add(this.accBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemsAdmin";
            this.Text = "ItemsAdmin";
            this.Load += new System.EventHandler(this.ItemsAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.accActionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDtaGrdVw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel accActionPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label xBtn;
        private System.Windows.Forms.Label accBtn;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private DataSet1TableAdapters.itemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.DataGridView itemsDtaGrdVw;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemnameDataGridViewTextBoxColumn;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource itemsBindingSource1;
        private DataSet2TableAdapters.itemsTableAdapter itemsTableAdapter1;
        private CuoreUI.Controls.cuiButton addBtn;
        private System.Windows.Forms.Label titleName;
    }
}