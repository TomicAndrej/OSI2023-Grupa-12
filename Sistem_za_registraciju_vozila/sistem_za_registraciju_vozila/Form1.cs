namespace sistem_za_registraciju_vozila
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
    }
}
