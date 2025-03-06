using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace GroceryAppWindowsForm
{
    public partial class MainForm : Form
    {
        public CartOrReceipt cartForm = new CartOrReceipt();
        public Receipt rec = new Receipt();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dairyCtrl.Hide();
            bakeryCtrl.Hide();
            snacksCtrl.Hide();
            bevCtrl.Hide();
            grainCtrl.Hide();
            prodCtrl.Hide();
        }

        private void snacksBtn_Click(object sender, EventArgs e)
        {
            HideAllUserControls();
            snacksCtrl.Show();
        }

        private void dairyBtn_Click(object sender, EventArgs e)
        {
            HideAllUserControls();
            dairyCtrl.Show();
        }

        private void bakeryBtn_Click(object sender, EventArgs e)
        {
            HideAllUserControls();
            bakeryCtrl.Show();
        }

        private void beveragesBtn_Click(object sender, EventArgs e)
        {
            HideAllUserControls();
            bevCtrl.Show();
        }

        private void grainsBtn_Click(object sender, EventArgs e)
        {
            HideAllUserControls();
            grainCtrl.Show();
        }

        private void produceBtn_Click(object sender, EventArgs e)
        {
            HideAllUserControls();
            prodCtrl.Show();
        }
        private void HideAllUserControls()
        {
            dairyCtrl.Hide();
            bakeryCtrl.Hide();
            snacksCtrl.Hide();
            bevCtrl.Hide();
            grainCtrl.Hide();
            prodCtrl.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bckLbl_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMnu = new MainMenuForm();
            mainMnu.Show();
            this.Close();
        }

        private void cartBtn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = this.FindForm() as MainForm;

            if (mainForm != null && mainForm.cartForm != null)
            {
                mainForm.cartForm.Show();
                this.Hide();
            }
        }

        private void bcktoHomeLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
