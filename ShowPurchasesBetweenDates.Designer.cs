namespace Project_v2
{
    partial class ShowPurchasesBetweenDates
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
            this.DateLabel = new System.Windows.Forms.Label();
            this.Date1Label = new System.Windows.Forms.Label();
            this.Date2Label = new System.Windows.Forms.Label();
            this.SignLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowPurchasesListView
            // 
            this.ShowPurchasesListView.HideSelection = false;
            this.ShowPurchasesListView.Location = new System.Drawing.Point(12, 62);
            this.ShowPurchasesListView.Name = "ShowPurchasesListView";
            this.ShowPurchasesListView.Size = new System.Drawing.Size(582, 306);
            this.ShowPurchasesListView.TabIndex = 0;
            this.ShowPurchasesListView.UseCompatibleStateImageBehavior = false;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(144, 20);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(109, 18);
            this.DateLabel.TabIndex = 3;
            this.DateLabel.Text = "Between dates ";
            // 
            // Date1Label
            // 
            this.Date1Label.AutoSize = true;
            this.Date1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date1Label.Location = new System.Drawing.Point(257, 20);
            this.Date1Label.Name = "Date1Label";
            this.Date1Label.Size = new System.Drawing.Size(46, 18);
            this.Date1Label.TabIndex = 4;
            this.Date1Label.Text = "label2";
            // 
            // Date2Label
            // 
            this.Date2Label.AutoSize = true;
            this.Date2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date2Label.Location = new System.Drawing.Point(366, 20);
            this.Date2Label.Name = "Date2Label";
            this.Date2Label.Size = new System.Drawing.Size(46, 18);
            this.Date2Label.TabIndex = 5;
            this.Date2Label.Text = "label2";
            // 
            // SignLabel
            // 
            this.SignLabel.AutoSize = true;
            this.SignLabel.Location = new System.Drawing.Point(350, 24);
            this.SignLabel.Name = "SignLabel";
            this.SignLabel.Size = new System.Drawing.Size(10, 13);
            this.SignLabel.TabIndex = 6;
            this.SignLabel.Text = ":";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(258, 374);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(78, 23);
            this.OKButton.TabIndex = 7;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ShowPurchasesBetweenDates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 409);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.SignLabel);
            this.Controls.Add(this.Date2Label);
            this.Controls.Add(this.Date1Label);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.ShowPurchasesListView);
            this.Name = "ShowPurchasesBetweenDates";
            this.Text = "ShowPurchasesBetweenDates";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ShowPurchasesListView;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label Date1Label;
        private System.Windows.Forms.Label Date2Label;
        private System.Windows.Forms.Label SignLabel;
        private System.Windows.Forms.Button OKButton;
    }
}