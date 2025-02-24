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
        private void dairyBtn_Click(object sender, EventArgs e)
        {
            dairyUsrCtrl.Show();
          //  bakeryUsrCtrl.Hide();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dairyUsrCtrl.Hide();
           // bakeryUsrCtrl.Hide();

        }

        private void bakeryBtn_Click(object sender, EventArgs e)
        {
            dairyUsrCtrl.Hide();
            //bakeryUsrCtrl.Show();
        }

        private void dairyUsrCtrl_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
