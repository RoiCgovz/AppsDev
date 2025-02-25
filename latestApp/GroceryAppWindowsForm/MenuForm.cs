namespace GroceryCalculatorDiscountApp
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void SHOP_Click(object sender, EventArgs e)//SHOP BUTTON
        {

        }
        private void SHOP_MouseLeave(object sender, EventArgs e)
        {
            SHOP.BackColor = Color.White;
        }
        private void SHOP_MouseHover(object sender, EventArgs e)
        {
            SHOP.BackColor = Color.Red;
        }

        private void EXIT_Click(object sender, EventArgs e)//EXIT BUTTON
        {
            Application.Exit();
        }

        private void EXIT_MouseMove(object sender, MouseEventArgs e)
        {
            EXIT.BackColor = Color.Red;
        }

        private void EXIT_MouseLeave(object sender, EventArgs e)
        {
            EXIT.BackColor = Color.White;
        }
    }
}
