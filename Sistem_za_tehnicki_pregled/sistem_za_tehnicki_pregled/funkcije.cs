using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistem_za_tehnicki_pregled
{
    internal class funkcije
    {
        private string terminiFilePath = "..\\..\\..\\..\\termini.txt";
        public bool provjeraKorisnickogImena(string username, string putanja)
        {
            if (username.Length < 5 || username.Length > 32)
            {
                //MessageBox.Show("Korisničko ime mora imati između 5 i 32 karaktera!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (username.Contains(","))
            {
                MessageBox.Show("Korisničko ime ne smije sadržavati zarez!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (username.Contains("\t"))
            {
                MessageBox.Show("Korisničko ime ne smije sadržavati tab!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (username.Contains("\n"))
            {
                MessageBox.Show("Korisničko ime ne smije sadržavati novi red!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (username.Contains(" "))
            {
                MessageBox.Show("Korisničko ime ne smije sadržavati razmak!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (username[0] == '0' || username[0] == '1' || username[0] == '2' || username[0] == '3' || username[0] == '4' || username[0] == '5' || username[0] == '6' || username[0] == '7' || username[0] == '8' || username[0] == '9')
            {
                MessageBox.Show("Korisničko ime ne smije počinjati brojem!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (username[0] == '.')
            {
                MessageBox.Show("Korisničko ime ne smije počinjati tačkom!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (username[username.Length - 1] == '.')
            {
                MessageBox.Show("Korisničko ime ne smije završavati tačkom!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            List<char> dozvoljeniKarakteri = new List<char>("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789._");
            foreach (char karakter in username)
            {
                if (!dozvoljeniKarakteri.Contains(karakter))
                {
                    MessageBox.Show("Korisničko ime sadrži nedozvoljeni karakter!\nDozvoljeni karakteri su samo slova, donja crta i tačka.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            FileStream fs = new FileStream(putanja, FileMode.Open, FileAccess.Read);
            try
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    while (!sr.EndOfStream)
                    {
                        string red = sr.ReadLine();
                        string[] podaci = red.Split(',');
                        if (username == podaci[0])
                        {
                            MessageBox.Show("Korisničko ime već postoji!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri čitanju iz datoteke: " + ex.Message);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
            return true;
        }


        public bool provjeraValidnostiLozinke(string lozinka)
        {
            if (lozinka.Length < 8 || lozinka.Length > 32)
            {
                //MessageBox.Show("Lozinka mora imati između 8 i 32 karaktera!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            foreach (char c in lozinka)
            {
                if (c == ',')
                {
                    MessageBox.Show("Lozinka ne smije sadržavati zarez!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (c == '\t')
                {
                    MessageBox.Show("Lozinka ne smije sadržavati tab!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (c == '\n')
                {
                    MessageBox.Show("Lozinka ne smije sadržavati novi red!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        public bool provjeraLogInPodataka(string username, string password, string putanja)
        {
            string poruka = "";
            if (username == "")
            {
                poruka += "Niste unijeli korisničko ime!\n";
            }
            if (password == "")
            {
                poruka += "Niste unijeli lozinku!\n";
            }

            if (poruka != "")
            {
                MessageBox.Show(poruka, "Obavezan unos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                FileStream fs = new FileStream(putanja, FileMode.Open, FileAccess.Read);
                try
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string red = sr.ReadLine();
                            string[] podaci = red.Split(',');
                            if (username == podaci[0] && password == podaci[1])
                            {
                                /*PrijavljenKlijentPanel.Visible = true;
                                KorisnickoImeTextBoxLogin.Text = "";
                                LozinkaTextBoxLogin.Text = "";
                                ako vrati true uraditi ^*/

                                //MessageBox.Show("Uspješno ste se prijavili!", "Prijava", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return true;
                            }
                            else if (username == podaci[0] && password != podaci[1])
                            {
                                MessageBox.Show("Pogrešna lozinka!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                        }
                        MessageBox.Show("Korisničko ime ne postoji!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška pri čitanju iz datoteke: " + ex.Message);
                    return false;
                }
                finally
                {
                    if (fs != null)
                    {
                        fs.Close();
                    }
                }
            }
        }

        public bool ProvjeriValidnostKorisnickogImena(string korisnickoIme)
        {
            List<char> dozvoljeniKarakteri = new List<char>("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789._\t\n");

            foreach (char karakter in korisnickoIme)
            {
                if (!dozvoljeniKarakteri.Contains(karakter))
                {
                    return false;
                }
            }
            if (korisnickoIme.Length < 5 || korisnickoIme.Length > 32)
            {
                return false;
            }
            if (korisnickoIme[0] == '.' || korisnickoIme[korisnickoIme.Length - 1] == '.')
            {
                return false;
            }
            if (korisnickoIme[0] == '0' || korisnickoIme[0] == '1' || korisnickoIme[0] == '2' || korisnickoIme[0] == '3' || korisnickoIme[0] == '4' || korisnickoIme[0] == '5' || korisnickoIme[0] == '6' || korisnickoIme[0] == '7' || korisnickoIme[0] == '8' || korisnickoIme[0] == '9')
            {
                return false;
            }
            return true;
        }

        public void RemoveAccount(string username, string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            bool accountRemoved = false;

            // Create a temporary file to store updated account information
            string tempFile = Path.GetTempFileName();

            using (StreamWriter writer = new StreamWriter(tempFile))
            {
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');

                    // Check if the line contains the username to be removed
                    if (parts.Length > 0 && parts[0] == username)
                    {
                        // Skip writing this line (effectively removing the account)
                        accountRemoved = true;
                        continue;
                    }

                    // Write other lines to the temporary file
                    writer.WriteLine(line);
                }
            }

            if (accountRemoved)
            {
                // Replace the original file with the temporary file
                File.Delete(filePath);
                File.Move(tempFile, filePath);
                MessageBox.Show($"Nalog '{username}' uspješno obrisan.", "Brisanje Naloga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Delete the temporary file if no account was removed
                File.Delete(tempFile);
                MessageBox.Show($"Nalog '{username}' nije pronađen.", "Brisanje Naloga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool DoesAccountExist(string username, string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                // Check if the line contains the provided username
                if (parts.Length > 0 && parts[0] == username)
                {
                    MessageBox.Show($"Nalog '{username}' postoji.", "Pretraga Naloga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }

            MessageBox.Show($"Nalog '{username}' ne postoji.", "Pretraga Naloga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        public void AddAccountWithInfoClient(string username, string password, string name, string lastName, string idNumber, string giroAccountNumber, string uniqueIdNumber, string filePath)
        {
            // Combine account information into a string
            //korIme,lozinka,ime,prezime,broj licne,broj ziro racuna,jmb
            string accountInfo = $"{username},{password},{name},{lastName},{idNumber},{giroAccountNumber},{uniqueIdNumber}";

            // Append the new account information to the file
            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine(accountInfo);
            }
        }

        public void ChangeAccountInfoClient(string username, string newUsername, string newPassword,
                                      string newIdNumber, string newGiroAccountNumber, string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            bool accountFound = false;

            // Create a temporary file to store updated account information
            string tempFile = Path.GetTempFileName();

            using (StreamWriter writer = new StreamWriter(tempFile))
            {
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');

                    // Check if the line contains the provided username
                    if (parts.Length > 0 && parts[0] == username)
                    {
                        accountFound = true;

                        // Change the password if a new password is provided
                        if (newUsername != "")
                        {
                            parts[0] = newUsername;
                        }

                        // Change the password if a new password is provided
                        if (newPassword != "")
                        {
                            parts[1] = newPassword;
                        }

                        // Change the ID number if a new ID number is provided
                        if (newIdNumber != "")
                        {
                            parts[4] = newIdNumber;
                        }

                        // Change the giro account number if a new giro account number is provided
                        if (newGiroAccountNumber != "")
                        {
                            parts[5] = newGiroAccountNumber;
                        }

                        // Join the parts back into a line and write to the temporary file
                        writer.WriteLine(string.Join(",", parts));
                    }
                    else
                    {
                        // Write other lines to the temporary file
                        writer.WriteLine(line);
                    }
                }
            }

            if (accountFound)
            {
                // Replace the original file with the temporary file
                File.Delete(filePath);
                File.Move(tempFile, filePath);
                MessageBox.Show($"Podci za nalog '{username}' uspjesno promijenjeni.");
            }
            else
            {
                // Delete the temporary file if the account was not found
                File.Delete(tempFile);
                MessageBox.Show($"Nalog '{username}' nije pronadjen.");
            }
        }
        public List<string> GetAllAccounts(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            List<string> usernames = new List<string>();

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                // Check if the line contains the provided username and password
                if (parts.Length > 0)
                {
                    usernames.Add($"{parts[0]},{parts[1]},{parts[4]},{parts[5]}");//TODO ispisivati samo username
                }
            }

            return usernames;
        }

        public bool ProvjeraTerminaDatogVozila(string brojSasije)
        {
            string[] lines = File.ReadAllLines(terminiFilePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length > 0 && parts[4] == brojSasije)
                {
                    return true;
                }
            }
            return false;
        }
        public bool ProvjeraZauzetostiTermina(string datum, string vrijeme)
        {
            string[] lines = File.ReadAllLines(terminiFilePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length > 0 && parts[1] == datum && parts[2] == vrijeme)
                {
                    return true;
                }
            }
            return false;
        }

        public void ZakaziTermin(string jmb, string datum, string vrijeme, string kategorija, string brojSasije)
        {
            if(ProvjeraZauzetostiTermina(datum, vrijeme))
            {
                MessageBox.Show("Termin je zauzet!");
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(terminiFilePath, true))
                {
                    writer.WriteLine($"{jmb},{datum},{vrijeme},{kategorija},{brojSasije}");
                }
            }
        }

        public bool RemoveTermin(string brojSasije)
        {
            bool terminPostoji = ProvjeraTerminaDatogVozila(brojSasije);
            if (terminPostoji)
            {
                string[] lines = File.ReadAllLines(terminiFilePath);

                // Create a temporary file to store updated account information
                string tempFile = Path.GetTempFileName();

                using (StreamWriter writer = new StreamWriter(tempFile))
                {
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(',');

                        // Check if the line doesnt contain the brojSasije to be removed
                        if (!(parts.Length > 0 && parts[4] == brojSasije))
                        {
                            writer.WriteLine(line);
                        }
                    }
                }
                // Replace the original file with the temporary file
                File.Delete(terminiFilePath);
                File.Move(tempFile, terminiFilePath);
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<string> GetAllTermini(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            List<string> termini = new List<string>();

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                // Check if the line contains the provided username and password
                if (parts.Length > 0)
                {
                    termini.Add($"{parts[0]},{parts[1]},{parts[2]},{parts[3]},{parts[4]}");
                }
            }
            return termini;
        }
        //TODO parser


    }
}
