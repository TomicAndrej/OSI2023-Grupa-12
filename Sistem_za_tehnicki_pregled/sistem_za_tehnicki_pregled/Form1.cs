using Microsoft.VisualBasic;
using System.Globalization;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace sistem_za_tehnicki_pregled
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InicijalizujPodatke();
            KategorijaComboBox.DataSource = new BindingSource(vozilaKategorije, null);
            KategorijaComboBox.DisplayMember = "Key";
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
                //MessageBox.Show("Uspješno ste se prijavili!", "Prijava", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void button_zakazivanjeTehnickog_Click(object sender, EventArgs e)
        {
            panel_zakazivanjeTermina1.Visible = !panel_zakazivanjeTermina1.Visible;
            button_zakazivanjeTermina1_pokreni.Enabled = true;
            textBox_zakazivanjeTermina1_brojSasije.Enabled = true;
        }

        private void button_zakazivanjeTermina1_otkazi_click(object sender, EventArgs e)
        {
            textBox_zakazivanjeTermina1_brojSasije.Text = string.Empty;
            textBox_zakazivanjeTermina2_kategorija.Text = string.Empty;
            textBox_zakazivanjeTermina2_potkategorija.Text = string.Empty;
            textBox_zakazivanjeTermina2_marka.Text = string.Empty;
            textBox_zakazivanjeTermina2_model.Text = string.Empty;
            textBox_zakazivanjeTermina2_godiste.Text = string.Empty;
            textBox_zakazivanjeTermina2_kubikaza.Text = string.Empty;
            textBox_zakazivanjeTermina2_stiker.Text = string.Empty;
            textBox_zakazivanjeTermina2_rokRegistracije.Text = string.Empty;
            dateTimePicker_zakazivanjeTermina3.Value = DateTime.Now;
            monthCalendar_zakazivanjeTermina3.SelectionStart = DateTime.Today;
            monthCalendar_zakazivanjeTermina3.SelectionEnd = DateTime.Today;
            panel_zakazivanjeTermina1.Visible = false;
            panel_zakazivanjeTermina3.Visible = false;
            panel_zakazivanjeTermina2.Visible = false;
        }

        private void button_zakazivanjeTermina3_zakaziTermin_click(object sender, EventArgs e)
        {
            string uneseniBrojSasije = textBox_zakazivanjeTermina1_brojSasije.Text;

            funkcije funkcije = new funkcije();
            bool voziloPostoji = funkcije.PretragaVozilaUFajluVozila(uneseniBrojSasije);

            DateTime selectedDate = monthCalendar_zakazivanjeTermina3.SelectionStart;
            string selectedDateFormatted = selectedDate.ToString("dd/MM/yyyy");

            DateTime selectedTime = dateTimePicker_zakazivanjeTermina3.Value;
            string selectedTimeFormatted = selectedTime.ToString("HH:mm");
            //TODO radnik mora unijeti jmb klijenta...(kod klijentskog zakazivanja se automatski uzima jmb klijenta funkcije.PronadjiJmbNaOsnovuNaloga(trenutniNalog))

            if (voziloPostoji)
            {
                if (funkcije.ZakaziTerminVoziloPostoji(uneseniBrojSasije, selectedDateFormatted, selectedTimeFormatted))
                {
                    textBox_zakazivanjeTermina1_brojSasije.Text = string.Empty;
                    textBox_zakazivanjeTermina2_kategorija.Text = string.Empty;
                    textBox_zakazivanjeTermina2_potkategorija.Text = string.Empty;
                    textBox_zakazivanjeTermina2_marka.Text = string.Empty;
                    textBox_zakazivanjeTermina2_model.Text = string.Empty;
                    textBox_zakazivanjeTermina2_godiste.Text = string.Empty;
                    textBox_zakazivanjeTermina2_kubikaza.Text = string.Empty;
                    textBox_zakazivanjeTermina2_stiker.Text = string.Empty;
                    textBox_zakazivanjeTermina2_rokRegistracije.Text = string.Empty;
                    dateTimePicker_zakazivanjeTermina3.Value = DateTime.Now;
                    monthCalendar_zakazivanjeTermina3.SelectionStart = DateTime.Today;
                    monthCalendar_zakazivanjeTermina3.SelectionEnd = DateTime.Today;
                    panel_zakazivanjeTermina1.Visible = false;
                    panel_zakazivanjeTermina3.Visible = false;
                    panel_zakazivanjeTermina2.Visible = false;
                }
            }
            else
            {
                string jmbKlijenta = Interaction.InputBox("Unesite JMB klijenta", "JMB klijenta", "jmb", -1, -1);
                if (funkcije.ZakaziTermin(jmbKlijenta, selectedDateFormatted, selectedTimeFormatted, textBox_zakazivanjeTermina2_kategorija.Text, textBox_zakazivanjeTermina2_potkategorija.Text, textBox_zakazivanjeTermina2_marka.Text, textBox_zakazivanjeTermina2_model.Text, textBox_zakazivanjeTermina2_godiste.Text, textBox_zakazivanjeTermina2_kubikaza.Text, uneseniBrojSasije, textBox_zakazivanjeTermina2_stiker.Text, textBox_zakazivanjeTermina2_rokRegistracije.Text))
                {
                    textBox_zakazivanjeTermina1_brojSasije.Text = string.Empty;
                    textBox_zakazivanjeTermina2_kategorija.Text = string.Empty;
                    textBox_zakazivanjeTermina2_potkategorija.Text = string.Empty;
                    textBox_zakazivanjeTermina2_marka.Text = string.Empty;
                    textBox_zakazivanjeTermina2_model.Text = string.Empty;
                    textBox_zakazivanjeTermina2_godiste.Text = string.Empty;
                    textBox_zakazivanjeTermina2_kubikaza.Text = string.Empty;
                    textBox_zakazivanjeTermina2_stiker.Text = string.Empty;
                    textBox_zakazivanjeTermina2_rokRegistracije.Text = string.Empty;
                    dateTimePicker_zakazivanjeTermina3.Value = DateTime.Now;
                    monthCalendar_zakazivanjeTermina3.SelectionStart = DateTime.Today;
                    monthCalendar_zakazivanjeTermina3.SelectionEnd = DateTime.Today;
                    panel_zakazivanjeTermina1.Visible = false;
                    panel_zakazivanjeTermina3.Visible = false;
                    panel_zakazivanjeTermina2.Visible = false;
                }
            }
        }
        //TODO kod zakazivanja termina bi se trebao dodati jmb klijenta i tablica vozila

        private void button_zakazivanjeTermina1_pokreni_Click(object sender, EventArgs e)
        {
            string uneseniBrojSasije = textBox_zakazivanjeTermina1_brojSasije.Text;
            funkcije funkcije = new funkcije();
            bool voziloImaTermin = funkcije.ProvjeraTerminaDatogVozila(uneseniBrojSasije);

            if (voziloImaTermin)
            {
                MessageBox.Show("Ovo vozilo već ima zakazan termin");
            }
            else
            {
                bool voziloPostoji = funkcije.PretragaVozilaUFajluVozila(uneseniBrojSasije);
                if (!voziloPostoji)
                {
                    panel_zakazivanjeTermina2.Visible = true;
                }
                else
                {
                    panel_zakazivanjeTermina3.Visible = true;
                }
                button_zakazivanjeTermina1_pokreni.Enabled = false;
                textBox_zakazivanjeTermina1_brojSasije.Enabled = false;
            }
        }
        private void textBox_zakazivanjeTermina1_brojSasije_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string uneseniBrojSasije = textBox_zakazivanjeTermina1_brojSasije.Text;
                funkcije funkcije = new funkcije();
                bool voziloImaTermin = funkcije.ProvjeraTerminaDatogVozila(uneseniBrojSasije);

                if (voziloImaTermin)
                {
                    MessageBox.Show("Ovo vozilo vec ima zakazan termin");
                }
                else
                {
                    bool voziloPostoji = funkcije.PretragaVozilaUFajluVozila(uneseniBrojSasije);
                    if (!voziloPostoji)
                    {
                        panel_zakazivanjeTermina2.Visible = true;
                    }
                    else
                    {
                        panel_zakazivanjeTermina3.Visible = true;
                    }
                }

                e.Handled = true; // Prevent the "ding" sound
            }
        }

        private void button_zakazivanjeTermina2_dalje_Click(object sender, EventArgs e)
        {
            panel_zakazivanjeTermina3.Visible = true;
            panel_zakazivanjeTermina2.Visible = false;
        }

        private void button_zakazivanjeTermina3_nazad_Click(object sender, EventArgs e)
        {
            panel_zakazivanjeTermina3.Visible = false;
            panel_zakazivanjeTermina2.Visible = true;
        }

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void button_obavljanjeTehnickog_Click(object sender, EventArgs e)
        {
            funkcije funkcije = new funkcije();
            listBox_obavljanjeTehnickog.DataSource = funkcije.GetAllTermini();
            panel_obavljanjeTehnickog.Visible = !panel_obavljanjeTehnickog.Visible;
        }

        private void button_obavljanjeTehnickog_otkazi_Click(object sender, EventArgs e)
        {
            panel_obavljanjeTehnickog.Visible = !panel_obavljanjeTehnickog.Visible;
        }

        private void listBox_obavljanjeTehnickog_DoubleClick(object sender, EventArgs e)
        {
            if (listBox_obavljanjeTehnickog.SelectedIndex != -1)
            {
                string selected = listBox_obavljanjeTehnickog.SelectedItem.ToString();
                string[] selectedSplit = selected.Split(',');
                string brojSasije = selectedSplit[4].Split(':')[1];
                string datum = selectedSplit[0].Split(':')[1];
                string vrijeme = selectedSplit[1].Split(':')[1];

                funkcije funkcije = new funkcije();
                bool uspjesno = funkcije.ObaviTehnicki(brojSasije, datum, vrijeme);

                if (uspjesno)
                {
                    MessageBox.Show("Uspjesno obavljen tehnicki pregled");
                    funkcije.IzdajPotvrduTP(brojSasije);
                }
                else
                {
                    MessageBox.Show("Niste prosli tehnicki pregled");
                }
                //funkcije.RemoveTermin(brojSasije);
                listBox_obavljanjeTehnickog.DataSource = funkcije.GetAllTermini();
            }
        }

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void button_prikazArhive_Click(object sender, EventArgs e)
        {
            panel_prikazArhive.Visible = !panel_prikazArhive.Visible;
            funkcije funkcije = new funkcije();
            listBox_prikazArhive.DataSource = funkcije.listaSvihIzvjestajaOIspravnosti();
        }

        private void button_prikazArhive_nazad_Click(object sender, EventArgs e)
        {
            panel_prikazArhive.Visible = !panel_prikazArhive.Visible;
        }

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void button_pregledIstorije_Click(object sender, EventArgs e)
        {
            panel_pregledIstorije.Visible = !panel_pregledIstorije.Visible;
            funkcije funkcije = new funkcije();
            listBox_pregledIstorije.DataSource = funkcije.listaIstorijeTP();
        }

        private void button_pregledIstorije_nazad_Click(object sender, EventArgs e)
        {
            panel_pregledIstorije.Visible = !panel_pregledIstorije.Visible;
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
                //AdministratorPanel.Visible = false;
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

        private void NazadSaPanelaZaPracenjeStatistikeNaPanelPrijavljenogAdministratoraButton_Click(object sender, EventArgs e)
        {
            PracenjeStatistikePanel.Visible = false;
        }

        private void PracenjeStatistikeButton_Click(object sender, EventArgs e)
        {
            PracenjeStatistikePanel.Visible = true;
            PracenjeStatistikePanel.BringToFront();
            PracenjeStatistikePanel.ResumeLayout();
        }

        private Dictionary<string, List<string>> vozilaKategorije = new Dictionary<string, List<string>>();
        public bool proslaIliNe;

        private void InicijalizujPodatke()
        {
            vozilaKategorije.Add("Izaberi kategoriju", new List<string>());
            vozilaKategorije.Add("KATEGORIJA M – Vozila za prevoz putnika", new List<string> { "Kategorija M1 – Putničko vozilo", "Kategorija M2 – Laki autobus", "Kategorija M3- Teški autobus" });
            vozilaKategorije.Add("KATEGORIJA L – Mopedi, Motocikli, Tricikli i Četvorocikli", new List<string> { "Kategorija L1 – Moped", "Kategorija L2 – Laki tricikl", "Kategorija L3 – Motocikl", "Kategorija L4 – Motocikl sa bočnim sedištem", "Kategorija L5 – Teški tricikl", "Kategorija L6 – Laki četvorocikl (quad)", "Kategorija L7 – Teški četvorocikl (quad)" });
            vozilaKategorije.Add("KATEGORIJA N – Teretna vozila", new List<string> { "Kategorija N1 - Vozila namenjena za prevoz robe čija najveća masa ne prelazi 3,5t.", "Kategorija N2 - Vozila namenjena za prevoz robe čija je najveća masa veća od 3,5t, ali manja od 12t.", "Kategorija N3 - Vozila namenjena za prevoz robe čija najveća masa prelazi 12t." });
            vozilaKategorije.Add("KATEGORIJA O – Priključna vozila", new List<string> { "Kategorija O1 – Prikolice čija najveća masa ne prelazi 0,75t.", "Kategorija O2 – Prikolice čija je najveća masa veća od 0,75t, ali ne prelazi iznad 3,5t.", "Kategorija O3 – Prikolice čija je masa veća od 3,5t, ali ne prelazi iznad 10t.", "Kategorija O4 – Prikolice čija najveća masa prelazi 10t." });
            vozilaKategorije.Add("KATEGORIJA T – Traktori", new List<string>());
            vozilaKategorije.Add("KATEGORIJA R – Priključno vozilo traktora", new List<string>());
            vozilaKategorije.Add("KATEGORIJA G – Terenska vozila", new List<string>());
        }

        private void VozilaKojaNisuProslaTehnickiButton_Click(object sender, EventArgs e)
        {
            PrikazStatistikePanel.Visible = true;
            PrikazStatistikePanel.BringToFront();
            PrikazStatistikePanel.ResumeLayout();
            StatistikaRichTextBox.Clear();
            proslaIliNe = false;
        }

        private void VozilaKojaSuProslaTehnickiButton_Click(object sender, EventArgs e)
        {
            PrikazStatistikePanel.Visible = true;
            PrikazStatistikePanel.BringToFront();
            PrikazStatistikePanel.ResumeLayout();
            StatistikaRichTextBox.Clear();
            proslaIliNe = true;
        }

        private void NazadSaPanelaZaPrikazStatistikeNaPanelZaPracenjeStatistikeButton_Click(object sender, EventArgs e)
        {
            PrikazStatistikePanel.Visible = false;
        }

        bool provjeraTehnickogPregleda(string line, int rBrReda)
        {
            string[] podaci = line.Split(',');
            string novaLinija = "";
            for (int i = 0; i < 10; i++)
            {
                novaLinija += podaci[i] + ",";
            }
            if (podaci[12] == "True")
            {
                return true;
            }
            else if (podaci[10] == "True")
            {
                DateTime.TryParseExact(podaci[9], "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime datumTehnickog);
                if (datumTehnickog.AddMonths(1) < DateTime.Now)
                {
                    novaLinija += "False,";
                    for (int i = 11; i < podaci.Length - 1; i++)
                    {
                        novaLinija += podaci[i] + ",";
                    }
                    novaLinija += podaci[podaci.Length - 1];
                    funkcije f = new funkcije();
                    f.ChangeLineInFile("..\\..\\..\\..\\..\\Fajlovi\\vozila.txt", rBrReda, novaLinija);
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public string ispis(string[] podaci)
        {
            string klijentIme = "", klijentPrezime = "", jmbg = "";
            using (StreamReader sr = new StreamReader("..\\..\\..\\..\\..\\Fajlovi\\klijent.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Split(',')[6] == podaci[2])
                    {
                        klijentIme = line.Split(',')[2];
                        klijentPrezime = line.Split(',')[3];
                        jmbg = line.Split(',')[6];
                        break;
                    }
                }
            }
            string result = "";
            result += klijentIme + " ";
            result += klijentPrezime + "(" + jmbg + "): ";
            result += podaci[0].Trim() + " ";
            if (podaci[1].Length > 0)
            {
                result += podaci[1].Trim() + " ";
            }
            result += podaci[3].Trim() + " ";
            result += podaci[4].Trim() + " ";
            result += podaci[5].Trim() + " ";
            result += podaci[11].Trim() + " ";
            return result;
        }

        private void PrikazStatistikeUPrikazuStatistikeButton_Click(object sender, EventArgs e)
        {
            StatistikaRichTextBox .Clear();
            string kategorija = ((KeyValuePair<string, List<string>>)KategorijaComboBox.SelectedItem).Key;
            if (KategorijaComboBox.SelectedItem != null && PotkategorijaComboBox.SelectedItem == null)
            {
                string[] lines = File.ReadAllLines("..\\..\\..\\..\\..\\Fajlovi\\vozila.txt");
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] podaci = lines[i].Split(',');
                    string kategorijaVozila = podaci[0].Trim();
                    if (proslaIliNe == true && kategorijaVozila[0] == kategorija[11] && provjeraTehnickogPregleda(lines[i], i))
                    {
                        StatistikaRichTextBox.AppendText(ispis(podaci) + "\n");
                    }
                    else if (proslaIliNe == false && kategorijaVozila[0] == kategorija[11] && !provjeraTehnickogPregleda(lines[i], i))
                    {
                        StatistikaRichTextBox.AppendText(ispis(podaci) + "\n");
                    }
                }
            }
            else if (KategorijaComboBox.SelectedItem != null && PotkategorijaComboBox.SelectedItem != null)
            {
                string[] lines = File.ReadAllLines("..\\..\\..\\..\\..\\Fajlovi\\vozila.txt");
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] podaci = lines[i].Split(',');
                    string kategorijaVozila = podaci[0].Trim();
                    string podkategorijaVozila = podaci[1].Trim();
                    if (proslaIliNe == true && kategorijaVozila[0] == kategorija[11] && podkategorijaVozila == PotkategorijaComboBox.SelectedItem.ToString().Split(" ")[1] && provjeraTehnickogPregleda(lines[i], i))
                    {
                        StatistikaRichTextBox.AppendText(ispis(podaci) + "\n");
                    }
                    else if (proslaIliNe == false && kategorijaVozila[0] == kategorija[11] && podkategorijaVozila == PotkategorijaComboBox.SelectedItem.ToString().Split(" ")[1] && !provjeraTehnickogPregleda(lines[i], i))
                    {
                        StatistikaRichTextBox.AppendText(ispis(podaci) + "\n");
                    }
                }
            }
        }

        private void KategorijaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (KategorijaComboBox.SelectedItem != null)
            {
                string odabranaKategorija = ((KeyValuePair<string, List<string>>)KategorijaComboBox.SelectedItem).Key;
                if (vozilaKategorije[odabranaKategorija].Any())
                {
                    List<string> podkategorije = vozilaKategorije[odabranaKategorija];
                    PotkategorijaComboBox.DataSource = podkategorije;
                    PotkategorijaComboBox.Enabled = true;
                }
                else
                {
                    PotkategorijaComboBox.DataSource = null;
                    PotkategorijaComboBox.Enabled = false;
                }
            }
        }
    }
}
