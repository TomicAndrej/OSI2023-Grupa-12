using Microsoft.VisualBasic;
using System.Reflection.Metadata.Ecma335;

namespace sistem_za_registraciju_vozila
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string trenutniNalog = "";

        private void KlijentButton_Click(object sender, EventArgs e)
        {
            KlijentPanel.Visible = true;
            IndikatorNaKomStePanelu.Text = "Klijent";
            IndikatorNaKomStePanelu.BringToFront();
            IndikatorNaKomStePanelu.Visible = true;
        }

        private void RadnikButton_Click(object sender, EventArgs e)
        {
            LoginRadnikaPanel.Visible = true;
            //RadnikPanel.Visible = true;
            IndikatorNaKomStePanelu.Text = "Radnik";
            IndikatorNaKomStePanelu.BringToFront();
            IndikatorNaKomStePanelu.Visible = true;
        }

        private void AdministratorButton_Click(object sender, EventArgs e)
        {
            AdministratorPanel.Visible = true;
            IndikatorNaKomStePanelu.Text = "Administrator";
            IndikatorNaKomStePanelu.BringToFront();
            IndikatorNaKomStePanelu.Visible = true;
        }

        private void NazadKlijentButton_Click(object sender, EventArgs e)
        {
            KlijentPanel.Visible = false;
            IndikatorNaKomStePanelu.Text = "";
        }

        private void NazadRadnikButton_Click(object sender, EventArgs e)
        {
            RadnikPanel.Visible = false;
            //IndikatorNaKomStePanelu.Text = "Radnik";
            /*LogovanAdministratorPanel.Visible = false;
            AdministratorPanel.Visible = false;
            RegistracijaAdministratorskihNalogaPanel.Visible = false;
            trenutniNalog = "";
            IndikatorNaKomStePanelu.Text = "";
            IzborniPanel.Visible = true;*/
            LoginRadnikaPanel.Visible = false;
            IndikatorNaKomStePanelu.Text = "";
            IzborniPanel.Visible = true;
        }

        private void NazadAdministratorButton_Click(object sender, EventArgs e)
        {
            AdministratorPanel.Visible = false;
            IndikatorNaKomStePanelu.Text = "";
        }

        private void RegistrujNalogButton_Click(object sender, EventArgs e)
        {
            string poruka = "";
            if (ImeTextBox.Text == "")
            {
                poruka += "Niste unijeli ime!\n";
            }
            if (PrezimeTextBox.Text == "")
            {
                poruka += "Niste unijeli prezime!\n";
            }
            if (KorisnickoImeTextBox.Text == "")
            {
                poruka += "Niste unijeli korisničko ime!\n";
            }
            if (LozinkaTextBox.Text == "")
            {
                poruka += "Niste unijeli lozinku!\n";
            }
            if (PotvrdaLozinkeTextBox.Text == "")
            {
                poruka += "Niste unijeli potvrdu lozinke!\n";
            }
            if (BrojLicneKarteTextBox.Text == "")
            {
                poruka += "Niste unijeli broj lične karte!\n";
            }
            if (BrojZiroRacunaTextBox.Text == "")
            {
                poruka += "Niste unijeli broj žiro računa!\n";
            }
            if (JMBGTextBox.Text == "")
            {
                poruka += "Niste unijeli JMBG!\n";
            }
            if (poruka != "")
            {
                MessageBox.Show(poruka, "Registracija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (LozinkaTextBox.Text.Length < 8 || LozinkaTextBox.Text.Length > 32)
            {
                MessageBox.Show("Lozinka mora imati između 8 i 32 karaktera!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (LozinkaTextBox.Text != PotvrdaLozinkeTextBox.Text)
            {
                MessageBox.Show("Lozinka i potvrda lozinke se ne poklapaju!", "Registracija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            funkcije f = new funkcije();
            if (!f.ProvjeriValidnostKorisnickogImena(KorisnickoImeTextBox.Text))
            {
                MessageBox.Show("Korisničko ime nije validno!", "Registracija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            /////////////////////
            if (!f.provjeraKorisnickogImena(KorisnickoImeTextBox.Text, "..\\..\\..\\..\\..\\Fajlovi\\klijent.txt"))
            {
                //MessageBox.Show("Korisničko ime već postoji!", "Registracija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            /////////////////////
            if (BrojZiroRacunaTextBox.Text.Length != 16)
            {
                MessageBox.Show("Broj žiro računa mora imati 16 cifara!", "Registracija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (JMBGTextBox.Text.Length != 13)
            {
                MessageBox.Show("JMBG mora imati 13 cifara!", "Registracija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            f.AddAccountWithInfoClient(KorisnickoImeTextBox.Text, LozinkaTextBox.Text, ImeTextBox.Text, PrezimeTextBox.Text, BrojLicneKarteTextBox.Text, BrojZiroRacunaTextBox.Text, JMBGTextBox.Text, "..\\..\\..\\..\\..\\Fajlovi\\klijent.txt");
            MessageBox.Show("Uspješno ste se registrovali!", "Registracija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RegistracijaNalogaPanel.Visible = false;
            ImeTextBox.Text = "";
            PrezimeTextBox.Text = "";
            KorisnickoImeTextBox.Text = "";
            LozinkaTextBox.Text = "";
            PotvrdaLozinkeTextBox.Text = "";
            BrojLicneKarteTextBox.Text = "";
            BrojZiroRacunaTextBox.Text = "";
            JMBGTextBox.Text = "";
        }

        private void RegistrujSeButton_Click(object sender, EventArgs e)
        {
            RegistracijaNalogaPanel.Visible = true;
        }

        private void NazadSaRegistracijeNaLoginButton_Click(object sender, EventArgs e)
        {
            RegistracijaNalogaPanel.Visible = false;
        }

        private void PrijaviSeButton_Click(object sender, EventArgs e)
        {
            funkcije f = new funkcije();
            if (f.provjeraLogInPodataka(KorisnickoImeTextBoxLogin.Text, LozinkaTextBoxLogin.Text, "..\\..\\..\\..\\..\\Fajlovi\\klijent.txt"))
            {
                // MessageBox.Show("Uspješno ste se prijavili!", "Prijava", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LogovanKlijentPanel.Visible = true;
                LogovanKlijentPanel.BringToFront();
                IndikatorNaKomStePanelu.Text = "Klijent: " + KorisnickoImeTextBoxLogin.Text;
                trenutniNalog = KorisnickoImeTextBoxLogin.Text;
                KorisnickoImeTextBoxLogin.Text = "";
                LozinkaTextBoxLogin.Text = "";
            }
        }

        private void KorisnickoImeTextBox_TextChanged(object sender, EventArgs e)
        {
            funkcije f = new funkcije();
            f.provjeraKorisnickogImena(KorisnickoImeTextBox.Text, "..\\..\\..\\..\\..\\Fajlovi\\klijent.txt");
        }

        private void LozinkaTextBox_TextChanged(object sender, EventArgs e)
        {
            funkcije f = new funkcije();
            f.provjeraValidnostiLozinke(LozinkaTextBox.Text);
        }

        private void PrijaviSeAdministratorButton_Click(object sender, EventArgs e)
        {
            funkcije f = new funkcije();
            if (f.provjeraLogInPodataka(KorisnickoImeAdministratorTextBoxLogin.Text, LozinkaAdministratorTextBoxLogin.Text, "..\\..\\..\\..\\..\\Fajlovi\\administrator.txt"))
            {
                //MessageBox.Show("Uspješno ste se prijavili!", "Prijava", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LogovanAdministratorPanel.Visible = true;
                LogovanAdministratorPanel.BringToFront();
                //AdministratorPanel.Visible = false;
                IndikatorNaKomStePanelu.Text = "Administrator: " + KorisnickoImeAdministratorTextBoxLogin.Text;
                trenutniNalog = KorisnickoImeAdministratorTextBoxLogin.Text;
                KorisnickoImeAdministratorTextBoxLogin.Text = "";
                LozinkaAdministratorTextBoxLogin.Text = "";
            }
        }
        // TODO postaviti trenutniNalog kod logovanja radnika
        private void OdjavaLogovanogAdministratoraButton_Click(object sender, EventArgs e)
        {
            LogovanAdministratorPanel.Visible = false;
            AdministratorPanel.Visible = false;
            RegistracijaAdministratorskihNalogaPanel.Visible = false;
            trenutniNalog = "";
            IndikatorNaKomStePanelu.Text = "";
            IzborniPanel.Visible = true;
        }

        private void RegistrujAdministratorskiNalogButton_Click(object sender, EventArgs e)
        {
            string poruka = "";
            if (ImeAdminRegistracijaTextBox.Text == "")
            {
                poruka += "Niste unijeli ime!\n";
            }
            if (PrezimeAdminRegistracijaTextBox.Text == "")
            {
                poruka += "Niste unijeli prezime!\n";
            }
            if (KorisnickoImeAdminRegistracijaTextBox.Text == "")
            {
                poruka += "Niste unijeli korisničko ime!\n";
            }
            if (LozinkaAdminRegistracijaTextBox.Text == "")
            {
                poruka += "Niste unijeli lozinku!\n";
            }
            if (PotvrdaLozinkeAdminRegistracijaTextBox.Text == "")
            {
                poruka += "Niste unijeli potvrdu lozinke!\n";
            }
            if (poruka != "")
            {
                MessageBox.Show(poruka, "Registracija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            funkcije f = new funkcije();
            if (!f.ProvjeriValidnostKorisnickogImena(KorisnickoImeAdminRegistracijaTextBox.Text))
            {
                MessageBox.Show("Korisničko ime nije validno!", "Registracija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!f.provjeraKorisnickogImena(KorisnickoImeAdminRegistracijaTextBox.Text, "..\\..\\..\\..\\..\\Fajlovi\\administrator.txt"))
            {
                //MessageBox.Show("Korisničko ime već postoji!", "Registracija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (LozinkaAdminRegistracijaTextBox.Text.Length < 8 || LozinkaAdminRegistracijaTextBox.Text.Length > 32)
            {
                MessageBox.Show("Lozinka mora imati između 8 i 32 karaktera!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (LozinkaAdminRegistracijaTextBox.Text != PotvrdaLozinkeAdminRegistracijaTextBox.Text)
            {
                MessageBox.Show("Lozinka i potvrda lozinke se ne poklapaju!", "Registracija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string red = KorisnickoImeAdminRegistracijaTextBox.Text +
                "," + LozinkaAdminRegistracijaTextBox.Text +
                "," + ImeAdminRegistracijaTextBox.Text +
                "," + PrezimeAdminRegistracijaTextBox.Text;
            using (StreamWriter writer = File.AppendText("..\\..\\..\\..\\..\\Fajlovi\\administrator.txt"))
            {
                writer.WriteLine(red);
            }
            MessageBox.Show("Uspješno ste registrovali administratora!", "Registracija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            KorisnickoImeAdminRegistracijaTextBox.Text = "";
            LozinkaAdminRegistracijaTextBox.Text = "";
            ImeAdminRegistracijaTextBox.Text = "";
            PrezimeAdminRegistracijaTextBox.Text = "";
            PotvrdaLozinkeAdminRegistracijaTextBox.Text = "";
        }

        private void KreiranjeAdministratorskihNalogaButton_Click(object sender, EventArgs e)
        {
            RegistracijaAdministratorskihNalogaPanel.Visible = true;
            RegistracijaAdministratorskihNalogaPanel.BringToFront();
            RegistracijaAdministratorskihNalogaPanel.ResumeLayout();
        }

        private void NazadSaPanelaZaRegisteracijuAdministratoraNaPanelPrijavljenogAdministratoraButton_Click(object sender, EventArgs e)
        {
            RegistracijaAdministratorskihNalogaPanel.Visible = false;
        }

        private void KreiranjeRadnickihNalogaButton_Click(object sender, EventArgs e)
        {
            RegistracijaRadnickihNalogaPanel.Visible = true;
            RegistracijaRadnickihNalogaPanel.BringToFront();
            RegistracijaRadnickihNalogaPanel.ResumeLayout();
        }

        private void NazadSaPanelaZaRegisteracijuRadnikaNaPanelPrijavljenogAdministratoraButton_Click(object sender, EventArgs e)
        {
            RegistracijaRadnickihNalogaPanel.Visible = false;
        }

        private void RegistrujRadnickiNalogButton_Click(object sender, EventArgs e)
        {
            string poruka = "";
            if (ImeRadnikRegistracijaTextBox.Text == "")
            {
                poruka += "Niste unijeli ime!\n";
            }
            if (PrezimeRadnikRegistracijaTextBox.Text == "")
            {
                poruka += "Niste unijeli prezime!\n";
            }
            if (KorisnickoImeRadnikRegistracijaTextBox.Text == "")
            {
                poruka += "Niste unijeli korisničko ime!\n";
            }
            if (LozinkaRadnikRegistracijaTextBox.Text == "")
            {
                poruka += "Niste unijeli lozinku!\n";
            }
            if (PotvrdaLozinkeRadnikRegistracijaTextBox.Text == "")
            {
                poruka += "Niste unijeli potvrdu lozinke!\n";
            }
            if (poruka != "")
            {
                MessageBox.Show(poruka, "Registracija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            funkcije f = new funkcije();
            if (!f.ProvjeriValidnostKorisnickogImena(KorisnickoImeRadnikRegistracijaTextBox.Text))
            {
                MessageBox.Show("Korisničko ime nije validno!", "Registracija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!f.provjeraKorisnickogImena(KorisnickoImeRadnikRegistracijaTextBox.Text, "..\\..\\..\\..\\..\\Fajlovi\\radnik.txt"))
            {
                //MessageBox.Show("Korisničko ime već postoji!", "Registracija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (LozinkaRadnikRegistracijaTextBox.Text.Length < 8 || LozinkaRadnikRegistracijaTextBox.Text.Length > 32)
            {
                MessageBox.Show("Lozinka mora imati između 8 i 32 karaktera!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (LozinkaRadnikRegistracijaTextBox.Text != PotvrdaLozinkeRadnikRegistracijaTextBox.Text)
            {
                MessageBox.Show("Lozinka i potvrda lozinke se ne poklapaju!", "Registracija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string red = KorisnickoImeRadnikRegistracijaTextBox.Text +
                "," + LozinkaRadnikRegistracijaTextBox.Text +
                "," + ImeRadnikRegistracijaTextBox.Text +
                "," + PrezimeRadnikRegistracijaTextBox.Text;
            using (StreamWriter writer = File.AppendText("..\\..\\..\\..\\..\\Fajlovi\\radnik.txt"))
            {
                writer.WriteLine(red);
            }
            MessageBox.Show("Uspješno ste registrovali radnika!", "Registracija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            KorisnickoImeRadnikRegistracijaTextBox.Text = "";
            LozinkaRadnikRegistracijaTextBox.Text = "";
            ImeRadnikRegistracijaTextBox.Text = "";
            PrezimeRadnikRegistracijaTextBox.Text = "";
            PotvrdaLozinkeRadnikRegistracijaTextBox.Text = "";

        }
        List<Radnik> administratori = new List<Radnik>();
        private void BrisanjeAdministratorskihNalogaButton_Click(object sender, EventArgs e)
        {
            BrisanjeAdministratorskihNalogaPanel.Visible = true;
            BrisanjeAdministratorskihNalogaPanel.BringToFront();
            BrisanjeAdministratorskihNalogaPanel.ResumeLayout();
            UcitajAdministratore();
            ListaAdministratorskihNalogaComboBox.DataSource = administratori;
            ListaAdministratorskihNalogaComboBox.DisplayMember = "PrikaziFormat";
            ListaAdministratorskihNalogaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ListaAdministratorskihNalogaComboBox.Enabled = true;
        }
        public void UcitajAdministratore()
        {
            administratori.Clear();
            using (StreamReader sr = new StreamReader("..\\..\\..\\..\\..\\Fajlovi\\administrator.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] strings = line.Split(',');
                    if (trenutniNalog != strings[0])
                    {
                        administratori.Add(new Radnik(strings[0], strings[1], strings[2], strings[3]));
                    }
                }
            }
        }
        List<Radnik> radnici = new List<Radnik>();
        public void UcitajRadnike()
        {
            radnici.Clear();
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
        public void BrisanjeRadnickihNalogaButton_Click(object sender, EventArgs e)
        {
            BrisanjeRadnickihNalogaPanel.Visible = true;
            BrisanjeRadnickihNalogaPanel.BringToFront();
            BrisanjeRadnickihNalogaPanel.ResumeLayout();
            UcitajRadnike();
            ListaRadnickihNalogaComboBox.DataSource = radnici;
            ListaRadnickihNalogaComboBox.DisplayMember = "PrikaziFormat";
            ListaRadnickihNalogaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ListaRadnickihNalogaComboBox.Enabled = true;
        }

        public void NazadSaPanelaZaBrisanjeRadnickihNalogaNaPanelPrijavljenogAdministratoraButton_Click(object sender, EventArgs e)
        {
            ListaRadnickihNalogaComboBox.DataSource = radnici;
            ListaRadnickihNalogaComboBox.DisplayMember = "PrikaziFormat";
            ListaRadnickihNalogaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ListaRadnickihNalogaComboBox.Enabled = true;
            BrisanjeRadnickihNalogaPanel.Visible = false;
        }

        public bool PraznaListaRadnickihNaloga()
        {
            if (radnici.Count == 0 && BrisanjeRadnickihNalogaPanel.Visible == true)
            {
                MessageBox.Show("Lista radnika je prazna!", "Brisanje radnika", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BrisanjeRadnickihNalogaPanel.Visible = false;
                return true;
            }
            return false;
        }

        public void UkloniRadnickiNalog(string KorisnickoIme, string putanja)
        {
            string[] lines = File.ReadAllLines(putanja);
            bool nalogUklonjen = false;
            string pomFajl = Path.GetTempFileName();
            using (StreamWriter sw = new StreamWriter(pomFajl))
            {
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length > 0 && parts[0] == KorisnickoIme)
                    {
                        nalogUklonjen = true;
                        continue;
                    }
                    sw.WriteLine(line);
                }
            }
            string[] pom = putanja.Split("\\");
            string[] pom2 = pom[pom.Length - 1].Split(".");
            if (nalogUklonjen)
            {
                File.Delete(putanja);
                File.Move(pomFajl, putanja);
                MessageBox.Show($"Nalog '{KorisnickoIme}' je uspješno uklonjen!", "Brisanje " + pom2[0] + "a", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                File.Delete(pomFajl);
                MessageBox.Show($"Nalog '{KorisnickoIme}' ne postoji!", "Brisanje " + pom2[0] + "a", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ListaRadnickihNalogaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PraznaListaRadnickihNaloga();
        }

        public void ObrisiRadnickiNalogButton_Click(object sender, EventArgs e)
        {
            if (PraznaListaRadnickihNaloga())
                return;
            Radnik radnik = (Radnik)ListaRadnickihNalogaComboBox.SelectedItem;
            if (radnik != null /*(ListaRadnickihNalogaComboBox.SelectedIndex != -1) && radnici.Count > 0 /*&& (radnik != radnici[0])*/)
            {
                DialogResult dr = MessageBox.Show($"Da li ste sigurni da želite da uklonite nalog '{radnik.PrikaziFormat}'?", "Brisanje radnika", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    UkloniRadnickiNalog(radnik.Username, "..\\..\\..\\..\\..\\Fajlovi\\radnik.txt");
                    ListaRadnickihNalogaComboBox.DataSource = null;
                    radnici.Remove(radnik);
                    ListaRadnickihNalogaComboBox.DataSource = radnici;
                    ListaRadnickihNalogaComboBox.DisplayMember = "PrikaziFormat";
                    ListaRadnickihNalogaComboBox.SelectedIndex = -1;
                    ListaRadnickihNalogaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                    ListaRadnickihNalogaComboBox.Enabled = true;
                }
            }
        }

        public void PregledPostojecihNalogaButton_Click(object sender, EventArgs e)
        {
            PregledPostojecihNalogaPanel.Visible = true;
            PregledPostojecihNalogaPanel.BringToFront();
            PregledPostojecihNalogaPanel.ResumeLayout();
            funkcije funkcije = new funkcije();
            PregledPostojecihNalogaKlijentListBox.DataSource = funkcije.GetListOfAllAccountsKlijent();
            PregledPostojecihNalogaRadnikListBox.DataSource = funkcije.GetListOfAllAccountsRadnik();
            PregledPostojecihNalogaAdminListBox.DataSource = funkcije.GetListOfAllAccountsAdmin();
        }

        public void NazadSaPanelaZaPregledPostojecihNalogaNaPanelPrijavljenogAdministratoraButton_Click(object sender, EventArgs e)
        {
            PregledPostojecihNalogaPanel.Visible = false;
        }


        private void NazadSaPanelaZaBrisanjeAdministratorskihNalogaNaPanelPrijavljenogAdministratoraButton_Click(object sender, EventArgs e)
        {
            ListaAdministratorskihNalogaComboBox.DataSource = administratori;
            ListaAdministratorskihNalogaComboBox.DisplayMember = "PrikaziFormat";
            ListaAdministratorskihNalogaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ListaAdministratorskihNalogaComboBox.Enabled = true;
            BrisanjeAdministratorskihNalogaPanel.Visible = false;
        }

        public bool PraznaListaAdministratorskihNaloga()
        {
            if (administratori.Count == 0 && BrisanjeAdministratorskihNalogaPanel.Visible == true)
            {
                MessageBox.Show("Lista administratora je prazna!", "Brisanje administratora", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        private void ListaAdministratorskihNalogaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PraznaListaAdministratorskihNaloga();
        }

        private void ObrisiAdministratorskiNalogButton_Click(object sender, EventArgs e)
        {
            if (PraznaListaAdministratorskihNaloga())
                return;
            Radnik admin = (Radnik)ListaAdministratorskihNalogaComboBox.SelectedItem;
            if (admin != null)
            {
                DialogResult dr = MessageBox.Show($"Da li ste sigurni da želite da uklonite nalog '{admin.PrikaziFormat}'?", "Brisanje administratora", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    UkloniRadnickiNalog(admin.Username, "..\\..\\..\\..\\..\\Fajlovi\\administrator.txt");
                    ListaAdministratorskihNalogaComboBox.DataSource = null;
                    administratori.Remove(admin);
                    ListaAdministratorskihNalogaComboBox.DataSource = administratori;
                    ListaAdministratorskihNalogaComboBox.DisplayMember = "PrikaziFormat";
                    ListaAdministratorskihNalogaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                    ListaAdministratorskihNalogaComboBox.Enabled = true;
                }
            }
        }

        private void PrijaviSeRadnikButton_Click(object sender, EventArgs e)
        {
            funkcije f = new funkcije();
            if (f.provjeraLogInPodataka(KorisnickoImeRadnikaTextBoxLogin.Text, LozinkaRadnikaTextBoxLogin.Text, "..\\..\\..\\..\\..\\Fajlovi\\radnik.txt"))
            {
                //MessageBox.Show("Uspješno ste se prijavili!", "Prijava", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RadnikPanel.Visible = true;
                RadnikPanel.BringToFront();
                IndikatorNaKomStePanelu.Text = "Radnik: " + KorisnickoImeRadnikaTextBoxLogin.Text;
                trenutniNalog = KorisnickoImeRadnikaTextBoxLogin.Text;
                KorisnickoImeRadnikaTextBoxLogin.Text = "";
                LozinkaRadnikaTextBoxLogin.Text = "";
            }
        }

        private void NazadSaLogovanogRadnikaNaIzborniPanelButton_Click(object sender, EventArgs e)
        {
            LoginRadnikaPanel.Visible = false;
            IndikatorNaKomStePanelu.Text = "";
        }

        private void OdjavaLogovanogKlijentaButton_Click(object sender, EventArgs e)
        {
            LogovanKlijentPanel.Visible = false;
            IndikatorNaKomStePanelu.Text = "";
            KlijentPanel.Visible = false;
            IzborniPanel.Visible = true;
        }

        // REGISTRACIJA VOZILA RADNIK-----------------------------------------------------------------------

        private void button_registracijaVozila_Click(object sender, EventArgs e)
        {
            panel_registracijaVozila.Visible = true;
        }

        private void button_registracijaVozila_otkazi_Click(object sender, EventArgs e)
        {
            panel_registracijaVozila.Visible = false;
            textBox_registracijaVozila_brojSasije.Text = string.Empty;
            label_registracijaVozila_generisanaTablica.Text = string.Empty;
            panel1_placanjeKazne.Visible = false;
            panel_registracijaVozila_provjeraKazne.Visible = true;
            label_registracijaVozila_generisanStiker.Text = string.Empty;
            textbox_registracijaVozila_unosPolise.Text = string.Empty;
            textBox_registracijaVozila_brojSasije.Enabled = true;
        }

        private void button_registracijaVozila_registruj_Click(object sender, EventArgs e)
        {
            funkcije funkcije = new funkcije();
            if (textBox_registracijaVozila_brojSasije.Text == string.Empty)
            {
                MessageBox.Show("Niste unijeli broj šasije!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!funkcije.provjeraBrojaSasije(textBox_registracijaVozila_brojSasije.Text))
            {
                MessageBox.Show("Vozilo sa ovim brojem šasije ne postoji!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (panel_registracijaVozila_provjeraKazne.Visible == true)
            {
                if (funkcije.DaLiPostojiFajlSaKaznama(funkcije.PronadjiJmbPrekoBrojaSasije(textBox_registracijaVozila_brojSasije.Text)))
                {
                    listaKazni.Items.Clear();
                    // TODO Dodati string koji cuva maticni broj logovanog klijenta
                    string maticniBroj = funkcije.PronadjiJmbPrekoBrojaSasije(textBox_registracijaVozila_brojSasije.Text);

                    using (StreamReader sr = new StreamReader("..\\..\\..\\..\\..\\kazne\\" + maticniBroj + ".txt"))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            string[] podaci = line.Split(',');
                            listaKazni.Items.Add(podaci[0] + " - Cijena: " + podaci[1] + "KM");
                        }
                    }

                    if (listaKazni.Items.Count == 0)
                    {
                        panel_registracijaVozila_provjeraKazne.Visible = false;
                        textBox_registracijaVozila_brojSasije.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Vlasnik vozila " + textBox_registracijaVozila_brojSasije.Text + " ima neplaćenih kazni.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        panel1_placanjeKazne.Visible = true;
                    }
                }
                else
                {
                    panel_registracijaVozila_provjeraKazne.Visible = false;
                    textBox_registracijaVozila_brojSasije.Enabled = false;
                }
            }
            else
            {
                if (funkcije.registracijaVozila(textBox_registracijaVozila_brojSasije.Text, label_registracijaVozila_generisanStiker.Text, label_registracijaVozila_generisanaTablica.Text, textbox_registracijaVozila_unosPolise.Text))
                {
                    panel_registracijaVozila.Visible = false;
                    textBox_registracijaVozila_brojSasije.Text = string.Empty;
                    label_registracijaVozila_generisanaTablica.Text = string.Empty;
                    panel1_placanjeKazne.Visible = false;
                    panel_registracijaVozila_provjeraKazne.Visible = true;
                    label_registracijaVozila_generisanStiker.Text = string.Empty;
                    textbox_registracijaVozila_unosPolise.Text = string.Empty;
                    textBox_registracijaVozila_brojSasije.Enabled = true;
                }
            }
        }
        private void textBox_registracijaVozila_brojSasije_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //trigger button click event
                button_registracijaVozila_registruj_Click(sender, e);

                e.Handled = true; // Prevent the "ding" sound
            }
        }

        private void button_registracijaVozila_generisiStiker_Click(object sender, EventArgs e)
        {
            funkcije funkcije = new funkcije();
            label_registracijaVozila_generisanStiker.Text = funkcije.generisiStiker();
        }

        //---------------------------------------------------------------------------------------------------

        private void listaKazni_DoubleClick(object sender, EventArgs e)
        {
            funkcije funkcije = new funkcije();
            if (listaKazni.SelectedIndex != -1)
            {

                DialogResult result = MessageBox.Show("Da li želite platiti kaznu?", "Plaćanje kazne", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string jmb = funkcije.PronadjiJmbPrekoBrojaSasije(textBox_registracijaVozila_brojSasije.Text);

                    string[] lines = File.ReadAllLines("..\\..\\..\\..\\..\\kazne\\" + jmb + ".txt");
                    string pomFajl = Path.GetTempFileName();
                    using (StreamWriter sw = new StreamWriter(pomFajl))
                    {
                        foreach (string line in lines)
                        {
                            string[] parts = line.Split(',');;
                            if (parts.Length > 0 && parts[0] == listaKazni.SelectedItem.ToString().Split('-')[0].Trim())
                            {
                                continue;
                            }
                            sw.WriteLine(line);
                        }
                    }
                    File.Delete("..\\..\\..\\..\\..\\kazne\\" + jmb + ".txt");
                    File.Move(pomFajl, "..\\..\\..\\..\\..\\kazne\\" + jmb + ".txt");

                    if (listaKazni.Items.Count == 0)
                    {
                        MessageBox.Show("Nemate kazni za plaćanje!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        panel1_placanjeKazne.Visible = false;
                    }
                    listaKazni.Items.RemoveAt(listaKazni.SelectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Niste izabrali kaznu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //GENRISANJE TABLICE--------------------------------------------------------------------------------------------------

        private void button_registracijaVozila_generisiTablicu_Click(object sender, EventArgs e)
        {
            panel_generisanjeTablice.Visible = true;
        }

        private void button_personalizovaneTablice_Click(object sender, EventArgs e)
        {
            GenerisiTabliceDugme.Visible = true;
            TriCifreLabela.Visible = true;
            button_nasumicneTablice.Enabled = false;
            CustomUnos.Visible = true;
        }

        private void CustomUnos_TextChanged(object sender, EventArgs e)
        {
            if (CustomUnos.Text.Length == 3)
            {
                GenerisiTabliceDugme.Enabled = true;
            }
            else GenerisiTabliceDugme.Enabled = false;
        }

        private void CustomUnos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Smijete unositi samo cifre!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (!char.IsControl(e.KeyChar) && CustomUnos.Text.Length > 2)
            {
                e.Handled = true;
                MessageBox.Show("Mozete unijeti samo 3 cifre!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegistarskeTablice_TextChanged(object sender, EventArgs e)
        {

        }

        private void GenerisiTabliceDugme_Click(object sender, EventArgs e)
        {
            funkcije funkcije = new funkcije();
            Random random = new Random();
            string tablice;
            char[] slova = ['A', 'E', 'T', 'K', 'J', 'O', 'M'];
            do
            {
                if (GenerisiTabliceDugme.Visible == true && TriCifreLabela.Visible == true && CustomUnos.Visible == true)
                {
                    char[] randomSlova = { slova[random.Next(0, slova.Length - 1)], slova[random.Next(0, slova.Length - 1)] };
                    char[] randomBrojevi = [(char)random.Next('0', '9' + 1), (char)random.Next('0', '9' + 1)];
                    tablice = $"{randomSlova[1]}{randomBrojevi[0]}{randomBrojevi[1]}-{randomSlova[0]}-{CustomUnos.Text}";
                }
                else
                {
                    char[] randomSlova = [slova[random.Next(slova.Length)], slova[random.Next(slova.Length)]];
                    char[] randomBrojevi = [(char)random.Next('0', '9' + 1), (char)random.Next('0', '9' + 1), (char)random.Next('0', '9' + 1), (char)random.Next('0', '9' + 1), (char)random.Next('0', '9' + 1)];
                    tablice = $"{randomSlova[1]}{randomBrojevi[0]}{randomBrojevi[1]}-{randomSlova[0]}-{randomBrojevi[2]}{randomBrojevi[3]}{randomBrojevi[4]}";
                }
            } while (funkcije.provjeriTablice(tablice));
            RegistarskeTablice.Text = tablice;
            label_registracijaVozila_generisanaTablica.Text = tablice;
            RegistarskeTablice.Visible = true;
        }

        private void button_nasumicneTablice_Click(object sender, EventArgs e)
        {
            button_personalizovaneTablice.Enabled = false;
            GenerisiTabliceDugme.Enabled = true;
            GenerisiTabliceDugme.Visible = true;
        }

        private void button_generisanjeTablice_nazad_Click(object sender, EventArgs e)
        {
            panel_generisanjeTablice.Visible = false;
            GenerisiTabliceDugme.Visible = false;
            TriCifreLabela.Visible = false;
            CustomUnos.Visible = false;
            GenerisiTabliceDugme.Enabled = false;
            RegistarskeTablice.Text = "";
            RegistarskeTablice.Visible = false;
            button_nasumicneTablice.Enabled = true;
            button_personalizovaneTablice.Enabled = true;
        }

        //---------------------------------------------------------------------------------------------------------------------

        // KLIJENT PANEL--------------------------------------------------------------------------------------------------------

        private void button_to_pregledPodatakaoRegistracijama_Click(object sender, EventArgs e)
        {
            funkcije f = new funkcije();
            panel_pregledPodatakaoRegistracijama.Visible = true;
            listbox_pregledPodatakaoRegistracijama.DataSource = f.ListaVozilaOdNaloga(trenutniNalog);
        }
        private void button_pregledPodatakaoRegistracijama_nazad_Click(object sender, EventArgs e)
        {
            panel_pregledPodatakaoRegistracijama.Visible = false;
        }

        private void button_to_placanjeKazniKlijent_Click(object sender, EventArgs e)
        {
            //Dodati string koji cuva maticni broj logovanog klijenta
            funkcije f = new funkcije();
            string maticniBroj = f.PronadjiJmbNaOsnovuNaloga(trenutniNalog);
            using (StreamReader sr = new StreamReader("..\\..\\..\\..\\..\\kazne\\" + maticniBroj + ".txt"))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] podaci = line.Split(',');
                    if (podaci[2] == "N")
                        listbox_placanjeKazniKlijent.Items.Add(podaci[0] + " - Cijena: " + podaci[1] + "KM");
                }
            }

            if (listbox_placanjeKazniKlijent.Items.Count == 0)
            {
                MessageBox.Show("Nemate kazni za plaćanje!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                panel_placanjeKazniKlijent.Visible = true;
            }
        }
        private void listbox_placanjeKazniKlijent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listbox_placanjeKazniKlijent.SelectedIndex != -1)
            {
                List<string[]> podaci = new List<string[]>();

                DialogResult result = MessageBox.Show("Da li želite platiti kaznu?", "Plaćanje kazne", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                funkcije f = new funkcije();
                string maticniBroj = f.PronadjiJmbNaOsnovuNaloga(trenutniNalog);
                if (result == DialogResult.Yes)
                {
                    using (StreamReader sr = new StreamReader("..\\..\\..\\..\\..\\kazne\\" + maticniBroj + ".txt"))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            podaci.Add(line.Split(','));
                        }
                    }
                    using (StreamWriter sw = new StreamWriter("..\\..\\..\\..\\..\\kazne\\" + maticniBroj + ".txt"))
                    {
                        string kazna = listbox_placanjeKazniKlijent.SelectedItem.ToString();
                        for (int i = 0; i < podaci.Count; i++)
                        {
                            if (kazna.Contains(podaci[i][0]))
                            {
                                sw.WriteLine(podaci[i][0] + "," + podaci[i][1] + "," + "P");
                            }
                            else
                            {
                                sw.WriteLine(podaci[i][0] + "," + podaci[i][1] + "," + podaci[i][2]);
                            }
                        }
                    }

                    listbox_placanjeKazniKlijent.Items.RemoveAt(listbox_placanjeKazniKlijent.SelectedIndex);
                    if (listbox_placanjeKazniKlijent.Items.Count == 0)
                    {
                        MessageBox.Show("Nemate kazni za plaćanje!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        panel_placanjeKazniKlijent.Visible = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Niste izabrali kaznu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button_placanjeKazniKlijent_nazad_Click(object sender, EventArgs e)
        {
            panel_placanjeKazniKlijent.Visible = false;
            listbox_placanjeKazniKlijent.Items.Clear();
        }


        //---------------------------------------------------------------------------------------------------------------------

        // BRISANJE I PROMJENA PODATAKA KLIJENTA--------------------------------------------------------------------------------

        private void PromjenaPodatakaButton_Click(object sender, EventArgs e)
        {
            string lozinka = Interaction.InputBox("Unesite lozinku da biste pristupili pomjeni podataka", "Promjena podataka", "lozinka", -1, -1);
            string[] lines = File.ReadAllLines("..\\..\\..\\..\\..\\Fajlovi\\klijent.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                string[] podaci = lines[i].Split(',');
                if (podaci[0] == trenutniNalog)
                {
                    if (podaci[1] == lozinka)
                    {
                        PromjenaPodatakaPanel.Visible = true;
                        PromjenaPodatakaPanel.BringToFront();
                        PromjenaPodatakaPanel.ResumeLayout();
                        if (PromjenaKorisnickogImenaRadioButton.Checked || PromjenaLozinkeRadioButton.Checked || PromjenaBrojaLicneKarteRadioButton.Checked || PromjenaBrojaZiroRacunaRadioButton.Checked)
                        {
                            PotvrdiPromjenuPodatakaButton.Enabled = true;
                        }
                        else
                        {
                            PotvrdiPromjenuPodatakaButton.Enabled = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Pogrešna lozinka!", "Promjena podataka", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                }
            }
        }


        private void NazadSaPromjenePodatakaNaLogovanogKlijenta_Click(object sender, EventArgs e)
        {
            PromjenaPodatakaPanel.Visible = false;
            PromjenaBrojaZiroRacunaRadioButton.Checked = false;
            PromjenaBrojaLicneKarteRadioButton.Checked = false;
            PromjenaKorisnickogImenaRadioButton.Checked = false;
            PromjenaLozinkeRadioButton.Checked = false;
            PotvrdiPromjenuPodatakaButton.Enabled = false;
            PotvrdaPromjeneLozinkeTextBox.Visible = false;
            PromjenaPodatakaTextBox.PasswordChar = '\0';
            PotvrdaPromjeneLozinkeLabel.Visible = false;
            PromjenaPodatakaLabel.Visible = false;
            PromjenaPodatakaTextBox.Text = "";
        }


        private void BrisanjeNalogaButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Da li ste sigurni da želite da obrišete nalog?", "Brisanje naloga", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string[] lines = File.ReadAllLines("..\\..\\..\\..\\..\\Fajlovi\\klijent.txt");
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] podaci = lines[i].Split(',');
                    if (podaci[0] == trenutniNalog)
                    {
                        funkcije f = new funkcije();
                        f.DeleteLineFromFile("..\\..\\..\\..\\..\\Fajlovi\\klijent.txt", i);
                        break;
                    }
                }
                LogovanKlijentPanel.Visible = false;
                IndikatorNaKomStePanelu.Text = "";
                KlijentPanel.Visible = false;
                IzborniPanel.Visible = true;
            }
        }

        private void PromjenaLozinkeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            PotvrdiPromjenuPodatakaButton.Enabled = true;
            PotvrdaPromjeneLozinkeTextBox.Visible = true;
            PromjenaPodatakaTextBox.PasswordChar = '*';
            PotvrdaPromjeneLozinkeLabel.Visible = true;
            PromjenaPodatakaLabel.Text = "Nova lozinka:";
            PromjenaPodatakaLabel.Visible = true;
        }

        private void PromjenaBrojaZiroRacunaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            PotvrdiPromjenuPodatakaButton.Enabled = true;
            PotvrdaPromjeneLozinkeTextBox.Visible = false;
            PromjenaPodatakaTextBox.PasswordChar = '\0';
            PotvrdaPromjeneLozinkeLabel.Visible = false;
            PromjenaPodatakaLabel.Text = "Novi broj žiro računa:";
            PromjenaPodatakaLabel.Visible = true;
        }

        private void PromjenaKorisnickogImenaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            PotvrdiPromjenuPodatakaButton.Enabled = true;
            PotvrdaPromjeneLozinkeTextBox.Visible = false;
            PromjenaPodatakaTextBox.PasswordChar = '\0';
            PotvrdaPromjeneLozinkeLabel.Visible = false;
            PromjenaPodatakaLabel.Text = "Novo korisničko ime:";
            PromjenaPodatakaLabel.Visible = true;
        }

        private void PromjenaBrojaLicneKarteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            PotvrdiPromjenuPodatakaButton.Enabled = true;
            PotvrdaPromjeneLozinkeTextBox.Visible = false;
            PromjenaPodatakaTextBox.PasswordChar = '\0';
            PotvrdaPromjeneLozinkeLabel.Visible = false;
            PromjenaPodatakaLabel.Text = "Novi broj lične karte:";
            PromjenaPodatakaLabel.Visible = true;
        }

        private void PotvrdiPromjenuPodatakaButton_Click(object sender, EventArgs e)
        {
            if (PromjenaKorisnickogImenaRadioButton.Checked)
            {
                if (PromjenaPodatakaTextBox.Text == "")
                {
                    MessageBox.Show("Polje za unos korisničkog imena ne smije biti prazno!", "Promjena korisničkog imena", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                funkcije f = new funkcije();
                if (!f.ProvjeriValidnostKorisnickogImena(PromjenaPodatakaTextBox.Text))
                {
                    MessageBox.Show("Korisničko ime nije validno!", "Registracija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                /////////////////////
                if (!f.provjeraKorisnickogImena(PromjenaPodatakaTextBox.Text, "..\\..\\..\\..\\..\\Fajlovi\\klijent.txt"))
                {
                    return;
                }
                string[] lines = File.ReadAllLines("..\\..\\..\\..\\..\\Fajlovi\\klijent.txt");
                for (int i = 0; i < lines.Length; i++)
                {
                    
                    string[] podaci = lines[i].Split(',');
                    if (podaci[0] == trenutniNalog)
                    {
                        podaci[0] = PromjenaPodatakaTextBox.Text;
                        string novaLinija = "";
                        for (int j = 0; j < podaci.Length - 1; j++)
                        {
                            novaLinija += podaci[j] + ",";
                        }
                        novaLinija += podaci[podaci.Length - 1];
                        
                        f.ChangeLineInFile("..\\..\\..\\..\\..\\Fajlovi\\klijent.txt", i, novaLinija);
                        trenutniNalog = PromjenaPodatakaTextBox.Text;
                        break;
                    }
                }
                trenutniNalog = PromjenaPodatakaTextBox.Text;
                IndikatorNaKomStePanelu.Text = "Klijent: " + trenutniNalog;
                MessageBox.Show("Uspješno ste promijenili korisničko ime!", "Promjena korisničkog imena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PromjenaPodatakaPanel.Visible = false;
                PromjenaBrojaLicneKarteRadioButton.Checked = false;
                PromjenaBrojaZiroRacunaRadioButton.Checked = false;
                PromjenaKorisnickogImenaRadioButton.Checked = false;
                PromjenaLozinkeRadioButton.Checked = false;
                PotvrdiPromjenuPodatakaButton.Enabled = false;
                PotvrdaPromjeneLozinkeTextBox.Visible = false;
                PromjenaPodatakaTextBox.PasswordChar = '\0';
                PotvrdaPromjeneLozinkeLabel.Visible = false;
                PromjenaPodatakaLabel.Visible = false;
                PromjenaPodatakaTextBox.Text = "";
            }
            else if (PromjenaLozinkeRadioButton.Checked)
            {
                if (PromjenaPodatakaTextBox.Text == "")
                {
                    MessageBox.Show("Polje za unos lozinke ne smije biti prazno!", "Promjena lozinke", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (PromjenaPodatakaTextBox.Text.Length < 8 || PromjenaPodatakaTextBox.Text.Length > 32)
                {
                    MessageBox.Show("Lozinka mora imati između 8 i 32 karaktera!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (PotvrdaPromjeneLozinkeTextBox.Text == "")
                {
                    MessageBox.Show("Niste potvrdili lozinku!", "Potvrda promjene lozinke", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (PromjenaPodatakaTextBox.Text != PotvrdaPromjeneLozinkeTextBox.Text)
                {
                    MessageBox.Show("Lozinka i potvrda lozinke se ne poklapaju!", "Promjena lozinke", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string[] lines = File.ReadAllLines("..\\..\\..\\..\\..\\Fajlovi\\klijent.txt");
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] podaci = lines[i].Split(',');
                    if (podaci[0] == trenutniNalog)
                    {
                        podaci[1] = PromjenaPodatakaTextBox.Text;
                        string novaLinija = "";
                        for (int j = 0; j < podaci.Length - 1; j++)
                        {
                            novaLinija += podaci[j] + ",";
                        }
                        novaLinija += podaci[podaci.Length - 1];
                        funkcije f = new funkcije();
                        f.ChangeLineInFile("..\\..\\..\\..\\..\\Fajlovi\\klijent.txt", i, novaLinija);
                        break;
                    }
                }
                MessageBox.Show("Uspješno ste promijenili lozinku!", "Promjena lozinke", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PromjenaPodatakaPanel.Visible = false;
                PromjenaBrojaLicneKarteRadioButton.Checked = false;
                PromjenaBrojaZiroRacunaRadioButton.Checked = false;
                PromjenaKorisnickogImenaRadioButton.Checked = false;
                PromjenaLozinkeRadioButton.Checked = false;
                PotvrdiPromjenuPodatakaButton.Enabled = false;
                PotvrdaPromjeneLozinkeTextBox.Visible = false;
                PromjenaPodatakaTextBox.PasswordChar = '\0';
                PotvrdaPromjeneLozinkeLabel.Visible = false;
                PromjenaPodatakaLabel.Visible = false;
                PromjenaPodatakaTextBox.Text = "";
            }
            else if (PromjenaBrojaLicneKarteRadioButton.Checked)
            {
                if (PromjenaPodatakaTextBox.Text == "")
                {
                    MessageBox.Show("Polje za unos broja lične karte ne smije biti prazno!", "Promjena broja lične karte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string[] lines = File.ReadAllLines("..\\..\\..\\..\\..\\Fajlovi\\klijent.txt");
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] podaci = lines[i].Split(',');
                    if (podaci[0] == trenutniNalog)
                    {
                        podaci[4] = PromjenaPodatakaTextBox.Text;
                        string novaLinija = "";
                        for (int j = 0; j < podaci.Length - 1; j++)
                        {
                            novaLinija += podaci[j] + ",";
                        }
                        novaLinija += podaci[podaci.Length - 1];
                        funkcije f = new funkcije();
                        f.ChangeLineInFile("..\\..\\..\\..\\..\\Fajlovi\\klijent.txt", i, novaLinija);
                        break;
                    }
                }
                MessageBox.Show("Uspješno ste promijenili broj lične karte!", "Promjena broja lične karte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PromjenaPodatakaPanel.Visible = false;
                PromjenaBrojaLicneKarteRadioButton.Checked = false;
                PromjenaBrojaZiroRacunaRadioButton.Checked = false;
                PromjenaKorisnickogImenaRadioButton.Checked = false;
                PromjenaLozinkeRadioButton.Checked = false;
                PotvrdiPromjenuPodatakaButton.Enabled = false;
                PotvrdaPromjeneLozinkeTextBox.Visible = false;
                PromjenaPodatakaTextBox.PasswordChar = '\0';
                PotvrdaPromjeneLozinkeLabel.Visible = false;
                PromjenaPodatakaLabel.Visible = false;
                PromjenaPodatakaTextBox.Text = "";
            }
            else if (PromjenaBrojaZiroRacunaRadioButton.Checked)
            {
                if (PromjenaPodatakaTextBox.Text == "")
                {
                    MessageBox.Show("Polje za unos broja žiro računa ne smije biti prazno!", "Promjena broja žiro računa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (PromjenaPodatakaTextBox.Text.Length != 16)
                {
                    MessageBox.Show("Broj žiro računa mora imati 16 cifara!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string[] lines = File.ReadAllLines("..\\..\\..\\..\\..\\Fajlovi\\klijent.txt");
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] podaci = lines[i].Split(',');
                    if (podaci[0] == trenutniNalog)
                    {
                        podaci[5] = PromjenaPodatakaTextBox.Text;
                        string novaLinija = "";
                        for (int j = 0; j < podaci.Length - 1; j++)
                        {
                            novaLinija += podaci[j] + ",";
                        }
                        novaLinija += podaci[podaci.Length - 1];
                        funkcije f = new funkcije();
                        f.ChangeLineInFile("..\\..\\..\\..\\..\\Fajlovi\\klijent.txt", i, novaLinija);
                        break;
                    }
                }
                MessageBox.Show("Uspješno ste promijenili broj žiro računa!", "Promjena broja žiro računa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PromjenaPodatakaPanel.Visible = false;
                PromjenaBrojaLicneKarteRadioButton.Checked = false;
                PromjenaBrojaZiroRacunaRadioButton.Checked = false;
                PromjenaKorisnickogImenaRadioButton.Checked = false;
                PromjenaLozinkeRadioButton.Checked = false;
                PotvrdiPromjenuPodatakaButton.Enabled = false;
                PotvrdaPromjeneLozinkeTextBox.Visible = false;
                PromjenaPodatakaTextBox.PasswordChar = '\0';
                PotvrdaPromjeneLozinkeLabel.Visible = false;
                PromjenaPodatakaLabel.Visible = false;
                PromjenaPodatakaTextBox.Text = "";
            }   
        }

        //---------------------------------------------------------------------------------------------------------------------
        
    }
}
