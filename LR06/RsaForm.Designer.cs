namespace LR06
{
    partial class RsaForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.encryptButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.eTextBox = new System.Windows.Forms.TextBox();
            this.nTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sourceRichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.encryptedRichTextBox = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.eLabel = new System.Windows.Forms.Label();
            this.dLabel = new System.Windows.Forms.Label();
            this.kLabel = new System.Windows.Forms.Label();
            this.fnLabel = new System.Windows.Forms.Label();
            this.nLabel = new System.Windows.Forms.Label();
            this.qLabel = new System.Windows.Forms.Label();
            this.pLabel = new System.Windows.Forms.Label();
            this.decryptedRichTextBox = new System.Windows.Forms.RichTextBox();
            this.decryptButton = new System.Windows.Forms.Button();
            this.encryptedRichTextBox2 = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.eTextBox2 = new System.Windows.Forms.TextBox();
            this.nTextBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(996, 786);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.encryptButton);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.sourceRichTextBox1);
            this.tabPage1.Controls.Add(this.encryptedRichTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(988, 757);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Шифруємо";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 17);
            this.label6.TabIndex = 37;
            this.label6.Text = "Зашифроване повідомлення";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "Повідомлення";
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(21, 247);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(634, 45);
            this.encryptButton.TabIndex = 34;
            this.encryptButton.Text = "Зашифрувати";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.eTextBox);
            this.groupBox1.Controls.Add(this.nTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(675, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 124);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вікритий ключ";
            // 
            // eTextBox
            // 
            this.eTextBox.Location = new System.Drawing.Point(29, 71);
            this.eTextBox.Name = "eTextBox";
            this.eTextBox.Size = new System.Drawing.Size(202, 22);
            this.eTextBox.TabIndex = 5;
            // 
            // nTextBox
            // 
            this.nTextBox.Location = new System.Drawing.Point(29, 28);
            this.nTextBox.Name = "nTextBox";
            this.nTextBox.Size = new System.Drawing.Size(202, 22);
            this.nTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "e";
            // 
            // sourceRichTextBox1
            // 
            this.sourceRichTextBox1.Location = new System.Drawing.Point(21, 29);
            this.sourceRichTextBox1.Name = "sourceRichTextBox1";
            this.sourceRichTextBox1.Size = new System.Drawing.Size(634, 203);
            this.sourceRichTextBox1.TabIndex = 32;
            this.sourceRichTextBox1.Text = "";
            // 
            // encryptedRichTextBox
            // 
            this.encryptedRichTextBox.Location = new System.Drawing.Point(21, 319);
            this.encryptedRichTextBox.Name = "encryptedRichTextBox";
            this.encryptedRichTextBox.Size = new System.Drawing.Size(634, 380);
            this.encryptedRichTextBox.TabIndex = 33;
            this.encryptedRichTextBox.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.decryptedRichTextBox);
            this.tabPage2.Controls.Add(this.decryptButton);
            this.tabPage2.Controls.Add(this.encryptedRichTextBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(988, 757);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Дешифруємо";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "Зашифроване повідомлення";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 407);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 17);
            this.label8.TabIndex = 30;
            this.label8.Text = "Повідомлення";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.generateButton);
            this.groupBox2.Controls.Add(this.eLabel);
            this.groupBox2.Controls.Add(this.kLabel);
            this.groupBox2.Controls.Add(this.fnLabel);
            this.groupBox2.Controls.Add(this.qLabel);
            this.groupBox2.Controls.Add(this.pLabel);
            this.groupBox2.Location = new System.Drawing.Point(513, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 407);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RSA";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nLabel);
            this.groupBox3.Controls.Add(this.dLabel);
            this.groupBox3.Location = new System.Drawing.Point(217, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 124);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Закритий ключ";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(14, 341);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(434, 45);
            this.generateButton.TabIndex = 5;
            this.generateButton.Text = "Згенерувати";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // eLabel
            // 
            this.eLabel.AutoSize = true;
            this.eLabel.Location = new System.Drawing.Point(17, 113);
            this.eLabel.Name = "eLabel";
            this.eLabel.Size = new System.Drawing.Size(16, 17);
            this.eLabel.TabIndex = 4;
            this.eLabel.Text = "e";
            // 
            // dLabel
            // 
            this.dLabel.AutoSize = true;
            this.dLabel.Location = new System.Drawing.Point(6, 83);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(16, 17);
            this.dLabel.TabIndex = 4;
            this.dLabel.Text = "d";
            // 
            // kLabel
            // 
            this.kLabel.AutoSize = true;
            this.kLabel.Location = new System.Drawing.Point(17, 142);
            this.kLabel.Name = "kLabel";
            this.kLabel.Size = new System.Drawing.Size(15, 17);
            this.kLabel.TabIndex = 4;
            this.kLabel.Text = "k";
            // 
            // fnLabel
            // 
            this.fnLabel.AutoSize = true;
            this.fnLabel.Location = new System.Drawing.Point(17, 80);
            this.fnLabel.Name = "fnLabel";
            this.fnLabel.Size = new System.Drawing.Size(39, 17);
            this.fnLabel.TabIndex = 4;
            this.fnLabel.Text = "Ф(n)";
            // 
            // nLabel
            // 
            this.nLabel.AutoSize = true;
            this.nLabel.Location = new System.Drawing.Point(6, 42);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(16, 17);
            this.nLabel.TabIndex = 4;
            this.nLabel.Text = "n";
            // 
            // qLabel
            // 
            this.qLabel.AutoSize = true;
            this.qLabel.Location = new System.Drawing.Point(17, 51);
            this.qLabel.Name = "qLabel";
            this.qLabel.Size = new System.Drawing.Size(16, 17);
            this.qLabel.TabIndex = 4;
            this.qLabel.Text = "q";
            // 
            // pLabel
            // 
            this.pLabel.AutoSize = true;
            this.pLabel.Location = new System.Drawing.Point(17, 22);
            this.pLabel.Name = "pLabel";
            this.pLabel.Size = new System.Drawing.Size(16, 17);
            this.pLabel.TabIndex = 4;
            this.pLabel.Text = "p";
            // 
            // decryptedRichTextBox
            // 
            this.decryptedRichTextBox.Location = new System.Drawing.Point(18, 427);
            this.decryptedRichTextBox.Name = "decryptedRichTextBox";
            this.decryptedRichTextBox.Size = new System.Drawing.Size(473, 322);
            this.decryptedRichTextBox.TabIndex = 26;
            this.decryptedRichTextBox.Text = "";
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(18, 358);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(473, 46);
            this.decryptButton.TabIndex = 29;
            this.decryptButton.Text = "Розшифрувати";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // encryptedRichTextBox2
            // 
            this.encryptedRichTextBox2.Location = new System.Drawing.Point(18, 37);
            this.encryptedRichTextBox2.Name = "encryptedRichTextBox2";
            this.encryptedRichTextBox2.Size = new System.Drawing.Size(473, 305);
            this.encryptedRichTextBox2.TabIndex = 27;
            this.encryptedRichTextBox2.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.eTextBox2);
            this.groupBox4.Controls.Add(this.nTextBox2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(217, 142);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(237, 124);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Вікритий ключ";
            // 
            // eTextBox2
            // 
            this.eTextBox2.Location = new System.Drawing.Point(29, 71);
            this.eTextBox2.Name = "eTextBox2";
            this.eTextBox2.Size = new System.Drawing.Size(202, 22);
            this.eTextBox2.TabIndex = 5;
            // 
            // nTextBox2
            // 
            this.nTextBox2.Location = new System.Drawing.Point(29, 28);
            this.nTextBox2.Name = "nTextBox2";
            this.nTextBox2.Size = new System.Drawing.Size(202, 22);
            this.nTextBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "e";
            // 
            // RsaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 786);
            this.Controls.Add(this.tabControl1);
            this.Name = "RsaForm";
            this.Text = "RSA";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label eLabel;
        private System.Windows.Forms.Label dLabel;
        private System.Windows.Forms.Label kLabel;
        private System.Windows.Forms.Label fnLabel;
        private System.Windows.Forms.Label nLabel;
        private System.Windows.Forms.Label qLabel;
        private System.Windows.Forms.Label pLabel;
        private System.Windows.Forms.RichTextBox decryptedRichTextBox;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.RichTextBox encryptedRichTextBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox eTextBox;
        private System.Windows.Forms.TextBox nTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox sourceRichTextBox1;
        private System.Windows.Forms.RichTextBox encryptedRichTextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox eTextBox2;
        private System.Windows.Forms.TextBox nTextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}