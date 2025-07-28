using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kripto
{
    public partial class Kredencijali : Form
    {
        public Kredencijali()
        {
            InitializeComponent();
        }

        private void Kredencijali_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        User user = new User();
        private void button1_Click(object sender, EventArgs e)
        {
            user.Username = textBox1.Text;
            user.Password = textBox2.Text;
            if (!user.checkIfUsernameExists()) { MessageBox.Show("Uneseno korisnicko ime nije validno!","WARNING"); return; }
            if(!user.checkPassword()) { MessageBox.Show("Nevalidna lozinka!","WARNING"); return; }
            Meni meni = new Meni(user.Username);
            this.Hide();
            meni.Location = this.Location;
            meni.StartPosition = FormStartPosition.Manual;
            meni.Show();
            //if (!user.verifyPotpis()) { MessageBox.Show("Digitalni potpis nije validan, neovlaštena izmjena","WARNING"); }
            string noviOtisak = Openssl.ExecuteOpenSSLCommand("openssl dgst -sha224 Tekst/" + user.Username + ".txt", true, false, true);
            noviOtisak = noviOtisak.TrimEnd(new[] { '\n', '\r' });
            var splitOtisak = noviOtisak.Split(' ');
            noviOtisak = splitOtisak[1];
            if (noviOtisak != user.vratiOtisak()) { MessageBox.Show("Desila se neovlaštena izmjena vaše datoteke!", "WARNING"); }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Korisničko ime")
            {
                textBox1.Text = "";
                textBox1.ForeColor = System.Drawing.SystemColors.WindowText; 
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Email adresa";
                textBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "Lozinka")
            {
                textBox2.PasswordChar = checkBox1.Checked ? '\0' : '*';
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Lozinka")
            {
                textBox2.Text = "";
                textBox2.ForeColor = System.Drawing.SystemColors.WindowText; 
                if (checkBox1.Checked == false)
                {
                    textBox2.PasswordChar = '*';
                }
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = "Lozinka";
                textBox2.ForeColor = System.Drawing.SystemColors.GrayText;
                if (checkBox1.Checked == true || checkBox1.Checked == false) { textBox2.PasswordChar = '\0'; }
            }
        }
    }
}
