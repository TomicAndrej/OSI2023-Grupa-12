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
            string red = "";
            red += ImeTextBox.Text + " ";
            red += PrezimeTextBox.Text + " ";
            red += KorisnickoImeTextBox.Text + " ";
            red += LozinkaTextBox.Text + " ";
            red += BrojLicneKarteTextBox.Text + " ";
            red += BrojZiroRacunaTextBox.Text + " ";
            red += JMBGTextBox.Text;
            FileStream fs = new FileStream(@"..\..\..\klijent.txt", FileMode.Append, FileAccess.Write);
            try
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(red);
                }
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
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri upisu u datoteku: " + ex.Message);
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
}
