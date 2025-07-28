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
    public partial class Meni : Form
    {
        private string username;
        private string otisak;
        public Meni(string username)
        {
            User user = new User();
            user.Username = username;
            string usersPath = $"./Certificates/users.txt";
            InitializeComponent();
            this.username = username;
            this.otisak = user.vratiOtisak();
        }
        User user = new User();
        private void Meni_FormClosed(object sender, FormClosedEventArgs e)
        {
            user.Username = username;
            string noviOtisak = user.izracunajOtisak();
            user.upisiNoviOtisak(noviOtisak);
            //Openssl.ExecuteOpenSSLCommand("winpty openssl dgst -sha224 -sign private/" + user.Username + ".key -out Tekst/" + user.Username + ".sign Tekst/" + user.Username + ".txt", false, true, false);
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedAlgorithm;
            string algorithm;

            if (sender == button1) { selectedAlgorithm = 0; algorithm = "Rail fence"; }
            else if (sender == button2) { selectedAlgorithm = 1; algorithm = "Myszkowski"; }
            else { selectedAlgorithm = 2; algorithm = "Playfair"; }

            Algoritam algoritam = new Algoritam(selectedAlgorithm, username);
            algoritam.Location = this.Location;
            algoritam.StartPosition = FormStartPosition.CenterScreen;
            algoritam.Text = algorithm;
            algoritam.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Istorija istorija = new Istorija(username);
            this.Hide();
            istorija.Location = this.Location;
            istorija.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Start start = new Start();
            this.Hide();
            start.Show();
            user.Username = username;
            string noviOtisak = user.izracunajOtisak();
            user.upisiNoviOtisak(noviOtisak);
        }
        /*
        private void Meni_Shown(object sender, EventArgs e)
        {
            string noviOtisak = Openssl.ExecuteOpenSSLCommand("openssl dgst -sha224 Tekst/" + username + ".txt", true, false, true);
            noviOtisak = noviOtisak.TrimEnd(new[] { '\n', '\r' });
            var splitOtisak = noviOtisak.Split(' ');
            noviOtisak = splitOtisak[1];
            if(noviOtisak != otisak) { MessageBox.Show("Desila se neovlaštena izmjena vaše datoteke!","WARNING"); }
        }*/
    }
}
