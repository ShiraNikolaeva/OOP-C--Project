namespace Project_v2
{
    partial class ShowPurchasesBetweenTotals
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
            this.FromAmountLabel = new System.Windows.Forms.Label();
            this.ToAmountLabel = new System.Windows.Forms.Label();
            this.Sign1Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowPurchasesListView = new System.Windows.Forms.ListView();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromLabel.Location = new System.Drawing.Point(209, 20);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(48, 18);
            this.FromLabel.TabIndex = 0;
            this.FromLabel.Text = "From:";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToLabel.Location = new System.Drawing.Point(227, 56);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(30, 18);
            this.ToLabel.TabIndex = 1;
            this.ToLabel.Text = "To:";
            // 
            // FromAmountLabel
            // 
            this.FromAmountLabel.AutoSize = true;
            this.FromAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromAmountLabel.Location = new System.Drawing.Point(321, 20);
            this.FromAmountLabel.Name = "FromAmountLabel";
            this.FromAmountLabel.Size = new System.Drawing.Size(46, 18);
            this.FromAmountLabel.TabIndex = 2;
            this.FromAmountLabel.Text = "label1";
            // 
            // ToAmountLabel
            // 
            this.ToAmountLabel.AutoSize = true;
            this.ToAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToAmountLabel.Location = new System.Drawing.Point(321, 56);
            this.ToAmountLabel.Name = "ToAmountLabel";
            this.ToAmountLabel.Size = new System.Drawing.Size(46, 18);
            this.ToAmountLabel.TabIndex = 3;
            this.ToAmountLabel.Text = "label1";
            // 
            // Sign1Label
            // 
            this.Sign1Label.AutoSize = true;
            this.Sign1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign1Label.Location = new System.Drawing.Point(299, 20);
            this.Sign1Label.Name = "Sign1Label";
            this.Sign1Label.Size = new System.Drawing.Size(16, 18);
            this.Sign1Label.TabIndex = 4;
            this.Sign1Label.Text = "$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "$";
            // 
            // ShowPurchasesListView
            // 
            this.ShowPurchasesListView.HideSelection = false;
            this.ShowPurchasesListView.Location = new System.Drawing.Point(12, 87);
            this.ShowPurchasesListView.Name = "ShowPurchasesListView";
            this.ShowPurchasesListView.Size = new System.Drawing.Size(582, 264);
            this.ShowPurchasesListView.TabIndex = 6;
            this.ShowPurchasesListView.UseCompatibleStateImageBehavior = false;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(264, 374);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 7;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ShowPurchasesBetweenTotals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 409);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.ShowPurchasesListView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sign1Label);
            this.Controls.Add(this.ToAmountLabel);
            this.Controls.Add(this.FromAmountLabel);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.FromLabel);
            this.Name = "ShowPurchasesBetweenTotals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowPurchasesBetweenTotals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.Label FromAmountLabel;
        private System.Windows.Forms.Label ToAmountLabel;
        private System.Windows.Forms.Label Sign1Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView ShowPurchasesListView;
        private System.Windows.Forms.Button OKButton;
    }
}