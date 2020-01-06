namespace Prompter.Masaustu
{
    partial class FormEkran
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
            this.pbAna = new System.Windows.Forms.PictureBox();
            this.timerAna = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbAna)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAna
            // 
            this.pbAna.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAna.Location = new System.Drawing.Point(-1, -1);
            this.pbAna.Name = "pbAna";
            this.pbAna.Size = new System.Drawing.Size(1280, 1024);
            this.pbAna.TabIndex = 0;
            this.pbAna.TabStop = false;
            // 
            // timerAna
            // 
            this.timerAna.Enabled = true;
            this.timerAna.Tick += new System.EventHandler(this.timerAna_Tick);
            // 
            // FormEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.pbAna);
            this.Name = "FormEkran";
            this.Text = "FormEkran";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEkran_FormClosing);
            this.Load += new System.EventHandler(this.FormEkran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAna)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAna;
        private System.Windows.Forms.Timer timerAna;
    }
}