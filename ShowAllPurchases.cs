﻿using System;
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
    public partial class ShowAllPurchases : Form
    {
        public ShowAllPurchases()
        {
            InitializeComponent();
            SetUpColumns();
            AddItems();
            NameLabel.Text = Program.GetUsername();
        }

        private void AddItems()
        {
            foreach (Purchase p in Program.ShowAllPurchases())
            {
                string[] row = {p.Purchase_ID.ToString(),p.Item.Item_Description,p.Item.Price.ToString(),
                    p.Qty.ToString(), p.Total.ToString(),p.Purchase_Date.ToString()};
                ShowPurchasesListView.Items.Add(new ListViewItem(row));
            }
        }

        private void SetUpColumns()
        {
            ShowPurchasesListView.View = View.Details;
            ShowPurchasesListView.Columns.Add("Purchase ID", -2, HorizontalAlignment.Center);
            ShowPurchasesListView.Columns.Add("Item", -2, HorizontalAlignment.Center);
            ShowPurchasesListView.Columns.Add("Price per item", -2, HorizontalAlignment.Center);
            ShowPurchasesListView.Columns.Add("Qty", -2, HorizontalAlignment.Center);
            ShowPurchasesListView.Columns.Add("Total", -2, HorizontalAlignment.Center);
            ShowPurchasesListView.Columns.Add("Date", -2, HorizontalAlignment.Center);
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
