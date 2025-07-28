using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kripto
{
    class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Otisak { get; set; }
        public string Serial { get; set; }

        public bool verifyPotpis()
        {
            string tempPath = $"./Certificates/Tekst/temp.key";
            Openssl.ExecuteOpenSSLCommand("winpty openssl rsa -in private/" + this.Username + ".key -pubout -out temp.key", false, true, false);
            string check = Openssl.ExecuteOpenSSLCommand("winpty openssl dgst -sha224 -verify temp.key -signature " + this.Username + ".sign " + this.Username + ".txt", false, true, false);
            if (File.Exists(tempPath))
            {
                File.Delete(tempPath);
            }
            else
            {
                Console.WriteLine("ERROR");
            }
            if (check.Contains("Verified OK")) return true;
            else return false;
        }
        public bool certificateRevoked()
        {
            string indexPath = $"./Certificates/index.txt";
            try
            {
                using (StreamReader citac = new StreamReader(indexPath))
                {
                    string linija;
                    while ((linija = citac.ReadLine()) != null)
                    {
                        string[] podaci = linija.Split('\t');
                        if (podaci[2] == this.Serial || podaci[3]==this.Serial)
                        {
                            if(linija.Contains("expired") || podaci[0] == "R") return true;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Greška prilikom čitanja fajla: {e.Message}");
                return false;
            }
            return false;
        }
        public bool checkIfUsernameExists(string cert)
        {
            string putanjaDoUsersFajla = @"C:\Users\mihaj\Desktop\Kripto project\Kripto\Certificates\users.txt";

            foreach (string linija in File.ReadLines(putanjaDoUsersFajla))
            {
                string[] parts = linija.Split(' ');
                string test = parts[0];
                if (test+".crt" == cert) return true;
            }
            return false;
        }
        public bool checkIfUsernameExists()
        {
            string putanjaDoUsersFajla = @"C:\Users\mihaj\Desktop\Kripto project\Kripto\Certificates\users.txt";

            foreach(string linija in File.ReadLines(putanjaDoUsersFajla))
            {
                string[] parts = linija.Split(' ');
                string test = parts[0];
                if (test == this.Username) return true;
            }
            return false;
        }
        
        public bool checkPassword()
        {
            string usersPath = $"./Certificates/users.txt";
            try
            {
                string encryptedSalt = string.Empty;
                string hash = string.Empty;
                using (StreamReader citac = new StreamReader(usersPath))
                {
                    string linija;
                    while ((linija = citac.ReadLine()) != null)
                    {
                        string[] podaci = linija.Split(' ');
                        if (podaci.Length >= 4 && podaci[0] == this.Username)
                        {
                            hash = podaci[1];
                            encryptedSalt = podaci[2];
                            break;
                        }
                    }
                }
                string tempPath = $"./Certificates/temp.txt";
                File.WriteAllText(tempPath, encryptedSalt + "\n");
                string tempPath2 = $"./Certificates/temp2.txt";
                //openssl enc -d -k sigurnost -aes256 -base64 -in fileToCryptedSalt -out fileToDecryptedSalt
                Openssl.ExecuteOpenSSLCommand("openssl enc -d -k private/" + this.Username + ".key -aes256 -base64 -in temp.txt -out temp2.txt", true, false, true);
                //Reading the decrypted salt
                string decryptedSalt = File.ReadAllText(tempPath2);
                //Deleting the temporary files
                if (File.Exists(tempPath) && File.Exists(tempPath2))
                {
                    File.Delete(tempPath2);
                    File.Delete(tempPath);
                }
                else
                {
                    Console.WriteLine("ERROR");
                }
                //Removing unecessary characters at the end
                decryptedSalt = decryptedSalt.TrimEnd(new[] { '\n', '\r' });
                //Hashing the password it inputed openssl passwd -5 -salt decryptedSalt InputedPassword
                string hashCheck = Openssl.ExecuteOpenSSLCommand("openssl passwd -5 -salt " + decryptedSalt + " " + this.Password, true, false, true);
                //Removing unecessary characters at the end
                hashCheck = hashCheck.TrimEnd(new[] { '\n', '\r' });
                var hashParts = hashCheck.Split('$');
                //Checking if the hashes are equal
                return hashParts[3].Equals(hash);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Greška prilikom čitanja fajla: {e.Message}");
                return false;
            }

        }

        public string izracunajOtisak()
        {
            string noviOtisak = Openssl.ExecuteOpenSSLCommand("openssl dgst -sha224 Tekst/" + this.Username + ".txt", true, false, true);
            noviOtisak = noviOtisak.TrimEnd(new[] { '\n', '\r' });
            var splitOtisak = noviOtisak.Split(' ');
            noviOtisak = splitOtisak[1];
            return noviOtisak;
        }

        public string vratiOtisak()
        {
            string usersPath = $"./Certificates/users.txt";
            try
            {
                using (StreamReader citac = new StreamReader(usersPath))
                {
                    string linija;
                    while ((linija = citac.ReadLine()) != null)
                    {
                        string[] podaci = linija.Split(' ');
                        if (podaci.Length >= 4 && podaci[0] == this.Username)
                        {
                            return podaci[3]; // Četvrti element je otisak
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Greška prilikom čitanja fajla: {e.Message}");
            }

            return null; // Ako korisnik nije pronađen
        }

        public void upisiNoviOtisak(string noviOtisak)
        {
            string usersPath = $"./Certificates/users.txt";
            try
            {
                // Učitaj sve linije iz fajla
                string[] linije = File.ReadAllLines(usersPath);
                string linija = string.Empty;
                // Pronađi red sa odgovarajućim korisničkim imenom
                for (int i = 0; i < linije.Length; i++)
                {
                    string[] podaci = linije[i].Split(' ');

                    if (podaci.Length >= 4 && podaci[0] == this.Username)
                    {
                        // Ako je pronađeno korisničko ime, izračunaj novi otisak
                        //string noviOtisak = IzracunajOtisak(novaLozinka, podaci[2]); // Novi otisak s novom lozinkom i postojećim solju
                        //linija = linije[i];
                        linije[i] = $"{this.Username} {podaci[1]} {podaci[2]} {noviOtisak}"; // Ažuriraj liniju sa novim otiskom
                        break; // Nakon ažuriranja, prekini pretragu
                    }
                }

                // Sačuvaj ažurirane linije nazad u fajl
                File.WriteAllLines(usersPath, linije);
                //Console.WriteLine($"Otisak za korisnika {ime} je uspešno ažuriran.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Greška prilikom izmene otiska: {e.Message}");
            }
        }

    }
}
