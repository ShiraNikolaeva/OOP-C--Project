namespace Project_v2
{
    partial class ShowItems
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
            this.ShowItemsListView = new System.Windows.Forms.ListView();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowItemsListView
            // 
            this.ShowItemsListView.HideSelection = false;
            this.ShowItemsListView.Location = new System.Drawing.Point(35, 35);
            this.ShowItemsListView.Name = "ShowItemsListView";
            this.ShowItemsListView.Size = new System.Drawing.Size(312, 295);
            this.ShowItemsListView.TabIndex = 0;
            this.ShowItemsListView.UseCompatibleStateImageBehavior = false;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(167, 349);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(54, 25);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ShowItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 386);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.ShowItemsListView);
            this.Name = "ShowItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowItems";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ShowItemsListView;
        private System.Windows.Forms.Button OKButton;
    }
}