namespace Kripto
{
    partial class Algoritam
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
            this.plaintextTxb = new System.Windows.Forms.TextBox();
            this.enkripcijaBtn = new System.Windows.Forms.Button();
            this.cipherTxb = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.keyTxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // plaintextTxb
            // 
            this.plaintextTxb.Location = new System.Drawing.Point(101, 134);
            this.plaintextTxb.MaxLength = 100;
            this.plaintextTxb.Name = "plaintextTxb";
            this.plaintextTxb.Size = new System.Drawing.Size(468, 22);
            this.plaintextTxb.TabIndex = 0;
            this.plaintextTxb.Text = "PLAINTEXT";
            // 
            // enkripcijaBtn
            // 
            this.enkripcijaBtn.Location = new System.Drawing.Point(584, 131);
            this.enkripcijaBtn.Name = "enkripcijaBtn";
            this.enkripcijaBtn.Size = new System.Drawing.Size(181, 28);
            this.enkripcijaBtn.TabIndex = 2;
            this.enkripcijaBtn.Text = "Enkripcija";
            this.enkripcijaBtn.UseVisualStyleBackColor = true;
            this.enkripcijaBtn.Click += new System.EventHandler(this.enkripcijaBtn_Click);
            // 
            // cipherTxb
            // 
            this.cipherTxb.Location = new System.Drawing.Point(101, 287);
            this.cipherTxb.Name = "cipherTxb";
            this.cipherTxb.ReadOnly = true;
            this.cipherTxb.Size = new System.Drawing.Size(664, 22);
            this.cipherTxb.TabIndex = 3;
            this.cipherTxb.Text = "ENKRIPTOVANI TEKST";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Nazad";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // keyTxb
            // 
            this.keyTxb.Location = new System.Drawing.Point(101, 162);
            this.keyTxb.Name = "keyTxb";
            this.keyTxb.Size = new System.Drawing.Size(468, 22);
            this.keyTxb.TabIndex = 1;
            this.keyTxb.Text = "KLJUČ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 91);
            this.label1.TabIndex = 5;
            this.label1.Text = "ALGORITAM";
            // 
            // Algoritam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keyTxb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cipherTxb);
            this.Controls.Add(this.enkripcijaBtn);
            this.Controls.Add(this.plaintextTxb);
            this.Name = "Algoritam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Algoritam";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Algoritam_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox plaintextTxb;
        private System.Windows.Forms.Button enkripcijaBtn;
        private System.Windows.Forms.TextBox cipherTxb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox keyTxb;
        private System.Windows.Forms.Label label1;
    }
}