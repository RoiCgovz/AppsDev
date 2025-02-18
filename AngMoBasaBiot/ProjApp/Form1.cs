namespace ProjApp
{
    public partial class MenuPage : Form
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        // Helper Function to go back to the main menu
        public void visTitle(bool bol)
        {
            if (bol)
                Tlable.Visible = MenuB.Visible = CheckB.Visible = ExitB.Visible = BackB.Visible = true;
            else
                Tlable.Visible = MenuB.Visible = CheckB.Visible = ExitB.Visible = false;
        }

        // Helper function to view the Menu
        public void visMenu(bool bol)
        {
            if (bol)
                prodtotal.Visible = totalLBL.Visible = selectprodLBL.Visible = prodLBL.Visible = categoryPnl.Visible = CatL.Visible = dairyBTN.Visible = FruitVegeB.Visible = MeatandFishB.Visible = grainsBtn.Visible =
                BackB.Visible = inputHereL.Visible = inputTBox.Visible = AddB.Visible = beverageBTN.Visible = snacksbtn.Visible = true;
            else
                prodtotal.Visible = totalLBL.Visible = selectprodLBL.Visible = prodLBL.Visible = categoryPnl.Visible = CatL.Visible = dairyBTN.Visible = FruitVegeB.Visible = MeatandFishB.Visible = grainsBtn.Visible =
                BackB.Visible = inputHereL.Visible = inputTBox.Visible = AddB.Visible = beverageBTN.Visible = snacksbtn.Visible = false;
        }

        // Exit Button in Title Page
        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        // Check Cart Button
        private void button2_Click(object sender, EventArgs e)
        {

        }
        // Menu Button
        private void button1_Click(object sender, EventArgs e)
        {
            visMenu(true);
            visTitle(false);
        }

        // Back Button
        private void BackB_Click(object sender, EventArgs e)
        {
            visTitle(true);
            visMenu(false);
            BackB.Visible = false;
            FruitsPNL.Visible = false;
        }

        //Fruits and vege Button
        private void FruitVegeB_Click(object sender, EventArgs e)
        {
            visMenu(true);
            FruitsPNL.Visible = true;
            meatPnl.Visible = false;
        }

        private void MeatandFishB_Click(object sender, EventArgs e)
        {
            visMenu(true);
            meatPnl.Visible = true;
            FruitsPNL.Visible = false;
        }

        private void breastLBL_Click(object sender, EventArgs e)
        {
            selectprodLBL.Text = breastLBL.Text;

        }
    }
}
