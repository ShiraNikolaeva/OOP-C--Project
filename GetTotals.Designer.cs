namespace Project_v2
{
    partial class GetTotals
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
            this.FromLabel = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.FromTextBox = new System.Windows.Forms.TextBox();
            this.ToTextBox = new System.Windows.Forms.TextBox();
            this.NoteLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.Sign1Label = new System.Windows.Forms.Label();
            this.Sign2Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromLabel.Location = new System.Drawing.Point(35, 40);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(48, 18);
            this.FromLabel.TabIndex = 0;
            this.FromLabel.Text = "From:";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToLabel.Location = new System.Drawing.Point(53, 82);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(30, 18);
            this.ToLabel.TabIndex = 1;
            this.ToLabel.Text = "To:";
            // 
            // FromTextBox
            // 
            this.FromTextBox.Location = new System.Drawing.Point(109, 41);
            this.FromTextBox.Name = "FromTextBox";
            this.FromTextBox.Size = new System.Drawing.Size(104, 20);
            this.FromTextBox.TabIndex = 2;
            // 
            // ToTextBox
            // 
            this.ToTextBox.Location = new System.Drawing.Point(109, 83);
            this.ToTextBox.Name = "ToTextBox";
            this.ToTextBox.Size = new System.Drawing.Size(104, 20);
            this.ToTextBox.TabIndex = 3;
            // 
            // NoteLabel
            // 
            this.NoteLabel.AutoSize = true;
            this.NoteLabel.Location = new System.Drawing.Point(68, 9);
            this.NoteLabel.Name = "NoteLabel";
            this.NoteLabel.Size = new System.Drawing.Size(136, 13);
            this.NoteLabel.TabIndex = 4;
            this.NoteLabel.Text = "Enter amounts in format 0.0";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(109, 133);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(62, 25);
            this.OKButton.TabIndex = 5;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // Sign1Label
            // 
            this.Sign1Label.AutoSize = true;
            this.Sign1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign1Label.Location = new System.Drawing.Point(89, 43);
            this.Sign1Label.Name = "Sign1Label";
            this.Sign1Label.Size = new System.Drawing.Size(16, 18);
            this.Sign1Label.TabIndex = 6;
            this.Sign1Label.Text = "$";
            // 
            // Sign2Label
            // 
            this.Sign2Label.AutoSize = true;
            this.Sign2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign2Label.Location = new System.Drawing.Point(89, 83);
            this.Sign2Label.Name = "Sign2Label";
            this.Sign2Label.Size = new System.Drawing.Size(16, 18);
            this.Sign2Label.TabIndex = 7;
            this.Sign2Label.Text = "$";
            // 
            // GetTotals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 170);
            this.Controls.Add(this.Sign2Label);
            this.Controls.Add(this.Sign1Label);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.NoteLabel);
            this.Controls.Add(this.ToTextBox);
            this.Controls.Add(this.FromTextBox);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.FromLabel);
            this.Name = "GetTotals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GetTotals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.TextBox FromTextBox;
        private System.Windows.Forms.TextBox ToTextBox;
        private System.Windows.Forms.Label NoteLabel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label Sign1Label;
        private System.Windows.Forms.Label Sign2Label;
    }
}