namespace Project_v2
{
    partial class ShowBalance
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
            this.YourBalanceLabel = new System.Windows.Forms.Label();
            this.SignLabel = new System.Windows.Forms.Label();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // YourBalanceLabel
            // 
            this.YourBalanceLabel.AutoSize = true;
            this.YourBalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourBalanceLabel.Location = new System.Drawing.Point(118, 29);
            this.YourBalanceLabel.Name = "YourBalanceLabel";
            this.YourBalanceLabel.Size = new System.Drawing.Size(122, 20);
            this.YourBalanceLabel.TabIndex = 0;
            this.YourBalanceLabel.Text = "Your balance is:";
            // 
            // SignLabel
            // 
            this.SignLabel.AutoSize = true;
            this.SignLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignLabel.Location = new System.Drawing.Point(118, 82);
            this.SignLabel.Name = "SignLabel";
            this.SignLabel.Size = new System.Drawing.Size(18, 20);
            this.SignLabel.TabIndex = 1;
            this.SignLabel.Text = "$";
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceLabel.Location = new System.Drawing.Point(146, 82);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(51, 20);
            this.BalanceLabel.TabIndex = 2;
            this.BalanceLabel.Text = "label1";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(150, 140);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 28);
            this.OKButton.TabIndex = 3;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ShowBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 180);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.BalanceLabel);
            this.Controls.Add(this.SignLabel);
            this.Controls.Add(this.YourBalanceLabel);
            this.Name = "ShowBalance";
            this.Text = "ShowBalance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label YourBalanceLabel;
        private System.Windows.Forms.Label SignLabel;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.Button OKButton;
    }
}