namespace Project_v2
{
    partial class PayBalanceSuccess
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
            this.NewBalanceLabel = new System.Windows.Forms.Label();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.SignLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewBalanceLabel
            // 
            this.NewBalanceLabel.AutoSize = true;
            this.NewBalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewBalanceLabel.Location = new System.Drawing.Point(63, 49);
            this.NewBalanceLabel.Name = "NewBalanceLabel";
            this.NewBalanceLabel.Size = new System.Drawing.Size(97, 18);
            this.NewBalanceLabel.TabIndex = 0;
            this.NewBalanceLabel.Text = "New balance:";
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BalanceLabel.Location = new System.Drawing.Point(203, 49);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(46, 18);
            this.BalanceLabel.TabIndex = 1;
            this.BalanceLabel.Text = "label1";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(142, 105);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // SignLabel
            // 
            this.SignLabel.AutoSize = true;
            this.SignLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignLabel.Location = new System.Drawing.Point(181, 49);
            this.SignLabel.Name = "SignLabel";
            this.SignLabel.Size = new System.Drawing.Size(16, 18);
            this.SignLabel.TabIndex = 3;
            this.SignLabel.Text = "$";
            // 
            // PayBalanceSuccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 140);
            this.Controls.Add(this.SignLabel);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.BalanceLabel);
            this.Controls.Add(this.NewBalanceLabel);
            this.Name = "PayBalanceSuccess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PayBalanceSuccess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NewBalanceLabel;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label SignLabel;
    }
}