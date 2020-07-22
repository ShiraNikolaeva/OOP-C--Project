using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_v2
{
    public partial class MakePurchase : Form
    {
        public MakePurchase()
        {
            InitializeComponent();
            BalanceLabel.Text = Program.GetBalance().ToString();
            SetUpColumns();
            AddItems();
        }
        private void SetUpColumns()
        {
            ShowItemsListView.View = View.Details;
            ShowItemsListView.Columns.Add("ID", -2, HorizontalAlignment.Center);
            ShowItemsListView.Columns.Add("Name", -2, HorizontalAlignment.Center);
            ShowItemsListView.Columns.Add("Price", -2, HorizontalAlignment.Center);
            ShowItemsListView.Columns.Add("Qty", -2, HorizontalAlignment.Center);
        }

        private void AddItems()
        {
            foreach (Item item in Program.ShowItems())
            {
                string[] row =
                    {item.ID.ToString(), item.Item_Description, item.Price.ToString(), item.Qty_on_hand.ToString()};
                ShowItemsListView.Items.Add(new ListViewItem(row));
            }
        }

        private void MakePurchaseButton_Click(object sender, EventArgs e)
        {
            int itemID=Int32.Parse(ItemIDTextBox.Text);
            int qty=Int32.Parse(QTYTextBox.Text);
            string errorMsg;
            if (qty < 0)
            {
                ShowError("Qty cannon be less than 0.");
            }

            if (Program.MakePurchase(itemID, qty))
            {
                Item item = Program.FindItem(itemID);
                Form receipt = new Receipt(DateTime.Now, item.Item_Description,
                    (double) item.Price, qty, (double) item.Price * qty);
                receipt.Show();
                this.Close();
            }
            else
            {
                ShowError("Something went wrong.. Try again.");
            }
        }

        private void ShowError(string msg)
        {
            Form error = new Error(msg);
            error.Show();
            Form newTry = new MakePurchase();
            newTry.Show();
            this.Close();
        }
    }
}
