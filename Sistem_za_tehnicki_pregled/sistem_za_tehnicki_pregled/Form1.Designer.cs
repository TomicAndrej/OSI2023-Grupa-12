using System.Configuration;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace sistem_za_tehnicki_pregled
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            IzborniPanel = new Panel();
            IndikatorNaKomStePanelu = new Label();
            KlijentPanel = new Panel();
            RegistracijaNalogaPanel = new Panel();
            NazadSaRegistracijeNaLoginButton = new Button();
            RegistrujNalogButton = new Button();
            JMBGLabel = new Label();
            BrojZiroRacunaLabel = new Label();
            BrojLicneKarteLabel = new Label();
            PotvrdaLozinkeLabel = new Label();
            LozinkaLabel = new Label();
            KorisnickoImeLabel = new Label();
            PrezimeLabel = new Label();
            ImeLabel = new Label();
            JMBGTextBox = new TextBox();
            BrojZiroRacunaTextBox = new TextBox();
            BrojLicneKarteTextBox = new TextBox();
            PotvrdaLozinkeTextBox = new TextBox();
            LozinkaTextBox = new TextBox();
            KorisnickoImeTextBox = new TextBox();
            PrezimeTextBox = new TextBox();
            ImeTextBox = new TextBox();
            RegistrujSeButton = new Button();
            NisteRegistrovaniLabel = new Label();
            PrijaviSeButton = new Button();
            LozinkaLabelLogin = new Label();
            LozinkaTextBoxLogin = new TextBox();
            KorisnickoImeTextBoxLogin = new TextBox();
            KorisnickoImeLabelLogin = new Label();
            NazadKlijentButton = new Button();
            LogovanKlijentPanel = new Panel();
            OdjavaLogovanogKlijentaButton = new Button();
            PromjenaPodatakaButton = new Button();
            PromjenaPodatakaPanel = new Panel();
            NazadSaPromjenePodatakaNaLogovanogKlijenta = new Button();
            PotvrdiPromjenuPodatakaButton = new Button();
            PromjenaPodatakaTextBox = new TextBox();
            PotvrdaPromjeneLozinkeTextBox = new TextBox();
            PromjenaBrojaZiroRacunaRadioButton = new RadioButton();
            PromjenaBrojaLicneKarteRadioButton = new RadioButton();
            PromjenaLozinkeRadioButton = new RadioButton();
            PromjenaKorisnickogImenaRadioButton = new RadioButton();
            PromjenaPodatakaLabel = new Label();
            PotvrdaPromjeneLozinkeLabel = new Label();
            BrisanjeNalogaButton = new Button();
            ZakazivanjeTerminaTehnickogButton = new Button();
            ZakazivanjeTerminaTehnickogPanel = new Panel();
            UnosBrojaSasijeTextBox = new TextBox();
            UnosBrojaSasijeLabel = new Label();
            PokretanjeZakazivanjaTerminaButton = new Button();
            ZakazivanjeTerminaMonthCalendar = new MonthCalendar();
            ZakazivanjeTerminaDateTimePicker = new DateTimePicker();
            ZakaziTerminAkoVoziloVecPostojiButton = new Button();
            MarkaZakazivanjeTextBox = new TextBox();
            ModelZakazivanjeTextBox = new TextBox();
            GodisteZakazivanjeTextBox = new TextBox();
            KubikazaZakazivanjeTextBox = new TextBox();
            KategorijaZakazivanjeComboBox = new ComboBox();
            PotkategorijaZakazivanjeComboBox = new ComboBox();
            KategorijaZakazivanjeLabel = new Label();
            PotkategorijaZakazivanjeLabel = new Label();
            MarkaZakazivanjeLabel = new Label();
            ModelZakazivanjeLabel = new Label();
            GodisteZakazivanjeLabel = new Label();
            KubikazaZakazivanjeLabel = new Label();
            ZakaziTerminaAkoVoziloNePostojiButton = new Button();
            NazadSaZakazivanjaTerminaTehnickogNaLogovanogKlijenta = new Button();
            AdministratorPanel = new Panel();
            KorisnickoImeAdministratorLabelLogin = new Label();
            LozinkaAdministratorLabelLogin = new Label();
            LozinkaAdministratorTextBoxLogin = new TextBox();
            KorisnickoImeAdministratorTextBoxLogin = new TextBox();
            PrijaviSeAdministratorButton = new Button();
            NazadAdministratorButton = new Button();
            LogovanAdministratorPanel = new Panel();
            OdjavaLogovanogAdministratoraButton = new Button();
            PracenjeStatistikeButton = new Button();
            PracenjeStatistikePanel = new Panel();
            NazadSaPanelaZaPracenjeStatistikeNaPanelPrijavljenogAdministratoraButton = new Button();
            VozilaKojaSuProslaTehnickiButton = new Button();
            VozilaKojaNisuProslaTehnickiButton = new Button();
            PrikazStatistikePanel = new Panel();
            KategorijaComboBox = new ComboBox();
            PotkategorijaComboBox = new ComboBox();
            PrikazStatistikeUPrikazuStatistikeButton = new Button();
            StatistikaRichTextBox = new RichTextBox();
            NazadSaPanelaZaPrikazStatistikeNaPanelZaPracenjeStatistikeButton = new Button();
            PregledPostojecihNalogaButton = new Button();
            BrisanjeRadnickihNalogaButton = new Button();
            BrisanjeAdministratorskihNalogaButton = new Button();
            KreiranjeRadnickihNalogaButton = new Button();
            KreiranjeAdministratorskihNalogaButton = new Button();
            RegistracijaAdministratorskihNalogaPanel = new Panel();
            RegistrujAdministratorskiNalogButton = new Button();
            PotvrdaLozinkeAdminRegistracijaLabel = new Label();
            LozinkaAdminRegistracijaLabel = new Label();
            KorisnickoImeAdminRegistracijaLabel = new Label();
            PrezimeAdminRegistracijaLabel = new Label();
            ImeAdminRegistracijaLabel = new Label();
            PotvrdaLozinkeAdminRegistracijaTextBox = new TextBox();
            LozinkaAdminRegistracijaTextBox = new TextBox();
            KorisnickoImeAdminRegistracijaTextBox = new TextBox();
            PrezimeAdminRegistracijaTextBox = new TextBox();
            ImeAdminRegistracijaTextBox = new TextBox();
            NazadSaPanelaZaRegisteracijuAdministratoraNaPanelPrijavljenogAdministratoraButton = new Button();
            PregledPostojecihNalogaPanel = new Panel();
            NazadSaPanelaZaPregledPostojecihNalogaNaPanelPrijavljenogAdministratoraButton = new Button();
            PregledPostojecihNalogaKlijentListBox = new ListBox();
            PregledPostojecihNalogaRadnikListBox = new ListBox();
            PregledPostojecihNalogaAdminListBox = new ListBox();
            PregledPostojecihNalogaKlijentLabel = new Label();
            PregledPostojecihNalogaRadnikLabel = new Label();
            PregledPostojecihNalogaAdminLabel = new Label();
            RegistracijaRadnickihNalogaPanel = new Panel();
            RegistrujRadnickiNalogButton = new Button();
            PotvrdaLozinkeRadnikRegistracijaLabel = new Label();
            LozinkaRadnikRegistracijaLabel = new Label();
            KorisnickoImeRadnikRegistracijaLabel = new Label();
            PrezimeRadnikRegistracijaLabel = new Label();
            ImeRadnikRegistracijaLabel = new Label();
            PotvrdaLozinkeRadnikRegistracijaTextBox = new TextBox();
            LozinkaRadnikRegistracijaTextBox = new TextBox();
            KorisnickoImeRadnikRegistracijaTextBox = new TextBox();
            PrezimeRadnikRegistracijaTextBox = new TextBox();
            ImeRadnikRegistracijaTextBox = new TextBox();
            NazadSaPanelaZaRegisteracijuRadnikaNaPanelPrijavljenogAdministratoraButton = new Button();
            BrisanjeRadnickihNalogaPanel = new Panel();
            ObrisiRadnickiNalogButton = new Button();
            ListaRadnickihNalogaComboBox = new ComboBox();
            HeaderListeRadnickihNaloga = new Label();
            NazadSaPanelaZaBrisanjeRadnickihNalogaNaPanelPrijavljenogAdministratoraButton = new Button();
            BrisanjeAdministratorskihNalogaPanel = new Panel();
            ObrisiAdministratorskiNalogButton = new Button();
            ListaAdministratorskihNalogaComboBox = new ComboBox();
            HeaderListeAdministratorskihNaloga = new Label();
            NazadSaPanelaZaBrisanjeAdministratorskihNalogaNaPanelPrijavljenogAdministratoraButton = new Button();
            LoginRadnikaPanel = new Panel();
            KorisnickoImeRadnikaLabelLogin = new Label();
            LozinkaRadnikaLabelLogin = new Label();
            LozinkaRadnikaTextBoxLogin = new TextBox();
            KorisnickoImeRadnikaTextBoxLogin = new TextBox();
            PrijaviSeRadnikButton = new Button();
            NazadSaLogovanogRadnikaNaIzborniPanelButton = new Button();
            RadnikPanel = new Panel();
            panel_pregledIstorije = new Panel();
            button_pregledIstorije_nazad = new Button();
            listBox_pregledIstorije = new ListBox();
            label_pregledIstorije_naslov = new Label();
            panel_prikazArhive = new Panel();
            button_prikazArhive_nazad = new Button();
            listBox_prikazArhive = new ListBox();
            label_prikazArhive_naslov = new Label();
            panel_obavljanjeTehnickog = new Panel();
            button_obavljanjeTehnickog_otkazi = new Button();
            label_obavljanjeTehnickog_naslov = new Label();
            listBox_obavljanjeTehnickog = new ListBox();
            JMBGZakazivanjeRadnikLabel= new Label();
            JMBGZakazivanjeRadnikTextBox = new TextBox();
            panel_zakazivanjeTermina1 = new Panel();
            UnosBrojaSasijeRadnikTextBox = new TextBox();
            UnosBrojaSasijeRadnikLabel = new Label();
            PokretanjeZakazivanjaTerminaRadnikButton = new Button();
            ZakazivanjeTerminaRadnikMonthCalendar = new MonthCalendar();
            ZakazivanjeTerminaRadnikDateTimePicker = new DateTimePicker();
            ZakaziTerminAkoVoziloVecPostojiRadnikButton = new Button();
            MarkaZakazivanjeRadnikTextBox = new TextBox();
            ModelZakazivanjeRadnikTextBox = new TextBox();
            GodisteZakazivanjeRadnikTextBox = new TextBox();
            KubikazaZakazivanjeRadnikTextBox = new TextBox();
            KategorijaZakazivanjeRadnikComboBox = new ComboBox();
            PotkategorijaZakazivanjeRadnikComboBox = new ComboBox();
            KategorijaZakazivanjeRadnikLabel = new Label();
            PotkategorijaZakazivanjeRadnikLabel = new Label();
            MarkaZakazivanjeRadnikLabel = new Label();
            ModelZakazivanjeRadnikLabel = new Label();
            GodisteZakazivanjeRadnikLabel = new Label();
            KubikazaZakazivanjeRadnikLabel = new Label();
            ZakaziTerminaAkoVoziloNePostojiRadnikButton = new Button();
            NazadSaZakazivanjaTerminaTehnickogNaLogovanogKlijentaRadnikButton = new Button();
            button_prikazArhive = new Button();
            button_zakazivanjeTehnickog = new Button();
            button_obavljanjeTehnickog = new Button();
            button_pregledIstorije = new Button();
            NazadRadnikButton = new Button();
            PrijavljujemSeKaoLabel = new Label();
            SistemZaTehnickiPregledLabel = new Label();
            AdministratorButton = new Button();
            RadnikButton = new Button();
            KlijentButton = new Button();
            panel_zakazivanjeTermina3 = new Panel();
            button_zakazivanjeTermina3_nazad = new Button();
            monthCalendar_zakazivanjeTermina3 = new MonthCalendar();
            dateTimePicker_zakazivanjeTermina3 = new DateTimePicker();
            button_zakazivanjeTermina3_zakaziTermin = new Button();
            panel_zakazivanjeTermina2 = new Panel();
            label_zakazivanjeTermina_kategorija = new Label();
            textBox_zakazivanjeTermina2_kategorija = new TextBox();
            label_zakazivanjeTermina_potkategorija = new Label();
            textBox_zakazivanjeTermina2_potkategorija = new TextBox();
            label_zakazivanjeTermina_marka = new Label();
            textBox_zakazivanjeTermina2_marka = new TextBox();
            label_zakazivanjeTermina_model = new Label();
            textBox_zakazivanjeTermina2_model = new TextBox();
            label_zakazivanjeTermina_godiste = new Label();
            textBox_zakazivanjeTermina2_godiste = new TextBox();
            label_zakazivanjeTermina_kubikaza = new Label();
            textBox_zakazivanjeTermina2_kubikaza = new TextBox();
            label_zakazivanjeTermina_stiker = new Label();
            textBox_zakazivanjeTermina2_stiker = new TextBox();
            button_zakazivanjeTermina2_dalje = new Button();
            textBox_zakazivanjeTermina2_rokRegistracije = new TextBox();
            label_zakazivanjeTermina_datumReg = new Label();
            button_zakazivanjeTermina1_pokreni = new Button();
            textBox_zakazivanjeTermina1_brojSasije = new TextBox();
            label_zakazivanjeTermina_unosBrojaSasije = new Label();
            button_zakazivanjeTermina1_otkazi = new Button();
            IzborniPanel.SuspendLayout();
            KlijentPanel.SuspendLayout();
            RegistracijaNalogaPanel.SuspendLayout();
            LogovanKlijentPanel.SuspendLayout();
            PromjenaPodatakaPanel.SuspendLayout();
            ZakazivanjeTerminaTehnickogPanel.SuspendLayout();
            AdministratorPanel.SuspendLayout();
            LogovanAdministratorPanel.SuspendLayout();
            PracenjeStatistikePanel.SuspendLayout();
            PrikazStatistikePanel.SuspendLayout();
            RegistracijaAdministratorskihNalogaPanel.SuspendLayout();
            PregledPostojecihNalogaPanel.SuspendLayout();
            RegistracijaRadnickihNalogaPanel.SuspendLayout();
            BrisanjeRadnickihNalogaPanel.SuspendLayout();
            BrisanjeAdministratorskihNalogaPanel.SuspendLayout();
            LoginRadnikaPanel.SuspendLayout();
            RadnikPanel.SuspendLayout();
            panel_pregledIstorije.SuspendLayout();
            panel_prikazArhive.SuspendLayout();
            panel_obavljanjeTehnickog.SuspendLayout();
            panel_zakazivanjeTermina1.SuspendLayout();
            panel_zakazivanjeTermina3.SuspendLayout();
            panel_zakazivanjeTermina2.SuspendLayout();
            SuspendLayout();
            // 
            // IzborniPanel
            // 
            IzborniPanel.BackColor = Color.FromArgb(255, 224, 192);
            IzborniPanel.Controls.Add(IndikatorNaKomStePanelu);
            IzborniPanel.Controls.Add(KlijentPanel);
            IzborniPanel.Controls.Add(AdministratorPanel);
            IzborniPanel.Controls.Add(LoginRadnikaPanel);
            IzborniPanel.Controls.Add(PrijavljujemSeKaoLabel);
            IzborniPanel.Controls.Add(SistemZaTehnickiPregledLabel);
            IzborniPanel.Controls.Add(AdministratorButton);
            IzborniPanel.Controls.Add(RadnikButton);
            IzborniPanel.Controls.Add(KlijentButton);
            IzborniPanel.Dock = DockStyle.Fill;
            IzborniPanel.Location = new Point(0, 0);
            IzborniPanel.Name = "IzborniPanel";
            IzborniPanel.Size = new Size(800, 450);
            IzborniPanel.TabIndex = 0;
            // 
            // IndikatorNaKomStePanelu
            // 
            IndikatorNaKomStePanelu.AutoSize = true;
            IndikatorNaKomStePanelu.Location = new Point(12, 9);
            IndikatorNaKomStePanelu.Name = "IndikatorNaKomStePanelu";
            IndikatorNaKomStePanelu.Size = new Size(0, 20);
            IndikatorNaKomStePanelu.TabIndex = 20;
            IndikatorNaKomStePanelu.Visible = false;
            // 
            // KlijentPanel
            // 
            KlijentPanel.Controls.Add(RegistracijaNalogaPanel);
            KlijentPanel.Controls.Add(RegistrujSeButton);
            KlijentPanel.Controls.Add(NisteRegistrovaniLabel);
            KlijentPanel.Controls.Add(PrijaviSeButton);
            KlijentPanel.Controls.Add(LozinkaLabelLogin);
            KlijentPanel.Controls.Add(LozinkaTextBoxLogin);
            KlijentPanel.Controls.Add(KorisnickoImeTextBoxLogin);
            KlijentPanel.Controls.Add(KorisnickoImeLabelLogin);
            KlijentPanel.Controls.Add(NazadKlijentButton);
            KlijentPanel.Controls.Add(LogovanKlijentPanel);
            KlijentPanel.Dock = DockStyle.Fill;
            KlijentPanel.Location = new Point(0, 0);
            KlijentPanel.Name = "KlijentPanel";
            KlijentPanel.Size = new Size(800, 450);
            KlijentPanel.TabIndex = 5;
            KlijentPanel.Visible = false;
            // 
            // RegistracijaNalogaPanel
            // 
            RegistracijaNalogaPanel.Controls.Add(NazadSaRegistracijeNaLoginButton);
            RegistracijaNalogaPanel.Controls.Add(RegistrujNalogButton);
            RegistracijaNalogaPanel.Controls.Add(JMBGLabel);
            RegistracijaNalogaPanel.Controls.Add(BrojZiroRacunaLabel);
            RegistracijaNalogaPanel.Controls.Add(BrojLicneKarteLabel);
            RegistracijaNalogaPanel.Controls.Add(PotvrdaLozinkeLabel);
            RegistracijaNalogaPanel.Controls.Add(LozinkaLabel);
            RegistracijaNalogaPanel.Controls.Add(KorisnickoImeLabel);
            RegistracijaNalogaPanel.Controls.Add(PrezimeLabel);
            RegistracijaNalogaPanel.Controls.Add(ImeLabel);
            RegistracijaNalogaPanel.Controls.Add(JMBGTextBox);
            RegistracijaNalogaPanel.Controls.Add(BrojZiroRacunaTextBox);
            RegistracijaNalogaPanel.Controls.Add(BrojLicneKarteTextBox);
            RegistracijaNalogaPanel.Controls.Add(PotvrdaLozinkeTextBox);
            RegistracijaNalogaPanel.Controls.Add(LozinkaTextBox);
            RegistracijaNalogaPanel.Controls.Add(KorisnickoImeTextBox);
            RegistracijaNalogaPanel.Controls.Add(PrezimeTextBox);
            RegistracijaNalogaPanel.Controls.Add(ImeTextBox);
            RegistracijaNalogaPanel.Dock = DockStyle.Fill;
            RegistracijaNalogaPanel.Location = new Point(0, 0);
            RegistracijaNalogaPanel.Name = "RegistracijaNalogaPanel";
            RegistracijaNalogaPanel.Size = new Size(800, 450);
            RegistracijaNalogaPanel.TabIndex = 7;
            RegistracijaNalogaPanel.Visible = false;
            // 
            // NazadSaRegistracijeNaLoginButton
            // 
            NazadSaRegistracijeNaLoginButton.Location = new Point(694, 409);
            NazadSaRegistracijeNaLoginButton.Name = "NazadSaRegistracijeNaLoginButton";
            NazadSaRegistracijeNaLoginButton.Size = new Size(94, 29);
            NazadSaRegistracijeNaLoginButton.TabIndex = 19;
            NazadSaRegistracijeNaLoginButton.Text = "Nazad";
            NazadSaRegistracijeNaLoginButton.UseVisualStyleBackColor = true;
            NazadSaRegistracijeNaLoginButton.Click += NazadSaRegistracijeNaLoginButton_Click;
            // 
            // RegistrujNalogButton
            // 
            RegistrujNalogButton.Location = new Point(300, 343);
            RegistrujNalogButton.Name = "RegistrujNalogButton";
            RegistrujNalogButton.Size = new Size(200, 29);
            RegistrujNalogButton.TabIndex = 18;
            RegistrujNalogButton.Text = "Registruj nalog";
            RegistrujNalogButton.UseVisualStyleBackColor = true;
            RegistrujNalogButton.Click += RegistrujNalogButton_Click;
            // 
            // JMBGLabel
            // 
            JMBGLabel.AutoSize = true;
            JMBGLabel.Location = new Point(178, 290);
            JMBGLabel.Name = "JMBGLabel";
            JMBGLabel.Size = new Size(49, 20);
            JMBGLabel.TabIndex = 16;
            JMBGLabel.Text = "JMBG:";
            // 
            // BrojZiroRacunaLabel
            // 
            BrojZiroRacunaLabel.AutoSize = true;
            BrojZiroRacunaLabel.Location = new Point(178, 257);
            BrojZiroRacunaLabel.Name = "BrojZiroRacunaLabel";
            BrojZiroRacunaLabel.Size = new Size(116, 20);
            BrojZiroRacunaLabel.TabIndex = 15;
            BrojZiroRacunaLabel.Text = "Broj žiro računa:";
            // 
            // BrojLicneKarteLabel
            // 
            BrojLicneKarteLabel.AutoSize = true;
            BrojLicneKarteLabel.Location = new Point(178, 224);
            BrojLicneKarteLabel.Name = "BrojLicneKarteLabel";
            BrojLicneKarteLabel.Size = new Size(111, 20);
            BrojLicneKarteLabel.TabIndex = 14;
            BrojLicneKarteLabel.Text = "Broj lične karte:";
            // 
            // PotvrdaLozinkeLabel
            // 
            PotvrdaLozinkeLabel.AutoSize = true;
            PotvrdaLozinkeLabel.Location = new Point(178, 191);
            PotvrdaLozinkeLabel.Name = "PotvrdaLozinkeLabel";
            PotvrdaLozinkeLabel.Size = new Size(113, 20);
            PotvrdaLozinkeLabel.TabIndex = 13;
            PotvrdaLozinkeLabel.Text = "Potvrda lozinke:";
            // 
            // LozinkaLabel
            // 
            LozinkaLabel.AutoSize = true;
            LozinkaLabel.Location = new Point(178, 158);
            LozinkaLabel.Name = "LozinkaLabel";
            LozinkaLabel.Size = new Size(62, 20);
            LozinkaLabel.TabIndex = 12;
            LozinkaLabel.Text = "Lozinka:";
            // 
            // KorisnickoImeLabel
            // 
            KorisnickoImeLabel.AutoSize = true;
            KorisnickoImeLabel.Location = new Point(178, 125);
            KorisnickoImeLabel.Name = "KorisnickoImeLabel";
            KorisnickoImeLabel.Size = new Size(109, 20);
            KorisnickoImeLabel.TabIndex = 11;
            KorisnickoImeLabel.Text = "Korisničko ime:";
            // 
            // PrezimeLabel
            // 
            PrezimeLabel.AutoSize = true;
            PrezimeLabel.Location = new Point(178, 92);
            PrezimeLabel.Name = "PrezimeLabel";
            PrezimeLabel.Size = new Size(65, 20);
            PrezimeLabel.TabIndex = 10;
            PrezimeLabel.Text = "Prezime:";
            // 
            // ImeLabel
            // 
            ImeLabel.AutoSize = true;
            ImeLabel.Location = new Point(178, 59);
            ImeLabel.Name = "ImeLabel";
            ImeLabel.Size = new Size(37, 20);
            ImeLabel.TabIndex = 9;
            ImeLabel.Text = "Ime:";
            // 
            // JMBGTextBox
            // 
            JMBGTextBox.Location = new Point(300, 287);
            JMBGTextBox.Name = "JMBGTextBox";
            JMBGTextBox.Size = new Size(200, 27);
            JMBGTextBox.TabIndex = 7;
            // 
            // BrojZiroRacunaTextBox
            // 
            BrojZiroRacunaTextBox.Location = new Point(300, 254);
            BrojZiroRacunaTextBox.Name = "BrojZiroRacunaTextBox";
            BrojZiroRacunaTextBox.Size = new Size(200, 27);
            BrojZiroRacunaTextBox.TabIndex = 6;
            // 
            // BrojLicneKarteTextBox
            // 
            BrojLicneKarteTextBox.Location = new Point(300, 221);
            BrojLicneKarteTextBox.Name = "BrojLicneKarteTextBox";
            BrojLicneKarteTextBox.Size = new Size(200, 27);
            BrojLicneKarteTextBox.TabIndex = 5;
            // 
            // PotvrdaLozinkeTextBox
            // 
            PotvrdaLozinkeTextBox.Location = new Point(300, 188);
            PotvrdaLozinkeTextBox.Name = "PotvrdaLozinkeTextBox";
            PotvrdaLozinkeTextBox.PasswordChar = '*';
            PotvrdaLozinkeTextBox.Size = new Size(200, 27);
            PotvrdaLozinkeTextBox.TabIndex = 4;
            // 
            // LozinkaTextBox
            // 
            LozinkaTextBox.Location = new Point(300, 155);
            LozinkaTextBox.Name = "LozinkaTextBox";
            LozinkaTextBox.PasswordChar = '*';
            LozinkaTextBox.Size = new Size(200, 27);
            LozinkaTextBox.TabIndex = 3;
            LozinkaTextBox.TextChanged += LozinkaTextBox_TextChanged;
            // 
            // KorisnickoImeTextBox
            // 
            KorisnickoImeTextBox.Location = new Point(300, 122);
            KorisnickoImeTextBox.Name = "KorisnickoImeTextBox";
            KorisnickoImeTextBox.Size = new Size(200, 27);
            KorisnickoImeTextBox.TabIndex = 2;
            KorisnickoImeTextBox.TextChanged += KorisnickoImeTextBox_TextChanged;
            // 
            // PrezimeTextBox
            // 
            PrezimeTextBox.Location = new Point(300, 89);
            PrezimeTextBox.Name = "PrezimeTextBox";
            PrezimeTextBox.Size = new Size(200, 27);
            PrezimeTextBox.TabIndex = 1;
            // 
            // ImeTextBox
            // 
            ImeTextBox.Location = new Point(300, 56);
            ImeTextBox.Name = "ImeTextBox";
            ImeTextBox.Size = new Size(200, 27);
            ImeTextBox.TabIndex = 0;
            // 
            // RegistrujSeButton
            // 
            RegistrujSeButton.Location = new Point(300, 260);
            RegistrujSeButton.Name = "RegistrujSeButton";
            RegistrujSeButton.Size = new Size(200, 29);
            RegistrujSeButton.TabIndex = 6;
            RegistrujSeButton.Text = "Registruj se";
            RegistrujSeButton.UseVisualStyleBackColor = true;
            RegistrujSeButton.Click += RegistrujSeButton_Click;
            // 
            // NisteRegistrovaniLabel
            // 
            NisteRegistrovaniLabel.AutoSize = true;
            NisteRegistrovaniLabel.Location = new Point(335, 237);
            NisteRegistrovaniLabel.Name = "NisteRegistrovaniLabel";
            NisteRegistrovaniLabel.Size = new Size(132, 20);
            NisteRegistrovaniLabel.TabIndex = 5;
            NisteRegistrovaniLabel.Text = "Niste registrovani?";
            // 
            // PrijaviSeButton
            // 
            PrijaviSeButton.Location = new Point(300, 166);
            PrijaviSeButton.Name = "PrijaviSeButton";
            PrijaviSeButton.Size = new Size(200, 29);
            PrijaviSeButton.TabIndex = 4;
            PrijaviSeButton.Text = "Prijavi se";
            PrijaviSeButton.UseVisualStyleBackColor = true;
            PrijaviSeButton.Click += PrijaviSeButton_Click;
            // 
            // LozinkaLabelLogin
            // 
            LozinkaLabelLogin.AutoSize = true;
            LozinkaLabelLogin.Location = new Point(185, 137);
            LozinkaLabelLogin.Name = "LozinkaLabelLogin";
            LozinkaLabelLogin.Size = new Size(62, 20);
            LozinkaLabelLogin.TabIndex = 3;
            LozinkaLabelLogin.Text = "Lozinka:";
            // 
            // LozinkaTextBoxLogin
            // 
            LozinkaTextBoxLogin.Location = new Point(300, 133);
            LozinkaTextBoxLogin.Name = "LozinkaTextBoxLogin";
            LozinkaTextBoxLogin.PasswordChar = '*';
            LozinkaTextBoxLogin.Size = new Size(200, 27);
            LozinkaTextBoxLogin.TabIndex = 2;
            // 
            // KorisnickoImeTextBoxLogin
            // 
            KorisnickoImeTextBoxLogin.Location = new Point(300, 100);
            KorisnickoImeTextBoxLogin.Name = "KorisnickoImeTextBoxLogin";
            KorisnickoImeTextBoxLogin.Size = new Size(200, 27);
            KorisnickoImeTextBoxLogin.TabIndex = 1;
            // 
            // KorisnickoImeLabelLogin
            // 
            KorisnickoImeLabelLogin.AutoSize = true;
            KorisnickoImeLabelLogin.Location = new Point(185, 103);
            KorisnickoImeLabelLogin.Name = "KorisnickoImeLabelLogin";
            KorisnickoImeLabelLogin.Size = new Size(109, 20);
            KorisnickoImeLabelLogin.TabIndex = 0;
            KorisnickoImeLabelLogin.Text = "Korisničko ime:";
            // 
            // NazadKlijentButton
            // 
            NazadKlijentButton.Location = new Point(694, 409);
            NazadKlijentButton.Name = "NazadKlijentButton";
            NazadKlijentButton.Size = new Size(94, 29);
            NazadKlijentButton.TabIndex = 8;
            NazadKlijentButton.Text = "Nazad";
            NazadKlijentButton.UseVisualStyleBackColor = true;
            NazadKlijentButton.Click += NazadKlijentButton_Click;
            // 
            // LogovanKlijentPanel
            // 
            LogovanKlijentPanel.Controls.Add(OdjavaLogovanogKlijentaButton);
            LogovanKlijentPanel.Controls.Add(PromjenaPodatakaButton);
            LogovanKlijentPanel.Controls.Add(PromjenaPodatakaPanel);
            LogovanKlijentPanel.Controls.Add(BrisanjeNalogaButton);
            LogovanKlijentPanel.Controls.Add(ZakazivanjeTerminaTehnickogButton);
            LogovanKlijentPanel.Controls.Add(ZakazivanjeTerminaTehnickogPanel);
            LogovanKlijentPanel.Dock = DockStyle.Fill;
            LogovanKlijentPanel.Location = new Point(0, 0);
            LogovanKlijentPanel.Name = "LogovanKlijentPanel";
            LogovanKlijentPanel.Size = new Size(800, 450);
            LogovanKlijentPanel.TabIndex = 9;
            LogovanKlijentPanel.Visible = false;
            // 
            // OdjavaLogovanogKlijentaButton
            // 
            OdjavaLogovanogKlijentaButton.Location = new Point(694, 409);
            OdjavaLogovanogKlijentaButton.Name = "OdjavaLogovanogKlijentaButton";
            OdjavaLogovanogKlijentaButton.Size = new Size(94, 29);
            OdjavaLogovanogKlijentaButton.TabIndex = 6;
            OdjavaLogovanogKlijentaButton.Text = "Odjava";
            OdjavaLogovanogKlijentaButton.UseVisualStyleBackColor = true;
            OdjavaLogovanogKlijentaButton.Click += OdjavaLogovanogKlijentaButton_Click;
            // 
            // PromjenaPodatakaButton
            // 
            PromjenaPodatakaButton.Location = new Point(275, 190);
            PromjenaPodatakaButton.Name = "PromjenaPodatakaButton";
            PromjenaPodatakaButton.Size = new Size(250, 70);
            PromjenaPodatakaButton.TabIndex = 1;
            PromjenaPodatakaButton.Text = "Promjena podataka";
            PromjenaPodatakaButton.UseVisualStyleBackColor = true;
            PromjenaPodatakaButton.Click += PromjenaPodatakaButton_Click;
            // 
            // PromjenaPodatakaPanel
            // 
            PromjenaPodatakaPanel.Controls.Add(NazadSaPromjenePodatakaNaLogovanogKlijenta);
            PromjenaPodatakaPanel.Controls.Add(PotvrdiPromjenuPodatakaButton);
            PromjenaPodatakaPanel.Controls.Add(PromjenaPodatakaTextBox);
            PromjenaPodatakaPanel.Controls.Add(PotvrdaPromjeneLozinkeTextBox);
            PromjenaPodatakaPanel.Controls.Add(PromjenaBrojaZiroRacunaRadioButton);
            PromjenaPodatakaPanel.Controls.Add(PromjenaBrojaLicneKarteRadioButton);
            PromjenaPodatakaPanel.Controls.Add(PromjenaLozinkeRadioButton);
            PromjenaPodatakaPanel.Controls.Add(PromjenaKorisnickogImenaRadioButton);
            PromjenaPodatakaPanel.Controls.Add(PromjenaPodatakaLabel);
            PromjenaPodatakaPanel.Controls.Add(PotvrdaPromjeneLozinkeLabel);
            PromjenaPodatakaPanel.Dock = DockStyle.Fill;
            PromjenaPodatakaPanel.Location = new Point(0, 0);
            PromjenaPodatakaPanel.Name = "PromjenaPodatakaPanel";
            PromjenaPodatakaPanel.Size = new Size(800, 450);
            PromjenaPodatakaPanel.TabIndex = 9;
            PromjenaPodatakaPanel.Visible = false;
            // 
            // NazadSaPromjenePodatakaNaLogovanogKlijenta
            // 
            NazadSaPromjenePodatakaNaLogovanogKlijenta.Location = new Point(694, 409);
            NazadSaPromjenePodatakaNaLogovanogKlijenta.Name = "NazadSaPromjenePodatakaNaLogovanogKlijenta";
            NazadSaPromjenePodatakaNaLogovanogKlijenta.Size = new Size(94, 29);
            NazadSaPromjenePodatakaNaLogovanogKlijenta.TabIndex = 8;
            NazadSaPromjenePodatakaNaLogovanogKlijenta.Text = "Nazad";
            NazadSaPromjenePodatakaNaLogovanogKlijenta.UseVisualStyleBackColor = true;
            NazadSaPromjenePodatakaNaLogovanogKlijenta.Click += NazadSaPromjenePodatakaNaLogovanogKlijenta_Click;
            // 
            // PotvrdiPromjenuPodatakaButton
            // 
            PotvrdiPromjenuPodatakaButton.Location = new Point(408, 226);
            PotvrdiPromjenuPodatakaButton.Name = "PotvrdiPromjenuPodatakaButton";
            PotvrdiPromjenuPodatakaButton.Size = new Size(200, 29);
            PotvrdiPromjenuPodatakaButton.TabIndex = 5;
            PotvrdiPromjenuPodatakaButton.Text = "Potvrdi";
            PotvrdiPromjenuPodatakaButton.UseVisualStyleBackColor = true;
            PotvrdiPromjenuPodatakaButton.Click += PotvrdiPromjenuPodatakaButton_Click;
            // 
            // PromjenaPodatakaTextBox
            // 
            PromjenaPodatakaTextBox.Location = new Point(408, 138);
            PromjenaPodatakaTextBox.Name = "PromjenaPodatakaTextBox";
            PromjenaPodatakaTextBox.Size = new Size(200, 27);
            PromjenaPodatakaTextBox.TabIndex = 4;
            // 
            // PotvrdaPromjeneLozinkeTextBox
            // 
            PotvrdaPromjeneLozinkeTextBox.Location = new Point(408, 186);
            PotvrdaPromjeneLozinkeTextBox.Name = "PotvrdaPromjeneLozinkeTextBox";
            PotvrdaPromjeneLozinkeTextBox.PasswordChar = '*';
            PotvrdaPromjeneLozinkeTextBox.Size = new Size(200, 27);
            PotvrdaPromjeneLozinkeTextBox.TabIndex = 4;
            PotvrdaPromjeneLozinkeTextBox.Visible = false;
            // 
            // PromjenaBrojaZiroRacunaRadioButton
            // 
            PromjenaBrojaZiroRacunaRadioButton.AutoSize = true;
            PromjenaBrojaZiroRacunaRadioButton.Location = new Point(111, 231);
            PromjenaBrojaZiroRacunaRadioButton.Name = "PromjenaBrojaZiroRacunaRadioButton";
            PromjenaBrojaZiroRacunaRadioButton.Size = new Size(209, 24);
            PromjenaBrojaZiroRacunaRadioButton.TabIndex = 3;
            PromjenaBrojaZiroRacunaRadioButton.TabStop = true;
            PromjenaBrojaZiroRacunaRadioButton.Text = "Promjena broja žiro računa";
            PromjenaBrojaZiroRacunaRadioButton.UseVisualStyleBackColor = true;
            PromjenaBrojaZiroRacunaRadioButton.CheckedChanged += PromjenaBrojaZiroRacunaRadioButton_CheckedChanged;
            // 
            // PromjenaBrojaLicneKarteRadioButton
            // 
            PromjenaBrojaLicneKarteRadioButton.AutoSize = true;
            PromjenaBrojaLicneKarteRadioButton.Location = new Point(111, 201);
            PromjenaBrojaLicneKarteRadioButton.Name = "PromjenaBrojaLicneKarteRadioButton";
            PromjenaBrojaLicneKarteRadioButton.Size = new Size(204, 24);
            PromjenaBrojaLicneKarteRadioButton.TabIndex = 2;
            PromjenaBrojaLicneKarteRadioButton.TabStop = true;
            PromjenaBrojaLicneKarteRadioButton.Text = "Promjena broja lične karte";
            PromjenaBrojaLicneKarteRadioButton.UseVisualStyleBackColor = true;
            PromjenaBrojaLicneKarteRadioButton.CheckedChanged += PromjenaBrojaLicneKarteRadioButton_CheckedChanged;
            // 
            // PromjenaLozinkeRadioButton
            // 
            PromjenaLozinkeRadioButton.AutoSize = true;
            PromjenaLozinkeRadioButton.Location = new Point(111, 171);
            PromjenaLozinkeRadioButton.Name = "PromjenaLozinkeRadioButton";
            PromjenaLozinkeRadioButton.Size = new Size(144, 24);
            PromjenaLozinkeRadioButton.TabIndex = 1;
            PromjenaLozinkeRadioButton.TabStop = true;
            PromjenaLozinkeRadioButton.Text = "Promjena lozinke";
            PromjenaLozinkeRadioButton.UseVisualStyleBackColor = true;
            PromjenaLozinkeRadioButton.CheckedChanged += PromjenaLozinkeRadioButton_CheckedChanged;
            // 
            // PromjenaKorisnickogImenaRadioButton
            // 
            PromjenaKorisnickogImenaRadioButton.AutoSize = true;
            PromjenaKorisnickogImenaRadioButton.Location = new Point(111, 141);
            PromjenaKorisnickogImenaRadioButton.Name = "PromjenaKorisnickogImenaRadioButton";
            PromjenaKorisnickogImenaRadioButton.Size = new Size(217, 24);
            PromjenaKorisnickogImenaRadioButton.TabIndex = 0;
            PromjenaKorisnickogImenaRadioButton.TabStop = true;
            PromjenaKorisnickogImenaRadioButton.Text = "Promjena korisničkog imena";
            PromjenaKorisnickogImenaRadioButton.UseVisualStyleBackColor = true;
            PromjenaKorisnickogImenaRadioButton.CheckedChanged += PromjenaKorisnickogImenaRadioButton_CheckedChanged;
            // 
            // PromjenaPodatakaLabel
            // 
            PromjenaPodatakaLabel.AutoSize = true;
            PromjenaPodatakaLabel.Location = new Point(408, 118);
            PromjenaPodatakaLabel.Name = "PromjenaPodatakaLabel";
            PromjenaPodatakaLabel.Size = new Size(0, 20);
            PromjenaPodatakaLabel.TabIndex = 9;
            // 
            // PotvrdaPromjeneLozinkeLabel
            // 
            PotvrdaPromjeneLozinkeLabel.AutoSize = true;
            PotvrdaPromjeneLozinkeLabel.Location = new Point(408, 166);
            PotvrdaPromjeneLozinkeLabel.Name = "PotvrdaPromjeneLozinkeLabel";
            PotvrdaPromjeneLozinkeLabel.Size = new Size(113, 20);
            PotvrdaPromjeneLozinkeLabel.TabIndex = 10;
            PotvrdaPromjeneLozinkeLabel.Text = "Potvrda lozinke:";
            PotvrdaPromjeneLozinkeLabel.Visible = false;
            // 
            // BrisanjeNalogaButton
            // 
            BrisanjeNalogaButton.Location = new Point(275, 320);
            BrisanjeNalogaButton.Name = "BrisanjeNalogaButton";
            BrisanjeNalogaButton.Size = new Size(250, 70);
            BrisanjeNalogaButton.TabIndex = 2;
            BrisanjeNalogaButton.Text = "Brisanje naloga";
            BrisanjeNalogaButton.UseVisualStyleBackColor = true;
            BrisanjeNalogaButton.Click += BrisanjeNalogaButton_Click;
            // 
            // ZakazivanjeTerminaTehnickogButton
            // 
            ZakazivanjeTerminaTehnickogButton.Location = new Point(275, 60);
            ZakazivanjeTerminaTehnickogButton.Name = "ZakazivanjeTerminaTehnickogButton";
            ZakazivanjeTerminaTehnickogButton.Size = new Size(250, 70);
            ZakazivanjeTerminaTehnickogButton.TabIndex = 3;
            ZakazivanjeTerminaTehnickogButton.Text = "Zakazivanje termina tehničkog pregleda";
            ZakazivanjeTerminaTehnickogButton.UseVisualStyleBackColor = true;
            ZakazivanjeTerminaTehnickogButton.Click += ZakazivanjeTerminaTehnickogButton_Click;
            // 
            // ZakazivanjeTerminaTehnickogPanel
            // 
            ZakazivanjeTerminaTehnickogPanel.Controls.Add(UnosBrojaSasijeTextBox);
            ZakazivanjeTerminaTehnickogPanel.Controls.Add(UnosBrojaSasijeLabel);
            ZakazivanjeTerminaTehnickogPanel.Controls.Add(PokretanjeZakazivanjaTerminaButton);
            ZakazivanjeTerminaTehnickogPanel.Controls.Add(ZakazivanjeTerminaMonthCalendar);
            ZakazivanjeTerminaTehnickogPanel.Controls.Add(ZakazivanjeTerminaDateTimePicker);
            ZakazivanjeTerminaTehnickogPanel.Controls.Add(ZakaziTerminAkoVoziloVecPostojiButton);
            ZakazivanjeTerminaTehnickogPanel.Controls.Add(MarkaZakazivanjeTextBox);
            ZakazivanjeTerminaTehnickogPanel.Controls.Add(ModelZakazivanjeTextBox);
            ZakazivanjeTerminaTehnickogPanel.Controls.Add(GodisteZakazivanjeTextBox);
            ZakazivanjeTerminaTehnickogPanel.Controls.Add(KubikazaZakazivanjeTextBox);
            ZakazivanjeTerminaTehnickogPanel.Controls.Add(KategorijaZakazivanjeComboBox);
            ZakazivanjeTerminaTehnickogPanel.Controls.Add(PotkategorijaZakazivanjeComboBox);
            ZakazivanjeTerminaTehnickogPanel.Controls.Add(KategorijaZakazivanjeLabel);
            ZakazivanjeTerminaTehnickogPanel.Controls.Add(PotkategorijaZakazivanjeLabel);
            ZakazivanjeTerminaTehnickogPanel.Controls.Add(MarkaZakazivanjeLabel);
            ZakazivanjeTerminaTehnickogPanel.Controls.Add(ModelZakazivanjeLabel);
            ZakazivanjeTerminaTehnickogPanel.Controls.Add(GodisteZakazivanjeLabel);
            ZakazivanjeTerminaTehnickogPanel.Controls.Add(KubikazaZakazivanjeLabel);
            ZakazivanjeTerminaTehnickogPanel.Controls.Add(ZakaziTerminaAkoVoziloNePostojiButton);
            ZakazivanjeTerminaTehnickogPanel.Controls.Add(NazadSaZakazivanjaTerminaTehnickogNaLogovanogKlijenta);
            ZakazivanjeTerminaTehnickogPanel.Dock = DockStyle.Fill;
            ZakazivanjeTerminaTehnickogPanel.Location = new Point(0, 0);
            ZakazivanjeTerminaTehnickogPanel.Name = "ZakazivanjeTerminaTehnickogPanel";
            ZakazivanjeTerminaTehnickogPanel.Size = new Size(800, 450);
            ZakazivanjeTerminaTehnickogPanel.TabIndex = 9;
            ZakazivanjeTerminaTehnickogPanel.Visible = false;
            // 
            // UnosBrojaSasijeTextBox
            // 
            UnosBrojaSasijeTextBox.Location = new Point(530, 20);
            UnosBrojaSasijeTextBox.Name = "UnosBrojaSasijeTextBox";
            UnosBrojaSasijeTextBox.Size = new Size(200, 27);
            UnosBrojaSasijeTextBox.TabIndex = 0;
            // 
            // UnosBrojaSasijeLabel
            // 
            UnosBrojaSasijeLabel.AutoSize = true;
            UnosBrojaSasijeLabel.Location = new Point(392, 23);
            UnosBrojaSasijeLabel.Name = "UnosBrojaSasijeLabel";
            UnosBrojaSasijeLabel.Size = new Size(132, 20);
            UnosBrojaSasijeLabel.TabIndex = 1;
            UnosBrojaSasijeLabel.Text = "Unesite broj šasije:";
            // 
            // PokretanjeZakazivanjaTerminaButton
            // 
            PokretanjeZakazivanjaTerminaButton.Location = new Point(580, 53);
            PokretanjeZakazivanjaTerminaButton.Name = "PokretanjeZakazivanjaTerminaButton";
            PokretanjeZakazivanjaTerminaButton.Size = new Size(100, 29);
            PokretanjeZakazivanjaTerminaButton.TabIndex = 2;
            PokretanjeZakazivanjaTerminaButton.Text = "Pokreni";
            PokretanjeZakazivanjaTerminaButton.UseVisualStyleBackColor = true;
            PokretanjeZakazivanjaTerminaButton.Click += PokretanjeZakazivanjaTerminaButton_Click;
            // 
            // ZakazivanjeTerminaMonthCalendar
            // 
            ZakazivanjeTerminaMonthCalendar.Location = new Point(40, 90);
            ZakazivanjeTerminaMonthCalendar.Name = "ZakazivanjeTerminaMonthCalendar";
            ZakazivanjeTerminaMonthCalendar.TabIndex = 3;
            ZakazivanjeTerminaMonthCalendar.Visible = false;
            // 
            // ZakazivanjeTerminaDateTimePicker
            // 
            ZakazivanjeTerminaDateTimePicker.Location = new Point(40, 309);
            ZakazivanjeTerminaDateTimePicker.Name = "ZakazivanjeTerminaDateTimePicker";
            ZakazivanjeTerminaDateTimePicker.Size = new Size(262, 27);
            ZakazivanjeTerminaDateTimePicker.TabIndex = 4;
            ZakazivanjeTerminaDateTimePicker.Visible = false;
            // 
            // ZakaziTerminAkoVoziloVecPostojiButton
            // 
            ZakaziTerminAkoVoziloVecPostojiButton.Location = new Point(105, 342);
            ZakaziTerminAkoVoziloVecPostojiButton.Name = "ZakaziTerminAkoVoziloVecPostojiButton";
            ZakaziTerminAkoVoziloVecPostojiButton.Size = new Size(130, 29);
            ZakaziTerminAkoVoziloVecPostojiButton.TabIndex = 5;
            ZakaziTerminAkoVoziloVecPostojiButton.Text = "Zakaži termin";
            ZakaziTerminAkoVoziloVecPostojiButton.UseVisualStyleBackColor = true;
            ZakaziTerminAkoVoziloVecPostojiButton.Visible = false;
            // 
            // MarkaZakazivanjeTextBox
            // 
            MarkaZakazivanjeTextBox.Location = new Point(480, 186);
            MarkaZakazivanjeTextBox.Name = "MarkaZakazivanjeTextBox";
            MarkaZakazivanjeTextBox.Size = new Size(280, 27);
            MarkaZakazivanjeTextBox.TabIndex = 8;
            MarkaZakazivanjeTextBox.Visible = false;
            // 
            // ModelZakazivanjeTextBox
            // 
            ModelZakazivanjeTextBox.Location = new Point(480, 219);
            ModelZakazivanjeTextBox.Name = "ModelZakazivanjeTextBox";
            ModelZakazivanjeTextBox.Size = new Size(280, 27);
            ModelZakazivanjeTextBox.TabIndex = 9;
            ModelZakazivanjeTextBox.Visible = false;
            // 
            // GodisteZakazivanjeTextBox
            // 
            GodisteZakazivanjeTextBox.Location = new Point(480, 252);
            GodisteZakazivanjeTextBox.Name = "GodisteZakazivanjeTextBox";
            GodisteZakazivanjeTextBox.Size = new Size(280, 27);
            GodisteZakazivanjeTextBox.TabIndex = 10;
            GodisteZakazivanjeTextBox.Visible = false;
            // 
            // KubikazaZakazivanjeTextBox
            // 
            KubikazaZakazivanjeTextBox.Location = new Point(480, 285);
            KubikazaZakazivanjeTextBox.Name = "KubikazaZakazivanjeTextBox";
            KubikazaZakazivanjeTextBox.Size = new Size(280, 27);
            KubikazaZakazivanjeTextBox.TabIndex = 11;
            KubikazaZakazivanjeTextBox.Visible = false;
            // 
            // KategorijaZakazivanjeComboBox
            // 
            KategorijaZakazivanjeComboBox.FormattingEnabled = true;
            KategorijaZakazivanjeComboBox.Items.AddRange(new object[] { "M – Vozila za prevoz putnika", "L – Mopedi, Motocikli, Tricikli i Četvorocikli", "N – Teretna vozila", "O – priključna vozila", "T – Traktori", "R – Priključno vozilo traktora", "G – Terenska vozila" });
            KategorijaZakazivanjeComboBox.Location = new Point(480, 119);
            KategorijaZakazivanjeComboBox.Name = "KategorijaZakazivanjeComboBox";
            KategorijaZakazivanjeComboBox.Size = new Size(280, 28);
            KategorijaZakazivanjeComboBox.TabIndex = 18;
            KategorijaZakazivanjeComboBox.Visible = false;
            KategorijaZakazivanjeComboBox.SelectedIndexChanged += KategorijaZakazivanjeComboBox_SelectedIndexChanged;
            // 
            // PotkategorijaZakazivanjeComboBox
            // 
            PotkategorijaZakazivanjeComboBox.FormattingEnabled = true;
            PotkategorijaZakazivanjeComboBox.Location = new Point(480, 153);
            PotkategorijaZakazivanjeComboBox.Name = "PotkategorijaZakazivanjeComboBox";
            PotkategorijaZakazivanjeComboBox.Size = new Size(280, 28);
            PotkategorijaZakazivanjeComboBox.TabIndex = 19;
            PotkategorijaZakazivanjeComboBox.Visible = false;
            // 
            // KategorijaZakazivanjeLabel
            // 
            KategorijaZakazivanjeLabel.AutoSize = true;
            KategorijaZakazivanjeLabel.Location = new Point(374, 123);
            KategorijaZakazivanjeLabel.Name = "KategorijaZakazivanjeLabel";
            KategorijaZakazivanjeLabel.Size = new Size(81, 20);
            KategorijaZakazivanjeLabel.TabIndex = 12;
            KategorijaZakazivanjeLabel.Text = "Kategorija:";
            KategorijaZakazivanjeLabel.Visible = false;
            // 
            // PotkategorijaZakazivanjeLabel
            // 
            PotkategorijaZakazivanjeLabel.AutoSize = true;
            PotkategorijaZakazivanjeLabel.Location = new Point(374, 156);
            PotkategorijaZakazivanjeLabel.Name = "PotkategorijaZakazivanjeLabel";
            PotkategorijaZakazivanjeLabel.Size = new Size(100, 20);
            PotkategorijaZakazivanjeLabel.TabIndex = 13;
            PotkategorijaZakazivanjeLabel.Text = "Potkategorija:";
            PotkategorijaZakazivanjeLabel.Visible = false;
            // 
            // MarkaZakazivanjeLabel
            // 
            MarkaZakazivanjeLabel.AutoSize = true;
            MarkaZakazivanjeLabel.Location = new Point(374, 189);
            MarkaZakazivanjeLabel.Name = "MarkaZakazivanjeLabel";
            MarkaZakazivanjeLabel.Size = new Size(53, 20);
            MarkaZakazivanjeLabel.TabIndex = 14;
            MarkaZakazivanjeLabel.Text = "Marka:";
            MarkaZakazivanjeLabel.Visible = false;
            // 
            // ModelZakazivanjeLabel
            // 
            ModelZakazivanjeLabel.AutoSize = true;
            ModelZakazivanjeLabel.Location = new Point(374, 222);
            ModelZakazivanjeLabel.Name = "ModelZakazivanjeLabel";
            ModelZakazivanjeLabel.Size = new Size(55, 20);
            ModelZakazivanjeLabel.TabIndex = 15;
            ModelZakazivanjeLabel.Text = "Model:";
            ModelZakazivanjeLabel.Visible = false;
            // 
            // GodisteZakazivanjeLabel
            // 
            GodisteZakazivanjeLabel.AutoSize = true;
            GodisteZakazivanjeLabel.Location = new Point(374, 255);
            GodisteZakazivanjeLabel.Name = "GodisteZakazivanjeLabel";
            GodisteZakazivanjeLabel.Size = new Size(63, 20);
            GodisteZakazivanjeLabel.TabIndex = 16;
            GodisteZakazivanjeLabel.Text = "Godište:";
            GodisteZakazivanjeLabel.Visible = false;
            // 
            // KubikazaZakazivanjeLabel
            // 
            KubikazaZakazivanjeLabel.AutoSize = true;
            KubikazaZakazivanjeLabel.Location = new Point(374, 288);
            KubikazaZakazivanjeLabel.Name = "KubikazaZakazivanjeLabel";
            KubikazaZakazivanjeLabel.Size = new Size(72, 20);
            KubikazaZakazivanjeLabel.TabIndex = 17;
            KubikazaZakazivanjeLabel.Text = "Kubikaža:";
            KubikazaZakazivanjeLabel.Visible = false;
            // 
            // ZakaziTerminaAkoVoziloNePostojiButton
            // 
            ZakaziTerminaAkoVoziloNePostojiButton.Location = new Point(335, 370);
            ZakaziTerminaAkoVoziloNePostojiButton.Name = "ZakaziTerminaAkoVoziloNePostojiButton";
            ZakaziTerminaAkoVoziloNePostojiButton.Size = new Size(130, 29);
            ZakaziTerminaAkoVoziloNePostojiButton.TabIndex = 20;
            ZakaziTerminaAkoVoziloNePostojiButton.Text = "Zakaži termin";
            ZakaziTerminaAkoVoziloNePostojiButton.UseVisualStyleBackColor = true;
            ZakaziTerminaAkoVoziloNePostojiButton.Visible = false;
            ZakaziTerminaAkoVoziloNePostojiButton.Click += ZakaziTerminaAkoVoziloNePostojiButton_Click;
            // 
            // NazadSaZakazivanjaTerminaTehnickogNaLogovanogKlijenta
            // 
            NazadSaZakazivanjaTerminaTehnickogNaLogovanogKlijenta.Location = new Point(694, 409);
            NazadSaZakazivanjaTerminaTehnickogNaLogovanogKlijenta.Name = "NazadSaZakazivanjaTerminaTehnickogNaLogovanogKlijenta";
            NazadSaZakazivanjaTerminaTehnickogNaLogovanogKlijenta.Size = new Size(94, 29);
            NazadSaZakazivanjaTerminaTehnickogNaLogovanogKlijenta.TabIndex = 8;
            NazadSaZakazivanjaTerminaTehnickogNaLogovanogKlijenta.Text = "Nazad";
            NazadSaZakazivanjaTerminaTehnickogNaLogovanogKlijenta.UseVisualStyleBackColor = true;
            NazadSaZakazivanjaTerminaTehnickogNaLogovanogKlijenta.Click += NazadSaZakazivanjaTerminaTehnickogNaLogovanogKlijenta_Click;
            // 
            // AdministratorPanel
            // 
            AdministratorPanel.Controls.Add(KorisnickoImeAdministratorLabelLogin);
            AdministratorPanel.Controls.Add(LozinkaAdministratorLabelLogin);
            AdministratorPanel.Controls.Add(LozinkaAdministratorTextBoxLogin);
            AdministratorPanel.Controls.Add(KorisnickoImeAdministratorTextBoxLogin);
            AdministratorPanel.Controls.Add(PrijaviSeAdministratorButton);
            AdministratorPanel.Controls.Add(NazadAdministratorButton);
            AdministratorPanel.Controls.Add(LogovanAdministratorPanel);
            AdministratorPanel.Dock = DockStyle.Fill;
            AdministratorPanel.Location = new Point(0, 0);
            AdministratorPanel.Name = "AdministratorPanel";
            AdministratorPanel.Size = new Size(800, 450);
            AdministratorPanel.TabIndex = 1;
            AdministratorPanel.Visible = false;
            // 
            // KorisnickoImeAdministratorLabelLogin
            // 
            KorisnickoImeAdministratorLabelLogin.AutoSize = true;
            KorisnickoImeAdministratorLabelLogin.Location = new Point(185, 103);
            KorisnickoImeAdministratorLabelLogin.Name = "KorisnickoImeAdministratorLabelLogin";
            KorisnickoImeAdministratorLabelLogin.Size = new Size(109, 20);
            KorisnickoImeAdministratorLabelLogin.TabIndex = 0;
            KorisnickoImeAdministratorLabelLogin.Text = "Korisničko ime:";
            // 
            // LozinkaAdministratorLabelLogin
            // 
            LozinkaAdministratorLabelLogin.AutoSize = true;
            LozinkaAdministratorLabelLogin.Location = new Point(185, 137);
            LozinkaAdministratorLabelLogin.Name = "LozinkaAdministratorLabelLogin";
            LozinkaAdministratorLabelLogin.Size = new Size(62, 20);
            LozinkaAdministratorLabelLogin.TabIndex = 3;
            LozinkaAdministratorLabelLogin.Text = "Lozinka:";
            // 
            // LozinkaAdministratorTextBoxLogin
            // 
            LozinkaAdministratorTextBoxLogin.Location = new Point(300, 133);
            LozinkaAdministratorTextBoxLogin.Name = "LozinkaAdministratorTextBoxLogin";
            LozinkaAdministratorTextBoxLogin.PasswordChar = '*';
            LozinkaAdministratorTextBoxLogin.Size = new Size(200, 27);
            LozinkaAdministratorTextBoxLogin.TabIndex = 2;
            // 
            // KorisnickoImeAdministratorTextBoxLogin
            // 
            KorisnickoImeAdministratorTextBoxLogin.Location = new Point(300, 100);
            KorisnickoImeAdministratorTextBoxLogin.Name = "KorisnickoImeAdministratorTextBoxLogin";
            KorisnickoImeAdministratorTextBoxLogin.Size = new Size(200, 27);
            KorisnickoImeAdministratorTextBoxLogin.TabIndex = 1;
            // 
            // PrijaviSeAdministratorButton
            // 
            PrijaviSeAdministratorButton.Location = new Point(300, 166);
            PrijaviSeAdministratorButton.Name = "PrijaviSeAdministratorButton";
            PrijaviSeAdministratorButton.Size = new Size(200, 29);
            PrijaviSeAdministratorButton.TabIndex = 5;
            PrijaviSeAdministratorButton.Text = "Prijavi se";
            PrijaviSeAdministratorButton.UseVisualStyleBackColor = true;
            PrijaviSeAdministratorButton.Click += PrijaviSeAdministratorButton_Click;
            // 
            // NazadAdministratorButton
            // 
            NazadAdministratorButton.Location = new Point(694, 409);
            NazadAdministratorButton.Name = "NazadAdministratorButton";
            NazadAdministratorButton.Size = new Size(94, 29);
            NazadAdministratorButton.TabIndex = 6;
            NazadAdministratorButton.Text = "Nazad";
            NazadAdministratorButton.UseVisualStyleBackColor = true;
            NazadAdministratorButton.Click += NazadAdministratorButton_Click;
            // 
            // LogovanAdministratorPanel
            // 
            LogovanAdministratorPanel.Controls.Add(OdjavaLogovanogAdministratoraButton);
            LogovanAdministratorPanel.Controls.Add(PracenjeStatistikeButton);
            LogovanAdministratorPanel.Controls.Add(PracenjeStatistikePanel);
            LogovanAdministratorPanel.Controls.Add(PregledPostojecihNalogaButton);
            LogovanAdministratorPanel.Controls.Add(BrisanjeRadnickihNalogaButton);
            LogovanAdministratorPanel.Controls.Add(BrisanjeAdministratorskihNalogaButton);
            LogovanAdministratorPanel.Controls.Add(KreiranjeRadnickihNalogaButton);
            LogovanAdministratorPanel.Controls.Add(KreiranjeAdministratorskihNalogaButton);
            LogovanAdministratorPanel.Controls.Add(RegistracijaAdministratorskihNalogaPanel);
            LogovanAdministratorPanel.Controls.Add(PregledPostojecihNalogaPanel);
            LogovanAdministratorPanel.Controls.Add(RegistracijaRadnickihNalogaPanel);
            LogovanAdministratorPanel.Controls.Add(BrisanjeRadnickihNalogaPanel);
            LogovanAdministratorPanel.Controls.Add(BrisanjeAdministratorskihNalogaPanel);
            LogovanAdministratorPanel.Location = new Point(0, 0);
            LogovanAdministratorPanel.Name = "LogovanAdministratorPanel";
            LogovanAdministratorPanel.Size = new Size(800, 450);
            LogovanAdministratorPanel.TabIndex = 20;
            LogovanAdministratorPanel.Visible = false;
            // 
            // OdjavaLogovanogAdministratoraButton
            // 
            OdjavaLogovanogAdministratoraButton.Location = new Point(694, 409);
            OdjavaLogovanogAdministratoraButton.Name = "OdjavaLogovanogAdministratoraButton";
            OdjavaLogovanogAdministratoraButton.Size = new Size(94, 29);
            OdjavaLogovanogAdministratoraButton.TabIndex = 6;
            OdjavaLogovanogAdministratoraButton.Text = "Odjava";
            OdjavaLogovanogAdministratoraButton.UseVisualStyleBackColor = true;
            OdjavaLogovanogAdministratoraButton.Click += OdjavaLogovanogAdministratoraButton_Click;
            // 
            // PracenjeStatistikeButton
            // 
            PracenjeStatistikeButton.Location = new Point(450, 320);
            PracenjeStatistikeButton.Name = "PracenjeStatistikeButton";
            PracenjeStatistikeButton.Size = new Size(250, 70);
            PracenjeStatistikeButton.TabIndex = 5;
            PracenjeStatistikeButton.Text = "Praćenje statistike";
            PracenjeStatistikeButton.UseVisualStyleBackColor = true;
            PracenjeStatistikeButton.Click += PracenjeStatistikeButton_Click;
            // 
            // PracenjeStatistikePanel
            // 
            PracenjeStatistikePanel.Controls.Add(NazadSaPanelaZaPracenjeStatistikeNaPanelPrijavljenogAdministratoraButton);
            PracenjeStatistikePanel.Controls.Add(VozilaKojaSuProslaTehnickiButton);
            PracenjeStatistikePanel.Controls.Add(VozilaKojaNisuProslaTehnickiButton);
            PracenjeStatistikePanel.Controls.Add(PrikazStatistikePanel);
            PracenjeStatistikePanel.Dock = DockStyle.Fill;
            PracenjeStatistikePanel.Location = new Point(0, 0);
            PracenjeStatistikePanel.Name = "PracenjeStatistikePanel";
            PracenjeStatistikePanel.Size = new Size(800, 450);
            PracenjeStatistikePanel.TabIndex = 7;
            PracenjeStatistikePanel.Visible = false;
            // 
            // NazadSaPanelaZaPracenjeStatistikeNaPanelPrijavljenogAdministratoraButton
            // 
            NazadSaPanelaZaPracenjeStatistikeNaPanelPrijavljenogAdministratoraButton.Location = new Point(694, 409);
            NazadSaPanelaZaPracenjeStatistikeNaPanelPrijavljenogAdministratoraButton.Name = "NazadSaPanelaZaPracenjeStatistikeNaPanelPrijavljenogAdministratoraButton";
            NazadSaPanelaZaPracenjeStatistikeNaPanelPrijavljenogAdministratoraButton.Size = new Size(94, 29);
            NazadSaPanelaZaPracenjeStatistikeNaPanelPrijavljenogAdministratoraButton.TabIndex = 20;
            NazadSaPanelaZaPracenjeStatistikeNaPanelPrijavljenogAdministratoraButton.Text = "Nazad";
            NazadSaPanelaZaPracenjeStatistikeNaPanelPrijavljenogAdministratoraButton.UseVisualStyleBackColor = true;
            NazadSaPanelaZaPracenjeStatistikeNaPanelPrijavljenogAdministratoraButton.Click += NazadSaPanelaZaPracenjeStatistikeNaPanelPrijavljenogAdministratoraButton_Click;
            // 
            // VozilaKojaSuProslaTehnickiButton
            // 
            VozilaKojaSuProslaTehnickiButton.Location = new Point(120, 166);
            VozilaKojaSuProslaTehnickiButton.Name = "VozilaKojaSuProslaTehnickiButton";
            VozilaKojaSuProslaTehnickiButton.Size = new Size(267, 71);
            VozilaKojaSuProslaTehnickiButton.TabIndex = 2;
            VozilaKojaSuProslaTehnickiButton.Text = "Vozila koja su prošla tehnički pregled";
            VozilaKojaSuProslaTehnickiButton.UseVisualStyleBackColor = true;
            VozilaKojaSuProslaTehnickiButton.Click += VozilaKojaSuProslaTehnickiButton_Click;
            // 
            // VozilaKojaNisuProslaTehnickiButton
            // 
            VozilaKojaNisuProslaTehnickiButton.Location = new Point(436, 166);
            VozilaKojaNisuProslaTehnickiButton.Name = "VozilaKojaNisuProslaTehnickiButton";
            VozilaKojaNisuProslaTehnickiButton.Size = new Size(283, 71);
            VozilaKojaNisuProslaTehnickiButton.TabIndex = 3;
            VozilaKojaNisuProslaTehnickiButton.Text = "Vozila koja nisu prošla tehnički pregled";
            VozilaKojaNisuProslaTehnickiButton.UseVisualStyleBackColor = true;
            VozilaKojaNisuProslaTehnickiButton.Click += VozilaKojaNisuProslaTehnickiButton_Click;
            // 
            // PrikazStatistikePanel
            // 
            PrikazStatistikePanel.Controls.Add(KategorijaComboBox);
            PrikazStatistikePanel.Controls.Add(PotkategorijaComboBox);
            PrikazStatistikePanel.Controls.Add(PrikazStatistikeUPrikazuStatistikeButton);
            PrikazStatistikePanel.Controls.Add(StatistikaRichTextBox);
            PrikazStatistikePanel.Controls.Add(NazadSaPanelaZaPrikazStatistikeNaPanelZaPracenjeStatistikeButton);
            PrikazStatistikePanel.Dock = DockStyle.Fill;
            PrikazStatistikePanel.Location = new Point(0, 0);
            PrikazStatistikePanel.Name = "PrikazStatistikePanel";
            PrikazStatistikePanel.Size = new Size(800, 450);
            PrikazStatistikePanel.TabIndex = 1;
            PrikazStatistikePanel.Visible = false;
            // 
            // KategorijaComboBox
            // 
            KategorijaComboBox.FormattingEnabled = true;
            KategorijaComboBox.Location = new Point(222, 43);
            KategorijaComboBox.Name = "KategorijaComboBox";
            KategorijaComboBox.Size = new Size(378, 28);
            KategorijaComboBox.TabIndex = 1;
            KategorijaComboBox.SelectedIndexChanged += KategorijaComboBox_SelectedIndexChanged;
            // 
            // PotkategorijaComboBox
            // 
            PotkategorijaComboBox.FormattingEnabled = true;
            PotkategorijaComboBox.Location = new Point(222, 91);
            PotkategorijaComboBox.Name = "PotkategorijaComboBox";
            PotkategorijaComboBox.Size = new Size(378, 28);
            PotkategorijaComboBox.TabIndex = 2;
            // 
            // PrikazStatistikeUPrikazuStatistikeButton
            // 
            PrikazStatistikeUPrikazuStatistikeButton.Location = new Point(334, 165);
            PrikazStatistikeUPrikazuStatistikeButton.Name = "PrikazStatistikeUPrikazuStatistikeButton";
            PrikazStatistikeUPrikazuStatistikeButton.Size = new Size(175, 31);
            PrikazStatistikeUPrikazuStatistikeButton.TabIndex = 3;
            PrikazStatistikeUPrikazuStatistikeButton.Text = "Prikaz statistike";
            PrikazStatistikeUPrikazuStatistikeButton.UseVisualStyleBackColor = true;
            PrikazStatistikeUPrikazuStatistikeButton.Click += PrikazStatistikeUPrikazuStatistikeButton_Click;
            // 
            // StatistikaRichTextBox
            // 
            StatistikaRichTextBox.Location = new Point(30, 250);
            StatistikaRichTextBox.Name = "StatistikaRichTextBox";
            StatistikaRichTextBox.ReadOnly = true;
            StatistikaRichTextBox.Size = new Size(640, 190);
            StatistikaRichTextBox.TabIndex = 2;
            StatistikaRichTextBox.Text = "";
            StatistikaRichTextBox.WordWrap = false;
            // 
            // NazadSaPanelaZaPrikazStatistikeNaPanelZaPracenjeStatistikeButton
            // 
            NazadSaPanelaZaPrikazStatistikeNaPanelZaPracenjeStatistikeButton.Location = new Point(694, 409);
            NazadSaPanelaZaPrikazStatistikeNaPanelZaPracenjeStatistikeButton.Name = "NazadSaPanelaZaPrikazStatistikeNaPanelZaPracenjeStatistikeButton";
            NazadSaPanelaZaPrikazStatistikeNaPanelZaPracenjeStatistikeButton.Size = new Size(94, 29);
            NazadSaPanelaZaPrikazStatistikeNaPanelZaPracenjeStatistikeButton.TabIndex = 6;
            NazadSaPanelaZaPrikazStatistikeNaPanelZaPracenjeStatistikeButton.Text = "Nazad";
            NazadSaPanelaZaPrikazStatistikeNaPanelZaPracenjeStatistikeButton.UseVisualStyleBackColor = true;
            NazadSaPanelaZaPrikazStatistikeNaPanelZaPracenjeStatistikeButton.Click += NazadSaPanelaZaPrikazStatistikeNaPanelZaPracenjeStatistikeButton_Click;
            // 
            // PregledPostojecihNalogaButton
            // 
            PregledPostojecihNalogaButton.Location = new Point(100, 320);
            PregledPostojecihNalogaButton.Name = "PregledPostojecihNalogaButton";
            PregledPostojecihNalogaButton.Size = new Size(250, 70);
            PregledPostojecihNalogaButton.TabIndex = 4;
            PregledPostojecihNalogaButton.Text = "Pregled postojećih naloga";
            PregledPostojecihNalogaButton.UseVisualStyleBackColor = true;
            PregledPostojecihNalogaButton.Click += PregledPostojecihNalogaButton_Click;
            // 
            // BrisanjeRadnickihNalogaButton
            // 
            BrisanjeRadnickihNalogaButton.Location = new Point(450, 190);
            BrisanjeRadnickihNalogaButton.Name = "BrisanjeRadnickihNalogaButton";
            BrisanjeRadnickihNalogaButton.Size = new Size(250, 70);
            BrisanjeRadnickihNalogaButton.TabIndex = 3;
            BrisanjeRadnickihNalogaButton.Text = "Brisanje radničkih naloga";
            BrisanjeRadnickihNalogaButton.UseVisualStyleBackColor = true;
            BrisanjeRadnickihNalogaButton.Click += BrisanjeRadnickihNalogaButton_Click;
            // 
            // BrisanjeAdministratorskihNalogaButton
            // 
            BrisanjeAdministratorskihNalogaButton.Location = new Point(100, 190);
            BrisanjeAdministratorskihNalogaButton.Name = "BrisanjeAdministratorskihNalogaButton";
            BrisanjeAdministratorskihNalogaButton.Size = new Size(250, 70);
            BrisanjeAdministratorskihNalogaButton.TabIndex = 2;
            BrisanjeAdministratorskihNalogaButton.Text = "Brisanje administratorskih naloga";
            BrisanjeAdministratorskihNalogaButton.UseVisualStyleBackColor = true;
            BrisanjeAdministratorskihNalogaButton.Click += BrisanjeAdministratorskihNalogaButton_Click;
            // 
            // KreiranjeRadnickihNalogaButton
            // 
            KreiranjeRadnickihNalogaButton.Location = new Point(450, 60);
            KreiranjeRadnickihNalogaButton.Name = "KreiranjeRadnickihNalogaButton";
            KreiranjeRadnickihNalogaButton.Size = new Size(250, 70);
            KreiranjeRadnickihNalogaButton.TabIndex = 1;
            KreiranjeRadnickihNalogaButton.Text = "Kreiranje radničkih naloga";
            KreiranjeRadnickihNalogaButton.UseVisualStyleBackColor = true;
            KreiranjeRadnickihNalogaButton.Click += KreiranjeRadnickihNalogaButton_Click;
            // 
            // KreiranjeAdministratorskihNalogaButton
            // 
            KreiranjeAdministratorskihNalogaButton.Location = new Point(100, 60);
            KreiranjeAdministratorskihNalogaButton.Name = "KreiranjeAdministratorskihNalogaButton";
            KreiranjeAdministratorskihNalogaButton.Size = new Size(250, 70);
            KreiranjeAdministratorskihNalogaButton.TabIndex = 0;
            KreiranjeAdministratorskihNalogaButton.Text = "Kreiranje administratorskih naloga";
            KreiranjeAdministratorskihNalogaButton.UseVisualStyleBackColor = true;
            KreiranjeAdministratorskihNalogaButton.Click += KreiranjeAdministratorskihNalogaButton_Click;
            // 
            // RegistracijaAdministratorskihNalogaPanel
            // 
            RegistracijaAdministratorskihNalogaPanel.Controls.Add(RegistrujAdministratorskiNalogButton);
            RegistracijaAdministratorskihNalogaPanel.Controls.Add(PotvrdaLozinkeAdminRegistracijaLabel);
            RegistracijaAdministratorskihNalogaPanel.Controls.Add(LozinkaAdminRegistracijaLabel);
            RegistracijaAdministratorskihNalogaPanel.Controls.Add(KorisnickoImeAdminRegistracijaLabel);
            RegistracijaAdministratorskihNalogaPanel.Controls.Add(PrezimeAdminRegistracijaLabel);
            RegistracijaAdministratorskihNalogaPanel.Controls.Add(ImeAdminRegistracijaLabel);
            RegistracijaAdministratorskihNalogaPanel.Controls.Add(PotvrdaLozinkeAdminRegistracijaTextBox);
            RegistracijaAdministratorskihNalogaPanel.Controls.Add(LozinkaAdminRegistracijaTextBox);
            RegistracijaAdministratorskihNalogaPanel.Controls.Add(KorisnickoImeAdminRegistracijaTextBox);
            RegistracijaAdministratorskihNalogaPanel.Controls.Add(PrezimeAdminRegistracijaTextBox);
            RegistracijaAdministratorskihNalogaPanel.Controls.Add(ImeAdminRegistracijaTextBox);
            RegistracijaAdministratorskihNalogaPanel.Controls.Add(NazadSaPanelaZaRegisteracijuAdministratoraNaPanelPrijavljenogAdministratoraButton);
            RegistracijaAdministratorskihNalogaPanel.Dock = DockStyle.Fill;
            RegistracijaAdministratorskihNalogaPanel.Location = new Point(0, 0);
            RegistracijaAdministratorskihNalogaPanel.Name = "RegistracijaAdministratorskihNalogaPanel";
            RegistracijaAdministratorskihNalogaPanel.Size = new Size(800, 450);
            RegistracijaAdministratorskihNalogaPanel.TabIndex = 20;
            RegistracijaAdministratorskihNalogaPanel.Visible = false;
            // 
            // RegistrujAdministratorskiNalogButton
            // 
            RegistrujAdministratorskiNalogButton.Location = new Point(300, 290);
            RegistrujAdministratorskiNalogButton.Name = "RegistrujAdministratorskiNalogButton";
            RegistrujAdministratorskiNalogButton.Size = new Size(200, 57);
            RegistrujAdministratorskiNalogButton.TabIndex = 10;
            RegistrujAdministratorskiNalogButton.Text = "Registruj administrtorski nalog";
            RegistrujAdministratorskiNalogButton.UseVisualStyleBackColor = true;
            RegistrujAdministratorskiNalogButton.Click += RegistrujAdministratorskiNalogButton_Click;
            // 
            // PotvrdaLozinkeAdminRegistracijaLabel
            // 
            PotvrdaLozinkeAdminRegistracijaLabel.AutoSize = true;
            PotvrdaLozinkeAdminRegistracijaLabel.Location = new Point(181, 235);
            PotvrdaLozinkeAdminRegistracijaLabel.Name = "PotvrdaLozinkeAdminRegistracijaLabel";
            PotvrdaLozinkeAdminRegistracijaLabel.Size = new Size(113, 20);
            PotvrdaLozinkeAdminRegistracijaLabel.TabIndex = 9;
            PotvrdaLozinkeAdminRegistracijaLabel.Text = "Potvrda lozinke:";
            // 
            // LozinkaAdminRegistracijaLabel
            // 
            LozinkaAdminRegistracijaLabel.AutoSize = true;
            LozinkaAdminRegistracijaLabel.Location = new Point(181, 202);
            LozinkaAdminRegistracijaLabel.Name = "LozinkaAdminRegistracijaLabel";
            LozinkaAdminRegistracijaLabel.Size = new Size(62, 20);
            LozinkaAdminRegistracijaLabel.TabIndex = 8;
            LozinkaAdminRegistracijaLabel.Text = "Lozinka:";
            // 
            // KorisnickoImeAdminRegistracijaLabel
            // 
            KorisnickoImeAdminRegistracijaLabel.AutoSize = true;
            KorisnickoImeAdminRegistracijaLabel.Location = new Point(181, 169);
            KorisnickoImeAdminRegistracijaLabel.Name = "KorisnickoImeAdminRegistracijaLabel";
            KorisnickoImeAdminRegistracijaLabel.Size = new Size(109, 20);
            KorisnickoImeAdminRegistracijaLabel.TabIndex = 7;
            KorisnickoImeAdminRegistracijaLabel.Text = "Korisničko ime:";
            // 
            // PrezimeAdminRegistracijaLabel
            // 
            PrezimeAdminRegistracijaLabel.AutoSize = true;
            PrezimeAdminRegistracijaLabel.Location = new Point(181, 136);
            PrezimeAdminRegistracijaLabel.Name = "PrezimeAdminRegistracijaLabel";
            PrezimeAdminRegistracijaLabel.Size = new Size(65, 20);
            PrezimeAdminRegistracijaLabel.TabIndex = 6;
            PrezimeAdminRegistracijaLabel.Text = "Prezime:";
            // 
            // ImeAdminRegistracijaLabel
            // 
            ImeAdminRegistracijaLabel.AutoSize = true;
            ImeAdminRegistracijaLabel.Location = new Point(181, 103);
            ImeAdminRegistracijaLabel.Name = "ImeAdminRegistracijaLabel";
            ImeAdminRegistracijaLabel.Size = new Size(37, 20);
            ImeAdminRegistracijaLabel.TabIndex = 5;
            ImeAdminRegistracijaLabel.Text = "Ime:";
            // 
            // PotvrdaLozinkeAdminRegistracijaTextBox
            // 
            PotvrdaLozinkeAdminRegistracijaTextBox.Location = new Point(300, 234);
            PotvrdaLozinkeAdminRegistracijaTextBox.Name = "PotvrdaLozinkeAdminRegistracijaTextBox";
            PotvrdaLozinkeAdminRegistracijaTextBox.PasswordChar = '*';
            PotvrdaLozinkeAdminRegistracijaTextBox.Size = new Size(200, 27);
            PotvrdaLozinkeAdminRegistracijaTextBox.TabIndex = 4;
            // 
            // LozinkaAdminRegistracijaTextBox
            // 
            LozinkaAdminRegistracijaTextBox.Location = new Point(300, 201);
            LozinkaAdminRegistracijaTextBox.Name = "LozinkaAdminRegistracijaTextBox";
            LozinkaAdminRegistracijaTextBox.PasswordChar = '*';
            LozinkaAdminRegistracijaTextBox.Size = new Size(200, 27);
            LozinkaAdminRegistracijaTextBox.TabIndex = 3;
            // 
            // KorisnickoImeAdminRegistracijaTextBox
            // 
            KorisnickoImeAdminRegistracijaTextBox.Location = new Point(300, 166);
            KorisnickoImeAdminRegistracijaTextBox.Name = "KorisnickoImeAdminRegistracijaTextBox";
            KorisnickoImeAdminRegistracijaTextBox.Size = new Size(200, 27);
            KorisnickoImeAdminRegistracijaTextBox.TabIndex = 2;
            // 
            // PrezimeAdminRegistracijaTextBox
            // 
            PrezimeAdminRegistracijaTextBox.Location = new Point(300, 133);
            PrezimeAdminRegistracijaTextBox.Name = "PrezimeAdminRegistracijaTextBox";
            PrezimeAdminRegistracijaTextBox.Size = new Size(200, 27);
            PrezimeAdminRegistracijaTextBox.TabIndex = 1;
            // 
            // ImeAdminRegistracijaTextBox
            // 
            ImeAdminRegistracijaTextBox.Location = new Point(300, 100);
            ImeAdminRegistracijaTextBox.Name = "ImeAdminRegistracijaTextBox";
            ImeAdminRegistracijaTextBox.Size = new Size(200, 27);
            ImeAdminRegistracijaTextBox.TabIndex = 0;
            // 
            // NazadSaPanelaZaRegisteracijuAdministratoraNaPanelPrijavljenogAdministratoraButton
            // 
            NazadSaPanelaZaRegisteracijuAdministratoraNaPanelPrijavljenogAdministratoraButton.Location = new Point(694, 409);
            NazadSaPanelaZaRegisteracijuAdministratoraNaPanelPrijavljenogAdministratoraButton.Name = "NazadSaPanelaZaRegisteracijuAdministratoraNaPanelPrijavljenogAdministratoraButton";
            NazadSaPanelaZaRegisteracijuAdministratoraNaPanelPrijavljenogAdministratoraButton.Size = new Size(94, 29);
            NazadSaPanelaZaRegisteracijuAdministratoraNaPanelPrijavljenogAdministratoraButton.TabIndex = 20;
            NazadSaPanelaZaRegisteracijuAdministratoraNaPanelPrijavljenogAdministratoraButton.Text = "Nazad";
            NazadSaPanelaZaRegisteracijuAdministratoraNaPanelPrijavljenogAdministratoraButton.UseVisualStyleBackColor = true;
            NazadSaPanelaZaRegisteracijuAdministratoraNaPanelPrijavljenogAdministratoraButton.Click += NazadSaPanelaZaRegisteracijuAdministratoraNaPanelPrijavljenogAdministratoraButton_Click;
            // 
            // PregledPostojecihNalogaPanel
            // 
            PregledPostojecihNalogaPanel.Controls.Add(NazadSaPanelaZaPregledPostojecihNalogaNaPanelPrijavljenogAdministratoraButton);
            PregledPostojecihNalogaPanel.Controls.Add(PregledPostojecihNalogaKlijentListBox);
            PregledPostojecihNalogaPanel.Controls.Add(PregledPostojecihNalogaRadnikListBox);
            PregledPostojecihNalogaPanel.Controls.Add(PregledPostojecihNalogaAdminListBox);
            PregledPostojecihNalogaPanel.Controls.Add(PregledPostojecihNalogaKlijentLabel);
            PregledPostojecihNalogaPanel.Controls.Add(PregledPostojecihNalogaRadnikLabel);
            PregledPostojecihNalogaPanel.Controls.Add(PregledPostojecihNalogaAdminLabel);
            PregledPostojecihNalogaPanel.Dock = DockStyle.Fill;
            PregledPostojecihNalogaPanel.Location = new Point(0, 0);
            PregledPostojecihNalogaPanel.Name = "PregledPostojecihNalogaPanel";
            PregledPostojecihNalogaPanel.Size = new Size(800, 450);
            PregledPostojecihNalogaPanel.TabIndex = 20;
            PregledPostojecihNalogaPanel.Visible = false;
            // 
            // NazadSaPanelaZaPregledPostojecihNalogaNaPanelPrijavljenogAdministratoraButton
            // 
            NazadSaPanelaZaPregledPostojecihNalogaNaPanelPrijavljenogAdministratoraButton.Location = new Point(694, 409);
            NazadSaPanelaZaPregledPostojecihNalogaNaPanelPrijavljenogAdministratoraButton.Name = "NazadSaPanelaZaPregledPostojecihNalogaNaPanelPrijavljenogAdministratoraButton";
            NazadSaPanelaZaPregledPostojecihNalogaNaPanelPrijavljenogAdministratoraButton.Size = new Size(94, 29);
            NazadSaPanelaZaPregledPostojecihNalogaNaPanelPrijavljenogAdministratoraButton.TabIndex = 20;
            NazadSaPanelaZaPregledPostojecihNalogaNaPanelPrijavljenogAdministratoraButton.Text = "Nazad";
            NazadSaPanelaZaPregledPostojecihNalogaNaPanelPrijavljenogAdministratoraButton.UseVisualStyleBackColor = true;
            NazadSaPanelaZaPregledPostojecihNalogaNaPanelPrijavljenogAdministratoraButton.Click += NazadSaPanelaZaPregledPostojecihNalogaNaPanelPrijavljenogAdministratoraButton_Click;
            // 
            // PregledPostojecihNalogaKlijentListBox
            // 
            PregledPostojecihNalogaKlijentListBox.FormattingEnabled = true;
            PregledPostojecihNalogaKlijentListBox.HorizontalScrollbar = true;
            PregledPostojecihNalogaKlijentListBox.ItemHeight = 20;
            PregledPostojecihNalogaKlijentListBox.Location = new Point(50, 73);
            PregledPostojecihNalogaKlijentListBox.Name = "PregledPostojecihNalogaKlijentListBox";
            PregledPostojecihNalogaKlijentListBox.Size = new Size(200, 304);
            PregledPostojecihNalogaKlijentListBox.TabIndex = 1;
            // 
            // PregledPostojecihNalogaRadnikListBox
            // 
            PregledPostojecihNalogaRadnikListBox.FormattingEnabled = true;
            PregledPostojecihNalogaRadnikListBox.HorizontalScrollbar = true;
            PregledPostojecihNalogaRadnikListBox.ItemHeight = 20;
            PregledPostojecihNalogaRadnikListBox.Location = new Point(280, 73);
            PregledPostojecihNalogaRadnikListBox.Name = "PregledPostojecihNalogaRadnikListBox";
            PregledPostojecihNalogaRadnikListBox.Size = new Size(200, 304);
            PregledPostojecihNalogaRadnikListBox.TabIndex = 1;
            // 
            // PregledPostojecihNalogaAdminListBox
            // 
            PregledPostojecihNalogaAdminListBox.FormattingEnabled = true;
            PregledPostojecihNalogaAdminListBox.HorizontalScrollbar = true;
            PregledPostojecihNalogaAdminListBox.ItemHeight = 20;
            PregledPostojecihNalogaAdminListBox.Location = new Point(510, 73);
            PregledPostojecihNalogaAdminListBox.Name = "PregledPostojecihNalogaAdminListBox";
            PregledPostojecihNalogaAdminListBox.Size = new Size(200, 304);
            PregledPostojecihNalogaAdminListBox.TabIndex = 1;
            // 
            // PregledPostojecihNalogaKlijentLabel
            // 
            PregledPostojecihNalogaKlijentLabel.AutoSize = true;
            PregledPostojecihNalogaKlijentLabel.Location = new Point(50, 50);
            PregledPostojecihNalogaKlijentLabel.Name = "PregledPostojecihNalogaKlijentLabel";
            PregledPostojecihNalogaKlijentLabel.Size = new Size(115, 20);
            PregledPostojecihNalogaKlijentLabel.TabIndex = 11;
            PregledPostojecihNalogaKlijentLabel.Text = "Klijentski nalozi:";
            // 
            // PregledPostojecihNalogaRadnikLabel
            // 
            PregledPostojecihNalogaRadnikLabel.AutoSize = true;
            PregledPostojecihNalogaRadnikLabel.Location = new Point(280, 50);
            PregledPostojecihNalogaRadnikLabel.Name = "PregledPostojecihNalogaRadnikLabel";
            PregledPostojecihNalogaRadnikLabel.Size = new Size(112, 20);
            PregledPostojecihNalogaRadnikLabel.TabIndex = 11;
            PregledPostojecihNalogaRadnikLabel.Text = "Radnički nalozi:";
            // 
            // PregledPostojecihNalogaAdminLabel
            // 
            PregledPostojecihNalogaAdminLabel.AutoSize = true;
            PregledPostojecihNalogaAdminLabel.Location = new Point(510, 50);
            PregledPostojecihNalogaAdminLabel.Name = "PregledPostojecihNalogaAdminLabel";
            PregledPostojecihNalogaAdminLabel.Size = new Size(164, 20);
            PregledPostojecihNalogaAdminLabel.TabIndex = 11;
            PregledPostojecihNalogaAdminLabel.Text = "Administratorski nalozi:";
            // 
            // RegistracijaRadnickihNalogaPanel
            // 
            RegistracijaRadnickihNalogaPanel.Controls.Add(RegistrujRadnickiNalogButton);
            RegistracijaRadnickihNalogaPanel.Controls.Add(PotvrdaLozinkeRadnikRegistracijaLabel);
            RegistracijaRadnickihNalogaPanel.Controls.Add(LozinkaRadnikRegistracijaLabel);
            RegistracijaRadnickihNalogaPanel.Controls.Add(KorisnickoImeRadnikRegistracijaLabel);
            RegistracijaRadnickihNalogaPanel.Controls.Add(PrezimeRadnikRegistracijaLabel);
            RegistracijaRadnickihNalogaPanel.Controls.Add(ImeRadnikRegistracijaLabel);
            RegistracijaRadnickihNalogaPanel.Controls.Add(PotvrdaLozinkeRadnikRegistracijaTextBox);
            RegistracijaRadnickihNalogaPanel.Controls.Add(LozinkaRadnikRegistracijaTextBox);
            RegistracijaRadnickihNalogaPanel.Controls.Add(KorisnickoImeRadnikRegistracijaTextBox);
            RegistracijaRadnickihNalogaPanel.Controls.Add(PrezimeRadnikRegistracijaTextBox);
            RegistracijaRadnickihNalogaPanel.Controls.Add(ImeRadnikRegistracijaTextBox);
            RegistracijaRadnickihNalogaPanel.Controls.Add(NazadSaPanelaZaRegisteracijuRadnikaNaPanelPrijavljenogAdministratoraButton);
            RegistracijaRadnickihNalogaPanel.Dock = DockStyle.Fill;
            RegistracijaRadnickihNalogaPanel.Location = new Point(0, 0);
            RegistracijaRadnickihNalogaPanel.Name = "RegistracijaRadnickihNalogaPanel";
            RegistracijaRadnickihNalogaPanel.Size = new Size(800, 450);
            RegistracijaRadnickihNalogaPanel.TabIndex = 21;
            RegistracijaRadnickihNalogaPanel.Visible = false;
            // 
            // RegistrujRadnickiNalogButton
            // 
            RegistrujRadnickiNalogButton.Location = new Point(300, 290);
            RegistrujRadnickiNalogButton.Name = "RegistrujRadnickiNalogButton";
            RegistrujRadnickiNalogButton.Size = new Size(200, 57);
            RegistrujRadnickiNalogButton.TabIndex = 10;
            RegistrujRadnickiNalogButton.Text = "Registruj radnički nalog";
            RegistrujRadnickiNalogButton.UseVisualStyleBackColor = true;
            RegistrujRadnickiNalogButton.Click += RegistrujRadnickiNalogButton_Click;
            // 
            // PotvrdaLozinkeRadnikRegistracijaLabel
            // 
            PotvrdaLozinkeRadnikRegistracijaLabel.AutoSize = true;
            PotvrdaLozinkeRadnikRegistracijaLabel.Location = new Point(181, 235);
            PotvrdaLozinkeRadnikRegistracijaLabel.Name = "PotvrdaLozinkeRadnikRegistracijaLabel";
            PotvrdaLozinkeRadnikRegistracijaLabel.Size = new Size(113, 20);
            PotvrdaLozinkeRadnikRegistracijaLabel.TabIndex = 11;
            PotvrdaLozinkeRadnikRegistracijaLabel.Text = "Potvrda lozinke:";
            // 
            // LozinkaRadnikRegistracijaLabel
            // 
            LozinkaRadnikRegistracijaLabel.AutoSize = true;
            LozinkaRadnikRegistracijaLabel.Location = new Point(181, 202);
            LozinkaRadnikRegistracijaLabel.Name = "LozinkaRadnikRegistracijaLabel";
            LozinkaRadnikRegistracijaLabel.Size = new Size(62, 20);
            LozinkaRadnikRegistracijaLabel.TabIndex = 8;
            LozinkaRadnikRegistracijaLabel.Text = "Lozinka:";
            // 
            // KorisnickoImeRadnikRegistracijaLabel
            // 
            KorisnickoImeRadnikRegistracijaLabel.AutoSize = true;
            KorisnickoImeRadnikRegistracijaLabel.Location = new Point(181, 169);
            KorisnickoImeRadnikRegistracijaLabel.Name = "KorisnickoImeRadnikRegistracijaLabel";
            KorisnickoImeRadnikRegistracijaLabel.Size = new Size(109, 20);
            KorisnickoImeRadnikRegistracijaLabel.TabIndex = 7;
            KorisnickoImeRadnikRegistracijaLabel.Text = "Korisničko ime:";
            // 
            // PrezimeRadnikRegistracijaLabel
            // 
            PrezimeRadnikRegistracijaLabel.AutoSize = true;
            PrezimeRadnikRegistracijaLabel.Location = new Point(181, 136);
            PrezimeRadnikRegistracijaLabel.Name = "PrezimeRadnikRegistracijaLabel";
            PrezimeRadnikRegistracijaLabel.Size = new Size(65, 20);
            PrezimeRadnikRegistracijaLabel.TabIndex = 6;
            PrezimeRadnikRegistracijaLabel.Text = "Prezime:";
            // 
            // ImeRadnikRegistracijaLabel
            // 
            ImeRadnikRegistracijaLabel.AutoSize = true;
            ImeRadnikRegistracijaLabel.Location = new Point(181, 103);
            ImeRadnikRegistracijaLabel.Name = "ImeRadnikRegistracijaLabel";
            ImeRadnikRegistracijaLabel.Size = new Size(37, 20);
            ImeRadnikRegistracijaLabel.TabIndex = 5;
            ImeRadnikRegistracijaLabel.Text = "Ime:";
            // 
            // PotvrdaLozinkeRadnikRegistracijaTextBox
            // 
            PotvrdaLozinkeRadnikRegistracijaTextBox.Location = new Point(300, 234);
            PotvrdaLozinkeRadnikRegistracijaTextBox.Name = "PotvrdaLozinkeRadnikRegistracijaTextBox";
            PotvrdaLozinkeRadnikRegistracijaTextBox.PasswordChar = '*';
            PotvrdaLozinkeRadnikRegistracijaTextBox.Size = new Size(200, 27);
            PotvrdaLozinkeRadnikRegistracijaTextBox.TabIndex = 4;
            // 
            // LozinkaRadnikRegistracijaTextBox
            // 
            LozinkaRadnikRegistracijaTextBox.Location = new Point(300, 201);
            LozinkaRadnikRegistracijaTextBox.Name = "LozinkaRadnikRegistracijaTextBox";
            LozinkaRadnikRegistracijaTextBox.PasswordChar = '*';
            LozinkaRadnikRegistracijaTextBox.Size = new Size(200, 27);
            LozinkaRadnikRegistracijaTextBox.TabIndex = 3;
            // 
            // KorisnickoImeRadnikRegistracijaTextBox
            // 
            KorisnickoImeRadnikRegistracijaTextBox.Location = new Point(300, 166);
            KorisnickoImeRadnikRegistracijaTextBox.Name = "KorisnickoImeRadnikRegistracijaTextBox";
            KorisnickoImeRadnikRegistracijaTextBox.Size = new Size(200, 27);
            KorisnickoImeRadnikRegistracijaTextBox.TabIndex = 2;
            // 
            // PrezimeRadnikRegistracijaTextBox
            // 
            PrezimeRadnikRegistracijaTextBox.Location = new Point(300, 133);
            PrezimeRadnikRegistracijaTextBox.Name = "PrezimeRadnikRegistracijaTextBox";
            PrezimeRadnikRegistracijaTextBox.Size = new Size(200, 27);
            PrezimeRadnikRegistracijaTextBox.TabIndex = 1;
            // 
            // ImeRadnikRegistracijaTextBox
            // 
            ImeRadnikRegistracijaTextBox.Location = new Point(300, 100);
            ImeRadnikRegistracijaTextBox.Name = "ImeRadnikRegistracijaTextBox";
            ImeRadnikRegistracijaTextBox.Size = new Size(200, 27);
            ImeRadnikRegistracijaTextBox.TabIndex = 0;
            // 
            // NazadSaPanelaZaRegisteracijuRadnikaNaPanelPrijavljenogAdministratoraButton
            // 
            NazadSaPanelaZaRegisteracijuRadnikaNaPanelPrijavljenogAdministratoraButton.Location = new Point(694, 409);
            NazadSaPanelaZaRegisteracijuRadnikaNaPanelPrijavljenogAdministratoraButton.Name = "NazadSaPanelaZaRegisteracijuRadnikaNaPanelPrijavljenogAdministratoraButton";
            NazadSaPanelaZaRegisteracijuRadnikaNaPanelPrijavljenogAdministratoraButton.Size = new Size(94, 29);
            NazadSaPanelaZaRegisteracijuRadnikaNaPanelPrijavljenogAdministratoraButton.TabIndex = 20;
            NazadSaPanelaZaRegisteracijuRadnikaNaPanelPrijavljenogAdministratoraButton.Text = "Nazad";
            NazadSaPanelaZaRegisteracijuRadnikaNaPanelPrijavljenogAdministratoraButton.UseVisualStyleBackColor = true;
            NazadSaPanelaZaRegisteracijuRadnikaNaPanelPrijavljenogAdministratoraButton.Click += NazadSaPanelaZaRegisteracijuRadnikaNaPanelPrijavljenogAdministratoraButton_Click;
            // 
            // BrisanjeRadnickihNalogaPanel
            // 
            BrisanjeRadnickihNalogaPanel.Controls.Add(ObrisiRadnickiNalogButton);
            BrisanjeRadnickihNalogaPanel.Controls.Add(ListaRadnickihNalogaComboBox);
            BrisanjeRadnickihNalogaPanel.Controls.Add(HeaderListeRadnickihNaloga);
            BrisanjeRadnickihNalogaPanel.Controls.Add(NazadSaPanelaZaBrisanjeRadnickihNalogaNaPanelPrijavljenogAdministratoraButton);
            BrisanjeRadnickihNalogaPanel.Dock = DockStyle.Fill;
            BrisanjeRadnickihNalogaPanel.Location = new Point(0, 0);
            BrisanjeRadnickihNalogaPanel.Name = "BrisanjeRadnickihNalogaPanel";
            BrisanjeRadnickihNalogaPanel.Size = new Size(800, 450);
            BrisanjeRadnickihNalogaPanel.TabIndex = 22;
            BrisanjeRadnickihNalogaPanel.Visible = false;
            // 
            // ObrisiRadnickiNalogButton
            // 
            ObrisiRadnickiNalogButton.Location = new Point(300, 290);
            ObrisiRadnickiNalogButton.Name = "ObrisiRadnickiNalogButton";
            ObrisiRadnickiNalogButton.Size = new Size(200, 57);
            ObrisiRadnickiNalogButton.TabIndex = 10;
            ObrisiRadnickiNalogButton.Text = "Obriši radnički nalog";
            ObrisiRadnickiNalogButton.UseVisualStyleBackColor = true;
            ObrisiRadnickiNalogButton.Click += ObrisiRadnickiNalogButton_Click;
            // 
            // ListaRadnickihNalogaComboBox
            // 
            ListaRadnickihNalogaComboBox.FormattingEnabled = true;
            ListaRadnickihNalogaComboBox.Location = new Point(200, 100);
            ListaRadnickihNalogaComboBox.Name = "ListaRadnickihNalogaComboBox";
            ListaRadnickihNalogaComboBox.Size = new Size(400, 28);
            ListaRadnickihNalogaComboBox.TabIndex = 9;
            ListaRadnickihNalogaComboBox.SelectedIndexChanged += ListaRadnickihNalogaComboBox_SelectedIndexChanged;
            // 
            // HeaderListeRadnickihNaloga
            // 
            HeaderListeRadnickihNaloga.AutoSize = true;
            HeaderListeRadnickihNaloga.Location = new Point(200, 80);
            HeaderListeRadnickihNaloga.Name = "HeaderListeRadnickihNaloga";
            HeaderListeRadnickihNaloga.Size = new Size(202, 20);
            HeaderListeRadnickihNaloga.TabIndex = 11;
            HeaderListeRadnickihNaloga.Text = "Ime Prezime (Korisničko ime)";
            // 
            // NazadSaPanelaZaBrisanjeRadnickihNalogaNaPanelPrijavljenogAdministratoraButton
            // 
            NazadSaPanelaZaBrisanjeRadnickihNalogaNaPanelPrijavljenogAdministratoraButton.Location = new Point(694, 409);
            NazadSaPanelaZaBrisanjeRadnickihNalogaNaPanelPrijavljenogAdministratoraButton.Name = "NazadSaPanelaZaBrisanjeRadnickihNalogaNaPanelPrijavljenogAdministratoraButton";
            NazadSaPanelaZaBrisanjeRadnickihNalogaNaPanelPrijavljenogAdministratoraButton.Size = new Size(94, 29);
            NazadSaPanelaZaBrisanjeRadnickihNalogaNaPanelPrijavljenogAdministratoraButton.TabIndex = 20;
            NazadSaPanelaZaBrisanjeRadnickihNalogaNaPanelPrijavljenogAdministratoraButton.Text = "Nazad";
            NazadSaPanelaZaBrisanjeRadnickihNalogaNaPanelPrijavljenogAdministratoraButton.UseVisualStyleBackColor = true;
            NazadSaPanelaZaBrisanjeRadnickihNalogaNaPanelPrijavljenogAdministratoraButton.Click += NazadSaPanelaZaBrisanjeRadnickihNalogaNaPanelPrijavljenogAdministratoraButton_Click;
            // 
            // BrisanjeAdministratorskihNalogaPanel
            // 
            BrisanjeAdministratorskihNalogaPanel.Controls.Add(ObrisiAdministratorskiNalogButton);
            BrisanjeAdministratorskihNalogaPanel.Controls.Add(ListaAdministratorskihNalogaComboBox);
            BrisanjeAdministratorskihNalogaPanel.Controls.Add(HeaderListeAdministratorskihNaloga);
            BrisanjeAdministratorskihNalogaPanel.Controls.Add(NazadSaPanelaZaBrisanjeAdministratorskihNalogaNaPanelPrijavljenogAdministratoraButton);
            BrisanjeAdministratorskihNalogaPanel.Dock = DockStyle.Fill;
            BrisanjeAdministratorskihNalogaPanel.Location = new Point(0, 0);
            BrisanjeAdministratorskihNalogaPanel.Name = "BrisanjeAdministratorskihNalogaPanel";
            BrisanjeAdministratorskihNalogaPanel.Size = new Size(800, 450);
            BrisanjeAdministratorskihNalogaPanel.TabIndex = 23;
            BrisanjeAdministratorskihNalogaPanel.Visible = false;
            // 
            // ObrisiAdministratorskiNalogButton
            // 
            ObrisiAdministratorskiNalogButton.Location = new Point(300, 290);
            ObrisiAdministratorskiNalogButton.Name = "ObrisiAdministratorskiNalogButton";
            ObrisiAdministratorskiNalogButton.Size = new Size(200, 57);
            ObrisiAdministratorskiNalogButton.TabIndex = 0;
            ObrisiAdministratorskiNalogButton.Text = "Obriši administratorski nalog";
            ObrisiAdministratorskiNalogButton.UseVisualStyleBackColor = true;
            ObrisiAdministratorskiNalogButton.Click += ObrisiAdministratorskiNalogButton_Click;
            // 
            // ListaAdministratorskihNalogaComboBox
            // 
            ListaAdministratorskihNalogaComboBox.FormattingEnabled = true;
            ListaAdministratorskihNalogaComboBox.Location = new Point(200, 100);
            ListaAdministratorskihNalogaComboBox.Name = "ListaAdministratorskihNalogaComboBox";
            ListaAdministratorskihNalogaComboBox.Size = new Size(400, 28);
            ListaAdministratorskihNalogaComboBox.TabIndex = 1;
            ListaAdministratorskihNalogaComboBox.SelectedIndexChanged += ListaAdministratorskihNalogaComboBox_SelectedIndexChanged;
            // 
            // HeaderListeAdministratorskihNaloga
            // 
            HeaderListeAdministratorskihNaloga.AutoSize = true;
            HeaderListeAdministratorskihNaloga.Location = new Point(200, 80);
            HeaderListeAdministratorskihNaloga.Name = "HeaderListeAdministratorskihNaloga";
            HeaderListeAdministratorskihNaloga.Size = new Size(202, 20);
            HeaderListeAdministratorskihNaloga.TabIndex = 2;
            HeaderListeAdministratorskihNaloga.Text = "Ime Prezime (Korisničko ime)";
            // 
            // NazadSaPanelaZaBrisanjeAdministratorskihNalogaNaPanelPrijavljenogAdministratoraButton
            // 
            NazadSaPanelaZaBrisanjeAdministratorskihNalogaNaPanelPrijavljenogAdministratoraButton.Location = new Point(694, 409);
            NazadSaPanelaZaBrisanjeAdministratorskihNalogaNaPanelPrijavljenogAdministratoraButton.Name = "NazadSaPanelaZaBrisanjeAdministratorskihNalogaNaPanelPrijavljenogAdministratoraButton";
            NazadSaPanelaZaBrisanjeAdministratorskihNalogaNaPanelPrijavljenogAdministratoraButton.Size = new Size(94, 29);
            NazadSaPanelaZaBrisanjeAdministratorskihNalogaNaPanelPrijavljenogAdministratoraButton.TabIndex = 3;
            NazadSaPanelaZaBrisanjeAdministratorskihNalogaNaPanelPrijavljenogAdministratoraButton.Text = "Nazad";
            NazadSaPanelaZaBrisanjeAdministratorskihNalogaNaPanelPrijavljenogAdministratoraButton.UseVisualStyleBackColor = true;
            NazadSaPanelaZaBrisanjeAdministratorskihNalogaNaPanelPrijavljenogAdministratoraButton.Click += NazadSaPanelaZaBrisanjeAdministratorskihNalogaNaPanelPrijavljenogAdministratoraButton_Click;
            // 
            // LoginRadnikaPanel
            // 
            LoginRadnikaPanel.Controls.Add(KorisnickoImeRadnikaLabelLogin);
            LoginRadnikaPanel.Controls.Add(LozinkaRadnikaLabelLogin);
            LoginRadnikaPanel.Controls.Add(LozinkaRadnikaTextBoxLogin);
            LoginRadnikaPanel.Controls.Add(KorisnickoImeRadnikaTextBoxLogin);
            LoginRadnikaPanel.Controls.Add(PrijaviSeRadnikButton);
            LoginRadnikaPanel.Controls.Add(NazadSaLogovanogRadnikaNaIzborniPanelButton);
            LoginRadnikaPanel.Controls.Add(RadnikPanel);
            LoginRadnikaPanel.Dock = DockStyle.Fill;
            LoginRadnikaPanel.Location = new Point(0, 0);
            LoginRadnikaPanel.Name = "LoginRadnikaPanel";
            LoginRadnikaPanel.Size = new Size(800, 450);
            LoginRadnikaPanel.TabIndex = 21;
            LoginRadnikaPanel.Visible = false;
            // 
            // KorisnickoImeRadnikaLabelLogin
            // 
            KorisnickoImeRadnikaLabelLogin.AutoSize = true;
            KorisnickoImeRadnikaLabelLogin.Location = new Point(185, 103);
            KorisnickoImeRadnikaLabelLogin.Name = "KorisnickoImeRadnikaLabelLogin";
            KorisnickoImeRadnikaLabelLogin.Size = new Size(109, 20);
            KorisnickoImeRadnikaLabelLogin.TabIndex = 0;
            KorisnickoImeRadnikaLabelLogin.Text = "Korisničko ime:";
            // 
            // LozinkaRadnikaLabelLogin
            // 
            LozinkaRadnikaLabelLogin.AutoSize = true;
            LozinkaRadnikaLabelLogin.Location = new Point(185, 137);
            LozinkaRadnikaLabelLogin.Name = "LozinkaRadnikaLabelLogin";
            LozinkaRadnikaLabelLogin.Size = new Size(62, 20);
            LozinkaRadnikaLabelLogin.TabIndex = 3;
            LozinkaRadnikaLabelLogin.Text = "Lozinka:";
            // 
            // LozinkaRadnikaTextBoxLogin
            // 
            LozinkaRadnikaTextBoxLogin.Location = new Point(300, 133);
            LozinkaRadnikaTextBoxLogin.Name = "LozinkaRadnikaTextBoxLogin";
            LozinkaRadnikaTextBoxLogin.PasswordChar = '*';
            LozinkaRadnikaTextBoxLogin.Size = new Size(200, 27);
            LozinkaRadnikaTextBoxLogin.TabIndex = 2;
            // 
            // KorisnickoImeRadnikaTextBoxLogin
            // 
            KorisnickoImeRadnikaTextBoxLogin.Location = new Point(300, 100);
            KorisnickoImeRadnikaTextBoxLogin.Name = "KorisnickoImeRadnikaTextBoxLogin";
            KorisnickoImeRadnikaTextBoxLogin.Size = new Size(200, 27);
            KorisnickoImeRadnikaTextBoxLogin.TabIndex = 1;
            // 
            // PrijaviSeRadnikButton
            // 
            PrijaviSeRadnikButton.Location = new Point(300, 166);
            PrijaviSeRadnikButton.Name = "PrijaviSeRadnikButton";
            PrijaviSeRadnikButton.Size = new Size(200, 29);
            PrijaviSeRadnikButton.TabIndex = 5;
            PrijaviSeRadnikButton.Text = "Prijavi se";
            PrijaviSeRadnikButton.UseVisualStyleBackColor = true;
            PrijaviSeRadnikButton.Click += PrijaviSeRadnikButton_Click;
            // 
            // NazadSaLogovanogRadnikaNaIzborniPanelButton
            // 
            NazadSaLogovanogRadnikaNaIzborniPanelButton.Location = new Point(694, 409);
            NazadSaLogovanogRadnikaNaIzborniPanelButton.Name = "NazadSaLogovanogRadnikaNaIzborniPanelButton";
            NazadSaLogovanogRadnikaNaIzborniPanelButton.Size = new Size(94, 29);
            NazadSaLogovanogRadnikaNaIzborniPanelButton.TabIndex = 6;
            NazadSaLogovanogRadnikaNaIzborniPanelButton.Text = "Nazad";
            NazadSaLogovanogRadnikaNaIzborniPanelButton.UseVisualStyleBackColor = true;
            NazadSaLogovanogRadnikaNaIzborniPanelButton.Click += NazadSaLogovanogRadnikaNaIzborniPanelButton_Click;
            // 
            // RadnikPanel
            // 
            RadnikPanel.Controls.Add(panel_pregledIstorije);
            RadnikPanel.Controls.Add(panel_prikazArhive);
            RadnikPanel.Controls.Add(panel_obavljanjeTehnickog);
            RadnikPanel.Controls.Add(panel_zakazivanjeTermina1);
            RadnikPanel.Controls.Add(button_prikazArhive);
            RadnikPanel.Controls.Add(button_zakazivanjeTehnickog);
            RadnikPanel.Controls.Add(button_obavljanjeTehnickog);
            RadnikPanel.Controls.Add(button_pregledIstorije);
            RadnikPanel.Controls.Add(NazadRadnikButton);
            RadnikPanel.Dock = DockStyle.Fill;
            RadnikPanel.Location = new Point(0, 0);
            RadnikPanel.Name = "RadnikPanel";
            RadnikPanel.Size = new Size(800, 450);
            RadnikPanel.TabIndex = 1;
            RadnikPanel.Visible = false;
            // 
            // panel_pregledIstorije
            // 
            panel_pregledIstorije.Controls.Add(button_pregledIstorije_nazad);
            panel_pregledIstorije.Controls.Add(listBox_pregledIstorije);
            panel_pregledIstorije.Controls.Add(label_pregledIstorije_naslov);
            panel_pregledIstorije.Dock = DockStyle.Fill;
            panel_pregledIstorije.Location = new Point(0, 0);
            panel_pregledIstorije.Name = "panel_pregledIstorije";
            panel_pregledIstorije.Size = new Size(800, 450);
            panel_pregledIstorije.TabIndex = 15;
            panel_pregledIstorije.Visible = false;
            // 
            // button_pregledIstorije_nazad
            // 
            button_pregledIstorije_nazad.Location = new Point(694, 409);
            button_pregledIstorije_nazad.Name = "button_pregledIstorije_nazad";
            button_pregledIstorije_nazad.Size = new Size(94, 29);
            button_pregledIstorije_nazad.TabIndex = 2;
            button_pregledIstorije_nazad.Text = "Nazad";
            button_pregledIstorije_nazad.UseVisualStyleBackColor = true;
            button_pregledIstorije_nazad.Click += button_pregledIstorije_nazad_Click;
            // 
            // listBox_pregledIstorije
            // 
            listBox_pregledIstorije.FormattingEnabled = true;
            listBox_pregledIstorije.HorizontalScrollbar = true;
            listBox_pregledIstorije.ItemHeight = 20;
            listBox_pregledIstorije.Location = new Point(50, 73);
            listBox_pregledIstorije.Name = "listBox_pregledIstorije";
            listBox_pregledIstorije.Size = new Size(527, 324);
            listBox_pregledIstorije.TabIndex = 1;
            // 
            // label_pregledIstorije_naslov
            // 
            label_pregledIstorije_naslov.AutoSize = true;
            label_pregledIstorije_naslov.Location = new Point(50, 45);
            label_pregledIstorije_naslov.Name = "label_pregledIstorije_naslov";
            label_pregledIstorije_naslov.Size = new Size(227, 20);
            label_pregledIstorije_naslov.TabIndex = 0;
            label_pregledIstorije_naslov.Text = "Prikaz istorije tehničkih pregleda:";
            // 
            // panel_prikazArhive
            // 
            panel_prikazArhive.Controls.Add(button_prikazArhive_nazad);
            panel_prikazArhive.Controls.Add(listBox_prikazArhive);
            panel_prikazArhive.Controls.Add(label_prikazArhive_naslov);
            panel_prikazArhive.Dock = DockStyle.Fill;
            panel_prikazArhive.Location = new Point(0, 0);
            panel_prikazArhive.Name = "panel_prikazArhive";
            panel_prikazArhive.Size = new Size(800, 450);
            panel_prikazArhive.TabIndex = 14;
            panel_prikazArhive.Visible = false;
            // 
            // button_prikazArhive_nazad
            // 
            button_prikazArhive_nazad.Location = new Point(694, 409);
            button_prikazArhive_nazad.Name = "button_prikazArhive_nazad";
            button_prikazArhive_nazad.Size = new Size(94, 29);
            button_prikazArhive_nazad.TabIndex = 2;
            button_prikazArhive_nazad.Text = "Nazad";
            button_prikazArhive_nazad.UseVisualStyleBackColor = true;
            button_prikazArhive_nazad.Click += button_prikazArhive_nazad_Click;
            // 
            // listBox_prikazArhive
            // 
            listBox_prikazArhive.FormattingEnabled = true;
            listBox_prikazArhive.HorizontalScrollbar = true;
            listBox_prikazArhive.ItemHeight = 20;
            listBox_prikazArhive.Location = new Point(50, 73);
            listBox_prikazArhive.Name = "listBox_prikazArhive";
            listBox_prikazArhive.Size = new Size(614, 344);
            listBox_prikazArhive.TabIndex = 1;
            // 
            // label_prikazArhive_naslov
            // 
            label_prikazArhive_naslov.AutoSize = true;
            label_prikazArhive_naslov.Location = new Point(50, 45);
            label_prikazArhive_naslov.Name = "label_prikazArhive_naslov";
            label_prikazArhive_naslov.Size = new Size(276, 20);
            label_prikazArhive_naslov.TabIndex = 0;
            label_prikazArhive_naslov.Text = "Prikaz svih izvještaja o ispravnosti vozila:";
            // 
            // panel_obavljanjeTehnickog
            // 
            panel_obavljanjeTehnickog.Controls.Add(button_obavljanjeTehnickog_otkazi);
            panel_obavljanjeTehnickog.Controls.Add(label_obavljanjeTehnickog_naslov);
            panel_obavljanjeTehnickog.Controls.Add(listBox_obavljanjeTehnickog);
            panel_obavljanjeTehnickog.Dock = DockStyle.Fill;
            panel_obavljanjeTehnickog.Location = new Point(0, 0);
            panel_obavljanjeTehnickog.Name = "panel_obavljanjeTehnickog";
            panel_obavljanjeTehnickog.Size = new Size(800, 450);
            panel_obavljanjeTehnickog.TabIndex = 13;
            panel_obavljanjeTehnickog.Visible = false;
            // 
            // button_obavljanjeTehnickog_otkazi
            // 
            button_obavljanjeTehnickog_otkazi.Location = new Point(694, 409);
            button_obavljanjeTehnickog_otkazi.Name = "button_obavljanjeTehnickog_otkazi";
            button_obavljanjeTehnickog_otkazi.Size = new Size(94, 29);
            button_obavljanjeTehnickog_otkazi.TabIndex = 2;
            button_obavljanjeTehnickog_otkazi.Text = "Otkaži";
            button_obavljanjeTehnickog_otkazi.UseVisualStyleBackColor = true;
            button_obavljanjeTehnickog_otkazi.Click += button_obavljanjeTehnickog_otkazi_Click;
            // 
            // label_obavljanjeTehnickog_naslov
            // 
            label_obavljanjeTehnickog_naslov.AutoSize = true;
            label_obavljanjeTehnickog_naslov.Location = new Point(60, 45);
            label_obavljanjeTehnickog_naslov.Name = "label_obavljanjeTehnickog_naslov";
            label_obavljanjeTehnickog_naslov.Size = new Size(390, 20);
            label_obavljanjeTehnickog_naslov.TabIndex = 1;
            label_obavljanjeTehnickog_naslov.Text = "Izaberite termin za koji želite da obavite tehnički pregled:";
            // 
            // listBox_obavljanjeTehnickog
            // 
            listBox_obavljanjeTehnickog.FormattingEnabled = true;
            listBox_obavljanjeTehnickog.HorizontalScrollbar = true;
            listBox_obavljanjeTehnickog.ItemHeight = 20;
            listBox_obavljanjeTehnickog.Location = new Point(60, 73);
            listBox_obavljanjeTehnickog.Name = "listBox_obavljanjeTehnickog";
            listBox_obavljanjeTehnickog.Size = new Size(420, 324);
            listBox_obavljanjeTehnickog.TabIndex = 0;
            listBox_obavljanjeTehnickog.DoubleClick += listBox_obavljanjeTehnickog_DoubleClick;
            // 
            // panel_zakazivanjeTermina1
            // 
            panel_zakazivanjeTermina1.Controls.Add(UnosBrojaSasijeRadnikTextBox);
            panel_zakazivanjeTermina1.Controls.Add(UnosBrojaSasijeRadnikLabel);
            panel_zakazivanjeTermina1.Controls.Add(PokretanjeZakazivanjaTerminaRadnikButton);
            panel_zakazivanjeTermina1.Controls.Add(ZakazivanjeTerminaRadnikMonthCalendar);
            panel_zakazivanjeTermina1.Controls.Add(ZakazivanjeTerminaRadnikDateTimePicker);
            panel_zakazivanjeTermina1.Controls.Add(ZakaziTerminAkoVoziloVecPostojiRadnikButton);
            panel_zakazivanjeTermina1.Controls.Add(MarkaZakazivanjeRadnikTextBox);
            panel_zakazivanjeTermina1.Controls.Add(ModelZakazivanjeRadnikTextBox);
            panel_zakazivanjeTermina1.Controls.Add(GodisteZakazivanjeRadnikTextBox);
            panel_zakazivanjeTermina1.Controls.Add(KubikazaZakazivanjeRadnikTextBox);
            panel_zakazivanjeTermina1.Controls.Add(KategorijaZakazivanjeRadnikComboBox);
            panel_zakazivanjeTermina1.Controls.Add(PotkategorijaZakazivanjeRadnikComboBox);
            panel_zakazivanjeTermina1.Controls.Add(KategorijaZakazivanjeRadnikLabel);
            panel_zakazivanjeTermina1.Controls.Add(PotkategorijaZakazivanjeRadnikLabel);
            panel_zakazivanjeTermina1.Controls.Add(MarkaZakazivanjeRadnikLabel);
            panel_zakazivanjeTermina1.Controls.Add(ModelZakazivanjeRadnikLabel);
            panel_zakazivanjeTermina1.Controls.Add(GodisteZakazivanjeRadnikLabel);
            panel_zakazivanjeTermina1.Controls.Add(KubikazaZakazivanjeRadnikLabel);
            panel_zakazivanjeTermina1.Controls.Add(ZakaziTerminaAkoVoziloNePostojiRadnikButton);
            panel_zakazivanjeTermina1.Controls.Add(JMBGZakazivanjeRadnikTextBox);
            panel_zakazivanjeTermina1.Controls.Add(JMBGZakazivanjeRadnikLabel);
            panel_zakazivanjeTermina1.Controls.Add(NazadSaZakazivanjaTerminaTehnickogNaLogovanogKlijentaRadnikButton);
            panel_zakazivanjeTermina1.Dock = DockStyle.Fill;
            panel_zakazivanjeTermina1.Location = new Point(0, 0);
            panel_zakazivanjeTermina1.Name = "panel_zakazivanjeTermina1";
            panel_zakazivanjeTermina1.Size = new Size(800, 450);
            panel_zakazivanjeTermina1.TabIndex = 6;
            panel_zakazivanjeTermina1.Visible = false;
            // 
            // UnosBrojaSasijeRadnikTextBox
            // 
            UnosBrojaSasijeRadnikTextBox.Location = new Point(530, 20);
            UnosBrojaSasijeRadnikTextBox.Name = "UnosBrojaSasijeRadnikTextBox";
            UnosBrojaSasijeRadnikTextBox.Size = new Size(200, 27);
            UnosBrojaSasijeRadnikTextBox.TabIndex = 0;
            // 
            // UnosBrojaSasijeRadnikLabel
            // 
            UnosBrojaSasijeRadnikLabel.AutoSize = true;
            UnosBrojaSasijeRadnikLabel.Location = new Point(392, 23);
            UnosBrojaSasijeRadnikLabel.Name = "UnosBrojaSasijeRadnikLabel";
            UnosBrojaSasijeRadnikLabel.Size = new Size(132, 20);
            UnosBrojaSasijeRadnikLabel.TabIndex = 1;
            UnosBrojaSasijeRadnikLabel.Text = "Unesite broj šasije:";
            // 
            // PokretanjeZakazivanjaTerminaRadnikButton
            // 
            PokretanjeZakazivanjaTerminaRadnikButton.Location = new Point(580, 53);
            PokretanjeZakazivanjaTerminaRadnikButton.Name = "PokretanjeZakazivanjaTerminaRadnikButton";
            PokretanjeZakazivanjaTerminaRadnikButton.Size = new Size(100, 29);
            PokretanjeZakazivanjaTerminaRadnikButton.TabIndex = 2;
            PokretanjeZakazivanjaTerminaRadnikButton.Text = "Pokreni";
            PokretanjeZakazivanjaTerminaRadnikButton.UseVisualStyleBackColor = true;
            PokretanjeZakazivanjaTerminaRadnikButton.Click += PokretanjeZakazivanjaTerminaRadnikButton_Click;
            // 
            // ZakazivanjeTerminaRadnikMonthCalendar
            // 
            ZakazivanjeTerminaRadnikMonthCalendar.Location = new Point(40, 90);
            ZakazivanjeTerminaRadnikMonthCalendar.Name = "ZakazivanjeTerminaRadnikMonthCalendar";
            ZakazivanjeTerminaRadnikMonthCalendar.TabIndex = 3;
            ZakazivanjeTerminaRadnikMonthCalendar.Visible = false;
            // 
            // ZakazivanjeTerminaRadnikDateTimePicker
            // 
            ZakazivanjeTerminaRadnikDateTimePicker.Location = new Point(40, 309);
            ZakazivanjeTerminaRadnikDateTimePicker.Name = "ZakazivanjeTerminaRadnikDateTimePicker";
            ZakazivanjeTerminaRadnikDateTimePicker.Size = new Size(262, 27);
            ZakazivanjeTerminaRadnikDateTimePicker.TabIndex = 4;
            ZakazivanjeTerminaRadnikDateTimePicker.Visible = false;
            // 
            // ZakaziTerminAkoVoziloVecPostojiRadnikButton
            // 
            ZakaziTerminAkoVoziloVecPostojiRadnikButton.Location = new Point(105, 342);
            ZakaziTerminAkoVoziloVecPostojiRadnikButton.Name = "ZakaziTerminAkoVoziloVecPostojiRadnikButton";
            ZakaziTerminAkoVoziloVecPostojiRadnikButton.Size = new Size(130, 29);
            ZakaziTerminAkoVoziloVecPostojiRadnikButton.TabIndex = 5;
            ZakaziTerminAkoVoziloVecPostojiRadnikButton.Text = "Zakaži termin";
            ZakaziTerminAkoVoziloVecPostojiRadnikButton.UseVisualStyleBackColor = true;
            ZakaziTerminAkoVoziloVecPostojiRadnikButton.Visible = false;
            // 
            // MarkaZakazivanjeRadnikTextBox
            // 
            MarkaZakazivanjeRadnikTextBox.Location = new Point(480, 186);
            MarkaZakazivanjeRadnikTextBox.Name = "MarkaZakazivanjeRadnikTextBox";
            MarkaZakazivanjeRadnikTextBox.Size = new Size(280, 27);
            MarkaZakazivanjeRadnikTextBox.TabIndex = 8;
            MarkaZakazivanjeRadnikTextBox.Visible = false;
            // 
            // ModelZakazivanjeRadnikTextBox
            // 
            ModelZakazivanjeRadnikTextBox.Location = new Point(480, 219);
            ModelZakazivanjeRadnikTextBox.Name = "ModelZakazivanjeRadnikTextBox";
            ModelZakazivanjeRadnikTextBox.Size = new Size(280, 27);
            ModelZakazivanjeRadnikTextBox.TabIndex = 9;
            ModelZakazivanjeRadnikTextBox.Visible = false;
            // 
            // GodisteZakazivanjeRadnikTextBox
            // 
            GodisteZakazivanjeRadnikTextBox.Location = new Point(480, 252);
            GodisteZakazivanjeRadnikTextBox.Name = "GodisteZakazivanjeRadnikTextBox";
            GodisteZakazivanjeRadnikTextBox.Size = new Size(280, 27);
            GodisteZakazivanjeRadnikTextBox.TabIndex = 10;
            GodisteZakazivanjeRadnikTextBox.Visible = false;
            // 
            // KubikazaZakazivanjeRadnikTextBox
            // 
            KubikazaZakazivanjeRadnikTextBox.Location = new Point(480, 285);
            KubikazaZakazivanjeRadnikTextBox.Name = "KubikazaZakazivanjeRadnikTextBox";
            KubikazaZakazivanjeRadnikTextBox.Size = new Size(280, 27);
            KubikazaZakazivanjeRadnikTextBox.TabIndex = 11;
            KubikazaZakazivanjeRadnikTextBox.Visible = false;
            //
            // JMBGZakazivanjeRadnikTextBox
            //
            JMBGZakazivanjeRadnikTextBox.Location = new Point(480, 318);
            JMBGZakazivanjeRadnikTextBox.Name = "JMBGZakazivanjeRadnikTextBox";
            JMBGZakazivanjeRadnikTextBox.Size = new Size(280, 27);
            JMBGZakazivanjeRadnikTextBox.TabIndex = 12;
            JMBGZakazivanjeRadnikTextBox.Visible = false;
            // 
            // KategorijaZakazivanjeRadnikComboBox
            // 
            KategorijaZakazivanjeRadnikComboBox.FormattingEnabled = true;
            KategorijaZakazivanjeRadnikComboBox.Items.AddRange(new object[] { "M – Vozila za prevoz putnika", "L – Mopedi, Motocikli, Tricikli i Četvorocikli", "N – Teretna vozila", "O – priključna vozila", "T – Traktori", "R – Priključno vozilo traktora", "G – Terenska vozila" });
            KategorijaZakazivanjeRadnikComboBox.Location = new Point(480, 119);
            KategorijaZakazivanjeRadnikComboBox.Name = "KategorijaZakazivanjeRadnikComboBox";
            KategorijaZakazivanjeRadnikComboBox.Size = new Size(280, 28);
            KategorijaZakazivanjeRadnikComboBox.TabIndex = 18;
            KategorijaZakazivanjeRadnikComboBox.Visible = false;
            KategorijaZakazivanjeRadnikComboBox.SelectedIndexChanged += KategorijaZakazivanjeRadnikComboBox_SelectedIndexChanged;
            // 
            // PotkategorijaZakazivanjeRadnikComboBox
            // 
            PotkategorijaZakazivanjeRadnikComboBox.FormattingEnabled = true;
            PotkategorijaZakazivanjeRadnikComboBox.Location = new Point(480, 153);
            PotkategorijaZakazivanjeRadnikComboBox.Name = "PotkategorijaZakazivanjeRadnikComboBox";
            PotkategorijaZakazivanjeRadnikComboBox.Size = new Size(280, 28);
            PotkategorijaZakazivanjeRadnikComboBox.TabIndex = 19;
            PotkategorijaZakazivanjeRadnikComboBox.Visible = false;
            // 
            // KategorijaZakazivanjeRadnikLabel
            // 
            KategorijaZakazivanjeRadnikLabel.AutoSize = true;
            KategorijaZakazivanjeRadnikLabel.Location = new Point(374, 123);
            KategorijaZakazivanjeRadnikLabel.Name = "KategorijaZakazivanjeRadnikLabel";
            KategorijaZakazivanjeRadnikLabel.Size = new Size(81, 20);
            KategorijaZakazivanjeRadnikLabel.TabIndex = 12;
            KategorijaZakazivanjeRadnikLabel.Text = "Kategorija:";
            KategorijaZakazivanjeRadnikLabel.Visible = false;
            // 
            // PotkategorijaZakazivanjeRadnikLabel
            // 
            PotkategorijaZakazivanjeRadnikLabel.AutoSize = true;
            PotkategorijaZakazivanjeRadnikLabel.Location = new Point(374, 156);
            PotkategorijaZakazivanjeRadnikLabel.Name = "PotkategorijaZakazivanjeRadnikLabel";
            PotkategorijaZakazivanjeRadnikLabel.Size = new Size(100, 20);
            PotkategorijaZakazivanjeRadnikLabel.TabIndex = 13;
            PotkategorijaZakazivanjeRadnikLabel.Text = "Potkategorija:";
            PotkategorijaZakazivanjeRadnikLabel.Visible = false;
            // 
            // MarkaZakazivanjeRadnikLabel
            // 
            MarkaZakazivanjeRadnikLabel.AutoSize = true;
            MarkaZakazivanjeRadnikLabel.Location = new Point(374, 189);
            MarkaZakazivanjeRadnikLabel.Name = "MarkaZakazivanjeRadnikLabel";
            MarkaZakazivanjeRadnikLabel.Size = new Size(53, 20);
            MarkaZakazivanjeRadnikLabel.TabIndex = 14;
            MarkaZakazivanjeRadnikLabel.Text = "Marka:";
            MarkaZakazivanjeRadnikLabel.Visible = false;
            // 
            // ModelZakazivanjeRadnikLabel
            // 
            ModelZakazivanjeRadnikLabel.AutoSize = true;
            ModelZakazivanjeRadnikLabel.Location = new Point(374, 222);
            ModelZakazivanjeRadnikLabel.Name = "ModelZakazivanjeRadnikLabel";
            ModelZakazivanjeRadnikLabel.Size = new Size(55, 20);
            ModelZakazivanjeRadnikLabel.TabIndex = 15;
            ModelZakazivanjeRadnikLabel.Text = "Model:";
            ModelZakazivanjeRadnikLabel.Visible = false;
            // 
            // GodisteZakazivanjeRadnikLabel
            // 
            GodisteZakazivanjeRadnikLabel.AutoSize = true;
            GodisteZakazivanjeRadnikLabel.Location = new Point(374, 255);
            GodisteZakazivanjeRadnikLabel.Name = "GodisteZakazivanjeRadnikLabel";
            GodisteZakazivanjeRadnikLabel.Size = new Size(63, 20);
            GodisteZakazivanjeRadnikLabel.TabIndex = 16;
            GodisteZakazivanjeRadnikLabel.Text = "Godište:";
            GodisteZakazivanjeRadnikLabel.Visible = false;
            // 
            // KubikazaZakazivanjeRadnikLabel
            // 
            KubikazaZakazivanjeRadnikLabel.AutoSize = true;
            KubikazaZakazivanjeRadnikLabel.Location = new Point(374, 288);
            KubikazaZakazivanjeRadnikLabel.Name = "KubikazaZakazivanjeRadnikLabel";
            KubikazaZakazivanjeRadnikLabel.Size = new Size(72, 20);
            KubikazaZakazivanjeRadnikLabel.TabIndex = 17;
            KubikazaZakazivanjeRadnikLabel.Text = "Kubikaža:";
            KubikazaZakazivanjeRadnikLabel.Visible = false;
            //
            // JMBGZakazivanjeRadnikLabel
            //
            JMBGZakazivanjeRadnikLabel.AutoSize = true;
            JMBGZakazivanjeRadnikLabel.Location = new Point(374, 321);
            JMBGZakazivanjeRadnikLabel.Name = "JMBGZakazivanjeRadnikLabel";
            JMBGZakazivanjeRadnikLabel.Size = new Size(53, 20);
            JMBGZakazivanjeRadnikLabel.TabIndex = 18;
            JMBGZakazivanjeRadnikLabel.Text = "JMBG:";
            JMBGZakazivanjeRadnikLabel.Visible = false;
            // 
            // ZakaziTerminaAkoVoziloNePostojiRadnikButton
            // 
            ZakaziTerminaAkoVoziloNePostojiRadnikButton.Location = new Point(335, 370);
            ZakaziTerminaAkoVoziloNePostojiRadnikButton.Name = "ZakaziTerminaAkoVoziloNePostojiRadnikButton";
            ZakaziTerminaAkoVoziloNePostojiRadnikButton.Size = new Size(130, 29);
            ZakaziTerminaAkoVoziloNePostojiRadnikButton.TabIndex = 20;
            ZakaziTerminaAkoVoziloNePostojiRadnikButton.Text = "Zakaži termin";
            ZakaziTerminaAkoVoziloNePostojiRadnikButton.UseVisualStyleBackColor = true;
            ZakaziTerminaAkoVoziloNePostojiRadnikButton.Visible = false;
            ZakaziTerminaAkoVoziloNePostojiRadnikButton.Click += ZakaziTerminaAkoVoziloNePostojiRadnikButton_Click;
            // 
            // NazadSaZakazivanjaTerminaTehnickogNaLogovanogKlijentaRadnikButton
            // 
            NazadSaZakazivanjaTerminaTehnickogNaLogovanogKlijentaRadnikButton.Location = new Point(694, 409);
            NazadSaZakazivanjaTerminaTehnickogNaLogovanogKlijentaRadnikButton.Name = "NazadSaZakazivanjaTerminaTehnickogNaLogovanogKlijentaRadnikButton";
            NazadSaZakazivanjaTerminaTehnickogNaLogovanogKlijentaRadnikButton.Size = new Size(94, 29);
            NazadSaZakazivanjaTerminaTehnickogNaLogovanogKlijentaRadnikButton.TabIndex = 8;
            NazadSaZakazivanjaTerminaTehnickogNaLogovanogKlijentaRadnikButton.Text = "Nazad";
            NazadSaZakazivanjaTerminaTehnickogNaLogovanogKlijentaRadnikButton.UseVisualStyleBackColor = true;
            NazadSaZakazivanjaTerminaTehnickogNaLogovanogKlijentaRadnikButton.Click += NazadSaZakazivanjaTerminaTehnickogNaLogovanogKlijentaRadnikButton_Click;
            // 
            // button_prikazArhive
            // 
            button_prikazArhive.Location = new Point(450, 200);
            button_prikazArhive.Name = "button_prikazArhive";
            button_prikazArhive.Size = new Size(200, 60);
            button_prikazArhive.TabIndex = 1;
            button_prikazArhive.Text = "Prikaz arhive sa izvještajima";
            button_prikazArhive.UseVisualStyleBackColor = true;
            button_prikazArhive.Click += button_prikazArhive_Click;
            // 
            // button_zakazivanjeTehnickog
            // 
            button_zakazivanjeTehnickog.Location = new Point(150, 70);
            button_zakazivanjeTehnickog.Name = "button_zakazivanjeTehnickog";
            button_zakazivanjeTehnickog.Size = new Size(200, 60);
            button_zakazivanjeTehnickog.TabIndex = 3;
            button_zakazivanjeTehnickog.Text = "Zakazivanje tehničkog pregleda";
            button_zakazivanjeTehnickog.UseVisualStyleBackColor = true;
            button_zakazivanjeTehnickog.Click += button_zakazivanjeTehnickog_Click;
            // 
            // button_obavljanjeTehnickog
            // 
            button_obavljanjeTehnickog.Location = new Point(150, 200);
            button_obavljanjeTehnickog.Name = "button_obavljanjeTehnickog";
            button_obavljanjeTehnickog.Size = new Size(200, 60);
            button_obavljanjeTehnickog.TabIndex = 0;
            button_obavljanjeTehnickog.Text = "Obavljanje tehničkog pregleda";
            button_obavljanjeTehnickog.UseVisualStyleBackColor = true;
            button_obavljanjeTehnickog.Click += button_obavljanjeTehnickog_Click;
            // 
            // button_pregledIstorije
            // 
            button_pregledIstorije.Location = new Point(450, 70);
            button_pregledIstorije.Name = "button_pregledIstorije";
            button_pregledIstorije.Size = new Size(200, 60);
            button_pregledIstorije.TabIndex = 2;
            button_pregledIstorije.Text = "Pregled istorije";
            button_pregledIstorije.UseVisualStyleBackColor = true;
            button_pregledIstorije.Click += button_pregledIstorije_Click;
            // 
            // NazadRadnikButton
            // 
            NazadRadnikButton.Location = new Point(694, 409);
            NazadRadnikButton.Name = "NazadRadnikButton";
            NazadRadnikButton.Size = new Size(94, 29);
            NazadRadnikButton.TabIndex = 2;
            NazadRadnikButton.Text = "Odjava";
            NazadRadnikButton.UseVisualStyleBackColor = true;
            NazadRadnikButton.Click += NazadRadnikButton_Click;
            // 
            // PrijavljujemSeKaoLabel
            // 
            PrijavljujemSeKaoLabel.AutoSize = true;
            PrijavljujemSeKaoLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            PrijavljujemSeKaoLabel.Location = new Point(296, 245);
            PrijavljujemSeKaoLabel.Name = "PrijavljujemSeKaoLabel";
            PrijavljujemSeKaoLabel.Size = new Size(208, 31);
            PrijavljujemSeKaoLabel.TabIndex = 4;
            PrijavljujemSeKaoLabel.Text = "Prijavljujem se kao:";
            // 
            // SistemZaTehnickiPregledLabel
            // 
            SistemZaTehnickiPregledLabel.AutoSize = true;
            SistemZaTehnickiPregledLabel.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            SistemZaTehnickiPregledLabel.Location = new Point(47, 99);
            SistemZaTehnickiPregledLabel.Name = "SistemZaTehnickiPregledLabel";
            SistemZaTehnickiPregledLabel.Size = new Size(706, 67);
            SistemZaTehnickiPregledLabel.TabIndex = 3;
            SistemZaTehnickiPregledLabel.Text = "SISTEM ZA TEHNIČKI PREGLED";
            // 
            // AdministratorButton
            // 
            AdministratorButton.Location = new Point(569, 302);
            AdministratorButton.Name = "AdministratorButton";
            AdministratorButton.Size = new Size(124, 29);
            AdministratorButton.TabIndex = 2;
            AdministratorButton.Text = "Administrator";
            AdministratorButton.UseVisualStyleBackColor = true;
            AdministratorButton.Click += AdministratorButton_Click;
            // 
            // RadnikButton
            // 
            RadnikButton.Location = new Point(338, 302);
            RadnikButton.Name = "RadnikButton";
            RadnikButton.Size = new Size(124, 29);
            RadnikButton.TabIndex = 1;
            RadnikButton.Text = "Radnik";
            RadnikButton.UseVisualStyleBackColor = true;
            RadnikButton.Click += RadnikButton_Click;
            // 
            // KlijentButton
            // 
            KlijentButton.Location = new Point(107, 302);
            KlijentButton.Name = "KlijentButton";
            KlijentButton.Size = new Size(124, 29);
            KlijentButton.TabIndex = 0;
            KlijentButton.Text = "Klijent";
            KlijentButton.UseVisualStyleBackColor = true;
            KlijentButton.Click += KlijentButton_Click;
            // 
            // panel_zakazivanjeTermina3
            // 
            panel_zakazivanjeTermina3.Controls.Add(button_zakazivanjeTermina3_nazad);
            panel_zakazivanjeTermina3.Controls.Add(monthCalendar_zakazivanjeTermina3);
            panel_zakazivanjeTermina3.Controls.Add(dateTimePicker_zakazivanjeTermina3);
            panel_zakazivanjeTermina3.Controls.Add(button_zakazivanjeTermina3_zakaziTermin);
            panel_zakazivanjeTermina3.Location = new Point(47, 64);
            panel_zakazivanjeTermina3.Name = "panel_zakazivanjeTermina3";
            panel_zakazivanjeTermina3.Size = new Size(408, 325);
            panel_zakazivanjeTermina3.TabIndex = 12;
            panel_zakazivanjeTermina3.Visible = false;
            // 
            // button_zakazivanjeTermina3_nazad
            // 
            button_zakazivanjeTermina3_nazad.Location = new Point(15, 275);
            button_zakazivanjeTermina3_nazad.Name = "button_zakazivanjeTermina3_nazad";
            button_zakazivanjeTermina3_nazad.Size = new Size(94, 29);
            button_zakazivanjeTermina3_nazad.TabIndex = 8;
            button_zakazivanjeTermina3_nazad.Text = "Nazad";
            button_zakazivanjeTermina3_nazad.UseVisualStyleBackColor = true;
            button_zakazivanjeTermina3_nazad.Click += button_zakazivanjeTermina3_nazad_Click;
            // 
            // monthCalendar_zakazivanjeTermina3
            // 
            monthCalendar_zakazivanjeTermina3.Location = new Point(10, 9);
            monthCalendar_zakazivanjeTermina3.Name = "monthCalendar_zakazivanjeTermina3";
            monthCalendar_zakazivanjeTermina3.TabIndex = 6;
            // 
            // dateTimePicker_zakazivanjeTermina3
            // 
            dateTimePicker_zakazivanjeTermina3.Format = DateTimePickerFormat.Time;
            dateTimePicker_zakazivanjeTermina3.Location = new Point(15, 228);
            dateTimePicker_zakazivanjeTermina3.Name = "dateTimePicker_zakazivanjeTermina3";
            dateTimePicker_zakazivanjeTermina3.Size = new Size(250, 27);
            dateTimePicker_zakazivanjeTermina3.TabIndex = 7;
            // 
            // button_zakazivanjeTermina3_zakaziTermin
            // 
            button_zakazivanjeTermina3_zakaziTermin.Location = new Point(137, 275);
            button_zakazivanjeTermina3_zakaziTermin.Name = "button_zakazivanjeTermina3_zakaziTermin";
            button_zakazivanjeTermina3_zakaziTermin.Size = new Size(128, 29);
            button_zakazivanjeTermina3_zakaziTermin.TabIndex = 3;
            button_zakazivanjeTermina3_zakaziTermin.Text = "Zakazi termin";
            button_zakazivanjeTermina3_zakaziTermin.UseVisualStyleBackColor = true;
            button_zakazivanjeTermina3_zakaziTermin.Click += button_zakazivanjeTermina3_zakaziTermin_click;
            // 
            // panel_zakazivanjeTermina2
            // 
            panel_zakazivanjeTermina2.Controls.Add(label_zakazivanjeTermina_kategorija);
            panel_zakazivanjeTermina2.Controls.Add(textBox_zakazivanjeTermina2_kategorija);
            panel_zakazivanjeTermina2.Controls.Add(label_zakazivanjeTermina_potkategorija);
            panel_zakazivanjeTermina2.Controls.Add(textBox_zakazivanjeTermina2_potkategorija);
            panel_zakazivanjeTermina2.Controls.Add(label_zakazivanjeTermina_marka);
            panel_zakazivanjeTermina2.Controls.Add(textBox_zakazivanjeTermina2_marka);
            panel_zakazivanjeTermina2.Controls.Add(label_zakazivanjeTermina_model);
            panel_zakazivanjeTermina2.Controls.Add(textBox_zakazivanjeTermina2_model);
            panel_zakazivanjeTermina2.Controls.Add(label_zakazivanjeTermina_godiste);
            panel_zakazivanjeTermina2.Controls.Add(textBox_zakazivanjeTermina2_godiste);
            panel_zakazivanjeTermina2.Controls.Add(label_zakazivanjeTermina_kubikaza);
            panel_zakazivanjeTermina2.Controls.Add(textBox_zakazivanjeTermina2_kubikaza);
            panel_zakazivanjeTermina2.Controls.Add(label_zakazivanjeTermina_stiker);
            panel_zakazivanjeTermina2.Controls.Add(textBox_zakazivanjeTermina2_stiker);
            panel_zakazivanjeTermina2.Controls.Add(button_zakazivanjeTermina2_dalje);
            panel_zakazivanjeTermina2.Controls.Add(textBox_zakazivanjeTermina2_rokRegistracije);
            panel_zakazivanjeTermina2.Controls.Add(label_zakazivanjeTermina_datumReg);
            panel_zakazivanjeTermina2.Location = new Point(53, 55);
            panel_zakazivanjeTermina2.Name = "panel_zakazivanjeTermina2";
            panel_zakazivanjeTermina2.Size = new Size(359, 322);
            panel_zakazivanjeTermina2.TabIndex = 10;
            panel_zakazivanjeTermina2.Visible = false;
            // 
            // label_zakazivanjeTermina_kategorija
            // 
            label_zakazivanjeTermina_kategorija.AutoSize = true;
            label_zakazivanjeTermina_kategorija.Location = new Point(16, 12);
            label_zakazivanjeTermina_kategorija.Name = "label_zakazivanjeTermina_kategorija";
            label_zakazivanjeTermina_kategorija.Size = new Size(81, 20);
            label_zakazivanjeTermina_kategorija.TabIndex = 9;
            label_zakazivanjeTermina_kategorija.Text = "Kategorija:";
            // 
            // textBox_zakazivanjeTermina2_kategorija
            // 
            textBox_zakazivanjeTermina2_kategorija.Location = new Point(149, 9);
            textBox_zakazivanjeTermina2_kategorija.Name = "textBox_zakazivanjeTermina2_kategorija";
            textBox_zakazivanjeTermina2_kategorija.Size = new Size(125, 27);
            textBox_zakazivanjeTermina2_kategorija.TabIndex = 8;
            // 
            // label_zakazivanjeTermina_potkategorija
            // 
            label_zakazivanjeTermina_potkategorija.AutoSize = true;
            label_zakazivanjeTermina_potkategorija.Location = new Point(16, 45);
            label_zakazivanjeTermina_potkategorija.Name = "label_zakazivanjeTermina_potkategorija";
            label_zakazivanjeTermina_potkategorija.Size = new Size(100, 20);
            label_zakazivanjeTermina_potkategorija.TabIndex = 10;
            label_zakazivanjeTermina_potkategorija.Text = "Potkategorija:";
            // 
            // textBox_zakazivanjeTermina2_potkategorija
            // 
            textBox_zakazivanjeTermina2_potkategorija.Location = new Point(149, 42);
            textBox_zakazivanjeTermina2_potkategorija.Name = "textBox_zakazivanjeTermina2_potkategorija";
            textBox_zakazivanjeTermina2_potkategorija.Size = new Size(125, 27);
            textBox_zakazivanjeTermina2_potkategorija.TabIndex = 17;
            // 
            // label_zakazivanjeTermina_marka
            // 
            label_zakazivanjeTermina_marka.AutoSize = true;
            label_zakazivanjeTermina_marka.Location = new Point(16, 78);
            label_zakazivanjeTermina_marka.Name = "label_zakazivanjeTermina_marka";
            label_zakazivanjeTermina_marka.Size = new Size(53, 20);
            label_zakazivanjeTermina_marka.TabIndex = 11;
            label_zakazivanjeTermina_marka.Text = "Marka:";
            // 
            // textBox_zakazivanjeTermina2_marka
            // 
            textBox_zakazivanjeTermina2_marka.Location = new Point(149, 75);
            textBox_zakazivanjeTermina2_marka.Name = "textBox_zakazivanjeTermina2_marka";
            textBox_zakazivanjeTermina2_marka.Size = new Size(125, 27);
            textBox_zakazivanjeTermina2_marka.TabIndex = 18;
            // 
            // label_zakazivanjeTermina_model
            // 
            label_zakazivanjeTermina_model.AutoSize = true;
            label_zakazivanjeTermina_model.Location = new Point(16, 111);
            label_zakazivanjeTermina_model.Name = "label_zakazivanjeTermina_model";
            label_zakazivanjeTermina_model.Size = new Size(55, 20);
            label_zakazivanjeTermina_model.TabIndex = 12;
            label_zakazivanjeTermina_model.Text = "Model:";
            // 
            // textBox_zakazivanjeTermina2_model
            // 
            textBox_zakazivanjeTermina2_model.Location = new Point(149, 108);
            textBox_zakazivanjeTermina2_model.Name = "textBox_zakazivanjeTermina2_model";
            textBox_zakazivanjeTermina2_model.Size = new Size(125, 27);
            textBox_zakazivanjeTermina2_model.TabIndex = 19;
            // 
            // label_zakazivanjeTermina_godiste
            // 
            label_zakazivanjeTermina_godiste.AutoSize = true;
            label_zakazivanjeTermina_godiste.Location = new Point(16, 144);
            label_zakazivanjeTermina_godiste.Name = "label_zakazivanjeTermina_godiste";
            label_zakazivanjeTermina_godiste.Size = new Size(63, 20);
            label_zakazivanjeTermina_godiste.TabIndex = 13;
            label_zakazivanjeTermina_godiste.Text = "Godište:";
            // 
            // textBox_zakazivanjeTermina2_godiste
            // 
            textBox_zakazivanjeTermina2_godiste.Location = new Point(149, 141);
            textBox_zakazivanjeTermina2_godiste.Name = "textBox_zakazivanjeTermina2_godiste";
            textBox_zakazivanjeTermina2_godiste.Size = new Size(125, 27);
            textBox_zakazivanjeTermina2_godiste.TabIndex = 20;
            // 
            // label_zakazivanjeTermina_kubikaza
            // 
            label_zakazivanjeTermina_kubikaza.AutoSize = true;
            label_zakazivanjeTermina_kubikaza.Location = new Point(16, 177);
            label_zakazivanjeTermina_kubikaza.Name = "label_zakazivanjeTermina_kubikaza";
            label_zakazivanjeTermina_kubikaza.Size = new Size(72, 20);
            label_zakazivanjeTermina_kubikaza.TabIndex = 14;
            label_zakazivanjeTermina_kubikaza.Text = "Kubikaža:";
            // 
            // textBox_zakazivanjeTermina2_kubikaza
            // 
            textBox_zakazivanjeTermina2_kubikaza.Location = new Point(149, 174);
            textBox_zakazivanjeTermina2_kubikaza.Name = "textBox_zakazivanjeTermina2_kubikaza";
            textBox_zakazivanjeTermina2_kubikaza.Size = new Size(125, 27);
            textBox_zakazivanjeTermina2_kubikaza.TabIndex = 21;
            // 
            // label_zakazivanjeTermina_stiker
            // 
            label_zakazivanjeTermina_stiker.AutoSize = true;
            label_zakazivanjeTermina_stiker.Location = new Point(16, 210);
            label_zakazivanjeTermina_stiker.Name = "label_zakazivanjeTermina_stiker";
            label_zakazivanjeTermina_stiker.Size = new Size(49, 20);
            label_zakazivanjeTermina_stiker.TabIndex = 15;
            label_zakazivanjeTermina_stiker.Text = "Stiker:";
            // 
            // textBox_zakazivanjeTermina2_stiker
            // 
            textBox_zakazivanjeTermina2_stiker.Location = new Point(149, 207);
            textBox_zakazivanjeTermina2_stiker.Name = "textBox_zakazivanjeTermina2_stiker";
            textBox_zakazivanjeTermina2_stiker.Size = new Size(125, 27);
            textBox_zakazivanjeTermina2_stiker.TabIndex = 22;
            // 
            // button_zakazivanjeTermina2_dalje
            // 
            button_zakazivanjeTermina2_dalje.Location = new Point(161, 279);
            button_zakazivanjeTermina2_dalje.Name = "button_zakazivanjeTermina2_dalje";
            button_zakazivanjeTermina2_dalje.Size = new Size(94, 29);
            button_zakazivanjeTermina2_dalje.TabIndex = 24;
            button_zakazivanjeTermina2_dalje.Text = "Dalje";
            button_zakazivanjeTermina2_dalje.UseVisualStyleBackColor = true;
            button_zakazivanjeTermina2_dalje.Click += button_zakazivanjeTermina2_dalje_Click;
            // 
            // textBox_zakazivanjeTermina2_rokRegistracije
            // 
            textBox_zakazivanjeTermina2_rokRegistracije.Location = new Point(149, 240);
            textBox_zakazivanjeTermina2_rokRegistracije.Name = "textBox_zakazivanjeTermina2_rokRegistracije";
            textBox_zakazivanjeTermina2_rokRegistracije.Size = new Size(125, 27);
            textBox_zakazivanjeTermina2_rokRegistracije.TabIndex = 23;
            // 
            // label_zakazivanjeTermina_datumReg
            // 
            label_zakazivanjeTermina_datumReg.AutoSize = true;
            label_zakazivanjeTermina_datumReg.Location = new Point(16, 243);
            label_zakazivanjeTermina_datumReg.Name = "label_zakazivanjeTermina_datumReg";
            label_zakazivanjeTermina_datumReg.Size = new Size(114, 20);
            label_zakazivanjeTermina_datumReg.TabIndex = 16;
            label_zakazivanjeTermina_datumReg.Text = "Rok registracije:";
            // 
            // button_zakazivanjeTermina1_pokreni
            // 
            button_zakazivanjeTermina1_pokreni.Location = new Point(550, 50);
            button_zakazivanjeTermina1_pokreni.Name = "button_zakazivanjeTermina1_pokreni";
            button_zakazivanjeTermina1_pokreni.Size = new Size(100, 29);
            button_zakazivanjeTermina1_pokreni.TabIndex = 11;
            button_zakazivanjeTermina1_pokreni.Text = "Pokreni";
            button_zakazivanjeTermina1_pokreni.UseVisualStyleBackColor = true;
            button_zakazivanjeTermina1_pokreni.Click += button_zakazivanjeTermina1_pokreni_Click;
            // 
            // textBox_zakazivanjeTermina1_brojSasije
            // 
            textBox_zakazivanjeTermina1_brojSasije.Location = new Point(500, 19);
            textBox_zakazivanjeTermina1_brojSasije.Name = "textBox_zakazivanjeTermina1_brojSasije";
            textBox_zakazivanjeTermina1_brojSasije.Size = new Size(200, 27);
            textBox_zakazivanjeTermina1_brojSasije.TabIndex = 2;
            textBox_zakazivanjeTermina1_brojSasije.KeyPress += textBox_zakazivanjeTermina1_brojSasije_KeyPress;
            // 
            // label_zakazivanjeTermina_unosBrojaSasije
            // 
            label_zakazivanjeTermina_unosBrojaSasije.AutoSize = true;
            label_zakazivanjeTermina_unosBrojaSasije.Location = new Point(360, 22);
            label_zakazivanjeTermina_unosBrojaSasije.Name = "label_zakazivanjeTermina_unosBrojaSasije";
            label_zakazivanjeTermina_unosBrojaSasije.Size = new Size(132, 20);
            label_zakazivanjeTermina_unosBrojaSasije.TabIndex = 1;
            label_zakazivanjeTermina_unosBrojaSasije.Text = "Unesite broj šasije:";
            // 
            // button_zakazivanjeTermina1_otkazi
            // 
            button_zakazivanjeTermina1_otkazi.Location = new Point(694, 409);
            button_zakazivanjeTermina1_otkazi.Name = "button_zakazivanjeTermina1_otkazi";
            button_zakazivanjeTermina1_otkazi.Size = new Size(94, 29);
            button_zakazivanjeTermina1_otkazi.TabIndex = 0;
            button_zakazivanjeTermina1_otkazi.Text = "Otkaži";
            button_zakazivanjeTermina1_otkazi.UseVisualStyleBackColor = true;
            button_zakazivanjeTermina1_otkazi.Click += button_zakazivanjeTermina1_otkazi_click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(IzborniPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistem za tehnički pregled";
            IzborniPanel.ResumeLayout(false);
            IzborniPanel.PerformLayout();
            KlijentPanel.ResumeLayout(false);
            KlijentPanel.PerformLayout();
            RegistracijaNalogaPanel.ResumeLayout(false);
            RegistracijaNalogaPanel.PerformLayout();
            LogovanKlijentPanel.ResumeLayout(false);
            PromjenaPodatakaPanel.ResumeLayout(false);
            PromjenaPodatakaPanel.PerformLayout();
            ZakazivanjeTerminaTehnickogPanel.ResumeLayout(false);
            ZakazivanjeTerminaTehnickogPanel.PerformLayout();
            AdministratorPanel.ResumeLayout(false);
            AdministratorPanel.PerformLayout();
            LogovanAdministratorPanel.ResumeLayout(false);
            PracenjeStatistikePanel.ResumeLayout(false);
            PrikazStatistikePanel.ResumeLayout(false);
            RegistracijaAdministratorskihNalogaPanel.ResumeLayout(false);
            RegistracijaAdministratorskihNalogaPanel.PerformLayout();
            PregledPostojecihNalogaPanel.ResumeLayout(false);
            PregledPostojecihNalogaPanel.PerformLayout();
            RegistracijaRadnickihNalogaPanel.ResumeLayout(false);
            RegistracijaRadnickihNalogaPanel.PerformLayout();
            BrisanjeRadnickihNalogaPanel.ResumeLayout(false);
            BrisanjeRadnickihNalogaPanel.PerformLayout();
            BrisanjeAdministratorskihNalogaPanel.ResumeLayout(false);
            BrisanjeAdministratorskihNalogaPanel.PerformLayout();
            LoginRadnikaPanel.ResumeLayout(false);
            LoginRadnikaPanel.PerformLayout();
            RadnikPanel.ResumeLayout(false);
            panel_pregledIstorije.ResumeLayout(false);
            panel_pregledIstorije.PerformLayout();
            panel_prikazArhive.ResumeLayout(false);
            panel_prikazArhive.PerformLayout();
            panel_obavljanjeTehnickog.ResumeLayout(false);
            panel_obavljanjeTehnickog.PerformLayout();
            panel_zakazivanjeTermina1.ResumeLayout(false);
            panel_zakazivanjeTermina1.PerformLayout();
            panel_zakazivanjeTermina3.ResumeLayout(false);
            panel_zakazivanjeTermina2.ResumeLayout(false);
            panel_zakazivanjeTermina2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox KategorijaComboBox;
        private ComboBox PotkategorijaComboBox;
        private Button PrikazStatistikeUPrikazuStatistikeButton;
        private RichTextBox StatistikaRichTextBox;
        private Button NazadSaPanelaZaPrikazStatistikeNaPanelZaPracenjeStatistikeButton;
        private Button VozilaKojaNisuProslaTehnickiButton;
        private Button VozilaKojaSuProslaTehnickiButton;
        private Panel IzborniPanel;
        private Label SistemZaTehnickiPregledLabel;
        private Button AdministratorButton;
        private Button RadnikButton;
        private Button KlijentButton;
        private Label PrijavljujemSeKaoLabel;
        private Panel KlijentPanel;
        private Panel RadnikPanel;
        private Panel AdministratorPanel;
        private Panel LoginRadnikaPanel;
        private Label KorisnickoImeLabelLogin;
        private Button NazadRadnikButton;
        private TextBox KorisnickoImeTextBoxLogin;
        private Panel PrikazStatistikePanel;
        private Label LozinkaLabelLogin;
        private TextBox LozinkaTextBoxLogin;
        private Button RegistrujSeButton;
        private Label NisteRegistrovaniLabel;
        private Button PrijaviSeButton;
        private Panel RegistracijaNalogaPanel;
        private Label LozinkaLabel;
        private Label KorisnickoImeLabel;
        private Label PrezimeLabel;
        private Label ImeLabel;
        private TextBox JMBGTextBox;
        private TextBox BrojZiroRacunaTextBox;
        private TextBox BrojLicneKarteTextBox;
        private TextBox PotvrdaLozinkeTextBox;
        private TextBox LozinkaTextBox;
        private TextBox KorisnickoImeTextBox;
        private TextBox PrezimeTextBox;
        private TextBox ImeTextBox;
        private Label JMBGLabel;
        private Label BrojZiroRacunaLabel;
        private Label BrojLicneKarteLabel;
        private Label PotvrdaLozinkeLabel;
        private Button RegistrujNalogButton;
        private Button NazadSaRegistracijeNaLoginButton;
        private TextBox KorisnickoImeAdministratorTextBoxLogin;
        private TextBox KorisnickoImeRadnikaTextBoxLogin;
        private Label LozinkaAdministratorLabelLogin;
        private Label LozinkaRadnikaLabelLogin;
        private TextBox LozinkaAdministratorTextBoxLogin;
        private TextBox LozinkaRadnikaTextBoxLogin;
        private Label KorisnickoImeAdministratorLabelLogin;
        private Label KorisnickoImeRadnikaLabelLogin;
        private Button ObrisiRadnickiNalogButton;
        private Button ObrisiAdministratorskiNalogButton;
        private Button PrijaviSeAdministratorButton;
        private Button PrijaviSeRadnikButton;
        private Button NazadKlijentButton;
        private Button PromjenaPodatakaButton;
        private Panel PromjenaPodatakaPanel;
        private Button BrisanjeNalogaButton;
        private Button ZakazivanjeTerminaTehnickogButton;
        private Panel ZakazivanjeTerminaTehnickogPanel;
        private Button NazadSaPromjenePodatakaNaLogovanogKlijenta;
        private Button NazadSaZakazivanjaTerminaTehnickogNaLogovanogKlijenta;
        private Button NazadSaZakazivanjaTerminaTehnickogNaLogovanogKlijentaRadnikButton;
        private ComboBox ListaRadnickihNalogaComboBox;
        private ComboBox ListaAdministratorskihNalogaComboBox;
        private Label HeaderListeRadnickihNaloga;
        private Label HeaderListeAdministratorskihNaloga;
        private Button NazadAdministratorButton;
        private Button NazadSaLogovanogRadnikaNaIzborniPanelButton;
        private Panel LogovanAdministratorPanel;
        private Panel LogovanKlijentPanel;
        private Button PracenjeStatistikeButton;
        private Button PregledPostojecihNalogaButton;
        private Panel PregledPostojecihNalogaPanel;
        private Panel PracenjeStatistikePanel;
        private ListBox PregledPostojecihNalogaKlijentListBox;
        private Label PregledPostojecihNalogaKlijentLabel;
        private Label PregledPostojecihNalogaRadnikLabel;
        private Label PregledPostojecihNalogaAdminLabel;
        private ListBox PregledPostojecihNalogaRadnikListBox;
        private ListBox PregledPostojecihNalogaAdminListBox;
        private Button BrisanjeRadnickihNalogaButton;
        private Button BrisanjeAdministratorskihNalogaButton;
        private Button KreiranjeRadnickihNalogaButton;
        private Button KreiranjeAdministratorskihNalogaButton;
        private Panel RegistracijaRadnickihNalogaPanel;
        private Button OdjavaLogovanogAdministratoraButton;
        private Button OdjavaLogovanogKlijentaButton;
        private Panel RegistracijaAdministratorskihNalogaPanel;
        private Button RegistrujAdministratorskiNalogButton;
        private Button RegistrujRadnickiNalogButton;
        private Label PotvrdaLozinkeAdminRegistracijaLabel;
        private Label LozinkaRadnikRegistracijaLabel;
        private Panel BrisanjeRadnickihNalogaPanel;
        private Panel BrisanjeAdministratorskihNalogaPanel;
        private Label PotvrdaLozinkeRadnikRegistracijaLabel;
        private Label LozinkaAdminRegistracijaLabel;
        private Label KorisnickoImeAdminRegistracijaLabel;
        private Label PrezimeAdminRegistracijaLabel;
        private Label PrezimeRadnikRegistracijaLabel;
        private Label ImeAdminRegistracijaLabel;
        private Label ImeRadnikRegistracijaLabel;
        private TextBox PotvrdaLozinkeAdminRegistracijaTextBox;
        private TextBox PotvrdaLozinkeRadnikRegistracijaTextBox;
        private TextBox LozinkaAdminRegistracijaTextBox;
        private TextBox LozinkaRadnikRegistracijaTextBox;
        private Label KorisnickoImeRadnikRegistracijaLabel;
        private TextBox KorisnickoImeAdminRegistracijaTextBox;
        private TextBox KorisnickoImeRadnikRegistracijaTextBox;
        private TextBox PrezimeAdminRegistracijaTextBox;
        private TextBox PrezimeRadnikRegistracijaTextBox;
        private TextBox ImeAdminRegistracijaTextBox;
        private TextBox ImeRadnikRegistracijaTextBox;
        private Label IndikatorNaKomStePanelu;
        private Button NazadSaPanelaZaRegisteracijuAdministratoraNaPanelPrijavljenogAdministratoraButton;
        private Button NazadSaPanelaZaPregledPostojecihNalogaNaPanelPrijavljenogAdministratoraButton;
        private Button NazadSaPanelaZaPracenjeStatistikeNaPanelPrijavljenogAdministratoraButton;
        private Button NazadSaPanelaZaRegisteracijuRadnikaNaPanelPrijavljenogAdministratoraButton;
        private Button NazadSaPanelaZaBrisanjeRadnickihNalogaNaPanelPrijavljenogAdministratoraButton;
        private Button NazadSaPanelaZaBrisanjeAdministratorskihNalogaNaPanelPrijavljenogAdministratoraButton;
        private Button button_prikazArhive;
        private Button button_zakazivanjeTehnickog;
        private Button button_obavljanjeTehnickog;
        private Button button_pregledIstorije;
        private Panel panel_zakazivanjeTermina1;
        private Panel panel_zakazivanjeTermina2;
        private Label label_zakazivanjeTermina_kategorija;
        private TextBox textBox_zakazivanjeTermina2_kategorija;
        private Label label_zakazivanjeTermina_potkategorija;
        private TextBox textBox_zakazivanjeTermina2_potkategorija;
        private Label label_zakazivanjeTermina_marka;
        private TextBox textBox_zakazivanjeTermina2_marka;
        private Label label_zakazivanjeTermina_model;
        private TextBox textBox_zakazivanjeTermina2_model;
        private Label label_zakazivanjeTermina_godiste;
        private TextBox textBox_zakazivanjeTermina2_godiste;
        private Label label_zakazivanjeTermina_kubikaza;
        private TextBox textBox_zakazivanjeTermina2_kubikaza;
        private Label label_zakazivanjeTermina_stiker;
        private TextBox textBox_zakazivanjeTermina2_stiker;
        private Button button_zakazivanjeTermina2_dalje;
        private TextBox textBox_zakazivanjeTermina2_rokRegistracije;
        private Label label_zakazivanjeTermina_datumReg;
        private Panel panel_zakazivanjeTermina3;
        private Button button_zakazivanjeTermina3_nazad;
        private MonthCalendar monthCalendar_zakazivanjeTermina3;
        private DateTimePicker dateTimePicker_zakazivanjeTermina3;
        private Button button_zakazivanjeTermina3_zakaziTermin;
        private Button button_zakazivanjeTermina1_pokreni;
        private TextBox textBox_zakazivanjeTermina1_brojSasije;
        private Label label_zakazivanjeTermina_unosBrojaSasije;
        private Button button_zakazivanjeTermina1_otkazi;
        private Panel panel_obavljanjeTehnickog;
        private Label label_obavljanjeTehnickog_naslov;
        private ListBox listBox_obavljanjeTehnickog;
        private Button button_obavljanjeTehnickog_otkazi;
        private Panel panel_prikazArhive;
        private ListBox listBox_prikazArhive;
        private Label label_prikazArhive_naslov;
        private Button button_prikazArhive_nazad;
        private Panel panel_pregledIstorije;
        private ListBox listBox_pregledIstorije;
        private Label label_pregledIstorije_naslov;
        private Button button_pregledIstorije_nazad;
        private RadioButton PromjenaKorisnickogImenaRadioButton;
        private RadioButton PromjenaLozinkeRadioButton;
        private RadioButton PromjenaBrojaLicneKarteRadioButton;
        private RadioButton PromjenaBrojaZiroRacunaRadioButton;
        private TextBox PromjenaPodatakaTextBox;
        private TextBox PotvrdaPromjeneLozinkeTextBox;
        private Button PotvrdiPromjenuPodatakaButton;
        private Label PotvrdaPromjeneLozinkeLabel;
        private Label PromjenaPodatakaLabel;
        private TextBox UnosBrojaSasijeTextBox;
        private Label UnosBrojaSasijeLabel;
        private Button PokretanjeZakazivanjaTerminaButton;
        private MonthCalendar ZakazivanjeTerminaMonthCalendar;
        private DateTimePicker ZakazivanjeTerminaDateTimePicker;
        private Button ZakaziTerminAkoVoziloVecPostojiButton;
        private TextBox MarkaZakazivanjeTextBox;
        private TextBox ModelZakazivanjeTextBox;
        private TextBox GodisteZakazivanjeTextBox;
        private TextBox KubikazaZakazivanjeTextBox;
        private Label KategorijaZakazivanjeLabel;
        private Label PotkategorijaZakazivanjeLabel;
        private Label MarkaZakazivanjeLabel;
        private Label ModelZakazivanjeLabel;
        private Label GodisteZakazivanjeLabel;
        private Label KubikazaZakazivanjeLabel;
        private ComboBox KategorijaZakazivanjeComboBox;
        private ComboBox PotkategorijaZakazivanjeComboBox;
        private Button ZakaziTerminaAkoVoziloNePostojiButton;
        private Label JMBGZakazivanjeRadnikLabel;
        private TextBox JMBGZakazivanjeRadnikTextBox;
        private TextBox UnosBrojaSasijeRadnikTextBox;
        private Label UnosBrojaSasijeRadnikLabel;
        private Button PokretanjeZakazivanjaTerminaRadnikButton;
        private MonthCalendar ZakazivanjeTerminaRadnikMonthCalendar;
        private DateTimePicker ZakazivanjeTerminaRadnikDateTimePicker;
        private Button ZakaziTerminAkoVoziloVecPostojiRadnikButton;
        private TextBox MarkaZakazivanjeRadnikTextBox;
        private TextBox ModelZakazivanjeRadnikTextBox;
        private TextBox GodisteZakazivanjeRadnikTextBox;
        private TextBox KubikazaZakazivanjeRadnikTextBox;
        private Label KategorijaZakazivanjeRadnikLabel;
        private Label PotkategorijaZakazivanjeRadnikLabel;
        private Label MarkaZakazivanjeRadnikLabel;
        private Label ModelZakazivanjeRadnikLabel;
        private Label GodisteZakazivanjeRadnikLabel;
        private Label KubikazaZakazivanjeRadnikLabel;
        private ComboBox KategorijaZakazivanjeRadnikComboBox;
        private ComboBox PotkategorijaZakazivanjeRadnikComboBox;
        private Button ZakaziTerminaAkoVoziloNePostojiRadnikButton;
    }
}
