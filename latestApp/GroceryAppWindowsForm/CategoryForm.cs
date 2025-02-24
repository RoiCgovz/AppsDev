using System;
using System.Windows.Forms;

namespace GroceryAppWindowsForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            /*dairyUserControl1.Hide();
            bakeryCtrl.Hide();
            snacksCtrl.Hide();
            bevCtrl.Hide();*/
        }
        private void snacksBtn_Click(object sender, EventArgs e)
        {
            /*dairyUserControl1.Hide();
            snacksCtrl.Show();
            bakeryCtrl.Hide();
            bevCtrl.Hide();*/
        }
        private void dairyBtn_Click(object sender, EventArgs e)
        {
            /*dairyUserControl1.Show();
            bakeryCtrl.Hide();
            snacksCtrl.Hide();
            bevCtrl.Hide();*/
        }
        private void bakeryBtn_Click(object sender, EventArgs e)
        {
            /*dairyUserControl1.Hide();
            bakeryCtrl.Show();
            snacksCtrl.Hide();
            bevCtrl.Hide();*/
        }

        private void dairyUsrCtrl_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void beveragesBtn_Click(object sender, EventArgs e)
        {
            /*dairyUserControl1.Hide();
            bakeryCtrl.Hide();
            snacksCtrl.Hide();
            bevCtrl.Show();*/
        }
    }
}
