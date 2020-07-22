namespace Project_v2
{
    partial class PayBalance
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
            this.CurrentBalanceLabel = new System.Windows.Forms.Label();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.PayButton = new System.Windows.Forms.Button();
            this.Sign1Label = new System.Windows.Forms.Label();
            this.Sign2Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CurrentBalanceLabel
            // 
            this.CurrentBalanceLabel.AutoSize = true;
            this.CurrentBalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentBalanceLabel.Location = new System.Drawing.Point(21, 44);
            this.CurrentBalanceLabel.Name = "CurrentBalanceLabel";
            this.CurrentBalanceLabel.Size = new System.Drawing.Size(118, 18);
            this.CurrentBalanceLabel.TabIndex = 0;
            this.CurrentBalanceLabel.Text = "Current Balance:";
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceLabel.Location = new System.Drawing.Point(171, 44);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(46, 18);
            this.BalanceLabel.TabIndex = 1;
            this.BalanceLabel.Text = "label1";
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLabel.Location = new System.Drawing.Point(32, 98);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(107, 18);
            this.AmountLabel.TabIndex = 2;
            this.AmountLabel.Text = "Amount to pay:";
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(174, 98);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(77, 20);
            this.AmountTextBox.TabIndex = 3;
            // 
            // PayButton
            // 
            this.PayButton.Location = new System.Drawing.Point(114, 153);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(64, 29);
            this.PayButton.TabIndex = 4;
            this.PayButton.Text = "PAY";
            this.PayButton.UseVisualStyleBackColor = true;
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // Sign1Label
            // 
            this.Sign1Label.AutoSize = true;
            this.Sign1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign1Label.Location = new System.Drawing.Point(149, 44);
            this.Sign1Label.Name = "Sign1Label";
            this.Sign1Label.Size = new System.Drawing.Size(16, 18);
            this.Sign1Label.TabIndex = 5;
            this.Sign1Label.Text = "$";
            // 
            // Sign2Label
            // 
            this.Sign2Label.AutoSize = true;
            this.Sign2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign2Label.Location = new System.Drawing.Point(149, 97);
            this.Sign2Label.Name = "Sign2Label";
            this.Sign2Label.Size = new System.Drawing.Size(16, 18);
            this.Sign2Label.TabIndex = 6;
            this.Sign2Label.Text = "$";
            // 
            // PayBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 198);
            this.Controls.Add(this.Sign2Label);
            this.Controls.Add(this.Sign1Label);
            this.Controls.Add(this.PayButton);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.BalanceLabel);
            this.Controls.Add(this.CurrentBalanceLabel);
            this.Name = "PayBalance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PayBalance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CurrentBalanceLabel;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Button PayButton;
        private System.Windows.Forms.Label Sign1Label;
        private System.Windows.Forms.Label Sign2Label;
    }
}