using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Kripto
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registracija registracija = new Registracija();
            registracija.Location = this.Location;
            registracija.StartPosition = FormStartPosition.Manual;
            registracija.Show();
            
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Purple;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kredencijali kred = new Kredencijali();
            this.Hide();
            kred.Location = this.Location;
            kred.StartPosition = FormStartPosition.Manual;
            kred.Show();
            
            /*
            Meni meni = new Meni("mihap23");
            this.Hide();
            meni.Location = this.Location;
            meni.StartPosition = FormStartPosition.Manual;
            meni.Show();*/
        }

        User user = new User();
        private void button1_Click(object sender, EventArgs e)
        {
            string certifikat = Path.GetFileName(textBox1.Text);
            if (!user.checkIfUsernameExists(certifikat)) { MessageBox.Show("Nevalidna putanja!", "GRESKA"); return; }

            string serial = Openssl.ExecuteOpenSSLCommand("openssl x509 -in certs/" + certifikat + " -noout -serial", true, false, true);
            serial = serial.TrimEnd(new[] { '\n', '\r' });
            string[] parts = serial.Split('=');
            serial=parts[1];
            user.Serial = serial;
            if (user.certificateRevoked()) { MessageBox.Show("Sertifikat je istekao ili je povučen", "GRESKA"); textBox1.Text = string.Empty; return; }
            string checkCA = Openssl.ExecuteOpenSSLCommand("openssl verify -CAfile rootca.pem certs/" + certifikat, true, false, true);
            if (checkCA.Contains("OK"))
            {
                button2.Visible = true;
                MessageBox.Show("Certifikat validiran!","Success");
            }
            else { MessageBox.Show("Neispravna putanja ili certifikat!", "GRESKA"); }
        }

        private void Start_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Unesite putanju do certifikata")
            {
                textBox1.Text = "";
                textBox1.ForeColor = System.Drawing.SystemColors.WindowText; // Vratite boju teksta na normalnu
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Unesite putanju do certifikata";
                textBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }
    }
}
