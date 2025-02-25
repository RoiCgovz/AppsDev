namespace GroceryCalculatorDiscountApp
{
    partial class MenuForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            SHOP = new Button();
            EXIT = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(251, -33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(422, 202);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // SHOP
            // 
            SHOP.Anchor = AnchorStyles.Bottom;
            SHOP.FlatAppearance.BorderColor = Color.Red;
            SHOP.FlatStyle = FlatStyle.Flat;
            SHOP.Font = new Font("Century", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SHOP.ForeColor = SystemColors.ControlText;
            SHOP.Location = new Point(387, 206);
            SHOP.Name = "SHOP";
            SHOP.Size = new Size(142, 45);
            SHOP.TabIndex = 1;
            SHOP.Text = "SHOP";
            SHOP.UseCompatibleTextRendering = true;
            SHOP.UseVisualStyleBackColor = true;
            SHOP.Click += SHOP_Click;
            SHOP.MouseLeave += SHOP_MouseLeave;
            SHOP.MouseHover += SHOP_MouseHover;
            // 
            // EXIT
            // 
            EXIT.Anchor = AnchorStyles.Bottom;
            EXIT.FlatAppearance.BorderColor = Color.Red;
            EXIT.FlatStyle = FlatStyle.Flat;
            EXIT.Font = new Font("Century", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EXIT.ForeColor = SystemColors.ControlText;
            EXIT.Location = new Point(387, 284);
            EXIT.Name = "EXIT";
            EXIT.Size = new Size(142, 45);
            EXIT.TabIndex = 1;
            EXIT.Text = "EXIT";
            EXIT.UseCompatibleTextRendering = true;
            EXIT.UseVisualStyleBackColor = true;
            EXIT.Click += EXIT_Click;
            EXIT.MouseLeave += EXIT_MouseLeave;
            EXIT.MouseMove += EXIT_MouseMove;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.a1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(917, 467);
            Controls.Add(EXIT);
            Controls.Add(SHOP);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuForm";
            Text = "Grocery Store";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ImageList imageList1;
        private PictureBox pictureBox1;
        private Button SHOP;
        private Button EXIT;
    }
}
