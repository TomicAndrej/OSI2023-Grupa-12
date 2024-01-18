using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
fajl sa vozilima:
kategorija,potkategorija,jmb,marka,model,godiste,kubikaza,brojSasije,stiker,datumReg,prosaoTp,tablica

fajl sa nalozima admin:
korIme,lozinka,ime,prezime

fajl sa nalozima radnicki:
korIme,lozinka,ime,prezime

fajl sa nalozima klijentski:
korIme,lozinka,ime,prezime,broj licne,broj ziro racuna,jmb

falj sa izvjestajima o ispravnosti:
brojSasije,kocnica,svjetla,retrovizori,pneumatici,signalizacija,izduvniSistem

fajl sa terminima za tehnicki pregled:
jmb,datum,vrijeme,kategorija,potkategorija,marka,model,godiste,kubikaza,brojSasije,stiker,datumReg,tablica

fajl sa istorijom tehnickih pregleda:
brojSasije,datum,vrijeme,prosaoTp

fajl sa kaznama:

fajl o potvrdi tehnickog pregleda:
brojSasije,tablica,datumTP,ime,prezime,marka,model
*/
namespace sistem_za_registraciju_vozila
{
    internal class funkcije
    {
        private string terminiFilePath = "..\\..\\..\\..\\..\\Fajlovi\\termini.txt";
        private string vozilaFilePath = "..\\..\\..\\..\\..\\Fajlovi\\vozila.txt";
        private string izvjestajiOIspravnostiFilePath = "..\\..\\..\\..\\..\\Fajlovi\\izvjestajiOIspravnosti.txt";
        private string istorijaTPFilePath = "..\\..\\..\\..\\..\\Fajlovi\\istorijaTP.txt";
        private string kazneFilePath = "..\\..\\..\\..\\..\\Fajlovi\\kazne.txt";
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
                MessageBox.Show($"Podaci za nalog '{username}' uspjesno promijenjeni.");
            }
            else
            {
                // Delete the temporary file if the account was not found
                File.Delete(tempFile);
                MessageBox.Show($"Nalog '{username}' nije pronadjen.");
            }
        }

        public bool ProvjeraTerminaDatogVozila(string brojSasije)
        {
            string[] lines = File.ReadAllLines(terminiFilePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length > 0 && parts[9] == brojSasije)
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

        public bool ZakaziTermin(string jmb, string datum, string vrijeme, string kategorija, string potkategorija, string marka, string model, string godiste, string kubikaza, string brojSasije, string stiker, string datumReg)
        {
            if (ProvjeraZauzetostiTermina(datum, vrijeme))
            {
                MessageBox.Show("Termin je zauzet!");
                return false;
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(terminiFilePath, true))
                {
                    writer.WriteLine($"{jmb},{datum},{vrijeme},{kategorija},{potkategorija},{marka},{model},{godiste},{kubikaza},{brojSasije},{stiker},{datumReg}");
                    MessageBox.Show("Termin zakazan");
                    return true;
                }
            }
        }

        public bool ZakaziTerminVoziloPostoji(string brojSasije, string datum, string vrijeme)
        {
            if (ProvjeraZauzetostiTermina(datum, vrijeme))
            {
                MessageBox.Show("Termin je zauzet!");
                return false;
            }
            else
            {
                string[] lines = File.ReadAllLines(vozilaFilePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length > 0 && parts[7] == brojSasije)
                    {
                        using (StreamWriter writer = new StreamWriter(terminiFilePath, true))
                        {
                            writer.WriteLine($"{parts[2]},{datum},{vrijeme},{parts[0]},{parts[1]},{parts[3]},{parts[4]},{parts[5]},{parts[6]},{brojSasije},{parts[8]},{parts[9]}");
                            MessageBox.Show("Termin zakazan");
                        }
                    }
                }
                return true;
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
                        if (!(parts.Length > 0 && parts[9] == brojSasije))
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

        public List<string> GetAllTermini()
        {
            string[] lines = File.ReadAllLines(terminiFilePath);
            List<string> termini = new List<string>();

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                //jmb,datum,vrijeme,kategorija,potkategorija,marka,model,godiste,kubikaza,brojSasije,stiker,datumReg
                if (parts.Length > 0)
                {
                    termini.Add($"Datum:{parts[1]}, Vrijeme:{parts[2]}, Marka:{parts[5]},Model:{parts[6]},Broj Šasije:{parts[9]}");
                }
            }
            return termini;
        }

        public void UcitajNaloge(List<Radnik> radnici)
        {
            using (StreamReader sr = new StreamReader("..\\..\\..\\..\\..\\Fajlovi\\radnik.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    radnici.Add(new Radnik(parts[0], parts[1], parts[2], parts[3]));
                }
            }
        }

        public List<string> GetListOfAllAccountsKlijent()
        {
            List<string> accounts = new List<string>();
            using (StreamReader sr = new StreamReader("..\\..\\..\\..\\..\\Fajlovi\\klijent.txt"))
            {
                string line;
                
                //sr.ReadLine();//skip the first line
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    accounts.Add($"{parts[2]} {parts[3]} ({parts[0]})");
                }
            }
            return accounts;
        }
        public List<string> GetListOfAllAccountsRadnik()
        {
            List<string> accounts = new List<string>();
            using (StreamReader sr = new StreamReader("..\\..\\..\\..\\..\\Fajlovi\\radnik.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    accounts.Add($"{parts[2]} {parts[3]} ({parts[0]})");
                }
            }
            return accounts;
        }
        public List<string> GetListOfAllAccountsAdmin()
        {
            List<string> accounts = new List<string>();
            using (StreamReader sr = new StreamReader("..\\..\\..\\..\\..\\Fajlovi\\administrator.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    accounts.Add($"{parts[2]} {parts[3]} ({parts[0]})");
                }
            }
            return accounts;
        }
        //TODO omoguciti da se kod brisanja ne prikazuje trenutno ulogovani admin
        public bool ProvjeraLozinkeDatogNaloga(string username, string newPassword, string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                // Check if the line contains the provided username and password
                if (parts.Length > 0 && parts[0] == username && parts[1] == newPassword)
                {
                    return true;
                }
            }
            return false;
        }
        public bool PretragaVozilaUFajluVozila(string brojSasije)
        {
            string[] lines = File.ReadAllLines(vozilaFilePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length > 0 && parts[7] == brojSasije)
                {
                    return true;
                }
            }
            return false;
        }
        public bool ObaviTehnicki(string brojSasije, string datum, string vrijeme)
        {
            //brojSasije,kocnica,svjetla,retrovizori,pneumatici,signalizacija,izduvniSistem
            Random random = new Random();

            // Define probabilities (0 has 10% chance, 1 has 90% chance)
            char[] probabilities = { '0', '1', '1', '1', '1', '1', '1', '1', '1', '1' };

            // Retrieve the number based on the index
            char kocnica = probabilities[random.Next(probabilities.Length)];
            char svjetla = probabilities[random.Next(probabilities.Length)];
            char retrovizori = probabilities[random.Next(probabilities.Length)];
            char pneumatici = probabilities[random.Next(probabilities.Length)];
            char signalizacija = probabilities[random.Next(probabilities.Length)];
            char izduvniSistem = probabilities[random.Next(probabilities.Length)];

            bool prosaoTp;
            if (kocnica == '1' && svjetla == '1' && retrovizori == '1' && pneumatici == '1' && signalizacija == '1' && izduvniSistem == '1')
            {
                prosaoTp = true;
            }
            else prosaoTp = false;

            MessageBox.Show($"Kočnica: {kocnica}\nSvjetla: {svjetla}\nRetrovizori: {retrovizori}\nPneumatici: {pneumatici}\nSignalizacija: {signalizacija}\nIzduvni sistem: {izduvniSistem}", "Izvještaj o ispravnosti");

            DodajIzvjestajOIspravnosti(brojSasije, kocnica.ToString(), svjetla.ToString(), retrovizori.ToString(), pneumatici.ToString(), signalizacija.ToString(), izduvniSistem.ToString());

            DodajIstorijuTP(brojSasije, datum, vrijeme, prosaoTp.ToString());
            DodavanjeVozilaUFajl(brojSasije, prosaoTp.ToString());

            return prosaoTp;
        }

        public string pronadjiTablicu(string brojSasije)
        {
            //kategorija,potkategorija,jmb,marka,model,godiste,kubikaza,brojSasije,stiker,datumReg,prosaoTp,(tablica)
            string[] lines = File.ReadAllLines(vozilaFilePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length > 0 && parts[7] == brojSasije)
                {
                    return parts[11];
                }
            }
            return "";//TODO da li se uvijek vraca parts[11] ili nekad ne
        }

        public string pronadjiImeNaOsnovuJmb(string jmb)
        {
            string[] lines = File.ReadAllLines("..\\..\\..\\..\\..\\Fajlovi\\klijent.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length > 0 && parts[6] == jmb)
                {
                    return parts[2];
                }
            }
            return "";
        }

        public string pronadjiPrezimeNaOsnovuJmb(string jmb)
        {
            string[] lines = File.ReadAllLines("..\\..\\..\\..\\..\\Fajlovi\\klijent.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length > 0 && parts[6] == jmb)
                {
                    return parts[3];
                }
            }
            return "";
        }

        public string PronadjiJmbNaOsnovuNaloga(string username)
        {
            string[] lines = File.ReadAllLines("..\\..\\..\\..\\..\\Fajlovi\\klijent.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length > 0 && parts[0] == username)
                {
                    return parts[6];
                }
            }
            return "";
        }

        public void IzdajPotvrduTP(string brojSasije)
        {
            MessageBox.Show("Pozvanana f-ja izdajPotvrdu");
            string[] lines = File.ReadAllLines(terminiFilePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length > 0 && parts[9] == brojSasije)
                {
                    //jmb,datum,vrijeme,kategorija,potkategorija,marka,model,godiste,kubikaza,brojSasije,stiker,datumReg
                    string potvrdaText = $"Registarska oznaka: {pronadjiTablicu(parts[9])}\n" +
                                         $"Broj šasije: {parts[9]}\n" +
                                         $"Marka: {parts[5]}\n" +
                                         $"Model: {parts[6]}\n" +
                                         $"Datum i vrijeme tehničkog pregleda: {parts[1]} {parts[2]}\n" +
                                         $"Ime i prezime: {pronadjiImeNaOsnovuJmb(parts[0])} {pronadjiPrezimeNaOsnovuJmb(parts[0])}";   
                    // create a .txt file in potvrdeTP folder
                    /*string potvrdaTPFilePath = "C:\\Users\\daco0\\Desktop\\tehnpregledTest\\TehnickiTest\\potvrdeTP\\" + brojSasije + ".txt";
                    using (StreamWriter writer = new StreamWriter(potvrdaTPFilePath, true))
                    {
                        writer.WriteLine(potvrdaText);
                    }*/ //TODO vidjeti sta sa ovim
                    MessageBox.Show(potvrdaText,"Potvrda za tehnički pregled");
                }
            }
        }

        public void DodajIzvjestajOIspravnosti(string brojSasije, string kocnica, string svjetla, string retrovizori, string pneumatici, string signalizacija, string izduvniSistem)
        {
            using (StreamWriter writer = new StreamWriter(izvjestajiOIspravnostiFilePath, true))
            {
                writer.WriteLine($"{brojSasije},{kocnica},{svjetla},{retrovizori},{pneumatici},{signalizacija},{izduvniSistem}");
            }
        }

        public void DodajIstorijuTP(string brojSasije, string datum, string vrijeme, string prosaoTp)
        {
            using (StreamWriter writer = new StreamWriter(istorijaTPFilePath, true))
            {
                writer.WriteLine($"{brojSasije},{datum},{vrijeme},{prosaoTp}");
            }
        }

        public void DodavanjeVozilaUFajl(string brojSasije, string prosaoTp)
        {
            string[] lines = File.ReadAllLines(vozilaFilePath);
            // Create a temporary file to store updated account information
            string tempFile = Path.GetTempFileName();

            using (StreamWriter writer = new StreamWriter(tempFile))
            {
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');

                    // Check if the line contains the provided username
                    if (parts.Length > 0 && parts[7] == brojSasije)
                    {
                        
                        parts[10] = prosaoTp;
                        writer.WriteLine(string.Join(",", parts));
                    }
                    else
                    {
                        // Write other lines to the temporary file
                        writer.WriteLine(line);
                    }
                }
            }
            // TODO da li se treba dodati vozilo u fajl vozila ako nije do tada postojalo (jer na potvrdi o uspjesnom
            // tehnickom pregledu pise tablica a ako vozilo nije u fajlu vozila ne mozemo doci do te tablice

            // Replace the original file with the temporary file
            File.Delete(vozilaFilePath);
            File.Move(tempFile, vozilaFilePath);
        }

        public List<string> listaSvihIzvjestajaOIspravnosti()
        {
            string[] lines = File.ReadAllLines(izvjestajiOIspravnostiFilePath);
            List<string> izvjestaji = new List<string>();

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                //brojSasije,kocnica,svjetla,retrovizori,pneumatici,signalizacija,izduvniSistem
                if (parts.Length > 0)
                {
                    izvjestaji.Add($"Vozilo: {parts[0]}, kocnice {((parts[1] == "1") ? "ispravne" : "neispravne")}, " +
                                   $"svjetla {((parts[2] == "1") ? "ispravna" : "neispravna")}, " +
                                   $"retorvizori {((parts[3] == "1") ? "ispravni" : "neispravni")}, " +
                                   $"pneumatici {((parts[4] == "1") ? "ispravni" : "neispravni")}, " +
                                   $"signalizacija {((parts[5] == "1") ? "ispravna" : "neispravna")}, " +
                                   $"izduvni sistem {((parts[6] == "1") ? "ispravan" : "neispravan")}");
                }
            }
            return izvjestaji;
        }

        public List<string> listaIstorijeTP()
        {
            string[] lines = File.ReadAllLines(istorijaTPFilePath);
            List<string> istorija = new List<string>();

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                //brojSasije,datum,vrijeme,prosaoTp
                if (parts.Length > 0)
                {
                    istorija.Add($"Vozilo: {parts[0]}, datum: {parts[1]}, vrijeme: {parts[2]}, " +
                                 $"prosao tehnicki pregled: {((parts[3] == "1") ? "da" : "ne")}");
                }
            }
            return istorija;
        }
        public void registracijaVozila(string brojSasije, string stiker, string tablica)
        {
            string[] lines = File.ReadAllLines(vozilaFilePath);
            // Create a temporary file to store updated account information
            string tempFile = Path.GetTempFileName();

            using (StreamWriter writer = new StreamWriter(tempFile))
            {
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');

                    // Check if the line contains the provided username
                    if (parts.Length > 0 && parts[7] == brojSasije)
                    {
                        parts[8] = stiker;
                        parts[11] = tablica;
                        parts[12] = "True";
                        writer.WriteLine(string.Join(",", parts));
                    }
                    else
                    {
                        // Write other lines to the temporary file
                        writer.WriteLine(line);
                    }
                }
            }
            // TODO da li se treba dodati vozilo u fajl vozila ako nije do tada postojalo (jer na potvrdi o uspjesnom
            // tehnickom pregledu pise tablica a ako vozilo nije u fajlu vozila ne mozemo doci do te tablice

            // Replace the original file with the temporary file
            File.Delete(vozilaFilePath);
            File.Move(tempFile, vozilaFilePath);
            MessageBox.Show("Vozilo uspješno registrovano!");
        }
        public string PronadjiJmbPrekoBrojaSasije(string brojSasije)
        {
            string[] lines = File.ReadAllLines(vozilaFilePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length > 0 && parts[7] == brojSasije)
                {
                    return parts[2];
                }
            }
            return "";
        }
        
        public bool provjeraBrojaSasije(string brojSasije)
        {
            string[] lines = File.ReadAllLines(vozilaFilePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length > 0 && parts[7] == brojSasije)
                {
                    return true;
                }
            }
            return false;
        }

        public string generisiStiker()
        {
            Random random = new Random();
            string stiker = "";
            for (int i = 0; i < 10; i++)
            {
                stiker += random.Next(0, 10).ToString();
            }

            //check if stiker already exists
            bool exists = false;
            string[] lines = File.ReadAllLines(vozilaFilePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length > 0 && parts[8] == stiker)
                {
                    exists = true;
                }
            }
            if (exists)
            {
                stiker = generisiStiker();
            }
            else
            {
                return stiker;
            }
            return stiker;
        }
        public bool DaLiPostojiFajlSaKaznama(string jmb)
        {
            string[] lines = File.ReadAllLines(kazneFilePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length > 0 && parts[0] == jmb)
                {
                    return true;
                }
            }
            return false;
        }

        public bool provjeriTablice(string tablice)
        {
            string[] lines = File.ReadAllLines(vozilaFilePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length > 0 && parts[11] == tablice)
                {
                    return true;
                }
            }
            return false;
        }

        public List<string> listaSvihVozila()
        {
            string[] lines = File.ReadAllLines(vozilaFilePath);
            List<string> vozila = new List<string>();
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                //kategorija,potkategorija,jmb,marka,model,godiste,kubikaza,brojSasije,stiker,datumReg,prosaoTp,tablica
                if (parts.Length > 0)
                {
                    vozila.Add($"Vozilo: {parts[0]}, {parts[1]}, {parts[2]}, {parts[3]}, {parts[4]}, {parts[5]}, " +
                                                      $"{parts[6]}, {parts[7]}, {parts[8]}, {parts[9]}, {((parts[10] == "1") ? "da" : "ne")}, {parts[11]}");
                }
            }
            return vozila;
        }
        public string pronadjiKategorijuNaOsnovuBrojaSasije(string brojSasije)
        {
            string[] lines = File.ReadAllLines(vozilaFilePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length > 0 && parts[7] == brojSasije)
                {
                    return parts[0];
                }
            }
            return "";
        }

        public void ChangeLineInFile(string filePath, int lineNumber, string newLineValue)
        {
            // Čitanje svih linija iz fajla
            string[] lines = File.ReadAllLines(filePath);

            // Provera da li je zadati red unutar opsega fajla
            if (lineNumber >= 0 && lineNumber <= lines.Length - 1)
            {
                // Postavljanje nove vrednosti linije
                lines[lineNumber] = newLineValue;

                // Pisanje izmenjenih linija nazad u fajl
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (string line in lines)
                    {
                        writer.WriteLine(line);
                    }
                }
            }
            else
            {
                Console.WriteLine("Zadati red ne postoji u fajlu.");
            }
        }
        public void DeleteLineFromFile(string filePath, int lineNumber)
        {
            // Čitanje svih linija iz fajla
            List<string> lines = new List<string>(File.ReadAllLines(filePath));

            // Provera da li je zadati red unutar opsega fajla
            if (lineNumber >= 0 && lineNumber <= lines.Count - 1)
            {
                // Brisanje linije
                lines.RemoveAt(lineNumber);

                // Pisanje izmenjenih linija nazad u fajl
                File.WriteAllLines(filePath, lines);
            }
            else
            {
                Console.WriteLine("Zadati red ne postoji u fajlu.");
            }
        }
        public List<string> ListaVozilaOdNaloga(string nalog)
        {
            List<string> vozila = new List<string>();
            string[] lines = File.ReadAllLines("..\\..\\..\\..\\..\\Fajlovi\\klijent.txt");
            string jmb = "";
            // get jmb based on username
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                if (parts.Length > 0 && parts[0] == nalog)
                {
                    jmb = parts[6];
                }
            }
            if (jmb == "") return vozila;


            lines = File.ReadAllLines(vozilaFilePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                if (parts.Length > 0 && parts[2] == jmb)
                {
                    vozila.Add($"{parts[3]} {parts[4]} {parts[5]}, Broj šasije: {parts[7]}, Broj tablice: {parts[11]}");
                }
            }
            return vozila;
        }


    }
}
