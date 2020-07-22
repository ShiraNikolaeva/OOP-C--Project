namespace Project_v2
{
    partial class LogInSuccess
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
            this.LoginSuccessLabel = new System.Windows.Forms.Label();
            this.LoginSuccessOKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginSuccessLabel
            // 
            this.LoginSuccessLabel.AutoSize = true;
            this.LoginSuccessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginSuccessLabel.Location = new System.Drawing.Point(81, 33);
            this.LoginSuccessLabel.Name = "LoginSuccessLabel";
            this.LoginSuccessLabel.Size = new System.Drawing.Size(117, 20);
            this.LoginSuccessLabel.TabIndex = 0;
            this.LoginSuccessLabel.Text = "Welcome back!";
            this.LoginSuccessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginSuccessLabel.Click += new System.EventHandler(this.LoginSuccessLabel_Click);
            // 
            // LoginSuccessOKButton
            // 
            this.LoginSuccessOKButton.Location = new System.Drawing.Point(119, 77);
            this.LoginSuccessOKButton.Name = "LoginSuccessOKButton";
            this.LoginSuccessOKButton.Size = new System.Drawing.Size(57, 23);
            this.LoginSuccessOKButton.TabIndex = 1;
            this.LoginSuccessOKButton.Text = "OK";
            this.LoginSuccessOKButton.UseVisualStyleBackColor = true;
            this.LoginSuccessOKButton.Click += new System.EventHandler(this.LoginSuccessOKButton_Click);
            // 
            // LogInSuccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.LoginSuccessOKButton);
            this.Controls.Add(this.LoginSuccessLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LogInSuccess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogInSuccess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginSuccessLabel;
        private System.Windows.Forms.Button LoginSuccessOKButton;
    }
}