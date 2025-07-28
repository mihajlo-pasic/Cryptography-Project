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
    public partial class Algoritam : Form
    {
        private int selectedAlgorithm;
        private string username;
        public Algoritam(int selectedAlgorithm, string username)
        {
            InitializeComponent();
            this.selectedAlgorithm = selectedAlgorithm;
            this.username = username;
        }

        Algoritmi algoritam = new Algoritmi();
        User user = new User();
        private void Algoritam_FormClosed(object sender, FormClosedEventArgs e)
        {
            user.Username = username;
            string noviOtisak = user.izracunajOtisak();
            user.upisiNoviOtisak(noviOtisak);
            Application.Exit();
        }

        private void enkripcijaBtn_Click(object sender, EventArgs e)
        {
            string putanjaDoFajla = $"./Certificates/Tekst/{username}.txt";
            try
            {
                using (StreamWriter sw = File.AppendText(putanjaDoFajla))
                {
                    switch (selectedAlgorithm)
                    {
                        case 0:
                            cipherTxb.Text = algoritam.Railfence(plaintextTxb.Text, int.Parse(keyTxb.Text));
                            string input0 = plaintextTxb.Text +" | RAIL FENCE | " + keyTxb.Text +" | " + cipherTxb.Text;
                            sw.WriteLine(input0);
                            break;
                        case 1:
                            cipherTxb.Text = algoritam.Myszkowski(plaintextTxb.Text, keyTxb.Text);
                            string input1 = plaintextTxb.Text + " | MYSZKOWSKI | " + keyTxb.Text + " | " + cipherTxb.Text;
                            sw.WriteLine(input1);
                            break;
                        case 2:
                            cipherTxb.Text = algoritam.Playfair(plaintextTxb.Text, keyTxb.Text);
                            string input2 = plaintextTxb.Text + " | PLAYFAIR | " + keyTxb.Text + " | " + cipherTxb.Text;
                            sw.WriteLine(input2);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (FormatException ex)
            { 
                MessageBox.Show("Niste unijeli validan broj šina za Rail fence algoritam.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Meni meni = new Meni(username);
            this.Hide();
            meni.Location = this.Location;
            meni.StartPosition = FormStartPosition.CenterScreen;
            meni.Show();
        }
    }
}
