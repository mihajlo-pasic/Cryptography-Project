namespace Kripto
{
    partial class Istorija
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
            this.backBtn = new System.Windows.Forms.Button();
            this.txbIstorija = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.backBtn.Location = new System.Drawing.Point(17, 405);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(108, 33);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "Nazad";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbIstorija
            // 
            this.txbIstorija.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbIstorija.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txbIstorija.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txbIstorija.Location = new System.Drawing.Point(17, 41);
            this.txbIstorija.Multiline = true;
            this.txbIstorija.Name = "txbIstorija";
            this.txbIstorija.ReadOnly = true;
            this.txbIstorija.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbIstorija.Size = new System.Drawing.Size(768, 358);
            this.txbIstorija.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = " TEKST | ALGORITAM | KLJUČ | ŠIFRAT";
            // 
            // Istorija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbIstorija);
            this.Controls.Add(this.backBtn);
            this.Name = "Istorija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Istorija";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Istorija_FormClosed);
            this.Load += new System.EventHandler(this.Istorija_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TextBox txbIstorija;
        private System.Windows.Forms.Label label1;
    }
}