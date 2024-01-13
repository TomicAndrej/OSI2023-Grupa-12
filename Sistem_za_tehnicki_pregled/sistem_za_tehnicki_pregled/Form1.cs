namespace sistem_za_tehnicki_pregled
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void KlijentButton_Click(object sender, EventArgs e)
        {
            KlijentPanel.Visible = true;
            IndikatorNaKomStePanelu.Text = "Klijent";
            IndikatorNaKomStePanelu.BringToFront();
            IndikatorNaKomStePanelu.Visible = true;
        }

        private void RadnikButton_Click(object sender, EventArgs e)
        {
            RadnikPanel.Visible = true;
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
            IndikatorNaKomStePanelu.Text = "";
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
                MessageBox.Show("Uspješno ste se prijavili!", "Prijava", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IndikatorNaKomStePanelu.Text = "Klijent: " + KorisnickoImeTextBoxLogin.Text;
                KorisnickoImeTextBoxLogin.Text = "";
                LozinkaTextBoxLogin.Text = "";
                /* 
                 * 
                 * 
                 * TODO: otvori formu za klijenta
                 * 
                 * 
                 * 
                 */
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
                KorisnickoImeAdministratorTextBoxLogin.Text = "";
                LozinkaAdministratorTextBoxLogin.Text = "";
            }
        }

        private void OdjavaLogovanogAdministratoraButton_Click(object sender, EventArgs e)
        {
            LogovanAdministratorPanel.Visible = false;
            AdministratorPanel.Visible = false;
            RegistracijaAdministratorskihNalogaPanel.Visible = false;
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
    }
}
