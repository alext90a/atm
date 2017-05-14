namespace ATM
{
    partial class StartMenu
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
            this.mGetMoneyButton = new System.Windows.Forms.Button();
            this.mInsertMoneyButton = new System.Windows.Forms.Button();
            this.mShowBankStatButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mGetMoneyButton
            // 
            this.mGetMoneyButton.Location = new System.Drawing.Point(95, 172);
            this.mGetMoneyButton.Name = "mGetMoneyButton";
            this.mGetMoneyButton.Size = new System.Drawing.Size(214, 23);
            this.mGetMoneyButton.TabIndex = 1;
            this.mGetMoneyButton.Text = "Get Money";
            this.mGetMoneyButton.UseVisualStyleBackColor = true;
            this.mGetMoneyButton.Click += new System.EventHandler(this.mGetMoneyButton_Click);
            // 
            // mInsertMoneyButton
            // 
            this.mInsertMoneyButton.Location = new System.Drawing.Point(95, 131);
            this.mInsertMoneyButton.Name = "mInsertMoneyButton";
            this.mInsertMoneyButton.Size = new System.Drawing.Size(214, 23);
            this.mInsertMoneyButton.TabIndex = 2;
            this.mInsertMoneyButton.Text = "Insert Money";
            this.mInsertMoneyButton.UseVisualStyleBackColor = true;
            this.mInsertMoneyButton.Click += new System.EventHandler(this.mInsertMoneyButton_Click);
            // 
            // mShowBankStatButton
            // 
            this.mShowBankStatButton.Location = new System.Drawing.Point(95, 211);
            this.mShowBankStatButton.Name = "mShowBankStatButton";
            this.mShowBankStatButton.Size = new System.Drawing.Size(214, 23);
            this.mShowBankStatButton.TabIndex = 3;
            this.mShowBankStatButton.Text = "Show bank state";
            this.mShowBankStatButton.UseVisualStyleBackColor = true;
            this.mShowBankStatButton.Click += new System.EventHandler(this.mShowBankStatButton_Click);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 376);
            this.Controls.Add(this.mShowBankStatButton);
            this.Controls.Add(this.mInsertMoneyButton);
            this.Controls.Add(this.mGetMoneyButton);
            this.Name = "StartMenu";
            this.Text = "ATM";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mGetMoneyButton;
        private System.Windows.Forms.Button mInsertMoneyButton;
        private System.Windows.Forms.Button mShowBankStatButton;
    }
}

