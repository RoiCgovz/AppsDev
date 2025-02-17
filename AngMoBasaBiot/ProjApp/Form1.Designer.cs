namespace ProjApp
{
    partial class MenuPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Tlable = new Label();
            MenuB = new Button();
            CheckB = new Button();
            ExitB = new Button();
            BackB = new Button();
            MenuList = new ListBox();
            FruitVegeB = new Button();
            MeatB = new Button();
            FishB = new Button();
            CatL = new Label();
            AddB = new Button();
            inputTBox = new TextBox();
            inputHereL = new Label();
            SuspendLayout();
            // 
            // Tlable
            // 
            Tlable.AutoSize = true;
            Tlable.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Tlable.Location = new Point(452, 109);
            Tlable.Name = "Tlable";
            Tlable.Size = new Size(222, 50);
            Tlable.TabIndex = 0;
            Tlable.Text = "Grocery Shit";
            Tlable.Click += label1_Click;
            // 
            // MenuB
            // 
            MenuB.Location = new Point(474, 222);
            MenuB.Name = "MenuB";
            MenuB.Size = new Size(200, 58);
            MenuB.TabIndex = 1;
            MenuB.Text = "Menu";
            MenuB.UseVisualStyleBackColor = true;
            MenuB.Click += button1_Click;
            // 
            // CheckB
            // 
            CheckB.Location = new Point(474, 297);
            CheckB.Name = "CheckB";
            CheckB.Size = new Size(200, 58);
            CheckB.TabIndex = 2;
            CheckB.Text = "Check";
            CheckB.UseVisualStyleBackColor = true;
            CheckB.Click += button2_Click;
            // 
            // ExitB
            // 
            ExitB.Location = new Point(474, 376);
            ExitB.Name = "ExitB";
            ExitB.Size = new Size(200, 58);
            ExitB.TabIndex = 3;
            ExitB.Text = "Exit";
            ExitB.UseVisualStyleBackColor = true;
            ExitB.Click += button3_Click;
            // 
            // BackB
            // 
            BackB.Location = new Point(946, 582);
            BackB.Name = "BackB";
            BackB.Size = new Size(151, 50);
            BackB.TabIndex = 4;
            BackB.Text = "Back";
            BackB.UseVisualStyleBackColor = true;
            BackB.Visible = false;
            BackB.Click += BackB_Click;
            // 
            // MenuList
            // 
            MenuList.BackColor = SystemColors.InfoText;
            MenuList.FormattingEnabled = true;
            MenuList.Location = new Point(4, 12);
            MenuList.Name = "MenuList";
            MenuList.Size = new Size(903, 634);
            MenuList.TabIndex = 5;
            MenuList.UseWaitCursor = true;
            MenuList.Visible = false;
            // 
            // FruitVegeB
            // 
            FruitVegeB.Location = new Point(965, 85);
            FruitVegeB.Name = "FruitVegeB";
            FruitVegeB.Size = new Size(121, 34);
            FruitVegeB.TabIndex = 6;
            FruitVegeB.Text = "Fruits/Vegetables";
            FruitVegeB.UseVisualStyleBackColor = true;
            FruitVegeB.Visible = false;
            // 
            // MeatB
            // 
            MeatB.Location = new Point(965, 137);
            MeatB.Name = "MeatB";
            MeatB.Size = new Size(121, 34);
            MeatB.TabIndex = 7;
            MeatB.Text = "Meat";
            MeatB.UseVisualStyleBackColor = true;
            MeatB.Visible = false;
            // 
            // FishB
            // 
            FishB.Location = new Point(965, 190);
            FishB.Name = "FishB";
            FishB.Size = new Size(121, 34);
            FishB.TabIndex = 8;
            FishB.Text = "Fish";
            FishB.UseVisualStyleBackColor = true;
            FishB.Visible = false;
            // 
            // CatL
            // 
            CatL.AutoSize = true;
            CatL.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CatL.Location = new Point(935, 23);
            CatL.Name = "CatL";
            CatL.Size = new Size(185, 47);
            CatL.TabIndex = 9;
            CatL.Text = "Categories";
            CatL.Visible = false;
            CatL.Click += label1_Click_1;
            // 
            // AddB
            // 
            AddB.Location = new Point(935, 407);
            AddB.Name = "AddB";
            AddB.Size = new Size(176, 48);
            AddB.TabIndex = 10;
            AddB.Text = "Add";
            AddB.UseVisualStyleBackColor = true;
            AddB.Visible = false;
            AddB.Click += button1_Click_1;
            // 
            // inputTBox
            // 
            inputTBox.Location = new Point(992, 340);
            inputTBox.Multiline = true;
            inputTBox.Name = "inputTBox";
            inputTBox.Size = new Size(51, 38);
            inputTBox.TabIndex = 11;
            inputTBox.Visible = false;
            inputTBox.TextChanged += textBox1_TextChanged;
            // 
            // inputHereL
            // 
            inputHereL.AutoSize = true;
            inputHereL.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inputHereL.Location = new Point(928, 286);
            inputHereL.Name = "inputHereL";
            inputHereL.Size = new Size(192, 40);
            inputHereL.TabIndex = 12;
            inputHereL.Text = "Input a designated number \r\nhere to be add to the cart\r\n";
            inputHereL.Visible = false;
            inputHereL.Click += inputHereL_Click;
            // 
            // MenuPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1132, 653);
            Controls.Add(inputHereL);
            Controls.Add(inputTBox);
            Controls.Add(AddB);
            Controls.Add(CatL);
            Controls.Add(FishB);
            Controls.Add(MeatB);
            Controls.Add(FruitVegeB);
            Controls.Add(BackB);
            Controls.Add(ExitB);
            Controls.Add(CheckB);
            Controls.Add(MenuB);
            Controls.Add(Tlable);
            Controls.Add(MenuList);
            Name = "MenuPage";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Tlable;
        private Button MenuB;
        private Button CheckB;
        private Button ExitB;
        private Button BackB;
        private ListBox MenuList;
        private Button FruitVegeB;
        private Button MeatB;
        private Button FishB;
        private Label CatL;
        private Button AddB;
        private TextBox inputTBox;
        private Label inputHereL;
    }
}
