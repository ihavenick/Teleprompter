namespace Prompter.Masaustu
{
    partial class FormPrompter
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
            this.labelYazi = new System.Windows.Forms.Label();
            this.timerPrompter = new System.Windows.Forms.Timer(this.components);
            this.panelAna = new System.Windows.Forms.Panel();
            this.btnAlt = new System.Windows.Forms.Button();
            this.btnUst = new System.Windows.Forms.Button();
            this.panelAna.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelYazi
            // 
            this.labelYazi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelYazi.AutoSize = true;
            this.labelYazi.BackColor = System.Drawing.Color.Transparent;
            this.labelYazi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelYazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 70.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelYazi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelYazi.Location = new System.Drawing.Point(-7, 473);
            this.labelYazi.Name = "labelYazi";
            this.labelYazi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelYazi.Size = new System.Drawing.Size(295, 107);
            this.labelYazi.TabIndex = 0;
            this.labelYazi.Text = "label1";
            // 
            // timerPrompter
            // 
            this.timerPrompter.Enabled = true;
            this.timerPrompter.Tick += new System.EventHandler(this.timerPrompter_Tick);
            // 
            // panelAna
            // 
            this.panelAna.Controls.Add(this.labelYazi);
            this.panelAna.Controls.Add(this.btnAlt);
            this.panelAna.Controls.Add(this.btnUst);
            this.panelAna.Location = new System.Drawing.Point(1, 1);
            this.panelAna.Name = "panelAna";
            this.panelAna.Size = new System.Drawing.Size(1280, 1024);
            this.panelAna.TabIndex = 1;
            // 
            // btnAlt
            // 
            this.btnAlt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlt.BackColor = System.Drawing.Color.Yellow;
            this.btnAlt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlt.Location = new System.Drawing.Point(-8, 535);
            this.btnAlt.Name = "btnAlt";
            this.btnAlt.Size = new System.Drawing.Size(1288, 15);
            this.btnAlt.TabIndex = 2;
            this.btnAlt.UseVisualStyleBackColor = false;
            this.btnAlt.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUst
            // 
            this.btnUst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUst.BackColor = System.Drawing.Color.Yellow;
            this.btnUst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUst.Location = new System.Drawing.Point(-6, 473);
            this.btnUst.Name = "btnUst";
            this.btnUst.Size = new System.Drawing.Size(1288, 15);
            this.btnUst.TabIndex = 1;
            this.btnUst.UseVisualStyleBackColor = false;
            // 
            // FormPrompter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.panelAna);
            this.Name = "FormPrompter";
            this.Text = "FormPrompter";
            this.Load += new System.EventHandler(this.FormPrompter_Load);
            this.panelAna.ResumeLayout(false);
            this.panelAna.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelYazi;
        private System.Windows.Forms.Timer timerPrompter;
        private System.Windows.Forms.Panel panelAna;
        private System.Windows.Forms.Button btnUst;
        private System.Windows.Forms.Button btnAlt;
    }
}