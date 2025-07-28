using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.IO;


namespace Kripto
{
    public partial class Registracija : Form
    {
        public Registracija()
        {
            InitializeComponent();
        }
        private string password = string.Empty;
        public string GetPassword() { return password; }

        private void Registracija_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Placeholder text prikazi u textbox-ovima
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Korisničko ime")
            {
                textBox1.Text = "";
                textBox1.ForeColor = System.Drawing.SystemColors.WindowText; // Vratite boju teksta na normalnu
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Korisničko ime";
                textBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Lozinka")
            {
                textBox2.Text = "";
                textBox2.ForeColor = System.Drawing.SystemColors.WindowText; // Vratite boju teksta na normalnu
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
                if (checkBox1.Checked==true || checkBox1.Checked == false) { textBox2.PasswordChar = '\0'; }
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Potvrdite lozinku")
            {
                textBox3.Text = "";
                textBox3.ForeColor = System.Drawing.SystemColors.WindowText; // Vratite boju teksta na normalnu
                if (checkBox2.Checked == false)
                {
                    textBox3.PasswordChar = '*';
                }
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                textBox3.Text = "Potvrdite lozinku";
                textBox3.ForeColor = System.Drawing.SystemColors.GrayText;
                if (checkBox2.Checked == true || checkBox2.Checked == false) { textBox3.PasswordChar = '\0'; }
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Država (dvoslovna oznaka)")
            {
                textBox4.Text = "";
                textBox4.ForeColor = System.Drawing.SystemColors.WindowText; // Vratite boju teksta na normalnu
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                textBox4.Text = "Država (dvoslovna oznaka)";
                textBox4.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Savezna država, entitet, provincija")
            {
                textBox5.Text = "";
                textBox5.ForeColor = System.Drawing.SystemColors.WindowText; // Vratite boju teksta na normalnu
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                textBox5.Text = "Savezna država, entitet, provincija";
                textBox5.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "Grad")
            {
                textBox6.Text = "";
                textBox6.ForeColor = System.Drawing.SystemColors.WindowText; // Vratite boju teksta na normalnu
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                textBox6.Text = "Grad";
                textBox6.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (textBox7.Text == "Naziv organizacije")
            {
                textBox7.Text = "";
                textBox7.ForeColor = System.Drawing.SystemColors.WindowText; // Vratite boju teksta na normalnu
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox7.Text))
            {
                textBox7.Text = "Naziv organizacije";
                textBox7.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }

        private void textBox8_Enter(object sender, EventArgs e)
        {
            if (textBox8.Text == "Naziv organizacione jedinice")
            {
                textBox8.Text = "";
                textBox8.ForeColor = System.Drawing.SystemColors.WindowText; // Vratite boju teksta na normalnu
            }
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox8.Text))
            {
                textBox8.Text = "Naziv organizacione jedinice";
                textBox8.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }

        private void textBox9_Enter(object sender, EventArgs e)
        {
            if (textBox9.Text == "Ime")
            {
                textBox9.Text = "";
                textBox9.ForeColor = System.Drawing.SystemColors.WindowText; // Vratite boju teksta na normalnu
            }
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox9.Text))
            {
                textBox9.Text = "Ime";
                textBox9.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }

        private void textBox10_Enter(object sender, EventArgs e)
        {
            if (textBox10.Text == "Email adresa")
            {
                textBox10.Text = "";
                textBox10.ForeColor = System.Drawing.SystemColors.WindowText; // Vratite boju teksta na normalnu
            }
        }

        private void textBox10_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox10.Text))
            {
                textBox10.Text = "Email adresa";
                textBox10.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            password = textBox2.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(textBox2.Text != "Lozinka")
            {
                textBox2.PasswordChar = checkBox1.Checked ? '\0' : '*';
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "Potvrdite lozinku")
            {
                textBox3.PasswordChar = checkBox2.Checked ? '\0' : '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start start = new Start();
            start.Show();
        }

        User user = new User();
        private void button1_Click(object sender, EventArgs e)
        {
            user.Username = textBox1.Text;
            user.Password = textBox2.Text;
            if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Ne poklapaju se lozinke!", "WARNING"); return;
            }
            if (user.checkIfUsernameExists()) { MessageBox.Show("Korisnicko ime vec postoji u sistemu!", "GRESKA"); }
            else
            {
                Openssl.ExecuteOpenSSLCommand("openssl genrsa -out private/" + textBox1.Text + "private.key -passout pass:" + textBox2.Text + " -aes256 4096", true, false, true);
                Openssl.ExecuteOpenSSLCommand("winpty openssl req -new -out requests/" + textBox1.Text + ".csr -config openssl.cnf -key private/" + textBox1.Text + "private.key" + " -subj \'//C=" + textBox4.Text + "\\ST=" + textBox5.Text + "\\L=" + textBox6.Text + "\\O=" + textBox7.Text + "\\OU=" + textBox8.Text + "\\CN=" + textBox9.Text + "\\emailAddress=" + textBox10.Text + "\'", false, true, false);
                Openssl.ExecuteOpenSSLCommand("openssl ca -in requests/" + textBox1.Text + ".csr -config openssl.cnf -out certs/" + textBox1.Text + ".crt", false, true, false);
                
                string putanjaDoFajla= $"./Certificates/Tekst/{user.Username}.txt";
                try
                {
                    // Ako fajl već postoji, obrise ga
                    if (File.Exists(putanjaDoFajla))
                    {
                        File.Delete(putanjaDoFajla);
                    }

                    // Kreiranje novog fajla
                    using (FileStream fs = File.Create(putanjaDoFajla))
                    {
                        Console.WriteLine($"Fajl '{putanjaDoFajla}' je uspešno kreiran.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Došlo je do greške prilikom kreiranja fajla: {ex.Message}");
                }
                string passwordHash = Openssl.ExecuteOpenSSLCommand("openssl passwd -5 " + user.Password, true, false, true);
                passwordHash = passwordHash.TrimEnd(new[] { '\n', '\r' });
                var splitedHash = passwordHash.Split('$');
                string salt = splitedHash[2];
                string hash = splitedHash[3];
                string tempPath = $"./Certificates/temp.txt";
                string tempPath2 = $"./Certificates/temp2.txt";
                File.WriteAllText(tempPath, salt);
                Openssl.ExecuteOpenSSLCommand("openssl enc -aes256 -base64 -k private/" + user.Username + ".key -in temp.txt -out temp2.txt", true, false, true);
                string cryptedSalt = File.ReadAllText(tempPath2);
                if (File.Exists(tempPath) && File.Exists(tempPath2))
                {
                    File.Delete(tempPath2);
                    File.Delete(tempPath);
                }
                else
                {
                    Console.WriteLine("ERROR");
                }
                cryptedSalt = cryptedSalt.TrimEnd(new[] { '\n', '\r' });

                //Openssl.ExecuteOpenSSLCommand("winpty openssl dgst -sha224 -sign private/" + user.Username + ".key -out Tekst/" + user.Username + ".sign Tekst/" + user.Username + ".txt", false, true, false);
                string otisak = Openssl.ExecuteOpenSSLCommand("openssl dgst -sha224 Tekst/" + user.Username + ".txt", true, false, true);
                otisak = otisak.TrimEnd(new[] { '\n', '\r' });
                var splitOtisak = otisak.Split(' ');
                otisak=splitOtisak[1];
                user.Otisak = otisak;
                string linija = user.Username +" "+ hash + " " + cryptedSalt + " "+ otisak;
                string usersPath = $"./Certificates/users.txt";
                try
                {
                    using (StreamWriter sw = File.AppendText(usersPath))
                    { 
                        sw.WriteLine(linija);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR");
                }
                 MessageBox.Show("Uspjesno ste se registrovali! Putanja do Vašeg sertifikata i privatnog ključa se nalazi u prikazanim textBox-ovima. " +
                    "Molimo Vas da ih sačuvate radi moguće prijave na sistem.", "Success");
                putanjaCert.Text = Directory.GetCurrentDirectory() + $"\\Certificates\\certs\\{user.Username}.crt";
                putanjaCert.Visible = true;
                putanjaKljuc.Text = Directory.GetCurrentDirectory() + $"\\Certificates\\private\\{user.Username}.key";
                putanjaKljuc.Visible = true;
                button1.Visible = false;
                return;
            }

        }
    }
}
