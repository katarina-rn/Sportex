namespace Klijent
{
    partial class Profil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profil));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.txtKI = new System.Windows.Forms.TextBox();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.lblKI = new System.Windows.Forms.Label();
            this.txtPib = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.lblPib = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtNazivN = new System.Windows.Forms.TextBox();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Teal;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 67);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(481, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "x";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 16F);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(244, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Podaci o naruciocu";
            // 
            // logo
            // 
            this.logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(232, 65);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(22, 263);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnObrisi);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btnIzmeni);
            this.panel3.Controls.Add(this.txtLozinka);
            this.panel3.Controls.Add(this.txtKI);
            this.panel3.Controls.Add(this.lblLozinka);
            this.panel3.Controls.Add(this.lblKI);
            this.panel3.Controls.Add(this.txtPib);
            this.panel3.Controls.Add(this.txtTelefon);
            this.panel3.Controls.Add(this.lblPib);
            this.panel3.Controls.Add(this.lblTelefon);
            this.panel3.Controls.Add(this.txtEmail);
            this.panel3.Controls.Add(this.txtAdresa);
            this.panel3.Controls.Add(this.txtNazivN);
            this.panel3.Controls.Add(this.lblAdresa);
            this.panel3.Controls.Add(this.lblEmail);
            this.panel3.Controls.Add(this.lblNaziv);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Century", 8.25F);
            this.panel3.ForeColor = System.Drawing.Color.Teal;
            this.panel3.Location = new System.Drawing.Point(22, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(487, 263);
            this.panel3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(280, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 20);
            this.button1.TabIndex = 43;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.BackColor = System.Drawing.Color.Teal;
            this.btnIzmeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzmeni.Font = new System.Drawing.Font("Century", 12F);
            this.btnIzmeni.ForeColor = System.Drawing.Color.White;
            this.btnIzmeni.Location = new System.Drawing.Point(331, 194);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(133, 48);
            this.btnIzmeni.TabIndex = 42;
            this.btnIzmeni.Text = "Sacuvaj";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // txtLozinka
            // 
            this.txtLozinka.Font = new System.Drawing.Font("Century", 11F);
            this.txtLozinka.ForeColor = System.Drawing.Color.Teal;
            this.txtLozinka.Location = new System.Drawing.Point(97, 59);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(216, 25);
            this.txtLozinka.TabIndex = 41;
            this.txtLozinka.UseSystemPasswordChar = true;
            // 
            // txtKI
            // 
            this.txtKI.Font = new System.Drawing.Font("Century", 11F);
            this.txtKI.ForeColor = System.Drawing.Color.Teal;
            this.txtKI.Location = new System.Drawing.Point(153, 28);
            this.txtKI.Name = "txtKI";
            this.txtKI.Size = new System.Drawing.Size(160, 25);
            this.txtKI.TabIndex = 40;
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Font = new System.Drawing.Font("Century", 12F);
            this.lblLozinka.Location = new System.Drawing.Point(25, 59);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(73, 20);
            this.lblLozinka.TabIndex = 39;
            this.lblLozinka.Text = "Lozinka:";
            // 
            // lblKI
            // 
            this.lblKI.AutoSize = true;
            this.lblKI.Font = new System.Drawing.Font("Century", 12F);
            this.lblKI.Location = new System.Drawing.Point(25, 28);
            this.lblKI.Name = "lblKI";
            this.lblKI.Size = new System.Drawing.Size(122, 20);
            this.lblKI.TabIndex = 38;
            this.lblKI.Text = "Korisnicko ime:";
            // 
            // txtPib
            // 
            this.txtPib.Font = new System.Drawing.Font("Century", 11F);
            this.txtPib.ForeColor = System.Drawing.Color.Teal;
            this.txtPib.Location = new System.Drawing.Point(97, 219);
            this.txtPib.Name = "txtPib";
            this.txtPib.Size = new System.Drawing.Size(216, 25);
            this.txtPib.TabIndex = 37;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Century", 11F);
            this.txtTelefon.ForeColor = System.Drawing.Color.Teal;
            this.txtTelefon.Location = new System.Drawing.Point(97, 188);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(216, 25);
            this.txtTelefon.TabIndex = 36;
            // 
            // lblPib
            // 
            this.lblPib.AutoSize = true;
            this.lblPib.Font = new System.Drawing.Font("Century", 12F);
            this.lblPib.Location = new System.Drawing.Point(25, 218);
            this.lblPib.Name = "lblPib";
            this.lblPib.Size = new System.Drawing.Size(43, 20);
            this.lblPib.TabIndex = 35;
            this.lblPib.Text = "PIB:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Century", 12F);
            this.lblTelefon.Location = new System.Drawing.Point(25, 188);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(68, 20);
            this.lblTelefon.TabIndex = 34;
            this.lblTelefon.Text = "Telefon:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century", 11F);
            this.txtEmail.ForeColor = System.Drawing.Color.Teal;
            this.txtEmail.Location = new System.Drawing.Point(97, 121);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(216, 25);
            this.txtEmail.TabIndex = 33;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Font = new System.Drawing.Font("Century", 11F);
            this.txtAdresa.ForeColor = System.Drawing.Color.Teal;
            this.txtAdresa.Location = new System.Drawing.Point(97, 152);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(216, 25);
            this.txtAdresa.TabIndex = 32;
            // 
            // txtNazivN
            // 
            this.txtNazivN.Font = new System.Drawing.Font("Century", 11F);
            this.txtNazivN.ForeColor = System.Drawing.Color.Teal;
            this.txtNazivN.Location = new System.Drawing.Point(97, 90);
            this.txtNazivN.Name = "txtNazivN";
            this.txtNazivN.Size = new System.Drawing.Size(216, 25);
            this.txtNazivN.TabIndex = 31;
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Font = new System.Drawing.Font("Century", 12F);
            this.lblAdresa.Location = new System.Drawing.Point(24, 152);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(65, 20);
            this.lblAdresa.TabIndex = 30;
            this.lblAdresa.Text = "Adresa:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century", 12F);
            this.lblEmail.Location = new System.Drawing.Point(25, 121);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(58, 20);
            this.lblEmail.TabIndex = 29;
            this.lblEmail.Text = "Email:";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Century", 12F);
            this.lblNaziv.Location = new System.Drawing.Point(25, 90);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(57, 20);
            this.lblNaziv.TabIndex = 28;
            this.lblNaziv.Text = "Naziv:";
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.Teal;
            this.btnObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisi.Font = new System.Drawing.Font("Century", 12F);
            this.btnObrisi.ForeColor = System.Drawing.Color.White;
            this.btnObrisi.Location = new System.Drawing.Point(331, 138);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(133, 48);
            this.btnObrisi.TabIndex = 44;
            this.btnObrisi.Text = "Obrisi nalog";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // Profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 330);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profil";
            this.Load += new System.EventHandler(this.Profil_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.TextBox txtKI;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.Label lblKI;
        private System.Windows.Forms.TextBox txtPib;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label lblPib;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtNazivN;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
    }
}