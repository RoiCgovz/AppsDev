﻿namespace GroceryAppWindowsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.cartBtn = new System.Windows.Forms.Label();
            this.bcktoHomeLbl = new System.Windows.Forms.Label();
            this.bckLbl = new System.Windows.Forms.Label();
            this.categoryPnl = new System.Windows.Forms.Panel();
            this.produceBtn = new System.Windows.Forms.Button();
            this.beveragesBtn = new System.Windows.Forms.Button();
            this.grainsBtn = new System.Windows.Forms.Button();
            this.snacksBtn = new System.Windows.Forms.Button();
            this.bakeryBtn = new System.Windows.Forms.Button();
            this.dairyBtn = new System.Windows.Forms.Button();
            this.snacksCtrl = new GroceryAppWindowsForm.Snacks();
            this.prodCtrl = new GroceryAppWindowsForm.Produce();
            this.grainCtrl = new GroceryAppWindowsForm.Grains();
            this.dairyCtrl = new GroceryAppWindowsForm.dairyUserControl();
            this.bevCtrl = new GroceryAppWindowsForm.Beverage();
            this.bakeryCtrl = new GroceryAppWindowsForm.bakeryUserControl();
            this.panel1.SuspendLayout();
            this.categoryPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(97)))), ((int)(((byte)(190)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.cartBtn);
            this.panel1.Controls.Add(this.bcktoHomeLbl);
            this.panel1.Controls.Add(this.bckLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 71);
            this.panel1.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.White;
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.Location = new System.Drawing.Point(863, 9);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(32, 33);
            this.closeButton.TabIndex = 3;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // cartBtn
            // 
            this.cartBtn.AutoSize = true;
            this.cartBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.cartBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartBtn.ForeColor = System.Drawing.Color.White;
            this.cartBtn.Location = new System.Drawing.Point(450, 0);
            this.cartBtn.Name = "cartBtn";
            this.cartBtn.Padding = new System.Windows.Forms.Padding(40, 20, 0, 0);
            this.cartBtn.Size = new System.Drawing.Size(94, 50);
            this.cartBtn.TabIndex = 2;
            this.cartBtn.Text = "Cart";
            this.cartBtn.Click += new System.EventHandler(this.cartBtn_Click);
            // 
            // bcktoHomeLbl
            // 
            this.bcktoHomeLbl.AutoSize = true;
            this.bcktoHomeLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.bcktoHomeLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcktoHomeLbl.ForeColor = System.Drawing.Color.White;
            this.bcktoHomeLbl.Location = new System.Drawing.Point(58, 0);
            this.bcktoHomeLbl.Name = "bcktoHomeLbl";
            this.bcktoHomeLbl.Padding = new System.Windows.Forms.Padding(320, 20, 0, 0);
            this.bcktoHomeLbl.Size = new System.Drawing.Size(392, 50);
            this.bcktoHomeLbl.TabIndex = 1;
            this.bcktoHomeLbl.Text = "Home";
            this.bcktoHomeLbl.Click += new System.EventHandler(this.bcktoHomeLbl_Click);
            // 
            // bckLbl
            // 
            this.bckLbl.AutoSize = true;
            this.bckLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.bckLbl.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bckLbl.ForeColor = System.Drawing.Color.White;
            this.bckLbl.Location = new System.Drawing.Point(0, 0);
            this.bckLbl.Name = "bckLbl";
            this.bckLbl.Padding = new System.Windows.Forms.Padding(20, 13, 0, 0);
            this.bckLbl.Size = new System.Drawing.Size(58, 53);
            this.bckLbl.TabIndex = 0;
            this.bckLbl.Text = "<";
            this.bckLbl.Click += new System.EventHandler(this.bckLbl_Click);
            // 
            // categoryPnl
            // 
            this.categoryPnl.AutoScroll = true;
            this.categoryPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(97)))), ((int)(((byte)(190)))));
            this.categoryPnl.Controls.Add(this.produceBtn);
            this.categoryPnl.Controls.Add(this.beveragesBtn);
            this.categoryPnl.Controls.Add(this.grainsBtn);
            this.categoryPnl.Controls.Add(this.snacksBtn);
            this.categoryPnl.Controls.Add(this.bakeryBtn);
            this.categoryPnl.Controls.Add(this.dairyBtn);
            this.categoryPnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.categoryPnl.Location = new System.Drawing.Point(0, 71);
            this.categoryPnl.Name = "categoryPnl";
            this.categoryPnl.Size = new System.Drawing.Size(270, 483);
            this.categoryPnl.TabIndex = 1;
            // 
            // produceBtn
            // 
            this.produceBtn.BackColor = System.Drawing.Color.Transparent;
            this.produceBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.produceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.produceBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produceBtn.ForeColor = System.Drawing.Color.White;
            this.produceBtn.Image = global::GroceryAppWindowsForm.Properties.Resources.prod;
            this.produceBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.produceBtn.Location = new System.Drawing.Point(0, 580);
            this.produceBtn.Name = "produceBtn";
            this.produceBtn.Size = new System.Drawing.Size(253, 113);
            this.produceBtn.TabIndex = 10;
            this.produceBtn.Text = "Produce";
            this.produceBtn.UseVisualStyleBackColor = false;
            this.produceBtn.Click += new System.EventHandler(this.produceBtn_Click);
            // 
            // beveragesBtn
            // 
            this.beveragesBtn.BackColor = System.Drawing.Color.Transparent;
            this.beveragesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.beveragesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beveragesBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beveragesBtn.ForeColor = System.Drawing.Color.White;
            this.beveragesBtn.Image = global::GroceryAppWindowsForm.Properties.Resources.bev;
            this.beveragesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.beveragesBtn.Location = new System.Drawing.Point(0, 467);
            this.beveragesBtn.Name = "beveragesBtn";
            this.beveragesBtn.Size = new System.Drawing.Size(253, 113);
            this.beveragesBtn.TabIndex = 8;
            this.beveragesBtn.Text = "Beverages";
            this.beveragesBtn.UseVisualStyleBackColor = false;
            this.beveragesBtn.Click += new System.EventHandler(this.beveragesBtn_Click);
            // 
            // grainsBtn
            // 
            this.grainsBtn.BackColor = System.Drawing.Color.Transparent;
            this.grainsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.grainsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grainsBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grainsBtn.ForeColor = System.Drawing.Color.White;
            this.grainsBtn.Image = global::GroceryAppWindowsForm.Properties.Resources.images1;
            this.grainsBtn.Location = new System.Drawing.Point(0, 348);
            this.grainsBtn.Name = "grainsBtn";
            this.grainsBtn.Size = new System.Drawing.Size(253, 119);
            this.grainsBtn.TabIndex = 9;
            this.grainsBtn.Text = "Grains";
            this.grainsBtn.UseVisualStyleBackColor = false;
            this.grainsBtn.Click += new System.EventHandler(this.grainsBtn_Click);
            // 
            // snacksBtn
            // 
            this.snacksBtn.BackColor = System.Drawing.Color.Transparent;
            this.snacksBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.snacksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.snacksBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snacksBtn.ForeColor = System.Drawing.Color.White;
            this.snacksBtn.Image = global::GroceryAppWindowsForm.Properties.Resources.snacks;
            this.snacksBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.snacksBtn.Location = new System.Drawing.Point(0, 229);
            this.snacksBtn.Name = "snacksBtn";
            this.snacksBtn.Size = new System.Drawing.Size(253, 119);
            this.snacksBtn.TabIndex = 6;
            this.snacksBtn.Text = "Snacks";
            this.snacksBtn.UseVisualStyleBackColor = false;
            this.snacksBtn.Click += new System.EventHandler(this.snacksBtn_Click);
            // 
            // bakeryBtn
            // 
            this.bakeryBtn.BackColor = System.Drawing.Color.Transparent;
            this.bakeryBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.bakeryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bakeryBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bakeryBtn.ForeColor = System.Drawing.Color.White;
            this.bakeryBtn.Image = global::GroceryAppWindowsForm.Properties.Resources.istockphoto_518468635_612x612;
            this.bakeryBtn.Location = new System.Drawing.Point(0, 119);
            this.bakeryBtn.Name = "bakeryBtn";
            this.bakeryBtn.Size = new System.Drawing.Size(253, 110);
            this.bakeryBtn.TabIndex = 5;
            this.bakeryBtn.Text = "Bakery";
            this.bakeryBtn.UseVisualStyleBackColor = false;
            this.bakeryBtn.Click += new System.EventHandler(this.bakeryBtn_Click);
            // 
            // dairyBtn
            // 
            this.dairyBtn.BackColor = System.Drawing.Color.Transparent;
            this.dairyBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dairyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dairyBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dairyBtn.ForeColor = System.Drawing.Color.White;
            this.dairyBtn.Image = global::GroceryAppWindowsForm.Properties.Resources.pastry_bakery_making_process_with_ingredients_114579_15238;
            this.dairyBtn.Location = new System.Drawing.Point(0, 0);
            this.dairyBtn.Name = "dairyBtn";
            this.dairyBtn.Size = new System.Drawing.Size(253, 119);
            this.dairyBtn.TabIndex = 4;
            this.dairyBtn.Text = "Dairy";
            this.dairyBtn.UseVisualStyleBackColor = false;
            this.dairyBtn.Click += new System.EventHandler(this.dairyBtn_Click);
            // 
            // snacksCtrl
            // 
            this.snacksCtrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(97)))), ((int)(((byte)(190)))));
            this.snacksCtrl.Location = new System.Drawing.Point(293, 109);
            this.snacksCtrl.Name = "snacksCtrl";
            this.snacksCtrl.Size = new System.Drawing.Size(589, 394);
            this.snacksCtrl.TabIndex = 7;
            // 
            // prodCtrl
            // 
            this.prodCtrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(97)))), ((int)(((byte)(194)))));
            this.prodCtrl.Location = new System.Drawing.Point(293, 109);
            this.prodCtrl.Name = "prodCtrl";
            this.prodCtrl.Size = new System.Drawing.Size(589, 363);
            this.prodCtrl.TabIndex = 6;
            // 
            // grainCtrl
            // 
            this.grainCtrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(97)))), ((int)(((byte)(194)))));
            this.grainCtrl.Location = new System.Drawing.Point(293, 109);
            this.grainCtrl.Name = "grainCtrl";
            this.grainCtrl.Size = new System.Drawing.Size(594, 401);
            this.grainCtrl.TabIndex = 5;
            // 
            // dairyCtrl
            // 
            this.dairyCtrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(97)))), ((int)(((byte)(190)))));
            this.dairyCtrl.Location = new System.Drawing.Point(293, 109);
            this.dairyCtrl.Name = "dairyCtrl";
            this.dairyCtrl.Size = new System.Drawing.Size(594, 388);
            this.dairyCtrl.TabIndex = 4;
            // 
            // bevCtrl
            // 
            this.bevCtrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(97)))), ((int)(((byte)(190)))));
            this.bevCtrl.Location = new System.Drawing.Point(293, 109);
            this.bevCtrl.Name = "bevCtrl";
            this.bevCtrl.Size = new System.Drawing.Size(595, 413);
            this.bevCtrl.TabIndex = 3;
            // 
            // bakeryCtrl
            // 
            this.bakeryCtrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(97)))), ((int)(((byte)(190)))));
            this.bakeryCtrl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bakeryCtrl.Location = new System.Drawing.Point(293, 109);
            this.bakeryCtrl.Name = "bakeryCtrl";
            this.bakeryCtrl.Size = new System.Drawing.Size(594, 401);
            this.bakeryCtrl.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(902, 554);
            this.Controls.Add(this.snacksCtrl);
            this.Controls.Add(this.prodCtrl);
            this.Controls.Add(this.grainCtrl);
            this.Controls.Add(this.dairyCtrl);
            this.Controls.Add(this.bevCtrl);
            this.Controls.Add(this.bakeryCtrl);
            this.Controls.Add(this.categoryPnl);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.categoryPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button snacksBtn;
        private System.Windows.Forms.Button bakeryBtn;
        private System.Windows.Forms.Button dairyBtn;
        private System.Windows.Forms.Button beveragesBtn;
        private System.Windows.Forms.Button grainsBtn;
        private System.Windows.Forms.Panel categoryPnl;
        private System.Windows.Forms.Button produceBtn;
        private System.Windows.Forms.Label cartBtn;
        private System.Windows.Forms.Label bckLbl;

       // private bakeryUserControl bakeryUsrCtrl;

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label bcktoHomeLbl;
        private bakeryUserControl bakeryCtrl;
        private Beverage bevCtrl;
        private dairyUserControl dairyCtrl;
        private Grains grainCtrl;
        private Produce prodCtrl;
        private Snacks snacksCtrl;
    }
}

