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
        }

        private void RadnikButton_Click(object sender, EventArgs e)
        {
            RadnikPanel.Visible = true;
        }

        private void AdministratorButton_Click(object sender, EventArgs e)
        {
            AdministratorPanel.Visible = true;
        }

        private void NazadKlijentButton_Click(object sender, EventArgs e)
        {
            KlijentPanel.Visible = false;
        }

        private void NazadRadnikButton_Click(object sender, EventArgs e)
        {
            RadnikPanel.Visible = false;
        }

        private void NazadAdministratorButton_Click(object sender, EventArgs e)
        {
            AdministratorPanel.Visible = false;
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
                KorisnickoImeTextBoxLogin.Text = "";
                LozinkaTextBoxLogin.Text = "";
                // TODO: otvori formu za klijenta
            }
            /*else
            {
                MessageBox.Show("Pogrešno korisničko ime ili lozinka!", "Prijava", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
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

        private void KorisnickoImeTextBox_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Korisničko ime mora imati između 5 i 32 karaktera!\nDozvoljeni karakteri su samo slova, brojevi, donja crta i tačka.\nKorisničko ime ne smije počinjati brojem, tačkom ili sadržavati razmak.", "Korisničko ime", MessageBoxButtons.OK, MessageBoxIcon.Information);
            KorisnickoImeTextBox.Focus();
        }

        private void LozinkaTextBox_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Lozinka mora imati između 8 i 32 karaktera!\nLozinka ne smije sadržavati zarez, tab ili novi red.", "Lozinka", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LozinkaTextBox.Focus();
        }

        private void BrojZiroRacunaTextBox_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Broj žiro računa mora imati 16 cifara!", "Broj žiro računa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BrojZiroRacunaTextBox.Focus();
        }

        private void JMBGTextBox_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("JMBG mora imati 13 cifara!", "JMBG", MessageBoxButtons.OK, MessageBoxIcon.Information);
            JMBGTextBox.Focus();
        }
    }
}
