namespace Lab5
{
    partial class Form1
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
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpChoose = new System.Windows.Forms.GroupBox();
            this.radStats = new System.Windows.Forms.RadioButton();
            this.radText = new System.Windows.Forms.RadioButton();
            this.grpText = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.btnJoin = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.chkSwap = new System.Windows.Forms.CheckBox();
            this.txtString2 = new System.Windows.Forms.TextBox();
            this.txtString1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpStats = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.grpLogin.SuspendLayout();
            this.grpChoose.SuspendLayout();
            this.grpText.SuspendLayout();
            this.grpStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpLogin
            // 
            this.grpLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grpLogin.Controls.Add(this.btnLogin);
            this.grpLogin.Controls.Add(this.txtCode);
            this.grpLogin.Controls.Add(this.label2);
            this.grpLogin.Controls.Add(this.lblCode);
            this.grpLogin.Controls.Add(this.label1);
            this.grpLogin.Location = new System.Drawing.Point(18, 16);
            this.grpLogin.Margin = new System.Windows.Forms.Padding(4);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Padding = new System.Windows.Forms.Padding(4);
            this.grpLogin.Size = new System.Drawing.Size(719, 73);
            this.grpLogin.TabIndex = 0;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Login";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(593, 22);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(102, 38);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "&Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(404, 33);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(109, 27);
            this.txtCode.TabIndex = 0;
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type:";
            // 
            // lblCode
            // 
            this.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCode.Location = new System.Drawing.Point(207, 33);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(98, 27);
            this.lblCode.TabIndex = 1;
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Authentication Code:";
            // 
            // grpChoose
            // 
            this.grpChoose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grpChoose.Controls.Add(this.radStats);
            this.grpChoose.Controls.Add(this.radText);
            this.grpChoose.Location = new System.Drawing.Point(18, 97);
            this.grpChoose.Margin = new System.Windows.Forms.Padding(4);
            this.grpChoose.Name = "grpChoose";
            this.grpChoose.Padding = new System.Windows.Forms.Padding(4);
            this.grpChoose.Size = new System.Drawing.Size(719, 73);
            this.grpChoose.TabIndex = 1;
            this.grpChoose.TabStop = false;
            this.grpChoose.Text = "Choose...";
            // 
            // radStats
            // 
            this.radStats.AutoSize = true;
            this.radStats.Location = new System.Drawing.Point(442, 28);
            this.radStats.Name = "radStats";
            this.radStats.Size = new System.Drawing.Size(72, 24);
            this.radStats.TabIndex = 1;
            this.radStats.TabStop = true;
            this.radStats.Text = "Stats";
            this.radStats.UseVisualStyleBackColor = true;
            // 
            // radText
            // 
            this.radText.AutoSize = true;
            this.radText.Location = new System.Drawing.Point(82, 28);
            this.radText.Name = "radText";
            this.radText.Size = new System.Drawing.Size(66, 24);
            this.radText.TabIndex = 0;
            this.radText.TabStop = true;
            this.radText.Text = "Text";
            this.radText.UseVisualStyleBackColor = true;
            // 
            // grpText
            // 
            this.grpText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grpText.Controls.Add(this.btnReset);
            this.grpText.Controls.Add(this.btnAnalyze);
            this.grpText.Controls.Add(this.btnJoin);
            this.grpText.Controls.Add(this.lblResults);
            this.grpText.Controls.Add(this.chkSwap);
            this.grpText.Controls.Add(this.txtString2);
            this.grpText.Controls.Add(this.txtString1);
            this.grpText.Controls.Add(this.label4);
            this.grpText.Controls.Add(this.label3);
            this.grpText.Location = new System.Drawing.Point(18, 179);
            this.grpText.Name = "grpText";
            this.grpText.Size = new System.Drawing.Size(356, 238);
            this.grpText.TabIndex = 2;
            this.grpText.TabStop = false;
            this.grpText.Text = "Text";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(261, 205);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(140, 205);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(75, 23);
            this.btnAnalyze.TabIndex = 4;
            this.btnAnalyze.Text = "&Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(19, 205);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(75, 23);
            this.btnJoin.TabIndex = 3;
            this.btnJoin.Text = "&Join";
            this.btnJoin.UseVisualStyleBackColor = true;
            // 
            // lblResults
            // 
            this.lblResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResults.Location = new System.Drawing.Point(19, 109);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(317, 82);
            this.lblResults.TabIndex = 5;
            // 
            // chkSwap
            // 
            this.chkSwap.AutoSize = true;
            this.chkSwap.Location = new System.Drawing.Point(23, 86);
            this.chkSwap.Name = "chkSwap";
            this.chkSwap.Size = new System.Drawing.Size(77, 24);
            this.chkSwap.TabIndex = 2;
            this.chkSwap.Text = "Swap";
            this.chkSwap.UseVisualStyleBackColor = true;
            // 
            // txtString2
            // 
            this.txtString2.Location = new System.Drawing.Point(124, 58);
            this.txtString2.Name = "txtString2";
            this.txtString2.Size = new System.Drawing.Size(212, 27);
            this.txtString2.TabIndex = 1;
            // 
            // txtString1
            // 
            this.txtString1.Location = new System.Drawing.Point(124, 20);
            this.txtString1.Name = "txtString1";
            this.txtString1.Size = new System.Drawing.Size(212, 27);
            this.txtString1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "String #2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "String #1:";
            // 
            // grpStats
            // 
            this.grpStats.BackColor = System.Drawing.Color.PeachPuff;
            this.grpStats.Controls.Add(this.listBox1);
            this.grpStats.Controls.Add(this.numericUpDown1);
            this.grpStats.Controls.Add(this.label11);
            this.grpStats.Controls.Add(this.label10);
            this.grpStats.Controls.Add(this.label9);
            this.grpStats.Controls.Add(this.button2);
            this.grpStats.Controls.Add(this.button1);
            this.grpStats.Controls.Add(this.label8);
            this.grpStats.Controls.Add(this.label7);
            this.grpStats.Controls.Add(this.label6);
            this.grpStats.Controls.Add(this.label5);
            this.grpStats.Location = new System.Drawing.Point(381, 179);
            this.grpStats.Name = "grpStats";
            this.grpStats.Size = new System.Drawing.Size(356, 238);
            this.grpStats.TabIndex = 3;
            this.grpStats.TabStop = false;
            this.grpStats.Text = "Stats";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "How many?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Sum:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Mean:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Odd:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "&Generate";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(246, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "&Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(79, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 27);
            this.label9.TabIndex = 6;
            this.label9.Text = "label9";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(79, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 27);
            this.label10.TabIndex = 7;
            this.label10.Text = "label10";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(79, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 27);
            this.label11.TabIndex = 8;
            this.label11.Text = "label11";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(116, 42);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(62, 27);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(184, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(161, 164);
            this.listBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 418);
            this.Controls.Add(this.grpStats);
            this.Controls.Add(this.grpText);
            this.Controls.Add(this.grpChoose);
            this.Controls.Add(this.grpLogin);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab5 by";
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.grpChoose.ResumeLayout(false);
            this.grpChoose.PerformLayout();
            this.grpText.ResumeLayout(false);
            this.grpText.PerformLayout();
            this.grpStats.ResumeLayout(false);
            this.grpStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpChoose;
        private System.Windows.Forms.GroupBox grpText;
        private System.Windows.Forms.GroupBox grpStats;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radStats;
        private System.Windows.Forms.RadioButton radText;
        private System.Windows.Forms.CheckBox chkSwap;
        private System.Windows.Forms.TextBox txtString2;
        private System.Windows.Forms.TextBox txtString1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

