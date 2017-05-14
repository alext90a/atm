namespace ATM
{
    partial class InsertMoneyForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.mSumTB = new System.Windows.Forms.TextBox();
            this.mInsertBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m500NominalField = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.m100NominalField = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.m50NominalField = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.m10NominalField = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.mCancelBtn = new System.Windows.Forms.Button();
            this.mOutMessageField = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m500NominalField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m100NominalField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m50NominalField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m10NominalField)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sum:";
            // 
            // mSumTB
            // 
            this.mSumTB.Location = new System.Drawing.Point(117, 41);
            this.mSumTB.Name = "mSumTB";
            this.mSumTB.Size = new System.Drawing.Size(100, 20);
            this.mSumTB.TabIndex = 1;
            // 
            // mInsertBtn
            // 
            this.mInsertBtn.Location = new System.Drawing.Point(183, 356);
            this.mInsertBtn.Name = "mInsertBtn";
            this.mInsertBtn.Size = new System.Drawing.Size(139, 23);
            this.mInsertBtn.TabIndex = 2;
            this.mInsertBtn.Text = "Insert";
            this.mInsertBtn.UseVisualStyleBackColor = true;
            this.mInsertBtn.Click += new System.EventHandler(this.mInsertBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m500NominalField);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.m100NominalField);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.m50NominalField);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.m10NominalField);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(78, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 128);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nominal";
            // 
            // m500NominalField
            // 
            this.m500NominalField.Location = new System.Drawing.Point(74, 98);
            this.m500NominalField.Name = "m500NominalField";
            this.m500NominalField.Size = new System.Drawing.Size(120, 20);
            this.m500NominalField.TabIndex = 5;
            this.m500NominalField.ValueChanged += new System.EventHandler(this.m500NominalField_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "500";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // m100NominalField
            // 
            this.m100NominalField.Location = new System.Drawing.Point(74, 72);
            this.m100NominalField.Name = "m100NominalField";
            this.m100NominalField.Size = new System.Drawing.Size(120, 20);
            this.m100NominalField.TabIndex = 5;
            this.m100NominalField.ValueChanged += new System.EventHandler(this.m100NominalField_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "100";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // m50NominalField
            // 
            this.m50NominalField.Location = new System.Drawing.Point(74, 46);
            this.m50NominalField.Name = "m50NominalField";
            this.m50NominalField.Size = new System.Drawing.Size(120, 20);
            this.m50NominalField.TabIndex = 3;
            this.m50NominalField.ValueChanged += new System.EventHandler(this.m50NominalField_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "50";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // m10NominalField
            // 
            this.m10NominalField.Location = new System.Drawing.Point(74, 20);
            this.m10NominalField.Name = "m10NominalField";
            this.m10NominalField.Size = new System.Drawing.Size(120, 20);
            this.m10NominalField.TabIndex = 1;
            this.m10NominalField.ValueChanged += new System.EventHandler(this.m10NominalField_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "10";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mCancelBtn
            // 
            this.mCancelBtn.Location = new System.Drawing.Point(26, 356);
            this.mCancelBtn.Name = "mCancelBtn";
            this.mCancelBtn.Size = new System.Drawing.Size(139, 23);
            this.mCancelBtn.TabIndex = 4;
            this.mCancelBtn.Text = "Cancel";
            this.mCancelBtn.UseVisualStyleBackColor = true;
            this.mCancelBtn.Click += new System.EventHandler(this.mCancelBtn_Click);
            // 
            // mOutMessageField
            // 
            this.mOutMessageField.Enabled = false;
            this.mOutMessageField.Location = new System.Drawing.Point(26, 239);
            this.mOutMessageField.Multiline = true;
            this.mOutMessageField.Name = "mOutMessageField";
            this.mOutMessageField.Size = new System.Drawing.Size(296, 101);
            this.mOutMessageField.TabIndex = 6;
            // 
            // InsertMoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 410);
            this.Controls.Add(this.mOutMessageField);
            this.Controls.Add(this.mCancelBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mInsertBtn);
            this.Controls.Add(this.mSumTB);
            this.Controls.Add(this.label1);
            this.Name = "InsertMoneyForm";
            this.Text = "InsertMoneyForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m500NominalField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m100NominalField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m50NominalField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m10NominalField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mSumTB;
        private System.Windows.Forms.Button mInsertBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown m500NominalField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown m100NominalField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown m50NominalField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown m10NominalField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button mCancelBtn;
        private System.Windows.Forms.TextBox mOutMessageField;
    }
}