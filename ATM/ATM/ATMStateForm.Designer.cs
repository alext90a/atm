namespace ATM
{
    partial class ATMStateForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mMax500TB = new System.Windows.Forms.TextBox();
            this.mMax100TB = new System.Windows.Forms.TextBox();
            this.mMax50TB = new System.Windows.Forms.TextBox();
            this.mMax10TB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m500NominalField = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.m100NominalField = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.m50NominalField = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.m10NominalField = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.mSumField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m500NominalField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m100NominalField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m50NominalField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m10NominalField)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mMax500TB);
            this.groupBox1.Controls.Add(this.mMax100TB);
            this.groupBox1.Controls.Add(this.mMax50TB);
            this.groupBox1.Controls.Add(this.mMax10TB);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.m500NominalField);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.m100NominalField);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.m50NominalField);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.m10NominalField);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(85, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 157);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nominal";
            // 
            // mMax500TB
            // 
            this.mMax500TB.Location = new System.Drawing.Point(188, 118);
            this.mMax500TB.Name = "mMax500TB";
            this.mMax500TB.ReadOnly = true;
            this.mMax500TB.Size = new System.Drawing.Size(47, 20);
            this.mMax500TB.TabIndex = 11;
            // 
            // mMax100TB
            // 
            this.mMax100TB.Location = new System.Drawing.Point(188, 92);
            this.mMax100TB.Name = "mMax100TB";
            this.mMax100TB.ReadOnly = true;
            this.mMax100TB.Size = new System.Drawing.Size(47, 20);
            this.mMax100TB.TabIndex = 10;
            // 
            // mMax50TB
            // 
            this.mMax50TB.Location = new System.Drawing.Point(188, 65);
            this.mMax50TB.Name = "mMax50TB";
            this.mMax50TB.ReadOnly = true;
            this.mMax50TB.Size = new System.Drawing.Size(47, 20);
            this.mMax50TB.TabIndex = 9;
            // 
            // mMax10TB
            // 
            this.mMax10TB.Location = new System.Drawing.Point(188, 40);
            this.mMax10TB.Name = "mMax10TB";
            this.mMax10TB.ReadOnly = true;
            this.mMax10TB.Size = new System.Drawing.Size(47, 20);
            this.mMax10TB.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Current amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Max";
            // 
            // m500NominalField
            // 
            this.m500NominalField.Location = new System.Drawing.Point(49, 118);
            this.m500NominalField.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.m500NominalField.Name = "m500NominalField";
            this.m500NominalField.ReadOnly = true;
            this.m500NominalField.Size = new System.Drawing.Size(120, 20);
            this.m500NominalField.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "500";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // m100NominalField
            // 
            this.m100NominalField.Location = new System.Drawing.Point(49, 92);
            this.m100NominalField.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.m100NominalField.Name = "m100NominalField";
            this.m100NominalField.ReadOnly = true;
            this.m100NominalField.Size = new System.Drawing.Size(120, 20);
            this.m100NominalField.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "100";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // m50NominalField
            // 
            this.m50NominalField.Location = new System.Drawing.Point(49, 66);
            this.m50NominalField.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.m50NominalField.Name = "m50NominalField";
            this.m50NominalField.ReadOnly = true;
            this.m50NominalField.Size = new System.Drawing.Size(120, 20);
            this.m50NominalField.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "50";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // m10NominalField
            // 
            this.m10NominalField.Location = new System.Drawing.Point(49, 40);
            this.m10NominalField.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.m10NominalField.Name = "m10NominalField";
            this.m10NominalField.ReadOnly = true;
            this.m10NominalField.Size = new System.Drawing.Size(120, 20);
            this.m10NominalField.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "10";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mSumField
            // 
            this.mSumField.Location = new System.Drawing.Point(159, 96);
            this.mSumField.Name = "mSumField";
            this.mSumField.ReadOnly = true;
            this.mSumField.Size = new System.Drawing.Size(120, 20);
            this.mSumField.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Sum:";
            // 
            // ATMStateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 376);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mSumField);
            this.Controls.Add(this.groupBox1);
            this.Name = "ATMStateForm";
            this.Text = "ATMStateForm";
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

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown m500NominalField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown m100NominalField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown m50NominalField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown m10NominalField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mSumField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox mMax500TB;
        private System.Windows.Forms.TextBox mMax100TB;
        private System.Windows.Forms.TextBox mMax50TB;
        private System.Windows.Forms.TextBox mMax10TB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
    }
}