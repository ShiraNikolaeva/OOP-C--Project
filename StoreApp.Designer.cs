namespace Project_v2
{
    partial class StoreApp
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
            this.LogInButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.CreateAccountButton = new System.Windows.Forms.Button();
            this.ShowItemsButton = new System.Windows.Forms.Button();
            this.MakePurchaseButton = new System.Windows.Forms.Button();
            this.ShowBalanceButton = new System.Windows.Forms.Button();
            this.PayBalanceButton = new System.Windows.Forms.Button();
            this.ShowAllPurchasesButton = new System.Windows.Forms.Button();
            this.ShowPurchasesBetweenDatesButton = new System.Windows.Forms.Button();
            this.ShowPurchasesInTotalRangeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogInButton
            // 
            this.LogInButton.Location = new System.Drawing.Point(448, 12);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(83, 25);
            this.LogInButton.TabIndex = 0;
            this.LogInButton.Text = "Log in";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(448, 13);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(83, 26);
            this.LogOutButton.TabIndex = 6;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Visible = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // CreateAccountButton
            // 
            this.CreateAccountButton.Location = new System.Drawing.Point(350, 12);
            this.CreateAccountButton.Name = "CreateAccountButton";
            this.CreateAccountButton.Size = new System.Drawing.Size(92, 25);
            this.CreateAccountButton.TabIndex = 7;
            this.CreateAccountButton.Text = "Create Account";
            this.CreateAccountButton.UseVisualStyleBackColor = true;
            this.CreateAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click);
            // 
            // ShowItemsButton
            // 
            this.ShowItemsButton.Location = new System.Drawing.Point(10, 10);
            this.ShowItemsButton.Name = "ShowItemsButton";
            this.ShowItemsButton.Size = new System.Drawing.Size(86, 23);
            this.ShowItemsButton.TabIndex = 8;
            this.ShowItemsButton.Text = "Show Items";
            this.ShowItemsButton.UseVisualStyleBackColor = true;
            this.ShowItemsButton.Click += new System.EventHandler(this.ShowItemsButton_Click);
            // 
            // MakePurchaseButton
            // 
            this.MakePurchaseButton.Location = new System.Drawing.Point(102, 10);
            this.MakePurchaseButton.Name = "MakePurchaseButton";
            this.MakePurchaseButton.Size = new System.Drawing.Size(105, 23);
            this.MakePurchaseButton.TabIndex = 9;
            this.MakePurchaseButton.Text = "Make Purchase";
            this.MakePurchaseButton.UseVisualStyleBackColor = true;
            this.MakePurchaseButton.Visible = false;
            this.MakePurchaseButton.Click += new System.EventHandler(this.MakePurchaseButton_Click);
            // 
            // ShowBalanceButton
            // 
            this.ShowBalanceButton.Location = new System.Drawing.Point(350, 43);
            this.ShowBalanceButton.Name = "ShowBalanceButton";
            this.ShowBalanceButton.Size = new System.Drawing.Size(92, 42);
            this.ShowBalanceButton.TabIndex = 10;
            this.ShowBalanceButton.Text = "Show Balance";
            this.ShowBalanceButton.UseVisualStyleBackColor = true;
            this.ShowBalanceButton.Visible = false;
            this.ShowBalanceButton.Click += new System.EventHandler(this.ShowBalanceButton_Click);
            // 
            // PayBalanceButton
            // 
            this.PayBalanceButton.Location = new System.Drawing.Point(448, 45);
            this.PayBalanceButton.Name = "PayBalanceButton";
            this.PayBalanceButton.Size = new System.Drawing.Size(83, 40);
            this.PayBalanceButton.TabIndex = 11;
            this.PayBalanceButton.Text = "Pay Balance";
            this.PayBalanceButton.UseVisualStyleBackColor = true;
            this.PayBalanceButton.Visible = false;
            this.PayBalanceButton.Click += new System.EventHandler(this.PayBalanceButton_Click);
            // 
            // ShowAllPurchasesButton
            // 
            this.ShowAllPurchasesButton.Location = new System.Drawing.Point(10, 46);
            this.ShowAllPurchasesButton.Name = "ShowAllPurchasesButton";
            this.ShowAllPurchasesButton.Size = new System.Drawing.Size(83, 42);
            this.ShowAllPurchasesButton.TabIndex = 12;
            this.ShowAllPurchasesButton.Text = "Show All Purchases";
            this.ShowAllPurchasesButton.UseVisualStyleBackColor = true;
            this.ShowAllPurchasesButton.Visible = false;
            this.ShowAllPurchasesButton.Click += new System.EventHandler(this.ShowAllPurchasesButton_Click);
            // 
            // ShowPurchasesBetweenDatesButton
            // 
            this.ShowPurchasesBetweenDatesButton.Location = new System.Drawing.Point(99, 44);
            this.ShowPurchasesBetweenDatesButton.Name = "ShowPurchasesBetweenDatesButton";
            this.ShowPurchasesBetweenDatesButton.Size = new System.Drawing.Size(95, 44);
            this.ShowPurchasesBetweenDatesButton.TabIndex = 13;
            this.ShowPurchasesBetweenDatesButton.Text = "Show Purchases Between Dates";
            this.ShowPurchasesBetweenDatesButton.UseVisualStyleBackColor = true;
            this.ShowPurchasesBetweenDatesButton.Visible = false;
            this.ShowPurchasesBetweenDatesButton.Click += new System.EventHandler(this.ShowPurchasesBetweenDatesButton_Click);
            // 
            // ShowPurchasesInTotalRangeButton
            // 
            this.ShowPurchasesInTotalRangeButton.Location = new System.Drawing.Point(200, 45);
            this.ShowPurchasesInTotalRangeButton.Name = "ShowPurchasesInTotalRangeButton";
            this.ShowPurchasesInTotalRangeButton.Size = new System.Drawing.Size(100, 41);
            this.ShowPurchasesInTotalRangeButton.TabIndex = 14;
            this.ShowPurchasesInTotalRangeButton.Text = "Show Purchases In Totals Range";
            this.ShowPurchasesInTotalRangeButton.UseVisualStyleBackColor = true;
            this.ShowPurchasesInTotalRangeButton.Visible = false;
            this.ShowPurchasesInTotalRangeButton.Click += new System.EventHandler(this.ShowPurchasesInTotalRangeButton_Click);
            // 
            // StoreApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(543, 118);
            this.Controls.Add(this.ShowPurchasesInTotalRangeButton);
            this.Controls.Add(this.ShowPurchasesBetweenDatesButton);
            this.Controls.Add(this.ShowAllPurchasesButton);
            this.Controls.Add(this.PayBalanceButton);
            this.Controls.Add(this.ShowBalanceButton);
            this.Controls.Add(this.MakePurchaseButton);
            this.Controls.Add(this.ShowItemsButton);
            this.Controls.Add(this.CreateAccountButton);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.LogInButton);
            this.Name = "StoreApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StoreApp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button CreateAccountButton;
        private System.Windows.Forms.Button ShowItemsButton;
        private System.Windows.Forms.Button MakePurchaseButton;
        private System.Windows.Forms.Button ShowBalanceButton;
        private System.Windows.Forms.Button PayBalanceButton;
        private System.Windows.Forms.Button ShowAllPurchasesButton;
        private System.Windows.Forms.Button ShowPurchasesBetweenDatesButton;
        private System.Windows.Forms.Button ShowPurchasesInTotalRangeButton;
    }
}

