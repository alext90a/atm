namespace ATM
{
    partial class GetMoneyForm
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
            this.mSumField = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.mPrefCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mGetMoneyBtn = new System.Windows.Forms.Button();
            this.mCancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mSumField)).BeginInit();
            this.SuspendLayout();
            // 
            // mSumField
            // 
            this.mSumField.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.mSumField.Location = new System.Drawing.Point(191, 54);
            this.mSumField.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.mSumField.Name = "mSumField";
            this.mSumField.Size = new System.Drawing.Size(120, 20);
            this.mSumField.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sum:";
            // 
            // mPrefCB
            // 
            this.mPrefCB.FormattingEnabled = true;
            this.mPrefCB.Location = new System.Drawing.Point(191, 111);
            this.mPrefCB.Name = "mPrefCB";
            this.mPrefCB.Size = new System.Drawing.Size(121, 21);
            this.mPrefCB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Preferable:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mGetMoneyBtn
            // 
            this.mGetMoneyBtn.Location = new System.Drawing.Point(256, 460);
            this.mGetMoneyBtn.Name = "mGetMoneyBtn";
            this.mGetMoneyBtn.Size = new System.Drawing.Size(75, 23);
            this.mGetMoneyBtn.TabIndex = 4;
            this.mGetMoneyBtn.Text = "Get money";
            this.mGetMoneyBtn.UseVisualStyleBackColor = true;
            this.mGetMoneyBtn.Click += new System.EventHandler(this.mGetMoneyBtn_Click);
            // 
            // mCancelBtn
            // 
            this.mCancelBtn.Location = new System.Drawing.Point(129, 460);
            this.mCancelBtn.Name = "mCancelBtn";
            this.mCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.mCancelBtn.TabIndex = 5;
            this.mCancelBtn.Text = "Cancel";
            this.mCancelBtn.UseVisualStyleBackColor = true;
            this.mCancelBtn.Click += new System.EventHandler(this.mCancelBtn_Click);
            // 
            // GetMoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 531);
            this.Controls.Add(this.mCancelBtn);
            this.Controls.Add(this.mGetMoneyBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mPrefCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mSumField);
            this.Name = "GetMoneyForm";
            this.Text = "GetMoneyForm";
            ((System.ComponentModel.ISupportInitialize)(this.mSumField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown mSumField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox mPrefCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button mGetMoneyBtn;
        private System.Windows.Forms.Button mCancelBtn;
    }
}