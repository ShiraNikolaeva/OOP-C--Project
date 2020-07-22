using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_v2
{
    public partial class ShowItems : Form
    {
        public ShowItems()
        {
            InitializeComponent();
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

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
