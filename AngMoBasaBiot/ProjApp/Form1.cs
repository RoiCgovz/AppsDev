namespace ProjApp
{
    public partial class MenuPage : Form
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            visMenu(true);
            visTitle(false);
        }

        private void BackB_Click(object sender, EventArgs e)
        {
            visTitle(true);
            visMenu(false);
            BackB.Visible = false;
        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        public void visTitle(bool bol)
        {
            if (bol)
                Tlable.Visible = MenuB.Visible = CheckB.Visible = ExitB.Visible = BackB.Visible = true;
            else
                Tlable.Visible = MenuB.Visible = CheckB.Visible = ExitB.Visible = false;
        }
        public void visMenu(bool bol)
        {
            if (bol)
                MenuList.Visible = CatL.Visible = FruitVegeB.Visible = MeatB.Visible = 
                FishB.Visible = BackB.Visible = inputHereL.Visible = inputTBox.Visible = 
                AddB.Visible = true;
            else
                MenuList.Visible = CatL.Visible = FruitVegeB.Visible = MeatB.Visible =
                 FishB.Visible = BackB.Visible = inputHereL.Visible = inputTBox.Visible =
                 AddB.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputHereL_Click(object sender, EventArgs e)
        {

        }
    }
}
