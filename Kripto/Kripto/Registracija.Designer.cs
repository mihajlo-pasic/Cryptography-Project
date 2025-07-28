namespace Kripto
{
    partial class Registracija
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.putanjaCert = new System.Windows.Forms.TextBox();
            this.putanjaKljuc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(632, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRACIJA";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox1.Location = new System.Drawing.Point(179, 169);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Korisničko ime";
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox2.Location = new System.Drawing.Point(179, 209);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(246, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Lozinka";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox3.Location = new System.Drawing.Point(179, 248);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(246, 22);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Potvrdite lozinku";
            this.textBox3.Enter += new System.EventHandler(this.textBox3_Enter);
            this.textBox3.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox4.Location = new System.Drawing.Point(549, 169);
            this.textBox4.MaxLength = 2;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(246, 22);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = "Država (dvoslovna oznaka)";
            this.textBox4.Enter += new System.EventHandler(this.textBox4_Enter);
            this.textBox4.Leave += new System.EventHandler(this.textBox4_Leave);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox5.Location = new System.Drawing.Point(549, 209);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(246, 22);
            this.textBox5.TabIndex = 7;
            this.textBox5.Text = "Savezna država, entitet, provincija";
            this.textBox5.Enter += new System.EventHandler(this.textBox5_Enter);
            this.textBox5.Leave += new System.EventHandler(this.textBox5_Leave);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox6.Location = new System.Drawing.Point(549, 248);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(246, 22);
            this.textBox6.TabIndex = 8;
            this.textBox6.Text = "Grad";
            this.textBox6.Enter += new System.EventHandler(this.textBox6_Enter);
            this.textBox6.Leave += new System.EventHandler(this.textBox6_Leave);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox7.Location = new System.Drawing.Point(549, 287);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(246, 22);
            this.textBox7.TabIndex = 9;
            this.textBox7.Text = "Naziv organizacije";
            this.textBox7.Enter += new System.EventHandler(this.textBox7_Enter);
            this.textBox7.Leave += new System.EventHandler(this.textBox7_Leave);
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox8.Location = new System.Drawing.Point(549, 326);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(246, 22);
            this.textBox8.TabIndex = 10;
            this.textBox8.Text = "Naziv organizacione jedinice";
            this.textBox8.Enter += new System.EventHandler(this.textBox8_Enter);
            this.textBox8.Leave += new System.EventHandler(this.textBox8_Leave);
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox9.Location = new System.Drawing.Point(549, 368);
            this.textBox9.MaxLength = 128;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(246, 22);
            this.textBox9.TabIndex = 11;
            this.textBox9.Text = "Ime";
            this.textBox9.Enter += new System.EventHandler(this.textBox9_Enter);
            this.textBox9.Leave += new System.EventHandler(this.textBox9_Leave);
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox10.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox10.Location = new System.Drawing.Point(549, 408);
            this.textBox10.MaxLength = 64;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(246, 22);
            this.textBox10.TabIndex = 12;
            this.textBox10.Text = "Email adresa";
            this.textBox10.Enter += new System.EventHandler(this.textBox10_Enter);
            this.textBox10.Leave += new System.EventHandler(this.textBox10_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 37);
            this.button1.TabIndex = 14;
            this.button1.Text = "Registruj me";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(431, 211);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(68, 20);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "prikaži";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(431, 250);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(68, 20);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "prikaži";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(40, 498);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 33);
            this.button2.TabIndex = 13;
            this.button2.Text = "Nazad";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // putanjaCert
            // 
            this.putanjaCert.Location = new System.Drawing.Point(58, 368);
            this.putanjaCert.Name = "putanjaCert";
            this.putanjaCert.Size = new System.Drawing.Size(406, 22);
            this.putanjaCert.TabIndex = 15;
            this.putanjaCert.Visible = false;
            // 
            // putanjaKljuc
            // 
            this.putanjaKljuc.Location = new System.Drawing.Point(58, 408);
            this.putanjaKljuc.Name = "putanjaKljuc";
            this.putanjaKljuc.Size = new System.Drawing.Size(406, 22);
            this.putanjaKljuc.TabIndex = 16;
            this.putanjaKljuc.Visible = false;
            // 
            // Registracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(988, 574);
            this.Controls.Add(this.putanjaKljuc);
            this.Controls.Add(this.putanjaCert);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Registracija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registracija";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registracija_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox putanjaCert;
        private System.Windows.Forms.TextBox putanjaKljuc;
    }
}