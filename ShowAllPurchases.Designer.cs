namespace Project_v2
{
    partial class ShowAllPurchases
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
            this.ShowPurchasesListView = new System.Windows.Forms.ListView();
            this.AllPurchasesLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowPurchasesListView
            // 
            this.ShowPurchasesListView.HideSelection = false;
            this.ShowPurchasesListView.Location = new System.Drawing.Point(12, 50);
            this.ShowPurchasesListView.Name = "ShowPurchasesListView";
            this.ShowPurchasesListView.Size = new System.Drawing.Size(582, 308);
            this.ShowPurchasesListView.TabIndex = 0;
            this.ShowPurchasesListView.UseCompatibleStateImageBehavior = false;
            // 
            // AllPurchasesLabel
            // 
            this.AllPurchasesLabel.AutoSize = true;
            this.AllPurchasesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllPurchasesLabel.Location = new System.Drawing.Point(187, 9);
            this.AllPurchasesLabel.Name = "AllPurchasesLabel";
            this.AllPurchasesLabel.Size = new System.Drawing.Size(122, 18);
            this.AllPurchasesLabel.TabIndex = 1;
            this.AllPurchasesLabel.Text = "All purchases for ";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(315, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(46, 18);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "label1";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(253, 373);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(69, 24);
            this.OKButton.TabIndex = 3;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ShowAllPurchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 409);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.AllPurchasesLabel);
            this.Controls.Add(this.ShowPurchasesListView);
            this.Name = "ShowAllPurchases";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowAllPurchases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ShowPurchasesListView;
        private System.Windows.Forms.Label AllPurchasesLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button OKButton;
    }
}