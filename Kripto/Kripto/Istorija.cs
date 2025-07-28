using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Kripto
{
    public partial class Istorija : Form
    {
        private string username;
        public Istorija(string username)
        {
            InitializeComponent();
            this.username = username;
        }
        User user = new User();
        private void Istorija_FormClosed(object sender, FormClosedEventArgs e)
        {
            user.Username = username;
            string noviOtisak = user.izracunajOtisak();
            user.upisiNoviOtisak(noviOtisak);
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Meni meni = new Meni(username);
            this.Hide();
            meni.Show();
        }

        private void Istorija_Load(object sender, EventArgs e)
        {
            string putanjaDoFajla = $"./Certificates/Tekst/{username}.txt";
            if (File.Exists(putanjaDoFajla))
            {
                string sadrzajFajla = File.ReadAllText(putanjaDoFajla);
                txbIstorija.Text = sadrzajFajla;
            }
        }
    }
}
