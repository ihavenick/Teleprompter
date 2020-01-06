namespace Prompter.Masaustu
{
    partial class FormKontrolPanel
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cbArkaPlan = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cbOtomatik = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnYukari = new System.Windows.Forms.Button();
            this.btnAsagi = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.timerEkran = new System.Windows.Forms.Timer(this.components);
            this.nHız = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBuyut = new System.Windows.Forms.Button();
            this.btnKucult = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHız)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arkaplan Koyu mu?";
            // 
            // cbArkaPlan
            // 
            this.cbArkaPlan.AutoSize = true;
            this.cbArkaPlan.Location = new System.Drawing.Point(118, 13);
            this.cbArkaPlan.Name = "cbArkaPlan";
            this.cbArkaPlan.Size = new System.Drawing.Size(15, 14);
            this.cbArkaPlan.TabIndex = 1;
            this.cbArkaPlan.UseVisualStyleBackColor = true;
            this.cbArkaPlan.CheckedChanged += new System.EventHandler(this.cbArkaPlan_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 90);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(428, 353);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(118, 33);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yazı Boyutu:";
            // 
            // cbOtomatik
            // 
            this.cbOtomatik.AutoSize = true;
            this.cbOtomatik.Location = new System.Drawing.Point(118, 59);
            this.cbOtomatik.Name = "cbOtomatik";
            this.cbOtomatik.Size = new System.Drawing.Size(15, 14);
            this.cbOtomatik.TabIndex = 5;
            this.cbOtomatik.UseVisualStyleBackColor = true;
            this.cbOtomatik.CheckedChanged += new System.EventHandler(this.cbOtomatik_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Otomatik:";
            // 
            // btnYukari
            // 
            this.btnYukari.Location = new System.Drawing.Point(241, 20);
            this.btnYukari.Name = "btnYukari";
            this.btnYukari.Size = new System.Drawing.Size(50, 23);
            this.btnYukari.TabIndex = 7;
            this.btnYukari.Text = "↑";
            this.btnYukari.UseVisualStyleBackColor = true;
            this.btnYukari.Click += new System.EventHandler(this.btnYukari_Click);
            // 
            // btnAsagi
            // 
            this.btnAsagi.Location = new System.Drawing.Point(241, 49);
            this.btnAsagi.Name = "btnAsagi";
            this.btnAsagi.Size = new System.Drawing.Size(50, 23);
            this.btnAsagi.TabIndex = 8;
            this.btnAsagi.Text = "↓";
            this.btnAsagi.UseVisualStyleBackColor = true;
            this.btnAsagi.Click += new System.EventHandler(this.btnAsagi_Click);
            // 
            // pbImage
            // 
            this.pbImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImage.Location = new System.Drawing.Point(450, 13);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(531, 430);
            this.pbImage.TabIndex = 9;
            this.pbImage.TabStop = false;
            // 
            // timerEkran
            // 
            this.timerEkran.Enabled = true;
            this.timerEkran.Tick += new System.EventHandler(this.timerEkran_Tick);
            // 
            // nHız
            // 
            this.nHız.Location = new System.Drawing.Point(192, 57);
            this.nHız.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nHız.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nHız.Name = "nHız";
            this.nHız.Size = new System.Drawing.Size(43, 20);
            this.nHız.TabIndex = 10;
            this.nHız.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nHız.ValueChanged += new System.EventHandler(this.nHız_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hız:";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(368, 54);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnBuyut
            // 
            this.btnBuyut.Location = new System.Drawing.Point(368, 25);
            this.btnBuyut.Name = "btnBuyut";
            this.btnBuyut.Size = new System.Drawing.Size(31, 23);
            this.btnBuyut.TabIndex = 13;
            this.btnBuyut.Text = "+";
            this.btnBuyut.UseVisualStyleBackColor = true;
            this.btnBuyut.Click += new System.EventHandler(this.btnBuyut_Click);
            // 
            // btnKucult
            // 
            this.btnKucult.Location = new System.Drawing.Point(412, 25);
            this.btnKucult.Name = "btnKucult";
            this.btnKucult.Size = new System.Drawing.Size(31, 23);
            this.btnKucult.TabIndex = 14;
            this.btnKucult.Text = "-";
            this.btnKucult.UseVisualStyleBackColor = true;
            this.btnKucult.Click += new System.EventHandler(this.btnKucult_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Bar konumu =";
            // 
            // FormKontrolPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 455);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnKucult);
            this.Controls.Add(this.btnBuyut);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nHız);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btnAsagi);
            this.Controls.Add(this.btnYukari);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbOtomatik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.cbArkaPlan);
            this.Controls.Add(this.label1);
            this.Name = "FormKontrolPanel";
            this.Text = "Kontrol Paneli";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormKontrolPanel_FormClosed);
            this.Load += new System.EventHandler(this.FormKontrolPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHız)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbArkaPlan;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbOtomatik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnYukari;
        private System.Windows.Forms.Button btnAsagi;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Timer timerEkran;
        private System.Windows.Forms.NumericUpDown nHız;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnBuyut;
        private System.Windows.Forms.Button btnKucult;
        private System.Windows.Forms.Label label5;
    }
}

