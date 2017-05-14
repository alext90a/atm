﻿namespace ATM
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m500NominalField = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.m100NominalField = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.m50NominalField = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.m10NominalField = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mSumField)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m500NominalField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m100NominalField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m50NominalField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m10NominalField)).BeginInit();
            this.SuspendLayout();
            // 
            // mSumField
            // 
            this.mSumField.Location = new System.Drawing.Point(191, 54);
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
            this.mGetMoneyBtn.Location = new System.Drawing.Point(256, 331);
            this.mGetMoneyBtn.Name = "mGetMoneyBtn";
            this.mGetMoneyBtn.Size = new System.Drawing.Size(75, 23);
            this.mGetMoneyBtn.TabIndex = 4;
            this.mGetMoneyBtn.Text = "Get money";
            this.mGetMoneyBtn.UseVisualStyleBackColor = true;
            this.mGetMoneyBtn.Click += new System.EventHandler(this.mGetMoneyBtn_Click);
            // 
            // mCancelBtn
            // 
            this.mCancelBtn.Location = new System.Drawing.Point(129, 331);
            this.mCancelBtn.Name = "mCancelBtn";
            this.mCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.mCancelBtn.TabIndex = 5;
            this.mCancelBtn.Text = "Cancel";
            this.mCancelBtn.UseVisualStyleBackColor = true;
            this.mCancelBtn.Click += new System.EventHandler(this.mCancelBtn_Click);
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
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(131, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 128);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nominal";
            // 
            // m500NominalField
            // 
            this.m500NominalField.Location = new System.Drawing.Point(74, 98);
            this.m500NominalField.Name = "m500NominalField";
            this.m500NominalField.Size = new System.Drawing.Size(120, 20);
            this.m500NominalField.TabIndex = 5;
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
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "10";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GetMoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 391);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mCancelBtn);
            this.Controls.Add(this.mGetMoneyBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mPrefCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mSumField);
            this.Name = "GetMoneyForm";
            this.Text = "GetMoneyForm";
            ((System.ComponentModel.ISupportInitialize)(this.mSumField)).EndInit();
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

        private System.Windows.Forms.NumericUpDown mSumField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox mPrefCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button mGetMoneyBtn;
        private System.Windows.Forms.Button mCancelBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown m500NominalField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown m100NominalField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown m50NominalField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown m10NominalField;
        private System.Windows.Forms.Label label6;
    }
}