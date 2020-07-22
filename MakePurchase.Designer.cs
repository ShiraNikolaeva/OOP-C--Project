namespace Project_v2
{
    partial class MakePurchase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AvailableBalanceLabel = new System.Windows.Forms.Label();
            this.ChooseYourItemLabel = new System.Windows.Forms.Label();
            this.ShowItemsListView = new System.Windows.Forms.ListView();
            this.Note = new System.Windows.Forms.Label();
            this.ItemIdLabel = new System.Windows.Forms.Label();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.QtyLabel = new System.Windows.Forms.Label();
            this.ItemIDTextBox = new System.Windows.Forms.TextBox();
            this.QTYTextBox = new System.Windows.Forms.TextBox();
            this.MakePurchaseButton = new System.Windows.Forms.Button();
            this.SignLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AvailableBalanceLabel
            // 
            this.AvailableBalanceLabel.AutoSize = true;
            this.AvailableBalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableBalanceLabel.Location = new System.Drawing.Point(477, 49);
            this.AvailableBalanceLabel.Name = "AvailableBalanceLabel";
            this.AvailableBalanceLabel.Size = new System.Drawing.Size(111, 20);
            this.AvailableBalanceLabel.TabIndex = 1;
            this.AvailableBalanceLabel.Text = "Your balance: ";
            // 
            // ChooseYourItemLabel
            // 
            this.ChooseYourItemLabel.AutoSize = true;
            this.ChooseYourItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseYourItemLabel.Location = new System.Drawing.Point(64, 13);
            this.ChooseYourItemLabel.Name = "ChooseYourItemLabel";
            this.ChooseYourItemLabel.Size = new System.Drawing.Size(289, 22);
            this.ChooseYourItemLabel.TabIndex = 2;
            this.ChooseYourItemLabel.Text = "Choose the item from the list below";
            // 
            // ShowItemsListView
            // 
            this.ShowItemsListView.HideSelection = false;
            this.ShowItemsListView.Location = new System.Drawing.Point(12, 49);
            this.ShowItemsListView.Name = "ShowItemsListView";
            this.ShowItemsListView.Size = new System.Drawing.Size(365, 297);
            this.ShowItemsListView.TabIndex = 3;
            this.ShowItemsListView.UseCompatibleStateImageBehavior = false;
            // 
            // Note
            // 
            this.Note.AutoSize = true;
            this.Note.Location = new System.Drawing.Point(407, 81);
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(406, 13);
            this.Note.TabIndex = 4;
            this.Note.Text = "Note: purchase will not be made if it will result in your balance dropping below " +
    "$-1000";
            // 
            // ItemIdLabel
            // 
            this.ItemIdLabel.AutoSize = true;
            this.ItemIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemIdLabel.Location = new System.Drawing.Point(478, 160);
            this.ItemIdLabel.Name = "ItemIdLabel";
            this.ItemIdLabel.Size = new System.Drawing.Size(54, 18);
            this.ItemIdLabel.TabIndex = 5;
            this.ItemIdLabel.Text = "Item ID";
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceLabel.Location = new System.Drawing.Point(606, 49);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(51, 20);
            this.BalanceLabel.TabIndex = 6;
            this.BalanceLabel.Text = "label1";
            // 
            // QtyLabel
            // 
            this.QtyLabel.AutoSize = true;
            this.QtyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtyLabel.Location = new System.Drawing.Point(478, 218);
            this.QtyLabel.Name = "QtyLabel";
            this.QtyLabel.Size = new System.Drawing.Size(38, 18);
            this.QtyLabel.TabIndex = 7;
            this.QtyLabel.Text = "QTY";
            // 
            // ItemIDTextBox
            // 
            this.ItemIDTextBox.Location = new System.Drawing.Point(610, 160);
            this.ItemIDTextBox.Name = "ItemIDTextBox";
            this.ItemIDTextBox.Size = new System.Drawing.Size(60, 20);
            this.ItemIDTextBox.TabIndex = 8;
            // 
            // QTYTextBox
            // 
            this.QTYTextBox.Location = new System.Drawing.Point(610, 216);
            this.QTYTextBox.Name = "QTYTextBox";
            this.QTYTextBox.Size = new System.Drawing.Size(60, 20);
            this.QTYTextBox.TabIndex = 9;
            // 
            // MakePurchaseButton
            // 
            this.MakePurchaseButton.Location = new System.Drawing.Point(550, 295);
            this.MakePurchaseButton.Name = "MakePurchaseButton";
            this.MakePurchaseButton.Size = new System.Drawing.Size(60, 30);
            this.MakePurchaseButton.TabIndex = 10;
            this.MakePurchaseButton.Text = "Purchase";
            this.MakePurchaseButton.UseVisualStyleBackColor = true;
            this.MakePurchaseButton.Click += new System.EventHandler(this.MakePurchaseButton_Click);
            // 
            // SignLabel
            // 
            this.SignLabel.AutoSize = true;
            this.SignLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignLabel.Location = new System.Drawing.Point(594, 49);
            this.SignLabel.Name = "SignLabel";
            this.SignLabel.Size = new System.Drawing.Size(16, 18);
            this.SignLabel.TabIndex = 11;
            this.SignLabel.Text = "$";
            // 
            // MakePurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 369);
            this.Controls.Add(this.SignLabel);
            this.Controls.Add(this.MakePurchaseButton);
            this.Controls.Add(this.QTYTextBox);
            this.Controls.Add(this.ItemIDTextBox);
            this.Controls.Add(this.QtyLabel);
            this.Controls.Add(this.BalanceLabel);
            this.Controls.Add(this.ItemIdLabel);
            this.Controls.Add(this.Note);
            this.Controls.Add(this.ShowItemsListView);
            this.Controls.Add(this.ChooseYourItemLabel);
            this.Controls.Add(this.AvailableBalanceLabel);
            this.Name = "MakePurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MakePurchase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AvailableBalanceLabel;
        private System.Windows.Forms.Label ChooseYourItemLabel;
        private System.Windows.Forms.ListView ShowItemsListView;
        private System.Windows.Forms.Label Note;
        private System.Windows.Forms.Label ItemIdLabel;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.Label QtyLabel;
        private System.Windows.Forms.TextBox ItemIDTextBox;
        private System.Windows.Forms.TextBox QTYTextBox;
        private System.Windows.Forms.Button MakePurchaseButton;
        private System.Windows.Forms.Label SignLabel;
    }
}