namespace StreamCryptosystems
{
	partial class Main
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
            this.plaintext = new System.Windows.Forms.TextBox();
            this.ciphertext = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.saveAsButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resultKey = new System.Windows.Forms.TextBox();
            this.readyThirdKey = new System.Windows.Forms.TextBox();
            this.readySecondKey = new System.Windows.Forms.TextBox();
            this.readyFirstKey = new System.Windows.Forms.TextBox();
            this.thirdKey = new System.Windows.Forms.TextBox();
            this.secondKey = new System.Windows.Forms.TextBox();
            this.firstKey = new System.Windows.Forms.TextBox();
            this.geffeButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lsfrKeyTextBox = new System.Windows.Forms.TextBox();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lfsrButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.RC4KeyTextBox = new System.Windows.Forms.TextBox();
            this.RC4KeyBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.RC4button = new System.Windows.Forms.Button();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // plaintext
            // 
            this.plaintext.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.plaintext.Location = new System.Drawing.Point(14, 262);
            this.plaintext.Multiline = true;
            this.plaintext.Name = "plaintext";
            this.plaintext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.plaintext.Size = new System.Drawing.Size(214, 189);
            this.plaintext.TabIndex = 0;
            this.plaintext.TextChanged += new System.EventHandler(this.plaintext_TextChanged);
            // 
            // ciphertext
            // 
            this.ciphertext.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ciphertext.Location = new System.Drawing.Point(317, 262);
            this.ciphertext.Multiline = true;
            this.ciphertext.Name = "ciphertext";
            this.ciphertext.ReadOnly = true;
            this.ciphertext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ciphertext.Size = new System.Drawing.Size(214, 189);
            this.ciphertext.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(14, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Open...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveAsButton
            // 
            this.saveAsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveAsButton.Location = new System.Drawing.Point(317, 457);
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(96, 34);
            this.saveAsButton.TabIndex = 13;
            this.saveAsButton.Text = "SaveAs...";
            this.saveAsButton.UseVisualStyleBackColor = true;
            this.saveAsButton.Click += new System.EventHandler(this.saveAsButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.resultKey);
            this.tabPage2.Controls.Add(this.readyThirdKey);
            this.tabPage2.Controls.Add(this.readySecondKey);
            this.tabPage2.Controls.Add(this.readyFirstKey);
            this.tabPage2.Controls.Add(this.thirdKey);
            this.tabPage2.Controls.Add(this.secondKey);
            this.tabPage2.Controls.Add(this.firstKey);
            this.tabPage2.Controls.Add(this.geffeButton);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(522, 222);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Geffe";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Common:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Third:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Second:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "First:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Enter first initial state of the register:";
            // 
            // resultKey
            // 
            this.resultKey.Location = new System.Drawing.Point(81, 183);
            this.resultKey.Multiline = true;
            this.resultKey.Name = "resultKey";
            this.resultKey.Size = new System.Drawing.Size(380, 27);
            this.resultKey.TabIndex = 15;
            // 
            // readyThirdKey
            // 
            this.readyThirdKey.Location = new System.Drawing.Point(81, 154);
            this.readyThirdKey.Multiline = true;
            this.readyThirdKey.Name = "readyThirdKey";
            this.readyThirdKey.Size = new System.Drawing.Size(380, 26);
            this.readyThirdKey.TabIndex = 14;
            // 
            // readySecondKey
            // 
            this.readySecondKey.Location = new System.Drawing.Point(81, 121);
            this.readySecondKey.Multiline = true;
            this.readySecondKey.Name = "readySecondKey";
            this.readySecondKey.Size = new System.Drawing.Size(380, 27);
            this.readySecondKey.TabIndex = 13;
            // 
            // readyFirstKey
            // 
            this.readyFirstKey.Location = new System.Drawing.Point(81, 89);
            this.readyFirstKey.Multiline = true;
            this.readyFirstKey.Name = "readyFirstKey";
            this.readyFirstKey.Size = new System.Drawing.Size(380, 26);
            this.readyFirstKey.TabIndex = 12;
            // 
            // thirdKey
            // 
            this.thirdKey.Location = new System.Drawing.Point(203, 63);
            this.thirdKey.MaxLength = 23;
            this.thirdKey.Name = "thirdKey";
            this.thirdKey.Size = new System.Drawing.Size(186, 20);
            this.thirdKey.TabIndex = 10;
            this.thirdKey.TextChanged += new System.EventHandler(this.firstKey_TextChanged);
            this.thirdKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyTextBox_KeyPress);
            // 
            // secondKey
            // 
            this.secondKey.Location = new System.Drawing.Point(202, 37);
            this.secondKey.MaxLength = 33;
            this.secondKey.Name = "secondKey";
            this.secondKey.Size = new System.Drawing.Size(187, 20);
            this.secondKey.TabIndex = 9;
            this.secondKey.TextChanged += new System.EventHandler(this.firstKey_TextChanged);
            this.secondKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyTextBox_KeyPress);
            // 
            // firstKey
            // 
            this.firstKey.Location = new System.Drawing.Point(203, 10);
            this.firstKey.MaxLength = 25;
            this.firstKey.Name = "firstKey";
            this.firstKey.Size = new System.Drawing.Size(186, 20);
            this.firstKey.TabIndex = 8;
            this.firstKey.TextChanged += new System.EventHandler(this.firstKey_TextChanged);
            this.firstKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyTextBox_KeyPress);
            // 
            // geffeButton
            // 
            this.geffeButton.Enabled = false;
            this.geffeButton.Location = new System.Drawing.Point(434, 25);
            this.geffeButton.Name = "geffeButton";
            this.geffeButton.Size = new System.Drawing.Size(47, 25);
            this.geffeButton.TabIndex = 11;
            this.geffeButton.Text = "Run";
            this.geffeButton.UseVisualStyleBackColor = true;
            this.geffeButton.Click += new System.EventHandler(this.geffeButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter third initial state of the register:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter second initial state of the register:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lsfrKeyTextBox);
            this.tabPage1.Controls.Add(this.keyTextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lfsrButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(522, 222);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "LFSR";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lsfrKeyTextBox
            // 
            this.lsfrKeyTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lsfrKeyTextBox.Location = new System.Drawing.Point(69, 71);
            this.lsfrKeyTextBox.Multiline = true;
            this.lsfrKeyTextBox.Name = "lsfrKeyTextBox";
            this.lsfrKeyTextBox.ReadOnly = true;
            this.lsfrKeyTextBox.Size = new System.Drawing.Size(380, 120);
            this.lsfrKeyTextBox.TabIndex = 6;
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(237, 16);
            this.keyTextBox.MaxLength = 25;
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(156, 20);
            this.keyTextBox.TabIndex = 3;
            this.keyTextBox.TextChanged += new System.EventHandler(this.keyTextBox_TextChanged);
            this.keyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter initial state of the register:";
            // 
            // lfsrButton
            // 
            this.lfsrButton.Enabled = false;
            this.lfsrButton.Location = new System.Drawing.Point(69, 42);
            this.lfsrButton.Name = "lfsrButton";
            this.lfsrButton.Size = new System.Drawing.Size(75, 23);
            this.lfsrButton.TabIndex = 5;
            this.lfsrButton.Text = "Run";
            this.lfsrButton.UseVisualStyleBackColor = true;
            this.lfsrButton.Click += new System.EventHandler(this.lfsrButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(530, 248);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.RC4KeyTextBox);
            this.tabPage3.Controls.Add(this.RC4KeyBox);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.RC4button);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(522, 222);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "RC4";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // RC4KeyTextBox
            // 
            this.RC4KeyTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RC4KeyTextBox.Location = new System.Drawing.Point(69, 71);
            this.RC4KeyTextBox.Multiline = true;
            this.RC4KeyTextBox.Name = "RC4KeyTextBox";
            this.RC4KeyTextBox.ReadOnly = true;
            this.RC4KeyTextBox.Size = new System.Drawing.Size(380, 120);
            this.RC4KeyTextBox.TabIndex = 10;
            // 
            // RC4KeyBox
            // 
            this.RC4KeyBox.Location = new System.Drawing.Point(237, 16);
            this.RC4KeyBox.MaxLength = 256;
            this.RC4KeyBox.Name = "RC4KeyBox";
            this.RC4KeyBox.Size = new System.Drawing.Size(156, 20);
            this.RC4KeyBox.TabIndex = 7;
            this.RC4KeyBox.TextChanged += new System.EventHandler(this.kyeBoxRC4_TextChanged);
            this.RC4KeyBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kyeBoxRC4_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(66, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Enter initial state of the register:";
            // 
            // RC4button
            // 
            this.RC4button.Enabled = false;
            this.RC4button.Location = new System.Drawing.Point(69, 42);
            this.RC4button.Name = "RC4button";
            this.RC4button.Size = new System.Drawing.Size(75, 23);
            this.RC4button.TabIndex = 9;
            this.RC4button.Text = "Run";
            this.RC4button.UseVisualStyleBackColor = true;
            this.RC4button.Click += new System.EventHandler(this.RC4button_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 495);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.saveAsButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ciphertext);
            this.Controls.Add(this.plaintext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox plaintext;
		private System.Windows.Forms.TextBox ciphertext;
		private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button saveAsButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resultKey;
        private System.Windows.Forms.TextBox readyThirdKey;
        private System.Windows.Forms.TextBox readySecondKey;
        private System.Windows.Forms.TextBox readyFirstKey;
        private System.Windows.Forms.TextBox thirdKey;
        private System.Windows.Forms.TextBox secondKey;
        private System.Windows.Forms.TextBox firstKey;
        private System.Windows.Forms.Button geffeButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox lsfrKeyTextBox;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lfsrButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox RC4KeyTextBox;
        private System.Windows.Forms.TextBox RC4KeyBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button RC4button;
    }
}

