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
            IzborniPanel = new Panel();
            KlijentPanel = new Panel();
            NazadKlijentButton = new Button();
            label3 = new Label();
            RadnikPanel = new Panel();
            NazadRadnikButton = new Button();
            label4 = new Label();
            AdministratorPanel = new Panel();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            AdministratorButton = new Button();
            RadnikButton = new Button();
            KlijentButton = new Button();
            NazadAdministratorButton = new Button();
            IzborniPanel.SuspendLayout();
            KlijentPanel.SuspendLayout();
            RadnikPanel.SuspendLayout();
            AdministratorPanel.SuspendLayout();
            SuspendLayout();
            // 
            // IzborniPanel
            // 
            IzborniPanel.BackColor = Color.FromArgb(255, 224, 192);
            IzborniPanel.Controls.Add(KlijentPanel);
            IzborniPanel.Controls.Add(RadnikPanel);
            IzborniPanel.Controls.Add(AdministratorPanel);
            IzborniPanel.Controls.Add(label2);
            IzborniPanel.Controls.Add(label1);
            IzborniPanel.Controls.Add(AdministratorButton);
            IzborniPanel.Controls.Add(RadnikButton);
            IzborniPanel.Controls.Add(KlijentButton);
            IzborniPanel.Dock = DockStyle.Fill;
            IzborniPanel.Location = new Point(0, 0);
            IzborniPanel.Name = "IzborniPanel";
            IzborniPanel.Size = new Size(800, 450);
            IzborniPanel.TabIndex = 0;
            // 
            // KlijentPanel
            // 
            KlijentPanel.Controls.Add(NazadKlijentButton);
            KlijentPanel.Controls.Add(label3);
            KlijentPanel.Dock = DockStyle.Fill;
            KlijentPanel.Location = new Point(0, 0);
            KlijentPanel.Name = "KlijentPanel";
            KlijentPanel.Size = new Size(800, 450);
            KlijentPanel.TabIndex = 5;
            KlijentPanel.Visible = false;
            // 
            // NazadKlijentButton
            // 
            NazadKlijentButton.Location = new Point(694, 409);
            NazadKlijentButton.Name = "NazadKlijentButton";
            NazadKlijentButton.Size = new Size(94, 29);
            NazadKlijentButton.TabIndex = 1;
            NazadKlijentButton.Text = "Nazad";
            NazadKlijentButton.UseVisualStyleBackColor = true;
            NazadKlijentButton.Click += NazadKlijentButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(200, 132);
            label3.Name = "label3";
            label3.Size = new Size(130, 20);
            label3.TabIndex = 0;
            label3.Text = "*klijentski prostor*";
            // 
            // RadnikPanel
            // 
            RadnikPanel.Controls.Add(NazadRadnikButton);
            RadnikPanel.Controls.Add(label4);
            RadnikPanel.Dock = DockStyle.Fill;
            RadnikPanel.Location = new Point(0, 0);
            RadnikPanel.Name = "RadnikPanel";
            RadnikPanel.Size = new Size(800, 450);
            RadnikPanel.TabIndex = 1;
            RadnikPanel.Visible = false;
            // 
            // NazadRadnikButton
            // 
            NazadRadnikButton.Location = new Point(694, 409);
            NazadRadnikButton.Name = "NazadRadnikButton";
            NazadRadnikButton.Size = new Size(94, 29);
            NazadRadnikButton.TabIndex = 2;
            NazadRadnikButton.Text = "Nazad";
            NazadRadnikButton.UseVisualStyleBackColor = true;
            NazadRadnikButton.Click += NazadRadnikButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(217, 133);
            label4.Name = "label4";
            label4.Size = new Size(120, 20);
            label4.TabIndex = 0;
            label4.Text = "*radnički prosor*";
            // 
            // AdministratorPanel
            // 
            AdministratorPanel.Controls.Add(NazadAdministratorButton);
            AdministratorPanel.Controls.Add(label5);
            AdministratorPanel.Dock = DockStyle.Fill;
            AdministratorPanel.Location = new Point(0, 0);
            AdministratorPanel.Name = "AdministratorPanel";
            AdministratorPanel.Size = new Size(800, 450);
            AdministratorPanel.TabIndex = 1;
            AdministratorPanel.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(314, 162);
            label5.Name = "label5";
            label5.Size = new Size(179, 20);
            label5.TabIndex = 0;
            label5.Text = "*administratorski prostor*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(296, 245);
            label2.Name = "label2";
            label2.Size = new Size(208, 31);
            label2.TabIndex = 4;
            label2.Text = "Prijavljujem se kao:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(47, 99);
            label1.Name = "label1";
            label1.Size = new Size(706, 67);
            label1.TabIndex = 3;
            label1.Text = "SISTEM ZA TEHNIČKI PREGLED";
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
            // NazadAdministratorButton
            // 
            NazadAdministratorButton.Location = new Point(694, 409);
            NazadAdministratorButton.Name = "NazadAdministratorButton";
            NazadAdministratorButton.Size = new Size(94, 29);
            NazadAdministratorButton.TabIndex = 2;
            NazadAdministratorButton.Text = "Nazad";
            NazadAdministratorButton.UseVisualStyleBackColor = true;
            NazadAdministratorButton.Click += NazadAdministratorButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(IzborniPanel);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistem za tehnički pregled";
            IzborniPanel.ResumeLayout(false);
            IzborniPanel.PerformLayout();
            KlijentPanel.ResumeLayout(false);
            KlijentPanel.PerformLayout();
            RadnikPanel.ResumeLayout(false);
            RadnikPanel.PerformLayout();
            AdministratorPanel.ResumeLayout(false);
            AdministratorPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel IzborniPanel;
        private Label label1;
        private Button AdministratorButton;
        private Button RadnikButton;
        private Button KlijentButton;
        private Label label2;
        private Panel KlijentPanel;
        private Panel RadnikPanel;
        private Panel AdministratorPanel;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button NazadKlijentButton;
        private Button NazadRadnikButton;
        private Button NazadAdministratorButton;
    }
}
