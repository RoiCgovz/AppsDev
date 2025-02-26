using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryAppWindowsForm
{
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bckLbl_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form existingMainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();

            if (existingMainForm != null)
            {
                existingMainForm.Show();
            }
            else
            {
                MainForm mn = new MainForm();
                mn.Show();
            }
        }
        public void AddToReceipt(string itemName, string itemQty)
        {
            if (int.TryParse(itemQty, out int newQty) && newQty > 0)
            {
                bool itemExists = false;

                for (int i = 0; i < receiptListBox.Items.Count; i++)
                {
                    string itemText = receiptListBox.Items[i].ToString();

                    if (itemText.StartsWith(itemName))
                    {
                        string[] parts = itemText.Split('-');
                        if (parts.Length == 2 && int.TryParse(parts[1].Trim(), out int existingQty))
                        {
                            int updatedQty = existingQty + newQty;
                            receiptListBox.Items[i] = $"{updatedQty} {"\t\t"} {itemName}";
                        }
                        itemExists = true;
                        break;
                    }
                }
                if (!itemExists)
                {
                    receiptListBox.Items.Add($"{newQty} {"\t\t"} {itemName}");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid quantity.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
