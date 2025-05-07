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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.accActionPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.xBtn = new System.Windows.Forms.Label();
            this.accBtn = new System.Windows.Forms.Label();
            this.dataSet1 = new RevisedGroceryApp.DataSet1();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter = new RevisedGroceryApp.DataSet1TableAdapters.itemsTableAdapter();
            this.itemsDtaGrdVw = new System.Windows.Forms.DataGridView();
            this.itemsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new RevisedGroceryApp.DataSet2();
            this.itemsTableAdapter1 = new RevisedGroceryApp.DataSet2TableAdapters.itemsTableAdapter();
            this.addBtn = new CuoreUI.Controls.cuiButton();
            this.titleName = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.grocerydbDataSet3 = new RevisedGroceryApp.grocerydbDataSet3();
            this.itemsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter2 = new RevisedGroceryApp.grocerydbDataSet3TableAdapters.itemsTableAdapter();
            this.itemidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatepnl = new System.Windows.Forms.Panel();
            this.categorycombobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveBtn = new CuoreUI.Controls.cuiButton();
            this.nametxtbox = new CuoreUI.Controls.cuiTextBox2();
            this.accActionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDtaGrdVw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grocerydbDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource2)).BeginInit();
            this.updatepnl.SuspendLayout();
            this.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemsDtaGrdVw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.itemsDtaGrdVw.ColumnHeadersHeight = 30;
            this.itemsDtaGrdVw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemidDataGridViewTextBoxColumn,
            this.itemnameDataGridViewTextBoxColumn});
            this.itemsDtaGrdVw.DataSource = this.itemsBindingSource2;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.itemsDtaGrdVw.DefaultCellStyle = dataGridViewCellStyle2;
            this.itemsDtaGrdVw.GridColor = System.Drawing.Color.White;
            this.itemsDtaGrdVw.Location = new System.Drawing.Point(377, 154);
            this.itemsDtaGrdVw.Name = "itemsDtaGrdVw";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemsDtaGrdVw.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.itemsDtaGrdVw.Size = new System.Drawing.Size(580, 464);
            this.itemsDtaGrdVw.TabIndex = 41;
            this.itemsDtaGrdVw.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // itemsBindingSource1
            // 
            this.itemsBindingSource1.DataMember = "items";
            this.itemsBindingSource1.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.addBtn.Location = new System.Drawing.Point(75, 303);
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
            // grocerydbDataSet3
            // 
            this.grocerydbDataSet3.DataSetName = "grocerydbDataSet3";
            this.grocerydbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsBindingSource2
            // 
            this.itemsBindingSource2.DataMember = "items";
            this.itemsBindingSource2.DataSource = this.grocerydbDataSet3;
            // 
            // itemsTableAdapter2
            // 
            this.itemsTableAdapter2.ClearBeforeFill = true;
            // 
            // itemidDataGridViewTextBoxColumn
            // 
            this.itemidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemidDataGridViewTextBoxColumn.DataPropertyName = "itemid";
            this.itemidDataGridViewTextBoxColumn.HeaderText = "Item ID";
            this.itemidDataGridViewTextBoxColumn.Name = "itemidDataGridViewTextBoxColumn";
            this.itemidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemnameDataGridViewTextBoxColumn
            // 
            this.itemnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemnameDataGridViewTextBoxColumn.DataPropertyName = "itemname";
            this.itemnameDataGridViewTextBoxColumn.HeaderText = "Item Name";
            this.itemnameDataGridViewTextBoxColumn.Name = "itemnameDataGridViewTextBoxColumn";
            // 
            // updatepnl
            // 
            this.updatepnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updatepnl.Controls.Add(this.categorycombobox);
            this.updatepnl.Controls.Add(this.label2);
            this.updatepnl.Controls.Add(this.backbtn);
            this.updatepnl.Controls.Add(this.label1);
            this.updatepnl.Controls.Add(this.saveBtn);
            this.updatepnl.Controls.Add(this.nametxtbox);
            this.updatepnl.Location = new System.Drawing.Point(240, 92);
            this.updatepnl.Name = "updatepnl";
            this.updatepnl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.updatepnl.Size = new System.Drawing.Size(521, 457);
            this.updatepnl.TabIndex = 70;
            this.updatepnl.Visible = false;
            // 
            // categorycombobox
            // 
            this.categorycombobox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorycombobox.FormattingEnabled = true;
            this.categorycombobox.Items.AddRange(new object[] {
            "Bakery",
            "Beverage",
            "Dairy",
            "Grains",
            "Produce",
            "Snacks"});
            this.categorycombobox.Location = new System.Drawing.Point(320, 248);
            this.categorycombobox.Name = "categorycombobox";
            this.categorycombobox.Size = new System.Drawing.Size(150, 33);
            this.categorycombobox.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(482, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 30);
            this.label2.TabIndex = 72;
            this.label2.Text = "X";
            // 
            // backbtn
            // 
            this.backbtn.AutoSize = true;
            this.backbtn.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.backbtn.Location = new System.Drawing.Point(27, 22);
            this.backbtn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(36, 37);
            this.backbtn.TabIndex = 72;
            this.backbtn.Text = "<";
            this.backbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(144, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 47);
            this.label1.TabIndex = 70;
            this.label1.Text = "What to Add?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveBtn
            // 
            this.saveBtn.CheckButton = false;
            this.saveBtn.Checked = false;
            this.saveBtn.CheckedBackground = System.Drawing.Color.Gray;
            this.saveBtn.CheckedForeColor = System.Drawing.Color.White;
            this.saveBtn.CheckedImageTint = System.Drawing.Color.White;
            this.saveBtn.CheckedOutline = System.Drawing.Color.Gray;
            this.saveBtn.Content = "Save";
            this.saveBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.HoverBackground = System.Drawing.Color.Gray;
            this.saveBtn.HoveredImageTint = System.Drawing.Color.White;
            this.saveBtn.HoverForeColor = System.Drawing.Color.White;
            this.saveBtn.HoverOutline = System.Drawing.Color.Empty;
            this.saveBtn.Image = null;
            this.saveBtn.ImageAutoCenter = true;
            this.saveBtn.ImageExpand = new System.Drawing.Point(0, 0);
            this.saveBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.saveBtn.Location = new System.Drawing.Point(163, 389);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.saveBtn.NormalForeColor = System.Drawing.Color.White;
            this.saveBtn.NormalImageTint = System.Drawing.Color.White;
            this.saveBtn.NormalOutline = System.Drawing.Color.Empty;
            this.saveBtn.OutlineThickness = 1.6F;
            this.saveBtn.PressedBackground = System.Drawing.Color.Black;
            this.saveBtn.PressedForeColor = System.Drawing.Color.White;
            this.saveBtn.PressedImageTint = System.Drawing.Color.White;
            this.saveBtn.PressedOutline = System.Drawing.Color.Empty;
            this.saveBtn.Rounding = new System.Windows.Forms.Padding(10);
            this.saveBtn.Size = new System.Drawing.Size(192, 46);
            this.saveBtn.TabIndex = 12;
            this.saveBtn.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // nametxtbox
            // 
            this.nametxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nametxtbox.BackgroundColor = System.Drawing.Color.White;
            this.nametxtbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nametxtbox.BorderSize = 1;
            this.nametxtbox.Content = "";
            this.nametxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nametxtbox.FocusBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.nametxtbox.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nametxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametxtbox.ForeColor = System.Drawing.Color.Gray;
            this.nametxtbox.Location = new System.Drawing.Point(76, 236);
            this.nametxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.nametxtbox.Multiline = false;
            this.nametxtbox.Name = "nametxtbox";
            this.nametxtbox.Padding = new System.Windows.Forms.Padding(15, 15, 15, 0);
            this.nametxtbox.PasswordChar = false;
            this.nametxtbox.PlaceholderColor = System.Drawing.SystemColors.WindowFrame;
            this.nametxtbox.PlaceholderText = "ItemName";
            this.nametxtbox.Rounding = new System.Windows.Forms.Padding(8);
            this.nametxtbox.Size = new System.Drawing.Size(150, 45);
            this.nametxtbox.TabIndex = 1;
            this.nametxtbox.TextOffset = new System.Drawing.Size(0, 0);
            this.nametxtbox.UnderlinedStyle = false;
            // 
            // ItemsAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1000, 640);
            this.Controls.Add(this.updatepnl);
            this.Controls.Add(this.titleName);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.accActionPanel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.xBtn);
            this.Controls.Add(this.accBtn);
            this.Controls.Add(this.itemsDtaGrdVw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemsAdmin";
            this.Text = "ItemsAdmin";
            this.Load += new System.EventHandler(this.ItemsAdmin_Load);
            this.accActionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDtaGrdVw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grocerydbDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource2)).EndInit();
            this.updatepnl.ResumeLayout(false);
            this.updatepnl.PerformLayout();
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
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource itemsBindingSource1;
        private DataSet2TableAdapters.itemsTableAdapter itemsTableAdapter1;
        private CuoreUI.Controls.cuiButton addBtn;
        private System.Windows.Forms.Label titleName;
        private grocerydbDataSet3 grocerydbDataSet3;
        private System.Windows.Forms.BindingSource itemsBindingSource2;
        private grocerydbDataSet3TableAdapters.itemsTableAdapter itemsTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel updatepnl;
        private System.Windows.Forms.ComboBox categorycombobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label backbtn;
        private System.Windows.Forms.Label label1;
        private CuoreUI.Controls.cuiButton saveBtn;
        private CuoreUI.Controls.cuiTextBox2 nametxtbox;
    }
}