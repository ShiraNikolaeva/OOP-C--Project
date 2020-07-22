namespace Project_v2
{
    partial class LoginFail
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
            this.Msg1 = new System.Windows.Forms.Label();
            this.Msg2 = new System.Windows.Forms.Label();
            this.OKLoginFailButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Msg1
            // 
            this.Msg1.AutoSize = true;
            this.Msg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Msg1.ForeColor = System.Drawing.Color.Red;
            this.Msg1.Location = new System.Drawing.Point(108, 40);
            this.Msg1.Name = "Msg1";
            this.Msg1.Size = new System.Drawing.Size(152, 31);
            this.Msg1.TabIndex = 0;
            this.Msg1.Text = "Login failed";
            // 
            // Msg2
            // 
            this.Msg2.AutoSize = true;
            this.Msg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Msg2.Location = new System.Drawing.Point(49, 92);
            this.Msg2.Name = "Msg2";
            this.Msg2.Size = new System.Drawing.Size(282, 20);
            this.Msg2.TabIndex = 1;
            this.Msg2.Text = "Please try again or create new account";
            // 
            // OKLoginFailButton
            // 
            this.OKLoginFailButton.Location = new System.Drawing.Point(154, 125);
            this.OKLoginFailButton.Name = "OKLoginFailButton";
            this.OKLoginFailButton.Size = new System.Drawing.Size(62, 24);
            this.OKLoginFailButton.TabIndex = 2;
            this.OKLoginFailButton.Text = "OK";
            this.OKLoginFailButton.UseVisualStyleBackColor = true;
            this.OKLoginFailButton.Click += new System.EventHandler(this.OKLoginFailButton_Click);
            // 
            // LoginFail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.OKLoginFailButton);
            this.Controls.Add(this.Msg2);
            this.Controls.Add(this.Msg1);
            this.Name = "LoginFail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginFail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Msg1;
        private System.Windows.Forms.Label Msg2;
        private System.Windows.Forms.Button OKLoginFailButton;
    }
}